using Backend.Domain.IRepositories;
using Backend.Domain.IServices;
using Backend.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class UsuarioServices: IUsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;

        }
        public async Task SaveUser(Usuario usuario)
        {
            await _usuarioRepository.SaveUser(usuario);
        }
    }
}
