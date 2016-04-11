using lojaComEntity.Entidades;
using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadesContext contexto = new EntidadesContext();

            PessoaFisica pf = new PessoaFisica()
            {
                Nome = "Guilherme",
                CPF = "123456",
                Senha = "123"
            };

            contexto.PessoasFisicas.Add(pf);

            PessoaJuridica pj = new PessoaJuridica()
            {
                Nome = "Alura",
                CNPJ = "789",
                Senha = "123"
            };

            contexto.PessoasJuridica.Add(pj);

            contexto.SaveChanges();
        } 
    }
}
