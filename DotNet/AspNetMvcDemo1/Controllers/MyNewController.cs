
using Microsoft.AspNetCore.Mvc;

public class MyNewController : Controller
{
    public string MyMethod()
    {
        return "Hello, we are now in MyNewController.MyMethod().";
    }

    public IActionResult Hello()
    {
        return View();
    }
}