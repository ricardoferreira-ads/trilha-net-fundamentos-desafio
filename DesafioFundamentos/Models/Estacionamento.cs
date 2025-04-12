using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }
    private List<string> veiculos = new List<string>();
    public void AdicionarVeiculo()
    {
        //Solicita para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string entrada = Console.ReadLine();
        
        if(entrada is not null){
        veiculos.Add(entrada);
        }

        Console.WriteLine($"Novo veiculo estacionado. Placa: {entrada}");
    }
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        //Solicita para o usuário digitar a placa e armazenar na variável placa
        string placa = "";
        placa = Console.ReadLine();
        if(placa is not null){
        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = 0;
            decimal valorTotal = 0; 
            //Solicita para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            Console.WriteLine("Quantas horas o veículo permaneceu estacionado?");
            horas =  Convert.ToInt32(Console.ReadLine());
            //Realiza o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            valorTotal = precoInicial + (precoPorHora*horas);
            //Remove a placa digitada da lista de veículos
            veiculos.Remove(placa);
            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
        }
    }
    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            //Realiza um laço de repetição, exibindo os veículos estacionados
            int cont = 1; 
            foreach (string veiculo in veiculos){
                Console.WriteLine($"Veiculo {cont}. Placa: {veiculo.ToUpper()}");
                cont++;
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
   
    }
}