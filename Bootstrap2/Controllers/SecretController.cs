using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bootstrap2.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class SecretController : Controller
    {
        public ContentResult Secret()
        {
            return Content("This is a secret...");
        }

        [AllowAnonymous]
        public ContentResult Overt()
        {
            return Content("This is not a secret....");
        }
    }
}