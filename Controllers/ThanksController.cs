using Microsoft.AspNetCore.Mvc;

namespace Friend_Group_Test;

public class ThanksController: Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Thanks/Thanks.cshtml");
    }
}