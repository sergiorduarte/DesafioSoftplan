using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSoftplan.Services.Services.Interfaces
{
    public interface IJurosService
    {
        Task<double> TaxaJuros();
        Task<string> Calculajuros(double valorInicial, int meses);
    }
}
