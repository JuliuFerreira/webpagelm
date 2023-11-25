using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace webpagelm.Pages
{
    public class SocialModel : PageModel
    {
        private readonly ILogger<SocialModel> _logger;

        public SocialModel(ILogger<SocialModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Doacao Ajuda { get; set; }
        public class Doacao
        {

            [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, nos informe o nome da instituição.")]
            public string Instituicao { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Precisamos do telefone para contato.")]
            public string Tel { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Conte um pouco sobre a instituição indicada...")]
            public string Mensagem { get; set; }
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                ViewData["MsgSucesso"] = $"Obrigado por sua indicação, entraremos em contato com a instituição {Ajuda.Instituicao}. ";
                return Page();

            }
            return Page();
        }
    }

}