using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tutorial10.Models;

namespace tutorial10.Services
{
    public class SqlServerDbService : ControllerBase, IDbService
    {

        public readonly PatientContext context;


        public SqlServerDbService(PatientContext context)
        {
            this.context = context;
        }

        private Doctor newDoctor = new Doctor();

        public IActionResult AddNewDoctor(Doctor doctor)
        {
            int indexNumberExist = context.Doctor.Where(d => d.IdDoctor == doctor.IdDoctor).Count();

            if (indexNumberExist > 0)
            {
                return BadRequest("Try to enter another idDoctor for this Doctor!\n" +
                    $"The last added Doctor has idDoctor : {context.Doctor.OrderBy(s1 => s1.IdDoctor).Select(d => d.IdDoctor).Last().ToString()}");
            }


            newDoctor = doctor;


            int doctorExist = context.Doctor.Where(d => d.FirstName == doctor.FirstName
                                                       && d.LastName == doctor.LastName
                                                       && d.Email == doctor.Email).Select(s1 => s1.IdDoctor).FirstOrDefault();

            if (doctorExist == 0)
            {
                context.Doctor.Add(newDoctor);
                context.SaveChanges();
            }
            else
            {
                return BadRequest($"This Doctor already exists idDoctor : {doctorExist}");
            }
            return Ok($"A new Doctor has been added idDoctor : {newDoctor.IdDoctor}");
        }

        public IActionResult DeleteDoctor(int id)
        {
            int idDoctor = context.Doctor.Where(d => d.IdDoctor == id).Select(d => d.IdDoctor).FirstOrDefault();

            if (idDoctor == 0)
            {
                return NotFound("Doctor with such id doesn't exists");
            }
            else
            {
                context.Doctor.Remove(context.Doctor.Where(d => d.IdDoctor == id).First());
            }

            context.SaveChanges();
            return Ok("Doctor has been deleted from Database");
        }

        public IActionResult GetDoctorData(int id)
        {
            if (!context.Doctor.Any(d => d.IdDoctor == id))
            {
                return NotFound("Doctor with such id doesn't exists");
            }
            Doctor doctor = context.Doctor.Where(d => d.IdDoctor == id).First();
            return Ok(doctor);
        }

        public IActionResult ModifyDoctorData(int id, string email)
        {
            if (context.Doctor.Any(d => d.IdDoctor == id))
            {
                return NotFound("Such doctor doesn't exists");
            }
            context.Doctor.Where(d => d.IdDoctor == id).ToList().ForEach(d => d.Email = email);
            context.SaveChanges();
            return Ok("Email was updated successfully");
        }
    }
}