using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

public class IndexPageModel : PageModel
{

    public void OnGet()
    {
        // ViewData["Message"] = "Hello!";
        Response.WriteAsync("One more time!");
    }

}