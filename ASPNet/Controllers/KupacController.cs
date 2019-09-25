using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet.Controllers
{
    public class KupacController : Controller
    {
        // GET: Kupac
        public string Index()
        {
            return "Dobrodosao na stranicu za kupce";
        }

        public string Dodaj(int? id) {

            if (id == 1)
            {
                return "dodali ste peru";
            }
            else if (id == 2)
            {
                return "dodali ste mirka";
            }
            else {
                return "niste dodali nikog";
            }
        }

        public string Informacije() {

            return "Ovo su informacije o kupcu";
        }

        public string Test(string Ime,string Prezime)
        {

            return "Bok " + Ime + " " + Prezime;
        }


    }
}