using Core.Domain;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        
        public async Task<IEnumerable<Client>> GetAll()
        {
            var litClients =  Enumerable.Range(1, 5).Select(index => new Client
            {
                Id = Random.Shared.Next(-20, 55),
                Nombre = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
            
            return await Task.FromResult(litClients);
        }
    }
}
