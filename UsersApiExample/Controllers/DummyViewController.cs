using Microsoft.AspNetCore.Mvc;
using UsersApiExample.Services;

namespace UsersApiExample.Controllers
{
    public class DummyViewController : Controller
    {
        private readonly IDummyApiServiceHelper _dummyApiServiceHelper;

        public DummyViewController(IDummyApiServiceHelper dummyApiServiceHelper)
        {
            _dummyApiServiceHelper = dummyApiServiceHelper;
        }
        [HttpGet]
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var result = await _dummyApiServiceHelper.GetUsersAsync(30, 0, cancellationToken);

            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id,CancellationToken cancellationToken)
        {
            var result = await _dummyApiServiceHelper.GetByIdAsync(id,cancellationToken);

            return View(result);
        }

    }
}
