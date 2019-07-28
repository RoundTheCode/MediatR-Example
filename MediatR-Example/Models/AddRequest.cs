using MediatR;

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
