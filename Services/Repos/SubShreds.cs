using RipMyPaperToShreds.com.Data;
using RipMyPaperToShreds.com.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using RipMyPaperToShreds.com.Models;
using Microsoft.EntityFrameworkCore;
using RipMyPaperToShreds.com.Services.Hubs;

namespace RipMyPaperToShreds.com.Services.Repos
{
    public class SubShreds : ISubShreds
    {
        private readonly ApplicationDbContext _db;

        public SubShreds(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Models.SubShreds> Create(Models.SubShreds subShred)
        {
            var check = await Read(subShred.ID);

            if(check == null)
            {
                await _db.SubShreds.AddAsync(subShred);
                await _db.SaveChangesAsync();

                return subShred;
            }

            return subShred;
        }

        public async Task Delete(Models.SubShreds subShred)
        {
            var check = Read(subShred.ID);

            if(check != null)
            {
                _db.SubShreds.Remove(subShred);
                await _db.SaveChangesAsync();
            }
        }

        public async Task<Models.SubShreds> Read(int id)
        {
            var subShred = await _db.SubShreds.FirstOrDefaultAsync(x => x.ID == id);
            return subShred;

        }

        public async Task<ICollection<Models.SubShreds>> ReadAll()
        {
          return await _db.SubShreds.ToListAsync();
            
        }

        public async Task<Models.SubShreds> Update(Models.SubShreds subShred)
        {
            var check = Read(subShred.ID);

            if(check != null)
            {
                _db.SubShreds.Update(subShred);
                await _db.SaveChangesAsync();
                return subShred;
            }

            return subShred;
        }
    }
}
