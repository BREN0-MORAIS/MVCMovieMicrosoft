using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Essa é Minha Action Padrão";
        //}

        //public string Welcome(string name,int  numTimes = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //}

        //public string Welcome(string name , int Id=1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name} ,  ID: {Id}");
        //}

    }
}
