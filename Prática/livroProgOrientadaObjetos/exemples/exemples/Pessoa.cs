﻿using Microsoft.VisualBasic;
namespace exemples
{
    abstract class Pessoa
    {
         string Nome;
         char Sexo;
    }
    public class Paciente : Pessoa
    {
        DateFormat dataInternacao;
    }
    public class Funcionario : Pessoa
    {
        DateFormat dataAdmissao;
        string matricula;
    }
    public class Medico : Funcionario
    {
        DateFormat CRM;

        void Operar()
        {
            
        }
        
        
        
    }
}