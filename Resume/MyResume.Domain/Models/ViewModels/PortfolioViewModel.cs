using MyResume.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyResume.Domain.Models.ViewModels
{
    public class PortfolioViewModel
    {
        public ICollection<ProjectCategory> ProjectCategories { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}
