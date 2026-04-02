using PjtFinanceSee.Model.Enums;
using PjtFinanceSee.Validations;
using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.DTOs.User;

public record UserUpdateDTO
{
    [Required(ErrorMessage = "o NOME DO ORÇAMENTO é obrigatório.")]
    [StringLength(30, ErrorMessage = "o NOME DO ORÇAMENTO3 não deve passar de 30 caracteres.")]
    public string Name { get; set; }
  
    [DecimalValuesRange(00.1, 99999999999.99)]
    [Required(ErrorMessage = "o atributo SÁALÁRIO precisa ser preenchido.")]
    public decimal Salary { get; set; }

    [Required(ErrorMessage = "o atributo STATUS precisa ser preenchido.")]
    public StatusUser Status { get; init; } = StatusUser.ACTIVE;

    public DateTime UpdateAt { get; init; } = DateTime.UtcNow;
}
