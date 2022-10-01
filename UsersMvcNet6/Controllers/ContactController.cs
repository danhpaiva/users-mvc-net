using Microsoft.AspNetCore.Mvc;
using UsersMvcNet6.Context;
using UsersMvcNet6.Models;

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

    [HttpGet]
    public IActionResult Criar()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Criar(Contact contact)
    {
      if (ModelState.IsValid)
      {
        _context.Contacts.Add(contact);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
      }
      else return View(contact);
    }

    [HttpGet]
    public IActionResult Editar(int id)
    {
      var contact = _context.Contacts.Find(id);
      if (contact == null) return RedirectToAction(nameof(Index));

      return View(contact);
    }
  }
}