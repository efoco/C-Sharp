using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovies.Controllers
{
    public class HelloWorld : Controller
    {
        //
        // GET: /Welcome/

        public string Index()
        {
            return "This is my index page";
        }

        public string Welcome(string name, int numTimes=1) 
        {
            return HttpUtility.HtmlEncode("Hello " + name + " , numTimes is " + numTimes);
        }

    }
}
