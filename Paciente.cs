using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaIMCObj
{
    public class Paciente
    {   
    //Propriedades do paciente / Variável 
        public string NomePaciente {get;set;}

        public double PesoPaciente { get; set; }

        public double AlturaPaciente {get;set; }

       public double ResultadoImcPaciente{get;set;}

       public string ResultadoStatusPaciente {get; set;}
    //Propriedades do paciente / Variável 

    //Construtor da class / Objeto
       public Paciente(string nome, double peso, double altura){
        
        NomePaciente = nome;
        
        PesoPaciente = peso;
        
        AlturaPaciente = altura;

       }
       //Construtor da class / Objeto

    }
}