using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace webpagelm.Pages
{
    public class ContatoModel : PageModel
    {
        private readonly ILogger<ContatoModel> _logger;

        public ContatoModel(ILogger<ContatoModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Contato Retorno { get; set; }
        public class Contato
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, qual seu nome?")]
            public string Nome { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Informe um E-mail.")]
            [EmailAddress(ErrorMessage = "Email Inválido.")]
            public string Email { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Precisamos do seu telefone de contato!")]
            public string Tel { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Envie uma mensagem.")]
            public string Mensagem { get; set; }
        }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                ViewData["MsgSucesso"] = $"{Retorno.Nome} Recebemos sua mensagem, retornatemos no telefone informado o mais breve possível.";
                return Page();

            }
            return Page();
        }
    }
}
 