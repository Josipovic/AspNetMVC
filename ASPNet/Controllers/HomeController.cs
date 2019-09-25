using ASPNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNet.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Dobar dan";
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string Informacije() {

            return "Ovo je stranica sa informacijama";
        }

        public string Zbroji(int a, int b) {

            return (a + b).ToString();

        }

        public string Ispis(string Ime,int BrojPonavljanja) {

            string x = "";

            for (int i = 0; i < BrojPonavljanja;i++) {

                x += Ime;

            }
            return x;
        }



        public ActionResult Testiranje() {

            int godine = 7;
            string ime = "ivan";
            ViewBag.god = godine;
            ViewBag.im = ime;
            return View();
        }

        public ActionResult Ja() {

            //int God = 20;
            //string Ime = "Katarina";
            //string Prezime = "Jos";
            //ViewBag.g = God;
            //ViewData["godine"] = "20";
            //ViewData["ime"] = "katarina";
            //ViewBag.i = Ime;
            //ViewBag.p = Prezime;
            //ViewData["prezime"] = "jos";

            Ucenik ivo = new Ucenik();
            ivo.Ime = "ivo";
            ivo.Prezime = "ivic";
            ivo.Godine = 16;
            return View(ivo);

        }

        //1.nacin prijenosa podataka iz controllera u view je pomocu ViewBaga
        //a 2.nacin je pomocu ViewData
        //3.nacin je pomocu ViewModela

        public ActionResult PopisUcenika() {

            List<string> ucenici = new List<string>();
            ucenici.Add("adam");
            ucenici.Add("marko");
            ucenici.Add("anastasija");
            ucenici.Add("ana");
            ucenici.Add("ivan");

            //ViewBag.ucenici = ucenici;
            //ViewData["ucenici"] = ucenici;
            return View(ucenici);
        }

        public ActionResult PopisZaposlenika() {

            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            Zaposlenik kata = new Zaposlenik();
            kata.Ime = "Kata";
            kata.Prezime = "katic";
            kata.Placa = "2399";

            Zaposlenik ivo = new Zaposlenik();
            ivo.Ime = "ivo";
            ivo.Prezime = "ivic";
            ivo.Placa = "4242";

            Zaposlenik marko = new Zaposlenik();
            marko.Ime = "marko";
            marko.Prezime = "markic";
            marko.Placa = "3233";

            zaposlenici.Add(kata);
            zaposlenici.Add(ivo);
            zaposlenici.Add(marko);
            return View(zaposlenici);

        }
        }


    }
