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

        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var result = await _dummyApiServiceHelper.GetUsersAsync(30, 0, cancellationToken);

            return View(result);
        }

        public async Task<IActionResult> Details(string userId,CancellationToken cancellationToken)
        {
            var result = await _dummyApiServiceHelper.GetByIdAsync("",cancellationToken);

            return View(result);
        }

    }
}
