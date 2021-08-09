using DesafioSoftplan.Services.Services;
using DesafioSoftplan.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioSoftplan.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JurosController : ControllerBase
    {
        private readonly IJurosService _jurosService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="jurosService"></param>
        public JurosController(IJurosService jurosService)
        {
            _jurosService = jurosService;
        }

        /// <summary>
        /// Retorna a taxa de juros
        /// </summary>
        
        /// <returns></returns>
        [HttpGet("taxaJuros")]
        public async Task<IActionResult> TaxaJuros()
        {
            return Ok(await _jurosService.TaxaJuros());
        }


        /// <summary>
        /// Retorna o calculo com juros compostos
        /// </summary>
        /// <remarks>
        /// Envio
        /// Get
        /// {
        ///  "valorInicial":double,
        ///  "meses":int
        /// }
        /// 
        /// </remarks>
        /// <param name="valorInicial"></param>
        /// <param name="meses"></param>
        /// <returns></returns>
        [HttpGet("calculajuros")]
        public async Task<IActionResult> Calculajuros(double valorInicial, int meses)
        {
            return Ok(await _jurosService.Calculajuros(valorInicial, meses));
        }
    }
}
