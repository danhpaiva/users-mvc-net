using Microsoft.AspNetCore.Mvc;
using UsersMvcNet6.Context;

namespace UsersMvcNet6.Controllers
{
  public class ContactController : Controller
  {
    private readonly ScheduleContext _context;

    public ContactController(ScheduleContext context)
    {
      _context = context;
    }

    public IActionResult Index()
    {
      var contacts = _context.Contacts.ToList();
      return View(contacts);
    }

    public IActionResult Criar()
    {
      return View();
    }
  }
}