using ColtEavesESCTechAssessment.Models;

namespace ColtEavesESCTechAssessment.DTO
{
    public class EmployeeInformtionDTO
    {
        public EmployeeInformtionDTO()
        {
            Dependents = new List<DependentDTO> ();
            Job = new JobDTO();
            Department = new DepartmentDTO();
            Location = new LocationDTO();
            Country = new CountryDTO();
            Region = new RegionDTO();
        }
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; } = string.Empty;

        public string EmployeePhone { get; set; } = string.Empty;   
        public string EmployeeDescription { get; set; } = string.Empty; 
        public string EmployeeDepartment { get; set; } = string.Empty;
        public string EmployeeLocation { get; set; } = string.Empty;
        public string EmployeeCountry { get; set; } = string.Empty;
        public string EmployeeRegion { get; set; } = string.Empty;
        public List<DependentDTO> Dependents { get; set; }
        public JobDTO Job { get; set; }
        public DepartmentDTO Department { get; set; }
        public LocationDTO Location { get; set; }
        public CountryDTO Country { get; set; }
        public RegionDTO Region { get; set; }
    }
}
