﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChartModule.ViewComponents
{
    [ViewComponent]
    public class HorizontalBarChartViewComponent : ViewComponent 
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}