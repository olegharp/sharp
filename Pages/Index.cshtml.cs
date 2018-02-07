using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Sharp.Models;

public class IndexPageModel : PageModel
{
    public void OnGet()
    {

        int? i = null;

        if (i.HasValue)
        {   
            int? k = i.Value;
        }

        Point origin = new Point();
        Point bottomRight = new Point(1366, 768);
        double distance = origin.DistanceTo(bottomRight);
        var myAnonymousObject = new { Name = "John", Age = 47 };

        ViewData["Message"] = $"Distance = {distance.ToString()}; Number of Point objects: {Point.ObjectCount()}";
        Response.WriteAsync($"myAnonymousObject.Name: {myAnonymousObject.Name}; myAnonymousObject.Age: {myAnonymousObject.Age}");
    }

}