using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet.Controllers
{
    public class SkolaController : Controller
    {
        // GET: Skola
        public string Index()
        {
            return "Dobrodosli u nasu skolu";
        }

        public string UpisiUcenika() {

            return "Ucenik je uspjesno upisan";
        }

        public string Telefon() {

            return "031/232/434";
        }


        public string Adresa() {

            return "Adresa skole";
        }

        public string About()
        {

            return "Radi!";

        }
    }
}