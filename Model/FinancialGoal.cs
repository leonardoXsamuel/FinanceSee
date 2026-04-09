using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.Model;

public class FinancialGoal
{
    public long Id { get; set; }

    [Required(ErrorMessage = "Preencha o atributo NOME.")]
    [StringLength(30, ErrorMessage = "o NOME DO OBJETIVO não deve passar de 30 caracteres.")]
    public string NameGoal { get; set; }

    public Decimal TargetValue { get; set; }

    private decimal _progressValue;
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
}
