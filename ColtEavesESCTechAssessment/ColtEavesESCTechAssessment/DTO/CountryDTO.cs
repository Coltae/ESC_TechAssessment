using ColtEavesESCTechAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColtEavesESCTechAssessment.DTO
{
    public class CountryDTO
    {
        public string CountryId { get; set; } = null!;
        public string? CountryName { get; set; }
        public int RegionId { get; set; }

    }
}
