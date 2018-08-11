using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi_JqueryAjax_Post.Service.Controllers
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
    public class VerilerController : ApiController
    {
        List<Insan> insanListe = new List<Insan>();

        public List<Insan> GetInsanlar()
        {
            return insanListe;
        }

        public void PostInsan(Insan insan)
        {
            insanListe.Add(insan);
        }
    }
}
