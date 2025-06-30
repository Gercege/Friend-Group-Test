using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Friend_Group_Test.Models;

namespace Friend_Group_Test.Controllers;

public class HomeController : Controller
{
    private readonly DataContext _context;
    public HomeController(DataContext context)
    {
        _context = context;
    }
    [HttpPost]
    public IActionResult Index(SelectedOptions model)
    {
        var entity = new SelectedOptions
        {
            Q1SelectedOption = model.Q1SelectedOption,
            Q2SelectedOption = model.Q2SelectedOption,
            Q3SelectedOption = model.Q3SelectedOption,
            Q4SelectedOption = model.Q4SelectedOption,  
            Q5SelectedOption = model.Q5SelectedOption,
            Q6SelectedOption = model.Q6SelectedOption,
            Q7SelectedOption = model.Q7SelectedOption,
            Q8SelectedOption = model.Q8SelectedOption,
            Q9SelectedOption = model.Q9SelectedOption,
            Q10SelectedOption = model.Q10SelectedOption,
            Q11SelectedOption = model.Q11SelectedOption,
            Q12SelectedOption = model.Q12SelectedOption,
            Q13SelectedOption = model.Q13SelectedOption,
            Q14SelectedOption = model.Q14SelectedOption,
            Q15SelectedOption = model.Q15SelectedOption,
            Q16SelectedOption = model.Q16SelectedOption,
            Q17SelectedOption = model.Q17SelectedOption,
            Q18SelectedOption = model.Q18SelectedOption,
            Q19SelectedOption = model.Q19SelectedOption,
            Q20SelectedOption = model.Q20SelectedOption,
            Q21SelectedOption = model.Q21SelectedOption,
            Q22SelectedOption = model.Q22SelectedOption,
            Q23SelectedOption = model.Q23SelectedOption,
            Q24SelectedOption = model.Q24SelectedOption,
            Q25SelectedOption = model.Q25SelectedOption,
            Q26SelectedOption = model.Q26SelectedOption,
            Q27SelectedOption = model.Q27SelectedOption,
            Q28SelectedOption = model.Q28SelectedOption,
            Q29SelectedOption = model.Q29SelectedOption,
            Q30SelectedOption = model.Q30SelectedOption,
            Q31SelectedOption = model.Q31SelectedOption
        };
        _context.SelectedOptionsDb.Add(entity);
        _context.SaveChanges();
        return RedirectToAction("", "Thanks");
        
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View("~/Views/Home/Submit.cshtml");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
