using System;

namespace AulaIMCObj
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            
            Console.WriteLine("Quantos Pacientes seram examinados :");
            int QuantPaciente = int.Parse(Console.ReadLine());
            
            //Objetos utilizados
            Paciente  ObjPaciente = new Paciente();
            Calculadora CalculaImc = new Calculadora();
            //Objetos utilizados

            //Armazena a quantidade de Pacientes que for necessário.
            for (int i = 0; i  < QuantPaciente; i ++)
            {
                Paciente NovoPaciente = new Paciente();   
                Console.WriteLine("Digite o nome do Paciente: ");         
                NovoPaciente.NomePaciente = Console.ReadLine();
                Console.WriteLine("Digite o peso do paciente : ");
                NovoPaciente.PesoPaciente = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do paciente :");
                NovoPaciente.AlturaPaciente = double.Parse(Console.ReadLine());
            
                NovoPaciente.ResultadoImcPaciente =  CalculaImc.CalculaImc(NovoPaciente.AlturaPaciente, NovoPaciente.PesoPaciente);
                NovoPaciente.ResultadoStatusPaciente = CalculaImc.StatusPaciente(NovoPaciente.ResultadoImcPaciente);
                ObjPaciente.ListaPaciente.Add(NovoPaciente);
            }
            
            
            //Resultados de todos os dados que foram utilizados
            Console.Clear();
            foreach (Paciente paciente in ObjPaciente.ListaPaciente)
            {
                Console.WriteLine("Nome: " + paciente.NomePaciente + ", Peso: " + paciente.PesoPaciente + ", Altura: " + paciente.AlturaPaciente );
                Console.WriteLine("Imc do paciente : "  + paciente.ResultadoImcPaciente);
                Console.WriteLine("Status do paciente: " + paciente.ResultadoStatusPaciente);
                Console.ReadLine();
            //Resultados de todos os dados que foram utilizados
            }
        }
    }
}
