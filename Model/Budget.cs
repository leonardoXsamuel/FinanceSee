using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace PjtFinanceSee.Model;

public class Budget
{
    public long Id { get; set; }

    [StringLength(30, ErrorMessage = "o NOME DO ORÇAMENTO não deve passar de 30 caracteres.")]
    public string Name { get; set; }

    [Range(1, 12, ErrorMessage = "o MÊS deve estar entre 1-12.")]
    public int Month { get; set; }

    [Range(1900, 2700, ErrorMessage = "informe um ANO válido. Ex: 2026.")]
    public int Year { get; set; }

    [ForeignKey("User")]
    public long UserId { get; set; }

    [Required(ErrorMessage = "O ORÇAMENTO deve, obrigatoriamente, estar associado à um usuário.")]
    public User User { get; set; }
}
