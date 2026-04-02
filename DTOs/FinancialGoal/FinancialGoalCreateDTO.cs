using PjtFinanceSee.Model;
using PjtFinanceSee.Validations;
using System.ComponentModel.DataAnnotations;


public record UserCreateDTO
{
    [Required(ErrorMessage = "Preencha o atributo NOME.")]
    [StringLength(30, ErrorMessage = "o NOME DO OBJETIVO não deve passar de 30 caracteres.")]
    public string NameGoal { get; set; }

    public Decimal TargetValue { get; set; }

    private decimal _progressValue;

    [Required(ErrorMessage = "")]
    [DecimalValuesRange(0.1,9999999999999.0, ErrorMessage = "o VALOR DE PROGRESSO inserido deve estar entre 0.1 e 9.999.999.999.999.0")]
    public Decimal ProgressValue
    {
        get => _progressValue;
        set
        {

            if (value < 0 || value > TargetValue)
                throw new Exception("o progresso não pode ser negativo ou maior do que o valor-alvo.");

            _progressValue = value;

        }
    }

    [DecimalValuesRange(0,100,ErrorMessage = "o valor de PROGRESSO deve estar entre 0% e 100%.")]
    public double ProgressPercent
    {
        get
        {
            if (TargetValue <= 0)
                return 0;

            return (double)(ProgressValue / TargetValue) * 100;
        }
    }

    // adicionar annot de FK
    [Required]
    public long UserId { get; set; }
    public User User { get; set; }

    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
