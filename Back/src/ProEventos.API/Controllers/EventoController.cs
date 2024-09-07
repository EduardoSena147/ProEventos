using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {

        }

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Fortaleza",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemURL = "Teste.png"
            },

            new Evento(){
                EventoId = 2,
                Tema = "Angular 11 e .NET 5",
                Local = "Maracanaú",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(10).ToString(),
                ImagemURL = "Teste.png"
            },

            new Evento(){
                EventoId = 3,
                Tema = "Angular 11 e .NET 5",
                Local = "Pacatuba",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(15).ToString(),
                ImagemURL = "Teste.png"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post(){
            return "Teste de POST";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return $"Exemplo de PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return $"Exemplo de DELETE com id = {id}";
        }
        /*
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Evento
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        */
    }
}
