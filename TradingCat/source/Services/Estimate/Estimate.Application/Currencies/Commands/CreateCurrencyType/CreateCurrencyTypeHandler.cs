using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Models;
using Estimate.Application.Common.Interfaces;
using Estimate.Domain.Entities;
using MediatR;

namespace Estimate.Application.Currencies.Commands.CreateCurrencyType
{
    public class CreateCurrencyTypeHandler : IRequestHandler<CreateCurrencyTypeCommand, BaseResponse<bool>>
    {
        private readonly IApplicationDbContext _context;

        public CreateCurrencyTypeHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<bool>> Handle(CreateCurrencyTypeCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<bool>();

            try
            {
                var currencyType = new CurrencyType
                {
                    Name = request.Name
                };

                await _context.SaveChangesAsync(cancellationToken);

                response.Data = true;

            }
            catch (Exception exception)
            {
                response.Errors.Add($"An error occurred while creating the currency type. \n Message: {exception.Message}");
            }

            return response;
        }
    }
}