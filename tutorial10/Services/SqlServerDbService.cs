using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tutorial10.Services
{
    public class SqlServerDbService : ControllerBase, IDbService
    {
        public IActionResult AddNewDoctor()
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult GetDoctorData(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult ModifyDoctorData(int id)
        {
            throw new NotImplementedException();
        }
    }
}