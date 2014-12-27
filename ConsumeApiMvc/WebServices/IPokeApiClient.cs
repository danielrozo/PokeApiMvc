using ConsumeApiMvc.Models;
using System.Threading.Tasks;

namespace ConsumeApiMvc.WebServices
{
    public interface IPokeApiClient
    {
        Task<Pokemon> GetPokemon(int id);

        Task<Ability> GetAbility(int id);

        Task<Models.Type> GetType(int id);
    }
}
