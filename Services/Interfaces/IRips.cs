using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    interface IRips
    {
        Task<Rips> Read(int id);
        Task<ICollection<Rips>> ReadAll();
        Task<Rips> Create(Rips rip);
        Task Delete(Rips rip);
        Task<Rips> Update(Rips rip);
    }
}
