using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Sharp.Models;

public class IndexPageModel : PageModel
{
    enum Season : byte { Spring, Summer, Fall, Autumn = Fall, Winter };
    enum Month : byte
    {
        January, February, March, April,
        May, June, July, August,
        September, October, November, December
    };

    struct Date
    {
        private int year;
        private Month month;
        private int day;
        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1900;
            this.month = mm;
            this.day = dd - 1;
        }
    }

    public void OnGet()
    {
        // Season cold = Season.Winter;
        Month last = Month.December;
        last++;

        int? i = null;

        if (i.HasValue)
        {   
            int? k = i.Value;
        }

        Point origin = new Point();
        Point bottomRight = new Point(1366, 768);
        double distance = origin.DistanceTo(bottomRight);
        var myAnonymousObject = new { Name = "John", Age = 47 };

        // ViewData["Message"] = $"Distance = {distance.ToString()}; Number of Point objects: {Point.ObjectCount()}";
        // Response.WriteAsync($"myAnonymousObject.Name: {myAnonymousObject.Name}; myAnonymousObject.Age: {myAnonymousObject.Age}");
        ViewData["Message"] = $"Last month + 1 = {last}";
    }

}