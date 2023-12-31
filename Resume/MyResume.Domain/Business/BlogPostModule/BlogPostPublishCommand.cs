﻿using MyResume.Domain.Business.BlogPostModule;
using MyResume.Domain.Models.DataContexts;
using MyResume.Domain.Models.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyResume.Domain.Business.BrandModule
{
    public class BlogPostPublishCommand : IRequest<BlogPost>
    {
        public int Id { get; set; }
        public class BlogPostPublishCommandHandler : IRequestHandler<BlogPostPublishCommand, BlogPost>
        {
            private readonly MyResumeDbContext db;

            public BlogPostPublishCommandHandler(MyResumeDbContext db)
            {
                this.db = db;
            }

            public async Task<BlogPost> Handle(BlogPostPublishCommand request, CancellationToken cancellationToken)
            {
                var data = db.BlogPosts.FirstOrDefault(m => m.Id == request.Id && m.PublishedDate == null);

                if (data == null)
                {
                    return null;
                }
                data.PublishedDate = DateTime.UtcNow.AddHours(4);
                await db.SaveChangesAsync(cancellationToken);
                return data;
            }
        }
    }
}

