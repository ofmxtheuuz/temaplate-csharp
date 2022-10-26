using System.Diagnostics;
using System.Reflection.Metadata;
using Markdig;
using Markdig.Syntax;
using Microsoft.AspNetCore.Mvc;
using Template.Models;

namespace Template.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var _pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().UseBootstrap().Build();
        string Document = System.IO.File.ReadAllText(@".\Controllers\README.md");

        var result = Markdown.ToHtml(Document, _pipeline);
        ViewBag.Result = result;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}