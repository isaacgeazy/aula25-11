using.System;
using.Microsoft.AspNetCore.Mvc;

namespace NomeCompletoDevWeb.Controllers
   {
[ApiController]
[Route("[controller]")]
public class Nome : ControllerBase
{
[HttpPost]
public Nomes Port(NomeCliente nomeRecebido)
{
    var nomeProcessado = new Nomes {
NomeCompleto = $"{nomeRecebido.nome}, {nomeRecebido.sobrenome}"
NomeCatalogo = $"{nomeRecebido.sobrenome.toUpper()}, {nomeRecebido.nome}"
    }
}
}
}