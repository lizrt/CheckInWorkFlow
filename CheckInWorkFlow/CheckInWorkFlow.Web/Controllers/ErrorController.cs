using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CheckInWorkFlow.Web.Models;
using CheckInWorkFlow.Business.Services;
using AutoMapper;
using CheckInWorkFlow.Data.Models;
using CheckInWorkFlow.Web.ViewModels;
using Microsoft.AspNetCore.Diagnostics;

namespace CheckInWorkFlow.Web.Controllers
{
public class ErrorController : Controller
    {
        private readonly ILogger<ErrorController> _logger;
        public ErrorController(ILogger<ErrorController> logger)
        {
            this._logger = logger;
        }
        /// <summary>
        /// This method handles 404 statuscode and show appropriate error page to user, the route is registered in startup.cs
        /// </summary>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            switch (statusCode)
            {
                case 404:
                    ////this log level logs message to file which is mentioned in nlog.config
                    ViewBag.ErrorMessage = "Sorry, the resource you looking for could not be found";
                    _logger.LogWarning($"404 Error Occured.Path = {statusCodeResult.OriginalPath}"+
                        $" and QueryString = {statusCodeResult.OriginalQueryString}");
                    break;
            }
            return View("NotFound");
        }
        /// <summary>
        /// This method handle exceptions globally, based on route mentioned in startup file ,return Error view page
        /// </summary>
        /// <returns></returns>
        [Route("Error")]
        public IActionResult Error()
        {
            var exceptionDetails = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            _logger.LogError($"The path {exceptionDetails.Path} threw an exception "+ $"{exceptionDetails.Error}");
            return View("Error");
        }
    }
}