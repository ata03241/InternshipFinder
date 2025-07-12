using System;
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

    public async Task<InternshipResponse> GetInternshipsAsync(string location)
    {
       string url = $"https://jobsearch.api.jobtechdev.se/search?q=praktik&county={location}&limit=10";
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
