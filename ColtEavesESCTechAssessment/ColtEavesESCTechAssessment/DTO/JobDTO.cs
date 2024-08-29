using ColtEavesESCTechAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColtEavesESCTechAssessment.DTO
{
    public class JobDTO
    {
        public int JobId { get; set; }
        public string JobTitle { get; set; } = null!;
        public decimal? MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }

    }
}
