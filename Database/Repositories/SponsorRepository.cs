﻿using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories
{
    public class SponsorRepository
    {
        private PracticeDbContext _context;
        public SponsorRepository(PracticeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Sponsor>> GetAll()
        {
            return await _context.Set<Sponsor>().ToListAsync();
        }

        public Sponsor CreateSponsor(Sponsor sponsor)
        {
            _context.Set<Sponsor>().Add(sponsor);
            return sponsor;
        }

        public Sponsor GetById(Guid id)
        {
            return _context.Set<Sponsor>().Find(id);
        }

        public Sponsor UpdateSponsor(Sponsor sponsor)
        {
            _context.Entry(sponsor).State = EntityState.Modified;
            return sponsor;
        }

        public Sponsor DeleteSponsor(Sponsor sponsor)
        {
            _context.Set<Sponsor>().Remove(sponsor);
            return sponsor;
        }
    }
}
