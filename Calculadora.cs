using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaIMCObj
{
    public class Calculadora
    {   

        //Método - Calcula o imc 
        public double CalculaImc(double p_AlturaPaciente , double p_PesoPaciente){
            
            return p_PesoPaciente / (p_AlturaPaciente * p_AlturaPaciente);

        }


        //Método - Mostra o status do paciente.
        public string StatusPaciente(double ImcResultado){
            
            
            if(ImcResultado < 18)
            return "Você está muito magro";

            if(ImcResultado < 24)
            return "Você está no peso ideal";

            if(ImcResultado< 30)
            return "Vocês está muito gordo";

            return "Status invalido";
        }
    }
}