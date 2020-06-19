using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class HashTags : IHashTags
    {
        private readonly ApplicationDbContext _db;

        public HashTags(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.HashTags> Create(Models.HashTags hashTag)
        {
            var check = await Read(hashTag.ID);

            if(check == null)
            {
                await _db.HashTags.AddAsync(hashTag);
                await _db.SaveChangesAsync();
                return hashTag;
            }
            return hashTag;
        }

        public async Task Delete(Models.HashTags hashTag)
        {
            var check = await Read(hashTag.ID);

            if (check != null)
            {
                _db.HashTags.Remove(hashTag);
                await _db.SaveChangesAsync();
                
            }
        }

        public async Task<Models.HashTags> Read(int id)
        {
            return await _db.HashTags.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<ICollection<Models.HashTags>> ReadAll()
        {
            return await _db.HashTags.ToListAsync();
        }

        public async Task<Models.HashTags> Update(Models.HashTags hashTag)
        {
            var check = await Read(hashTag.ID);

            if(check != null)
            {
                _db.HashTags.Update(hashTag);
                await _db.SaveChangesAsync();
                return hashTag;
            }
            return hashTag;
        }
    }
}
