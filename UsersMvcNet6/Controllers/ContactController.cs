using Microsoft.AspNetCore.Mvc;

namespace UsersMvcNet6.Controllers
{
  public class ContactController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}