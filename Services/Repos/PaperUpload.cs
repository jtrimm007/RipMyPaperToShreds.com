using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class PaperUpload : IPaperUpload
    {
        private ApplicationDbContext _db;

        public PaperUpload(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.PaperUpload> Create(Models.PaperUpload paperUpload)
        {
            var check = await Read(paperUpload.ID);

            if(check == null)
            {
                await _db.PaperUpload.AddAsync(paperUpload);
                await _db.SaveChangesAsync();
                return paperUpload;
            }

            return paperUpload;
        }

        public async Task Delete(Models.PaperUpload paperUpload)
        {
            var check = await Read(paperUpload.ID);

            if(check != null)
            {
                _db.PaperUpload.Remove(paperUpload);
                await _db.SaveChangesAsync();
            }

        }

        public async Task<Models.PaperUpload> Read(int id)
        {
            return await _db.PaperUpload.FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<List<Models.PaperUpload>> ReadAll()
        {
            return await _db.PaperUpload.ToListAsync();
        }

        public async Task<Models.PaperUpload> Update(Models.PaperUpload paperUpload)
        {
            var check = await Read(paperUpload.ID);

            if(check != null)
            {
                _db.PaperUpload.Update(paperUpload);
                await _db.SaveChangesAsync();

                return paperUpload;
            }

            return paperUpload;
        }
    }
}
