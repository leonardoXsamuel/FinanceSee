using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace PjtFinanceSee.Model;

public class Budget
{

    public long Id { get; set; }

    [StringLength(30, ErrorMessage = "o nome do orçamento não deve passar de 30 caracteres.")]
    public string Name { get; set; }

    private int _month;
    public int Month
    {
        get => _month;
        set
        {
            if (value > 12 || value < 0)
                throw new Exception("o atributo MÊS deve estar entre 1-12.");

            _month = value;
        }
    }

    [Range(1900, 2700, ErrorMessage = "informe um ano válido.")]
    public int Year { get; set; }

    private decimal _salary;
    public decimal Salary
    {
        get => _salary; 
        set
        {
            if (value < 0)
                throw new Exception("o atributo SALARIO não pode ser negativo.");

            _salary = value;
        }
    }

    // adicionar annot de FK
    public long UserId { get; set; }

    public User User { get; set; }


}
