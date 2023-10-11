using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webpagelm.Pages
{
    public class SimuladorModel : PageModel
    {
        private readonly ILogger<SimuladorModel> _logger;

        public SimuladorModel(ILogger<SimuladorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}