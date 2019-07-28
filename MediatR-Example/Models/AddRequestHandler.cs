using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Example.Models
{
    public class AddRequestHandler : IRequestHandler<AddRequest, AddResponse>
    {
        public Task<AddResponse> Handle(AddRequest request, CancellationToken cancellationToken)
        {
            var additionResult = request.NumberOne + request.NumberTwo;
            var response = new AddResponse(additionResult);

            return Task.FromResult(response);
        }
    }
}
