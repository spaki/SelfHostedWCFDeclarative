using SelfHostedWCF.Servicos;
using System;
using System.ServiceModel;

namespace SelfHostedWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(AlunoService), new Uri[] { });
            host.Open();
            Console.WriteLine("Serviço rodando...");
            Console.WriteLine("Tecle para finalizar.");
            Console.ReadKey();
            host.Close();
        }
    }
}
