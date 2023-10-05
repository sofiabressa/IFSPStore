using IFSPStore;
using IFStore.Domain.Entities;
using System.Text.Json;

namespace IFSPStore.text;
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestUsuario()
        {
            var usuario = new Usuario();
            usuario.Nome = "Emanuel";
            Console.WriteLine(JsonSerializer.Serialize(usuario));

            Assert.AreEqual(usuario.Nome, "Emanuel");


        }
        [TestMethod]
        public void TestProduto()
        {
            var produto = new Produto();
            produto.Nome = "Alface";
            Console.WriteLine(JsonSerializer.Serialize(produto));

            Assert.AreEqual(produto.Nome, "Alface");
        }
    }
