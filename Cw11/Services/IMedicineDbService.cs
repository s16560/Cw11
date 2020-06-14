using Cw11.DTOs;
using Cw11.DTOs.Requests;

namespace Cw11.Services
{
    public interface IMedicineDbService
    {
        public DoctorDataResponse GetDoctorData(int idDoctor);
        public DoctorDataResponse AddDoctor(AddDoctorRequest request);
        public DoctorDataResponse ModifyDoctorData(ModifyDoctorDataRequest request);
        public DoctorDataResponse RemoveDoctor(int idDoctor);
    }
}
