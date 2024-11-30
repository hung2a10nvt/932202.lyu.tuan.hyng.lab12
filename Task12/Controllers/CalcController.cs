using Microsoft.AspNetCore.Mvc;
using Task12.Models;

namespace Task12.Controllers
{
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult ManualParsingInSingleAction()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult ManualParsingInSingleAction(CalcModel model)
        {
            double result = 0;
            string error = null;

            try
            {
                switch (model.Operation)
                {
                    case "+":
                        result = model.Num1 + model.Num2;
                        break;
                    case "-":
                        result = model.Num1 - model.Num2;
                        break;
                    case "*":
                        result = model.Num1 * model.Num2;
                        break;
                    case "/":
                        if (model.Num2 == 0)
                        {
                            error = "Error: Division by zero.";
                        }
                        else
                        {
                            result = model.Num1 / model.Num2;
                        }
                        break;
                    default:
                        error = "Invalid operation.";
                        break;
                }
            }
            catch (Exception ex)
            {
                error = $"Error: {ex.Message}";
            }

            if (error != null)
            {
                return RedirectToAction("Result", new { result = error });
            }

            return RedirectToAction("Result", new { result });
        }

        [HttpGet]
        public IActionResult ManualParsingInSeparateActions()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult ManualParsingInSeparateActions(CalcModel model)
        {
            double result = 0;
            string error = null;

            try
            {
                int num1 = model.Num1;
                int num2 = model.Num2;
                string operation = model.Operation;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            error = "Error: Division by zero.";
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        error = "Invalid operation.";
                        break;
                }
            }
            catch (Exception ex)
            {
                error = $"Error: {ex.Message}";
            }

            if (error != null)
            {
                return RedirectToAction("Result", new { result = error });
            }

            return RedirectToAction("Result", new { result });
        }

        [HttpGet]
        public IActionResult ModelBindingParameters()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult ModelBindingParameters(int num1, int num2, string operation)
        {
            double result = 0;
            string error = null;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            error = "Error: Division by zero.";
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        error = "Invalid operation.";
                        break;
                }
            }
            catch (Exception ex)
            {
                error = $"Error: {ex.Message}";
            }

            if (error != null)
            {
                return RedirectToAction("Result", new { result = error });
            }

            return RedirectToAction("Result", new { result });
        }

        [HttpGet]
        public IActionResult ModelBindingSeparateModel()
        {
            return View();  
        }

        [HttpPost]
        public IActionResult ModelBindingSeparateModel(CalcModel model)
        {
            double result = 0;
            string error = null;

            try
            {
                switch (model.Operation)
                {
                    case "+":
                        result = model.Num1 + model.Num2;
                        break;
                    case "-":
                        result = model.Num1 - model.Num2;
                        break;
                    case "*":
                        result = model.Num1 * model.Num2;
                        break;
                    case "/":
                        if (model.Num2 == 0)
                        {
                            error = "Error: Division by zero.";
                        }
                        else
                        {
                            result = model.Num1 / model.Num2;
                        }
                        break;
                    default:
                        error = "Invalid operation.";
                        break;
                }
            }
            catch (Exception ex)
            {
                error = $"Error: {ex.Message}";
            }

            if (error != null)
            {
                return RedirectToAction("Result", new { result = error });
            }

            return RedirectToAction("Result", new { result });
        }

        public IActionResult Result(string result)
        {
            ViewBag.Result = result;
            return View();
        }
    }
}
