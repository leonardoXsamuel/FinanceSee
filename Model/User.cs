using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.Model;

public class User
{
    public long Id { get; set; }

    [Required(ErrorMessage = "preencha o NOME")]
    [StringLength(55, ErrorMessage = "o nome de usuario não deve passar de 55 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "preencha o EMAIL")]
    [EmailAddress(ErrorMessage = "Valor digitado é inválido.")]
    public string Email { get; set; }

    public string Password { get; set; }

    public DateTime CreatedAt { get; set;  }


    // criar demais atributos e inserir anotações


}
