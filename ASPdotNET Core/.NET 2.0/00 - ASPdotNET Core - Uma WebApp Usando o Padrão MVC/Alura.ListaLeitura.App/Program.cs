﻿using Alura.ListaLeitura.App.Negocio;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Alura.ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder().UseKestrel().UseStartup<Startup>().Build();
            host.Run();

            /*var _repo = new LivroRepositorioCSV();
            ImprimeLista(_repo.ParaLer);
            ImprimeLista(_repo.Lendo);
            ImprimeLista(_repo.Lidos);*/
        }

        static void ImprimeLista(ListaDeLeitura lista)
        {
            Console.WriteLine(lista);
        }
    }
}
