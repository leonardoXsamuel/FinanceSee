using Microsoft.AspNetCore.Identity;
using PjtFinanceSee.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.Model;

public class User
{
    [Key]
    public long Id { get; set; }

    [Required(ErrorMessage = "preencha o NOME")]
    [StringLength(55, ErrorMessage = "o nome de usuario não deve passar de 55 caracteres.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "preencha o TELEFONE.")]
    [RegularExpression(@"^\(?\d{2}\)?\s?\d{4,5}-?\d{4}$",
     ErrorMessage = "informe um telefone válido com DDD. Ex: (11) 91234-5678")]
    [MaxLength(15)]
    public string Phone { get; set; }

    [Required(ErrorMessage = "preencha o EMAIL.")]
    [EmailAddress(ErrorMessage = "Valor digitado é inválido.")]
    public string Email { get; set; }

    [MaxLength(20, ErrorMessage = "o atributo SENHA não pode ter mais de 20 caracteres.")]
    [Required(ErrorMessage = "preencha a SENHA.")]
    public string Password { get; set; }

    public StatusUser Status { get; init; } = StatusUser.ACTIVE;

    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;


}
