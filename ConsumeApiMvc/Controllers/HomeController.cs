using ConsumeApiMvc.ViewModels;
using ConsumeApiMvc.WebServices;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ConsumeApiMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPokeApiClient _pokeApiClient;

        public HomeController(IPokeApiClient pokeApiClient)
        {
            _pokeApiClient = pokeApiClient;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pokemon()
        {
            var vm = new PokemonViewModel();
            return View(vm);
        }

        [HttpPost]
        public async Task<ActionResult> Pokemon(int id)
        {
            var pokemon = await _pokeApiClient.GetPokemon(id);
            var vm = new PokemonViewModel
            {
                Pokemon = pokemon
            };
            return View(vm);
        }

        public ActionResult Ability()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Ability(int id)
        {
            var ability = await _pokeApiClient.GetAbility(id);
            return View(ability);
        }

        public ActionResult Type()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Type(int id)
        {
            var type = await _pokeApiClient.GetType(id);
            return View(type);
        }
    }
}