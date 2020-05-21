using Core.Domain.Models;

namespace Estimate.Application.Currencies.Queries.GetCurrencyTypes
{
    public class CurrencyTypeDto : BaseDto<int>
    {
        public string Name { get; set; }
    }
}