using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tutorial10.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        [HttpGet("/get/doctor/{id}")]
        public IActionResult GetDoctorData(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddNewDoctor()
        {
            return Ok();
        }
        [HttpPost("/modify/doctor/data/{id}")]
        public IActionResult ModifyDoctorData(int id)
        {
            return Ok();
        }
        [HttpDelete("/delete/doctor/{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            return ok();
        }
    }
}