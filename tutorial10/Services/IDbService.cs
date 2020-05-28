using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial10.Models;

namespace tutorial10.Services
{
    public interface IDbService
    {
        public IActionResult GetDoctorData(int id);
        public IActionResult AddNewDoctor(Doctor doctor);
        public IActionResult ModifyDoctorData(int id, string email);
        public IActionResult DeleteDoctor(int id);
    }
}