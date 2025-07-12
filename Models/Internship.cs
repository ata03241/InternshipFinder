using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace InternshipFinder.Models;

public class InternshipResponse
{
    [JsonPropertyName("total")]
    public Total Total { get; set; }

    [JsonPropertyName("positions")]
    public int Positions { get; set; }

    [JsonPropertyName("query_time_in_millis")]
    public int QueryTimeInMillis { get; set; }

    [JsonPropertyName("result_time_in_millis")]
    public int ResultTimeInMillis { get; set; }

    [JsonPropertyName("hits")]
    public List<Hit> Hits { get; set; }
}

public class Total
{
    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Hit
{
    [JsonPropertyName("relevance")]
    public double Relevance { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("external_id")]
    public string ExternalId { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("webpage_url")]
    public string WebpageUrl { get; set; }

    [JsonPropertyName("logo_url")]
    public string LogoUrl { get; set; }

    [JsonPropertyName("headline")]
    public string Headline { get; set; }

    [JsonPropertyName("application_deadline")]
    public DateTime ApplicationDeadline { get; set; }

    [JsonPropertyName("number_of_vacancies")]
    public int NumberOfVacancies { get; set; }

    [JsonPropertyName("description")]
    public Description Description { get; set; }

    [JsonPropertyName("employment_type")]
    public EmploymentType EmploymentType { get; set; }

    [JsonPropertyName("salary_description")]
    public string SalaryDescription { get; set; }

    [JsonPropertyName("duration")]
    public Duration Duration { get; set; }

    [JsonPropertyName("working_hours_type")]
    public WorkingHoursType WorkingHoursType { get; set; }

    [JsonPropertyName("employer")]
    public Employer Employer { get; set; }

    [JsonPropertyName("application_details")]
    public ApplicationDetails ApplicationDetails { get; set; }

    [JsonPropertyName("experience_required")]
    public bool ExperienceRequired { get; set; }

    [JsonPropertyName("access_to_own_car")]
    public bool AccessToOwnCar { get; set; }

    [JsonPropertyName("driving_license_required")]
    public bool DrivingLicenseRequired { get; set; }

    [JsonPropertyName("occupation")]
    public Occupation Occupation { get; set; }

    [JsonPropertyName("workplace_address")]
    public WorkplaceAddress WorkplaceAddress { get; set; }

    [JsonPropertyName("application_contacts")]
    public List<ApplicationContact> ApplicationContacts { get; set; }

    [JsonPropertyName("publication_date")]
    public DateTime PublicationDate { get; set; }

    [JsonPropertyName("last_publication_date")]
    public DateTime LastPublicationDate { get; set; }

    [JsonPropertyName("removed")]
    public bool Removed { get; set; }

    [JsonPropertyName("source_type")]
    public string SourceType { get; set; }

    [JsonPropertyName("timestamp")]
    public long Timestamp { get; set; }
}

public class Description
{
    [JsonPropertyName("text")]
    public string Text { get; set; }

    [JsonPropertyName("text_formatted")]
    public string TextFormatted { get; set; }
}

public class EmploymentType
{
    [JsonPropertyName("concept_id")]
    public string ConceptId { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("legacy_ams_taxonomy_id")]
    public string LegacyAmsTaxonomyId { get; set; }
}

public class Duration
{
    [JsonPropertyName("concept_id")]
    public string ConceptId { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("legacy_ams_taxonomy_id")]
    public string LegacyAmsTaxonomyId { get; set; }
}

public class WorkingHoursType
{
    [JsonPropertyName("concept_id")]
    public string ConceptId { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("legacy_ams_taxonomy_id")]
    public string LegacyAmsTaxonomyId { get; set; }
}

public class Employer
{
    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("organization_number")]
    public string OrganizationNumber { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("workplace")]
    public string Workplace { get; set; }
}

public class ApplicationDetails
{
    [JsonPropertyName("information")]
    public string Information { get; set; }

    [JsonPropertyName("reference")]
    public string Reference { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("via_af")]
    public bool ViaAf { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("other")]
    public string Other { get; set; }
}

public class Occupation
{
    [JsonPropertyName("concept_id")]
    public string ConceptId { get; set; }

    [JsonPropertyName("label")]
    public string Label { get; set; }

    [JsonPropertyName("legacy_ams_taxonomy_id")]
    public string LegacyAmsTaxonomyId { get; set; }
}

public class WorkplaceAddress
{
    [JsonPropertyName("municipality")]
    public string Municipality { get; set; }

    [JsonPropertyName("municipality_code")]
    public string MunicipalityCode { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("region_code")]
    public string RegionCode { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("coordinates")]
    public double?[] Coordinates { get; set; }
}

public class ApplicationContact
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("telephone")]
    public string Telephone { get; set; }

    [JsonPropertyName("contact_type")]
    public string ContactType { get; set; }
}
