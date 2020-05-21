using Core.Domain.Models;
using MediatR;

namespace Estimate.Application.Currencies.Commands.CreateCurrencyType
{
    public class CreateCurrencyTypeCommand : IRequest<BaseResponse<bool>>
    {
        public string Name { get; set; }
    }
}