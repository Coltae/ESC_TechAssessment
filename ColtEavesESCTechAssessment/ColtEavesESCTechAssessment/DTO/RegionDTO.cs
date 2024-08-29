using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColtEavesESCTechAssessment.DTO
{
    public class RegionDTO
    {
        public int RegionId { get; set; }
        public string? RegionName { get; set; }
    }
}
