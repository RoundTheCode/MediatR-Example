using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR_Example.Models
{
    public class AddRequest : IRequest<AddResponse>
    {
        public AddRequest(int numberOne, int numberTwo)
        {
            NumberOne = numberOne;
            NumberTwo = numberTwo;
        }

        public virtual int NumberOne { get; }

        public virtual int NumberTwo { get; }

    }
}
