using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class Papers : IPapers
    {
        private readonly ApplicationDbContext _db;

        public Papers(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Papers> Create(Models.Papers paper)
        {
            var check = await Read(paper.ID);

            if(check == null)
            {
                await _db.Papers.AddAsync(paper);
                await _db.SaveChangesAsync();
                return paper;
            }
            return paper;
        }

        public async Task Delete(Models.Papers paper)
        {
            var check = await Read(paper.ID);

            if(check != null)
            {
                _db.Papers.Remove(paper);
                await _db.SaveChangesAsync();
                
            }
        }

        public async Task<Models.Papers> Read(int id)
        {
            return await _db.Papers.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<ICollection<Models.Papers>> ReadAll()
        {
            return await _db.Papers.ToListAsync();
        }

        public async Task<Models.Papers> Update(Models.Papers paper)
        {
            var check = await Read(paper.ID);

            if(check != null)
            {
                _db.Papers.Update(paper);
                await _db.SaveChangesAsync();
                return paper;
            }
            return paper;
        }
    }
}
