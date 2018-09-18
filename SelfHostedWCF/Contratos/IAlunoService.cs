using SelfHostedWCF.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace SelfHostedWCF.Contratos
{
    [ServiceContract]
    public interface IAlunoService
    {
        [OperationContract]
        Aluno Criar(Aluno aluno);

        [OperationContract]
        List<Aluno> Listar(string parteDoNome);
    }
}
