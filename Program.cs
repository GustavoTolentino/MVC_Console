using System;
using MVC_Console.Controllers;

namespace MVC_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.ListarProdutos();
        }
    }
}
