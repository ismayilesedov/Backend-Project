﻿using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Domain.Business.ProjectCategoryModule
{

    public class ProjectCategoryGetAllQuery : IRequest<List<ProjectCategory>>
    {
        public class ProjectCategoryGetAllQueryHandler : IRequestHandler<ProjectCategoryGetAllQuery, List<ProjectCategory>>
        {
            private readonly MyResumeDbContext db;

            public ProjectCategoryGetAllQueryHandler(MyResumeDbContext db)
            {
                this.db = db;
            }
            public async Task<List<ProjectCategory>> Handle(ProjectCategoryGetAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.ProjectCategories
                .Where(bp => bp.DeletedDate == null)
                .ToListAsync(cancellationToken);

                return data;
            }
        }


    }
}
