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

       public List<Paciente> ListaPaciente = new   List<Paciente>();


    //Propriedades do paciente / Variável 

    //Construtor da class / Objeto
       
       public Paciente()
       {

       }
       //Construtor da class / Objeto
    }
}