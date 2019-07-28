

namespace MediatR_Example.Models
{
    public class AddResponse
    {
        public AddResponse(int total)
        {
            Total = total;
        }

        public virtual int Total { get; }
    }
}
