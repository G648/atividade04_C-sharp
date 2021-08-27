using System;

namespace Atividade04
{
    class Program
    {
        //Escreva um programa que receba a idade de 10 pessoas, 
        //calcule e exiba a quantidade de pessoas mais de 18 anos 
        //e a quantidade de pessoas com menos de 18 anos.
        static void Main(string[] args)
        {
            Console.WriteLine("seja bem vindo ao programa!");

            int pessoas =0;
            int idade;
            

            do
            {
                Console.WriteLine("digite a sua idade: ");
                idade = int.Parse(Console.ReadLine());
                pessoas ++;

                 if(idade >= 18){
                    Console.WriteLine("voce é maior de idade");
                    
                }else{
                    Console.WriteLine($"voce é menor de idade");
                }

            } while (pessoas <=5);

            Console.WriteLine($"o numero de pessoas maiores de idade é de: ");
            Console.WriteLine($"o numero de pessoas menores de idade é de:  ");
        }
    }
}
