using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class PaperHashes : IPaperHashes
    {
        private readonly ApplicationDbContext _db;

        public PaperHashes(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.PaperHashes> Create(Models.PaperHashes paperHashes)
        {
            var check = await Read(paperHashes);

            if(check == null)
            {
                await _db.PaperHashes.AddAsync(paperHashes);
                await _db.SaveChangesAsync();
                return paperHashes;
            }
            return paperHashes;
        }

        public async Task Delete(Models.PaperHashes paperHashes)
        {
            var check = await Read(paperHashes);

            if(check != null)
            {
                _db.PaperHashes.Remove(paperHashes);
                await _db.SaveChangesAsync();

            }
        }

        public async Task<Models.PaperHashes> Read(Models.PaperHashes paperHashes)
        {
            return await _db.PaperHashes.FirstOrDefaultAsync(x => x.PaperId == paperHashes.PaperId && x.HashTagId == paperHashes.HashTagId);
        }

        public async Task<ICollection<Models.PaperHashes>> ReadAll()
        {
            return await _db.PaperHashes.ToListAsync();
        }

        public async Task<Models.PaperHashes> Update(Models.PaperHashes paperHashes)
        {
            var check = await Read(paperHashes);

            if(check != null)
            {
                _db.PaperHashes.Update(paperHashes);
                await _db.SaveChangesAsync();
                return paperHashes;
            }
            return paperHashes;
        }
    }
}
