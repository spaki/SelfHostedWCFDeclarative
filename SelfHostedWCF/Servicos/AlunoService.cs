using SelfHostedWCF.Contratos;
using SelfHostedWCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfHostedWCF.Servicos
{
    public class AlunoService : IAlunoService
    {
        private static List<Aluno> alunos;
        public Aluno Criar(Aluno aluno)
        {
            if (alunos == null)
                alunos = new List<Aluno>();

            // validar idade 
            if (aluno.Idade < 5)
                throw new Exception("Idade inválida");

            // gerar id
            aluno.Id = alunos.Count + 1;

            alunos.Add(aluno);

            return aluno;
        }

        public List<Aluno> Listar(string parteDoNome)
        {
            if (string.IsNullOrWhiteSpace(parteDoNome))
                parteDoNome = string.Empty;

            var resultado = alunos.Where(aluno => aluno.Nome.Contains(parteDoNome)).ToList();
            return resultado;
        }
    }
}
