using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class Rips : IRips
    {
        private readonly ApplicationDbContext _db;

        public Rips(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Rips> Create(Models.Rips rip)
        {
            var check = await Read(rip.ID);

            if(check == null)
            {
                await _db.Rips.AddAsync(rip);
                await _db.SaveChangesAsync();
                return rip;
            }
            return rip;
        }

        public async Task Delete(Models.Rips rip)
        {
            var check = await Read(rip.ID);

            if(check != null)
            {
                _db.Rips.Remove(rip);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<Models.Rips> Read(int id)
        {
            return await _db.Rips.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<ICollection<Models.Rips>> ReadAll()
        {
            return await _db.Rips.ToListAsync();
        }

        public async Task<Models.Rips> Update(Models.Rips rip)
        {
            var check = await Read(rip.ID);

            if(check != null)
            {
                _db.Rips.Update(rip);
                await _db.SaveChangesAsync();
                return rip;
            }
            return rip;
        }
    }
}
