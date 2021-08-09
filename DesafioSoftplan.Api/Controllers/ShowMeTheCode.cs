using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioSoftplan.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShowMeTheCode
    {
        /// <summary>
        /// Retorna a url do git
        /// </summary>
        /// <returns></returns>
        [HttpGet("showmethecode")]
        public string Code()
        {
            return "https://github.com/sergiorduarte/DesafioSoftplan";
        }
    }
}
