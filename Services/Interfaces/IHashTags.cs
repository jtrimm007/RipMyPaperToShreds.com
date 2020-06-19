using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    interface IHashTags
    {
        Task<HashTags> Read(int id);
        Task<ICollection<HashTags>> ReadAll();
        Task<HashTags> Create(HashTags hashTag);
        Task Delete(HashTags hashTag);
        Task<HashTags> Update(HashTags hashTag);
    }
}
