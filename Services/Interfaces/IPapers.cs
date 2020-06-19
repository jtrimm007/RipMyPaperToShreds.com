using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    interface IPapers
    {
        Task<Papers> Read(int id);
        Task<ICollection<Papers>> ReadAll();
        Task<Papers> Create(Papers paper);
        Task Delete(Papers paper);
        Task<Papers> Update(Papers paper);
    }
}
