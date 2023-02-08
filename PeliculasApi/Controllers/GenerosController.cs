using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PeliculasApi.Entidades;
//using PeliculasApi.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace PeliculasApi.Controllers
{

    [Route("api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {

        //private readonly IRepositorio repositorio;
        private readonly ILogger<GenerosController> logger;
        private readonly ApplicationDbContext context;

        public GenerosController(
            ILogger<GenerosController> logger,
            ApplicationDbContext context)
        {
            this.logger = logger;
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Genero>>> Get()
        {
            return await context.Generos.ToListAsync();
        }

        //[HttpGet("guid")]
        //public ActionResult<Guid> GetGuid()
        //{
        //    return Ok(new
        //    {
        //        Guid_GenerosController = repositorio.ObtenerGUID(),
        //        Guid_WeatherForecastController = weatherForecastController.ObtenerGUIDWeatherForecastController()
        //    });
        //}

        //[HttpGet("ejemplo")] // End point asignando una ruta: api/generos/ejemplo
        //[HttpGet("{Id}")] // End point con variable: api/generos/3
        //[HttpGet("{Id}/{nombre}")] // end point concatenentod 2 variable: api/generos/3/felipe
        //[HttpGet("{Id}/{nombre=Roberto}")] // end point con valor por defecto 2 variable: api/generos/3/felipe
        //[HttpGet("{Id:int}/{nombre=Roberto}")] // validar para no registre cadena string en una variable int

        [HttpGet("{Id:int}")] // validar para no registre cadena string en una variable int
        public async Task<ActionResult<Genero>> Get(int Id)  
        {

            throw new NotImplementedException();

        }

        [HttpPost]
        public async Task<ActionResult> post([FromBody] Genero genero)
        {
            context.Add(genero);
            await context.SaveChangesAsync();
            return NoContent();

        }

        [HttpPut]
        public ActionResult put([FromBody] Genero genero)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
