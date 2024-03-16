﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using Veterinary.API.Data;
using Veterinary.Shared.Entities;

namespace Veterinary.API.Controllers
{



    [ApiController]
    [Route("/api/owners")]
    public class OwnersController : ControllerBase
    {

        private readonly DataContext _context;




        public OwnersController(DataContext context)
        {


            _context = context;


        }



        //Método Get por lista--- Select * From Owners
        [HttpGet]
        public async Task<ActionResult> Get()
        {

            return Ok(await _context.Owners.ToListAsync());



        }




        //Método Get por parámetro--- Select * From Owners
        [HttpGet("id:int")]
        public async Task<ActionResult> Get(int id)
        {

            var owner = await _context.Owners.FirstOrDefaultAsync(x => x.Id == id);

            if (owner == null)
            {


                return NotFound();
            }

            return Ok(owner);


        }




        //Médoto Post- Guardar registros

        [HttpPost]
        public async Task<ActionResult> Post(Owner owner)
        {
            _context.Owners.Add(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);

        }


        //Médoto Put- Actualizar registros

        [HttpPut]
        public async Task<ActionResult> Put(Owner owner)
        {
            _context.Owners.Update(owner);
            await _context.SaveChangesAsync();
            return Ok(owner);//200

        }



        //Método Delete--- Eliminar registros
        [HttpDelete("id:int")]
        public async Task<ActionResult> Delete(int id)
        {

            var filasafectadas = await _context.Owners
                .Where(x => x.Id == id)
                .ExecuteDeleteAsync();

            if (filasafectadas==0)
            {
                return NotFound();//404


            }
            return NoContent(); //204
             



        }


    }
}
