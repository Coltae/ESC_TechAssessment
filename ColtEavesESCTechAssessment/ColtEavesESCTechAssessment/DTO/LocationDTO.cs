using ColtEavesESCTechAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColtEavesESCTechAssessment.DTO
{
    public class LocationDTO
    {
        public int LocationId { get; set; }
        public string? StreetAddress { get; set; }
        public string? PostalCode { get; set; }
        public string City { get; set; } = null!;
        public string? StateProvince { get; set; }
        public string CountryId { get; set; } = null!;

    }
}
