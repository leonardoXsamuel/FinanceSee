using PjtFinanceSee.Model;

namespace PjtFinanceSee.DTOs.FinancialGoal;

public record FinancialGoalResponseDTO(string NameGoal,
        Decimal TargetValue,
        Decimal ProgressValue,
        DateTime CreatedAt)
{
    public double ProgressPercent =>
        TargetValue == 0 ? 0 : (double)(ProgressValue / TargetValue) * 100;
}