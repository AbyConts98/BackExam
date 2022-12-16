using Backend.Domain.IRepositories;
using Backend.Domain.Models;
using Backend.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   

namespace Backend.Persistence.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AplicationDbContext _context;
        public UsuarioRepository(AplicationDbContext context)
        {
            _context = context;

        }
        public async Task SaveUser(Usuario usuario) 
        {
            _context.Add(usuario);
            await _context.SaveChangesAsync();
        }
    }
}
