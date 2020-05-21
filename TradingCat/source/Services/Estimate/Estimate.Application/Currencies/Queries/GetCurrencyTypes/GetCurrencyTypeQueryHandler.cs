using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Models;
using Estimate.Application.Common.Interfaces;
using Estimate.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Estimate.Application.Currencies.Queries.GetCurrencyTypes
{
    public class GetCurrencyTypesQueryHandler : IRequestHandler<GetCurrencyTypesQuery, BaseResponse<List<CurrencyTypeDto>>>
    {
        private readonly IApplicationDbContext _context;

        public GetCurrencyTypesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<BaseResponse<List<CurrencyTypeDto>>> Handle(GetCurrencyTypesQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<List<CurrencyTypeDto>>();

            try
            {
                var currencyTypes = await _context.Set<CurrencyType>().Select(x => new CurrencyTypeDto()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();

                response.Data = currencyTypes;
            }
            catch (Exception exception)
            {
                response.Errors.Add($"An error occurred while getting the currency types. \n Message: {exception.Message}");
            }

            return response;
        }
    }
}