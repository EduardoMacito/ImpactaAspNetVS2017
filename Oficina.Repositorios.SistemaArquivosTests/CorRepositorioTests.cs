using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
       private CorRepositorio _corRepositorio = new CorRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            var cores = _corRepositorio.Selecionar();

            foreach (var cor in cores)
            {
                Console.WriteLine($" {cor.Id}: {cor.Nome}");

            }
        }

        [TestMethod()]
        [DataRow(1)] //parametro de entrada
        [DataRow(-1)] //executa quantas vezes for necessário
        public void SelecionarPorIdTeste(int id)
        {
            var cor = _corRepositorio.Selecionar(id);

            if (id > 0)
            {
                Assert.IsTrue(cor.Nome == "Amarelo");
               // Assert.IsTrue(cor.Nome.Equals("Amarelo"));
            }
            else
            {
                Assert.IsNull(cor);

            }
        }
    }
}