using MVCAplikacija.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAplikacija.Controllers
{
    public class ProizvodiJSONController : Controller
    {
        // GET: ProizvodiJSON
        public ActionResult Index(ProizvodJSON proizvodi)
        {
            List<ProizvodJSON> listaProizvoda = new List<ProizvodJSON>();
            JSONOperacije jsonOperacije = new JSONOperacije();

            listaProizvoda = JsonConvert.DeserializeObject<List<ProizvodJSON>>(jsonOperacije.GetJsonData());

            ProizvodJSON proizvod = listaProizvoda.FirstOrDefault(p => p.ID == proizvodi.ID);

            /*
            var pom = listaProizvoda.Select(x => x.ID).ToList();
            foreach (var id in pom)
            {
                if (proizvod.ID != id && proizvod.ID > 0)

            }*/

            if (proizvod == null && proizvodi.ID != 0)
            {
                listaProizvoda.Add(proizvodi);
            }
            else if(proizvodi.ID != 0)
            {
                int index = listaProizvoda.FindIndex(i => i.ID == proizvodi.ID);
                listaProizvoda[index] = proizvodi;
            }

            string jsonString = JsonConvert.SerializeObject(listaProizvoda);
            jsonOperacije.WriteJsonData(jsonString);

            return View("~/Views/ProizvodiJSON/Index.cshtml", listaProizvoda);
        }
    }

    public class JSONOperacije
    {
        string path = System.Web.HttpContext.Current.Server.MapPath("Data/proizvodi.json");

        public JSONOperacije()
        {

        }

        public string GetJsonData()
        {
            string result;

            using(StreamReader streamReader = new StreamReader(path))
            {
                result = streamReader.ReadToEnd();
            }
            return result;
        }

        public void WriteJsonData(string jsonString)
        {
            using(var streamWriter = File.CreateText(path))
            {
                streamWriter.Write(jsonString);
            }
        }

    }
}