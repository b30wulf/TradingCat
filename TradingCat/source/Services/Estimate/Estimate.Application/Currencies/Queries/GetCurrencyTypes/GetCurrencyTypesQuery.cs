using System.Collections.Generic;
using Core.Domain.Models;
using MediatR;

namespace Estimate.Application.Currencies.Queries.GetCurrencyTypes
{
    public class GetCurrencyTypesQuery : IRequest<BaseResponse<List<CurrencyTypeDto>>>
    {
        
    }
}