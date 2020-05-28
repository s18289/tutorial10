using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial10.Services
{
    public interface IDbService
    {
        public IActionResult GetDoctorData(int id);
        public IActionResult AddNewDoctor();
        public IActionResult ModifyDoctorData(int id);
        public IActionResult DeleteDoctor(int id);
    }
}