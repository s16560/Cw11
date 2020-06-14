using Cw11.DTOs.Requests;
using Cw11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IMedicineDbService _context;

        public DoctorsController(IMedicineDbService context)
        {
            _context = context;
        }

        //pobranie doktora po id
        [HttpGet("{idDoctor}")]
        public IActionResult GetDoctorData(int idDoctor)
        {
            var response = _context.GetDoctorData(idDoctor);
            if (response == null)
                return NotFound("Nie znaleziono doktora o id " + idDoctor);

            return Ok(response);
        }

        //dodanie doktora
        [HttpPost("add")]
        public IActionResult AddDoctor(AddDoctorRequest request)
        {
            var response = _context.AddDoctor(request);
            return Created("Dodano doktora", response);
        }

        //modyfikacja doktora
        [HttpPost("modifyDoctorData")]
        public IActionResult ModifyDoctorData(ModifyDoctorDataRequest request)
        {
            var response = _context.ModifyDoctorData(request);
            if (response == null)
                return NotFound("Nie znaleziono doktora o id " + request.IdDoctor);

            return Ok(response);
        }

        //usunięcie doktora po id
        [HttpDelete("removeDoctor/{idDoctor}")]
        public IActionResult RemoveDoctor(int idDoctor)
        {
            var response = _context.RemoveDoctor(idDoctor);
            if (response == null)
                return NotFound("Nie znaleziono doktora o id " + idDoctor);

            return Ok(response);
        }

    }
}