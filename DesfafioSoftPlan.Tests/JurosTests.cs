using DesafioSoftplan.Services.Services;
using DesafioSoftplan.Services.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DesfafioSoftPlan.Tests
{
    [TestClass()]
    public class JurosTests 
    {
        protected IJurosService _jurosService;

        [TestInitialize]
        public void Setup()
        {
            _jurosService = new JurosService();
        }
        [TestCategory("Juros")]
        [TestMethod("Verifica a TaxaJuros")]
        [DataRow(0.01)]
        public async Task Juros_VerificaTaxaDeJuros_Valido(double value)
        {
            // arrange
           
           
            //// act
            var resultTask = await _jurosService.TaxaJuros();

            //// Assert
            Assert.IsTrue(value == resultTask);
        }

        [TestCategory("Juros")]
        [TestMethod("Verifica a TaxaJuros")]
        [DataRow(0.02)]
        public async Task Juros_VerificaTaxaDeJuros_Invalid(double value)
        {
            // arrange


            //// act
            var resultTask = await _jurosService.TaxaJuros();

            //// Assert
            Assert.IsTrue(value != resultTask);
        }
        [TestCategory("Juros")]
        [TestMethod("Calcula o valor dos juros")]
        [DataRow(100,5, "105,10")]
        public async Task Juros_CalculaOValorDosJuros_Valid(double valorInicial,int meses, string valorFinal)
        {
            // arrange

            //// act
            var resultTask = await _jurosService.Calculajuros(valorInicial,meses);

            //// Assert
            Assert.IsTrue(valorFinal == resultTask);
        }
        [TestCategory("Juros")]
        [TestMethod("Calcula o valor dos juros")]
        [DataRow(100, 5, 106.10)]
        [DataRow(0, 5, 106.10)]
        public async Task Juros_CalculaOValorDosJuros_Invalid(double valorInicial, int meses, double valorFinal)
        {
            // arrange

            //// act
            var resultTask = await _jurosService.Calculajuros(valorInicial, meses);

            //// Assert
            Assert.IsTrue(valorFinal.ToString() != resultTask);
        }
    }
}
