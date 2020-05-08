using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiHarjoituskoodi.Models;

namespace WebApiHarjoituskoodi.Controllers
{
    [Route("omareitti/[controller]")]
    [ApiController]
    public class HenkilotController : ControllerBase
    {
        [HttpGet]
        [Route("merkkijono/{nimi}")]
        public string MerkkiJono(string nimi)
        {
            return "Päivää " + nimi;
        }

        [Route("paivamaara")]
        public DateTime Pvm()
        {
            return DateTime.Now;

        }

        [HttpGet]
        [Route("olio")]
        public Henkilo Olio()
        {
            return new Henkilo()
            {
                Nimi = "Paavo Pesusieni",
                Osoite = "Vesipolku 11",
                Ika = 11
            };
        }

        [HttpGet]
        [Route("oliolista")]
        public List<Henkilo> OlioLista()
        {
            List<Henkilo> henkilot = new List<Henkilo>()
            {
                new Henkilo()
                {
                    Nimi = "Paavo Pesusieni",
                    Osoite = "Vesipolku 11",
                       Ika = 11
                },
                new Henkilo()
                {
                    Nimi = "Liisa Pesusieni",
                    Osoite = "Vesipolku 11",
                       Ika = 10
                },
                new Henkilo()
                {
                    Nimi = "Heikki Koralli",
                    Osoite = "Karinkulma 222",
                       Ika = 10
                }

            };
            return henkilot;
        }

    }
}