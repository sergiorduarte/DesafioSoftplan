using DesafioSoftplan.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services
{

    public class JurosService : IJurosService
    {
        public async Task<string> Calculajuros(double valorInicial, int meses)
        {
            var valor = valorInicial * (1 + await TaxaJuros());
            var pow = Math.Pow(10, 8);
            var valorTruncado = Math.Truncate(Math.Pow(valor, meses)) / pow;
            return valorTruncado.ToString("###,###,##0.00", CultureInfo.CurrentCulture) ;
        }
        public async Task<double> TaxaJuros()
        {
            return 0.01;
        }


    }
}
