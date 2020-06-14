using Cw11.DTOs;
using Cw11.DTOs.Requests;
using Cw11.Models;

namespace Cw11.Services
{
    public class EfMedicineDbService : IMedicineDbService
    {
        private readonly MedicineDbContext _context;
        public EfMedicineDbService(MedicineDbContext context)
        {
            _context = context;
        }

        public DoctorDataResponse GetDoctorData(int idDoctor)
        {
            var doctor = _context.Doctors.Find(idDoctor);
            if (doctor == null) return null;

            var response = new DoctorDataResponse();
            response.IdDoctor = doctor.IdDoctor;
            response.FirstName = doctor.FirstName;
            response.LastName = doctor.LastName;
            response.Email = doctor.Email;

            return response;
        }

        public DoctorDataResponse AddDoctor(AddDoctorRequest request)
        {
            Doctor doctor = new Doctor();
          //  doctor.IdDoctor = _context.Doctors.Max(d => d.IdDoctor) + 1;
            doctor.FirstName = request.FirstName;
            doctor.LastName = request.LastName;
            doctor.Email = request.Email;

            _context.Doctors.Add(doctor);
            _context.SaveChanges();

            var response = new DoctorDataResponse();
            response.IdDoctor = doctor.IdDoctor;
            response.FirstName = doctor.FirstName;
            response.LastName = doctor.LastName;
            response.Email = doctor.Email;

            return response;
        }

        public DoctorDataResponse ModifyDoctorData(ModifyDoctorDataRequest request)
        {
            var doctor = _context.Doctors.Find(request.IdDoctor);
            if (doctor == null) return null;

            doctor.FirstName = request.FirstName;
            doctor.LastName = request.LastName;
            doctor.Email = request.Email;

            _context.SaveChanges();

            var response = new DoctorDataResponse();
            response.IdDoctor = doctor.IdDoctor;
            response.FirstName = doctor.FirstName;
            response.LastName = doctor.LastName;
            response.Email = doctor.Email;

            return response;            
        }

        public DoctorDataResponse RemoveDoctor(int idDoctor)
        {
            var doctor = _context.Doctors.Find(idDoctor);
            if (doctor == null) return null;

            _context.Doctors.Remove(doctor);
            _context.SaveChanges();

            var response = new DoctorDataResponse();
            response.IdDoctor = doctor.IdDoctor;
            response.FirstName = doctor.FirstName;
            response.LastName = doctor.LastName;
            response.Email = doctor.Email;

            return response;
        }
    }
}
