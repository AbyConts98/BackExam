using Backend.Domain.Models;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    public interface IUsuarioService
    {
        Task SaveUser(Usuario usuario);
    }
}