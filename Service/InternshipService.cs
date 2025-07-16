using System;
using System.Text;
using System.Text.Json;
using InternshipFinder.Models;

namespace InternshipFinder.Service;

public class InternshipService
{
    private readonly HttpClient _httpClient;

    public InternshipService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<InternshipResponse> GetInternshipsAsync(
        string location,
        int? number,
        string headline,
        string keyword,
        bool? experienceRequired,
        bool? drivingLicenseRequired,
        int? page,
        int? pageSize)
    {

        var queryParams = new StringBuilder();

        //rrequired q parameter
        queryParams.Append("q=praktik");

        if (!string.IsNullOrEmpty(location))
        {
            queryParams.Append($"&county={Uri.EscapeDataString(location)}");
        }

        if (number.HasValue)
        {
            queryParams.Append($"&limit={number.Value}");
        }

        if (!string.IsNullOrEmpty(headline))
        {
            queryParams.Append($"&headline={Uri.EscapeDataString(headline)}");
        }

        if (!string.IsNullOrEmpty(keyword))
        {
            queryParams.Append($"&keyword={Uri.EscapeDataString(keyword)}");
        }

        if (experienceRequired.HasValue)
        {
            queryParams.Append($"&experience_required={experienceRequired.Value.ToString().ToLower()}");
        }

        if (drivingLicenseRequired.HasValue)
        {
            queryParams.Append($"&driving_license_required={drivingLicenseRequired.Value.ToString().ToLower()}");
        }

        if (page.HasValue)
        {
            queryParams.Append($"&page={page.Value}");
        }

        if (page.HasValue && page > 1 && pageSize.HasValue)
        {
            int offset = (page.Value - 1) * pageSize.Value;
            queryParams.Append($"&offset={offset}");
        }


        string url = $"https://jobsearch.api.jobtechdev.se/search?{queryParams}";
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode(); // Ensure the request was successful


        var json = await response.Content.ReadAsStringAsync(); // Read the response content as a string
        Console.WriteLine($"Response JSON: {json}");


        var internshipResponse = JsonSerializer.Deserialize<InternshipResponse>(json);
        if (internshipResponse == null)
        {
            throw new Exception("Failed to deserialize internship response.");
        }

        var filterLocations = internshipResponse.Hits?.ToList() ?? new List<Hit>();

        // Filter hits based on known locations
        if (!string.IsNullOrEmpty(location))
        {
            filterLocations = filterLocations
                .Where(l => l.WorkplaceAddress != null &&
                            l.WorkplaceAddress.Municipality?.Equals(location, StringComparison.OrdinalIgnoreCase) == true
                            || l.WorkplaceAddress.Region?.Equals(location, StringComparison.OrdinalIgnoreCase) == true
                            || l.WorkplaceAddress.Country?.Equals(location, StringComparison.OrdinalIgnoreCase) == true)
                .ToList();
        }

        if (!string.IsNullOrEmpty(headline))
        {
            filterLocations = filterLocations
                .Where(i => i.Headline != null && i.Headline.Contains(headline, StringComparison.OrdinalIgnoreCase)
                        || i.Label != null && i.Label.Contains(headline, StringComparison.OrdinalIgnoreCase)
                        || i.Description != null && i.Description.Text != null && i.Description.Text.Contains(headline, StringComparison.OrdinalIgnoreCase)
                        || i.Occupation != null && i.Occupation.Label != null && i.Occupation.Label.Contains(headline, StringComparison.OrdinalIgnoreCase)
                        || i.WorkplaceAddress != null && i.WorkplaceAddress.Municipality != null && i.WorkplaceAddress.Municipality.Contains(headline, StringComparison.OrdinalIgnoreCase)
                        )
                .ToList();
        }


        if (!string.IsNullOrEmpty(keyword))
        {
            filterLocations = filterLocations
                .Where(i => i.Occupation.Label != null && i.Occupation.Label.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                        || i.Description != null && i.Description.Text != null && i.Description.Text.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                        || i.Label != null && i.Label.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                        || i.Headline != null && i.Headline.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        if (experienceRequired.HasValue)
        {
            filterLocations = filterLocations
                .Where(i => i.ExperienceRequired == experienceRequired.Value)
                .ToList();
        }

        if (drivingLicenseRequired.HasValue)
        {
            filterLocations = filterLocations
                .Where(i => i.DrivingLicenseRequired == drivingLicenseRequired.Value)
                .ToList();
        }

        if (number.HasValue && number > 0)
        {
            filterLocations = filterLocations.Take(number.Value).ToList();
        }

        internshipResponse.Hits = filterLocations;

        return internshipResponse;
    }
    
    
}
