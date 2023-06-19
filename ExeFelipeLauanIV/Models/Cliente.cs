using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExeFelipeLauanIV.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        [DataType(DataType.Text)]
        [DisplayName("Código do Cliente")]
        public int IdCli { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(150)]
        [DataType(DataType.Text)]
        [DisplayName("Nome do Cliente")]
        public string NomeCli { get; set; }

        [Required(ErrorMessage = "Informe o CPF")]
        [MaxLength(19)]
        [DataType(DataType.Text)]
        [DisplayName("CPF")]
        [System.Web.Mvc.Remote("SelectCPF", "Home", ErrorMessage = "CPF já cadastrado")]
        public int Cpf { get; set; }

        [Required(ErrorMessage = "O e-mail é obrigatório")]
        [MaxLength(50)]
        [DataType(DataType.EmailAddress)]
        [DisplayName("E-mail")]
        [System.Web.Mvc.Remote("SelectEmail", "Home", ErrorMessage = "E-mail já cadastrado")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Login é obrigatório")]
        [MaxLength(15)]
        [DataType(DataType.Text)]
        [DisplayName("Login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        [MaxLength(15)]
        [DataType(DataType.Password)]
        [DisplayName("Senha")]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas são diferentes")]
        [DisplayName("Confirme a senha")]
        public string ConfirmaSenha { get; set; }

        [Required(ErrorMessage = "A data é obrigatória")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data do cadastro")]
        [DataType(DataType.Date)]
        [Compare("DataAtual", ErrorMessage = "A data de cadastro deve ser igual ou posterior à data atual.")]
        public DateTime? DataCadastro { get; set; }

        public DateTime DataAtual { get; set; } = DateTime.Now.Date;
    }
}
