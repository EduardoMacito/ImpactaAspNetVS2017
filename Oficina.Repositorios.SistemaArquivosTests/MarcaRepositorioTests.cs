﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class MarcaRepositorioTests
    {
        MarcaRepositorio _marcaRepositorio = new MarcaRepositorio();

        [TestMethod()]
        public void SelecionarTest()
        {
            var marcas = _marcaRepositorio.Selecionar();

            foreach (var marca in marcas)
            {
                Console.WriteLine($" {marca.Id}: {marca.Nome}");

            }
        }

        [TestMethod()]
        [DataRow(3)] //parametro de entrada
        [DataRow(-1)] //executa quantas vezes for necessário
        public void SelecionarPorIdTeste(int id)
        {
            var marca = _marcaRepositorio.Selecionar(id);

            if (id > 0)
            {
                Assert.IsTrue(marca.Nome == "GM");
                // Assert.IsTrue(cor.Nome.Equals("GM"));
            }
            else
            {
                Assert.IsNull(marca);

            }
        }
    }
}