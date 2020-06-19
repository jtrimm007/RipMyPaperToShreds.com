using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    interface ISubShreds
    {
        Task<SubShreds> Read(int id);
        Task<ICollection<SubShreds>> ReadAll();
        Task<SubShreds> Create(SubShreds subShred);
        Task Delete(SubShreds subShred);
        Task<SubShreds> Update(SubShreds subShred);
    }
}
