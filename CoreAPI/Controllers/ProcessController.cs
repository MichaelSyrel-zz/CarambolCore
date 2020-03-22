using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core;

namespace CoreAPI.Controllers
{
    [Route("/api/ProcessController")]
    public class ProcessController : ApiController
    {
        [Route("Process")]
        [HttpGet]
        public HttpResponseMessage GetProcessById(int processId)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("ActiveProcesses")]
        [HttpGet]
        public HttpResponseMessage GetActiveProcesses()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
