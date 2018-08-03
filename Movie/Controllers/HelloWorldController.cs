using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // Get: /HelloWorld/
        public string Index()
        {
            return "This is my default action";
        }

        //
        // Get: /HelloWorld/Welcome/:id
        public string Welcome(int ID)
        {
            return HtmlEncoder.Default.Encode($"Welcome, your ID is: {ID}");
        }
    }
}
