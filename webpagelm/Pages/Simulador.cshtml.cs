using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace webpagelm.Pages
{
    public class SimuladorModel : PageModel
    {
        private readonly ILogger<SimuladorModel> _logger;

        public SimuladorModel(ILogger<SimuladorModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public Pessoa Cliente { get; set; }
        public class Pessoa
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor, qual seu nome?")]
            public string Nome { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Digite seu CPF para lhe entregar uma simulção mais completa.")]
            public string Cpf { get; set; }

            [Required (AllowEmptyStrings = false, ErrorMessage = "Informe um E-mail.")]
            [EmailAddress (ErrorMessage = "Email Inválido")]
            public string Email { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Precisamos do seu telefone de contato!")]
            public string Tel { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Nos informe quanto você precisa:")]
            public string Valor { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Escreva algumas informações adicionais apra que possamos melhor lhe atender!")]
            public string Mensagem { get; set; }
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                ViewData["MsgSucesso"] =  $"{Cliente.Nome} Recebemos sua solicitação, logo entraremos em contato com a simulação solicitada.";
                return Page();

            }
            return Page();
        }
    }
}