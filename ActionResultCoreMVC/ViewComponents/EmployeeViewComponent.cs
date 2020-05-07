using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActionResultCoreMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ActionResultCoreMVC.ViewComponents
{
    public class EmployeeViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext db;
        public EmployeeViewComponent(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var employee = await db.Employees.ToListAsync();
            return View(employee);
        }
    }
}
