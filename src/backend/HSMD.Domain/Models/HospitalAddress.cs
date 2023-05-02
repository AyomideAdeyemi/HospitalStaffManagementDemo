

using HSMD.Domain.Common;

namespace HSMD.Domain.Models
{
    public class HospitalAddress : AuditableBaseEntity
    {
        public int BuildingNumber { get; set; }
        public string? StreetName { get; set; }
        public string? Area_locality { get; set; }
        public string? LandMark { get; set; }
        public string? City { get; set; }
        public int Zip_Postalcode { get; set; }
        public string? State_Province { get; set; }

        public ICollection<Hospital> Hospitals  { get; set; }


    }
}
