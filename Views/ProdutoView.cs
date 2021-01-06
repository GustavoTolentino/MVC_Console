using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produtos){
            foreach (var item in produtos)
            {
                System.Console.WriteLine($"Codigo : {item.Codigo}");
                System.Console.WriteLine($"Produto : {item.Nome}");
                System.Console.WriteLine($"Preco : {item.Preco}");
            }
        }
    }
}