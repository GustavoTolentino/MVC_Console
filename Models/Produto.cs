using System.Collections.Generic;
using System.IO;

namespace MVC_Console.Models
{
    public class Produto
    {
        public int Codigo{get; set;}
        public string Nome{get; set;}
        public float Preco{get; set;}

        private const string PATH = "Database/Produto.csv";

        public Produto produto()
        {
            // Verificar se a pasta existe
            string pasta = PATH.Split("/")[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }


            // Verificar se o arquivo existe
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            return new Produto();
        }
            
            
            
            
            public List<Produto> Ler(){
                List<Produto> produtos = new List<Produto>();

                string[] linhas = File.ReadAllLines(PATH);

                // Percorremos as linhas do csv
                foreach (string item in linhas)
                {
                    string[] atributos = item.Split(";");
                    // 1;JBL;5.000,00
                    // [0] = 1
                    // [1] = JBL
                    // [2] = 5.000,00

                    // Passamos para um objeto do tipo produto
                    Produto prod = new Produto();
                    prod.Codigo = int.Parse(atributos [0]);
                    prod.Nome = atributos[1];
                    prod.Preco = float.Parse(atributos[3]);

                    produtos.Add(prod);

                    

                }

                return produtos;
            }



        }
    }
