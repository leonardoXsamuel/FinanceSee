using PjtFinanceSee.Model;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PjtFinanceSee.DTOs.Budget;

class BudgetResponseDTO(string Name, int Month, int Year, UserResponseDTO User);