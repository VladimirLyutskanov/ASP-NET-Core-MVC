using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Controllers
{
    public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }

        [Route("Error/{statuscode}")]
        public IActionResult HttpStatusCodeHandler(int statuscode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statuscode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the page could not be found";
                    logger.LogWarning($"404 Error Ocurred. Path = {statusCodeResult.OriginalPath}" +
                        $"and QuryString = {statusCodeResult.OriginalQueryString}");
                    break;
            }
            return View("NotFound");
        }



        [Route("Error")]
        [AllowAnonymous]
        public IActionResult Error()
        {
            var exeptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();

            logger.LogError($"The path{exeptionDetails.Path} threw exeption {exeptionDetails.Error}");

            return View("Error");
        }

    }
}
