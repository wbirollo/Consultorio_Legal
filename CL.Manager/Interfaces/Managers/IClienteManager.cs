﻿using CL.Core.Domain;
using CL.Core.Shared.ModelViews.Cliente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CL.Manager.Interfaces.Managers
{
    public interface IClienteManager
    {
        Task DeleteClienteAsync(int id);

        Task<Cliente> GetClienteAsync(int id);

        Task<IEnumerable<Cliente>> GetClientesAsync();

        Task<Cliente> InsertClienteAsync(NovoCliente cliente);

        Task<Cliente> UpdateClienteAsync(AlteraCliente cliente);
    }
}