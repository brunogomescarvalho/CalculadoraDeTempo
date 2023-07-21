using CalculadoraDeTempo.Domain;

namespace CalculadoraDeTempo.Teste
{
    [TestClass]
    public class CalculadoraTempoTestes
    {
        CalculadoraTempo periodo;

        public CalculadoraTempoTestes()
        {
            periodo = new CalculadoraTempo();
        }

        [TestMethod]
        public void Deve_retornar_um_minuto()
        {
            DateTime data = DateTime.Now.AddMinutes(-1);

            string periodoEmTexto = periodo.ObterTempoString(data);

            Assert.AreEqual("O teste foi realizado a 1 minuto atrás", periodoEmTexto);
        }

        [TestMethod]
        public void Deve_retornar_uma_hora()
        {
            DateTime data = DateTime.Now.AddHours(-1);

            string periodoEmTexto = periodo.ObterTempoString(data);

            Assert.AreEqual("O teste foi realizado a 1 hora atrás", periodoEmTexto);
        }


        [TestMethod]
        public void Deve_retornar_um_dia()
        {
            DateTime data = DateTime.Now.AddDays(-1);

            string periodoEmTexto = periodo.ObterTempoString(data);

            Assert.AreEqual("O teste foi realizado a 1 dia atrás", periodoEmTexto);

        }

        [TestMethod]
        public void Deve_retornar_uma_semana_e_quatro_dias()
        {
            DateTime data = DateTime.Now.AddDays(-11);

            string periodoEmTexto = periodo.ObterTempoString(data);

            Assert.AreEqual("O teste foi realizado a 1 semana e 4 dias atrás", periodoEmTexto);
        }


        [TestMethod]
        public void Deve_retornar_dois_meses_tres_semanas_e_quatro_dias()
        {
            DateTime data = DateTime.Now.AddDays(-85);

            string periodoEmTexto = periodo.ObterTempoString(data);

            Assert.AreEqual("O teste foi realizado a 2 meses 3 semanas e 4 dias atrás", periodoEmTexto);
        }
    }
}