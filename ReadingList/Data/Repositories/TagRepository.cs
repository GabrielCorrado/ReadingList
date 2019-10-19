﻿using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Data.Repositories
{
    internal class TagRepository : Repository<Tag>, ITagRepository
    {
        internal TagRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Tag FindByName(string tagName)
        {
            return Set.FirstOrDefault(x => x.TagName == tagName);
        }

        public Task<Tag> FindByNameAsync(string tagName)
        {
            return Set.FirstOrDefaultAsync(x => x.TagName == tagName);
        }

        public Task<Tag> FindByNameAsync(CancellationToken cancellationToken, string tagName)
        {
            return Set.FirstOrDefaultAsync(x => x.TagName == tagName, cancellationToken);
        }
    }
}