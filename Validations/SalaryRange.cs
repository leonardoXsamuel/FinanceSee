using System.ComponentModel.DataAnnotations;

namespace PjtFinanceSee.Validations;

public class DecimalValuesRange : ValidationAttribute
{
    private readonly decimal _min;
    private readonly decimal _max;

    public DecimalValuesRange(double min, double max)
    {
        _min = (decimal)min;
        _max = (decimal)max;
    }

    protected override ValidationResult IsValid(object value, ValidationContext context)
    {
        if (value is not decimal d)
            return new ValidationResult("o valor informado é inválido.");

        if (d < _min || d > _max)
            return new ValidationResult(
                ErrorMessage ?? $"o valor deve estar entre {_min:C} e {_max:C}.");

        return ValidationResult.Success;
    }
}

}
