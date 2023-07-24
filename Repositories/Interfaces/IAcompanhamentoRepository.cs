using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcompanhamentoPaciente.Models;

namespace AcompanhamentoPaciente.Repositories.Interfaces
{
    public interface IAcompanhamentoRepository
    {
        Task<IEnumerable<Acompanhamento>> BuscarTodos();
        Task<Acompanhamento?> BuscarPorId(int id);
        Task<bool> Adicionar(Acompanhamento acompanhamento);
        Task<bool> Atualizar(int id, Acompanhamento acompanhamento);
        Task<bool> ExcluirPorId(int id);
    }
}