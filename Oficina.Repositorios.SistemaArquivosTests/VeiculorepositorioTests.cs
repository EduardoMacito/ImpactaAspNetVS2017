using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculorepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new Veiculo();
            
            veiculo.Ano = 2018;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Flex;
            veiculo.Cor = new CorRepositorio().Selecionar(2);
            veiculo.Modelo = new ModeloRepositorio().Selecionar(3);
            veiculo.Placa = "ENR-5975";
            veiculo.Observacao = "Observação!!";

            new VeiculoRepositorio().Inserir(veiculo);
        }
    }
}