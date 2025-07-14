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
        string category,
        string keyword,
        DateTime? applicationDeadlineBefore,
        bool? experienceRequired,
        DateTime? publishedDate,
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


        if (!string.IsNullOrEmpty(category))
        {
            queryParams.Append($"&category={Uri.EscapeDataString(category)}");
        }

        if (!string.IsNullOrEmpty(keyword))
        {
            queryParams.Append($"&keyword={Uri.EscapeDataString(keyword)}");
        }

        if (applicationDeadlineBefore.HasValue)
        {
            queryParams.Append($"&application_deadline_before={applicationDeadlineBefore.Value:yyyy-MM-dd}");
        }

        if (experienceRequired.HasValue)
        {
            queryParams.Append($"&experience_required={experienceRequired.Value.ToString().ToLower()}");
        }

        if (publishedDate.HasValue)
        {
            queryParams.Append($"&published_date={publishedDate.Value:yyyy-MM-dd}");
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
        response.EnsureSuccessStatusCode();


        var json = await response.Content.ReadAsStringAsync();

        Console.WriteLine($"Response JSON: {json}");
        var internshipResponse = JsonSerializer.Deserialize<InternshipResponse>(json);
        if (internshipResponse == null)
        {
            throw new Exception("Failed to deserialize internship response.");
        }

        return internshipResponse;

    }
    
    

}
