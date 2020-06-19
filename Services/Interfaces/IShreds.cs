using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    interface IShreds
    {
        Task<Shreds> Read(int id);
        Task<ICollection<Shreds>> ReadAll();
        Task<Shreds> Create(Shreds shred);
        Task Delete(Shreds shred);
        Task<Shreds> Update(Shreds shred);
    }
}
