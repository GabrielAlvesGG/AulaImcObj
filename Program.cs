using System;

namespace AulaIMCObj
{
    class Program
    {
        static void Main(string[] args)
        {   

           
            Console.WriteLine("Digite o nome do Paciente: ");         
            string NomePaciente= Console.ReadLine();

           
            Console.WriteLine("Digite o peso do paciente : ");
            double pesoPaciente = double.Parse(Console.ReadLine());

           
            Console.WriteLine("Digite a altura do paciente :");
            double alturaPaciente = double.Parse(Console.ReadLine());
            
           
            //Objetos que foram criados
            Paciente  ObjPaciente = new Paciente(NomePaciente, pesoPaciente, alturaPaciente);
            Calculadora CalculaImc = new Calculadora();
           //Objetos que foram criados
           
           
           //São métodos que são utilizados e retornam um valor
            ObjPaciente.ResultadoImcPaciente =  CalculaImc.CalculaImc(ObjPaciente.AlturaPaciente, ObjPaciente.PesoPaciente);
            ObjPaciente.ResultadoStatusPaciente = CalculaImc.StatusPaciente(ObjPaciente.ResultadoImcPaciente);
            //São métodos que são utilizados e retornam um valor

            
            
            //Resultados de todos os dados que foram utilizados
            Console.Clear();
            Console.WriteLine("Nome: " + ObjPaciente.NomePaciente + ", Peso: " + ObjPaciente.PesoPaciente + ", Altura: " + ObjPaciente.AlturaPaciente );
            Console.WriteLine("Imc do paciente : "  + ObjPaciente.ResultadoImcPaciente);
            Console.WriteLine("Status do paciente: " + ObjPaciente.ResultadoStatusPaciente);
            Console.ReadLine();
            //Resultados de todos os dados que foram utilizados
        }
    }
}
