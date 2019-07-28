using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR_Example.Models;
using MediatR;

namespace MediatR_Example.Controllers
{
    public class HomeController : Controller
    {
        protected readonly IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var request = new AddRequest(3, 9);
            var response = await _mediator.Send(request);

            return View(response);
        }
    }
}
