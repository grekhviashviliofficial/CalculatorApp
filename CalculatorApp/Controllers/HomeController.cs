using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Models;

namespace CalculatorApp.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new CalculatorViewModel());
    }

    [HttpPost]
    public IActionResult Index(CalculatorViewModel model, string action)
    {
        switch (action)
        {
            case "C":
                model.FirstValue = "";
                model.SecondValue = "";
                model.PendingOperation = "";
                model.Result = 0;
                model.Display = "0";
                break;
            case "+":
            case "-":
            case "*":
            case "/":
                model.PendingOperation = action;
                break;
            case "=":
                switch (model.PendingOperation)
                {
                    case "+":
                        model.Result = decimal.Parse(model.FirstValue) + decimal.Parse(model.SecondValue);
                        model.Display = model.Result.ToString();
                        break;
                    case "-":
                        model.Result = decimal.Parse(model.FirstValue) - decimal.Parse(model.SecondValue);
                        model.Display = model.Result.ToString();
                        break;
                    case "*":
                        model.Result = decimal.Parse(model.FirstValue) * decimal.Parse(model.SecondValue);
                        model.Display = model.Result.ToString();
                        break;
                    case "/":
                        if (decimal.Parse(model.SecondValue) != 0)
                        {
                            model.Result = decimal.Parse(model.FirstValue) / decimal.Parse(model.SecondValue);
                            model.Display = model.Result.ToString();
                        }
                        else
                            model.Display = "Error";
                        break;
                }
                model.FirstValue = model.Result.ToString();
                model.SecondValue = "";
                model.PendingOperation = "";
                break;
            default:
                if (string.IsNullOrEmpty(model.FirstValue))
                {
                    model.FirstValue = action;
                    model.Display = model.FirstValue;
                    break;
                }
                else if (string.IsNullOrEmpty(model.PendingOperation))
                {
                    model.FirstValue += action;
                    model.Display = model.FirstValue;
                    break;
                }
                else if (string.IsNullOrEmpty(model.SecondValue))
                {
                    model.SecondValue = action;
                    model.Display = model.SecondValue;
                }
                else
                {
                    model.SecondValue += action;
                    model.Display = model.SecondValue;
                }
                break;
        }
        ModelState.Clear();

        return View(model);
    }
}