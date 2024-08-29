using ColtEavesESCTechAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColtEavesESCTechAssessment.DTO
{
    public class DepartmentDTO
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; } = null!;
        public int? LocationId { get; set; }

    }
}
