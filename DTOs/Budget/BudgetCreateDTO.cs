using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.DTOs.Budget;

public class BudgetCreateDTO
{
    [StringLength(30, ErrorMessage = "o NOME DO ORÇAMENTO não deve passar de 30 caracteres.")]
    public string Name { get; set; }

    [Range(1, 12, ErrorMessage = "o MÊS deve estar entre 1-12.")]
    public int Month { get; set; }

    [Range(1900, 2700, ErrorMessage = "informe um ANO válido. Ex: 2026.")]
    public int Year { get; set; }

    [Required(ErrorMessage = "O ORÇAMENTO deve estar associado a um usuário.")]
    public long UserId { get; set; }
}
