using ColtEavesESCTechAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ColtEavesESCTechAssessment.DTO
{
    public class DependentDTO
    {
        public int DependentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Relationship { get; set; } = null!;
        public int EmployeeId { get; set; }
    }
}
