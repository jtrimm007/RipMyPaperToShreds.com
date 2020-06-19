using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    interface IPaperHashes
    {
        Task<PaperHashes> Read(PaperHashes paperHashes);
        Task<ICollection<PaperHashes>> ReadAll();
        Task<PaperHashes> Create(PaperHashes paperHashes);
        Task Delete(PaperHashes paperHashes);
        Task<PaperHashes> Update(PaperHashes paperHashes);
    }
}
