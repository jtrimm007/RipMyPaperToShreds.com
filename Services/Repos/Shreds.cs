using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class Shreds : IShreds
    {
        private readonly ApplicationDbContext _db;

        public Shreds(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.Shreds> Create(Models.Shreds shred)
        {
            var check = await Read(shred.ID);

            if(check == null)
            {
                await _db.Shreds.AddAsync(shred);
                await _db.SaveChangesAsync();
                return shred;
            }

            return shred;
        }

        public async Task Delete(Models.Shreds shred)
        {
            var check = await Read(shred.ID);

            if(check != null)
            {
                _db.Shreds.Remove(shred);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<Models.Shreds> Read(int id)
        {
            return await _db.Shreds.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<ICollection<Models.Shreds>> ReadAll()
        {
            return await _db.Shreds.ToListAsync();
        }

        public async Task<Models.Shreds> Update(Models.Shreds shred)
        {
            var check = await Read(shred.ID);

            if(check != null)
            {
                _db.Shreds.Update(shred);
                await _db.SaveChangesAsync();
                return shred;
            }
            return shred;
        }
    }
}
