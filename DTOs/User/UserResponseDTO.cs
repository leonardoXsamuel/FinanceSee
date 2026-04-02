using PjtFinanceSee.Model.Enums;

namespace PjtFinanceSee.DTOs.User;

public record FinancialGoalResponseDTO(string Name, string Email, StatusUser Status, DateTime CreatedAt);
