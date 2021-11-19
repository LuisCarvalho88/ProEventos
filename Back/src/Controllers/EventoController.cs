using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
            new Evento(){
            EventoId = 1,
            Tema = "Angular 11 e .NET5",
            Local = "São Paulo",
            Lote = "1° Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "Foto.png"
            },
            new Evento(){
            EventoId = 2,
            Tema = "Angular e suas novidades",
            Local = "Belo Horizonte",
            Lote = "2° Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString(),
            ImagemURL = "Foto1.png"
            }
        };

        public EventoController()
        {           
        }

        [HttpGet]
        public IEnumerable<Evento> Get(){
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(Evento => Evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("id")]
        public string Post(int id)
        {
            return $"exemplo de put com id ";
        }
    }
}
