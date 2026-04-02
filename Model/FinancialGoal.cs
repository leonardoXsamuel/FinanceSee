using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.Model;

public class FinancialGoal
{

    public long Id { get; set; }

    [StringLength(30, ErrorMessage = "o nome do orçamento não deve passar de 30 caracteres.")]
    public string Name { get; set; }
    // criar demais atributos e inserir anotações

    public Decimal TargetValue { get; set; }

    public Decimal Progress
    {
        get; set
        {

            if (value < 0 || value >= TargetValue)
                throw new Exception("o progresso não pode ser negativo ou maior do que o valor-alvo.");

            Progress = value;

        }
    }

    // adicionar annot de FK
    public long UserId { get; set; }
    public User User { get; set; }
}
