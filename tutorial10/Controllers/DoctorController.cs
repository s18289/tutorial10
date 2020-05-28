using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tutorial10.Models;
using tutorial10.Services;

namespace tutorial10.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {

        public readonly IDbService _service;
        public DoctorController(IDbService service)
        {
            _service = service;
        }

        [HttpGet("/get/doctor/{id}")]
        public IActionResult GetDoctorData(int id)
        {
            return Ok(_service.GetDoctorData(id));
        }

        [HttpPost]
        public IActionResult AddNewDoctor(Doctor doctor)
        {
            return _service.AddNewDoctor(doctor);
        }
        [HttpPost("/modify/doctor/data")]
        public IActionResult ModifyDoctorData(int id, string email)
        {
            return _service.ModifyDoctorData(id, email);
        }
        [HttpDelete("/delete/doctor/{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            return _service.DeleteDoctor(id);
        }
    }
}