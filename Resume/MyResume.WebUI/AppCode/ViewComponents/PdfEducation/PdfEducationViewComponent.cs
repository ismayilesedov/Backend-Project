﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyResume.Domain.Models.DataContexts;
using System.Linq;
using System.Threading.Tasks;

namespace MyResume.WebUI.AppCode.ViewComponents.PdfEducation
{
    public class PdfEducationViewComponent : ViewComponent
    {
        private readonly MyResumeDbContext db;

        public PdfEducationViewComponent(MyResumeDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var data = await db.ResumeDiplomas.Where(rd=>rd.DeletedDate==null).ToListAsync();

            if (data == null)
            {
                return null;
            }

            return View(await Task.FromResult(data));
        }
    }
}
