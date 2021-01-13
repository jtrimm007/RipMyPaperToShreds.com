using RipMyPaperToShreds.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Interfaces
{
    public interface IPaperUpload
    {

        Task<PaperUpload> Read(int id);
        Task<List<PaperUpload>> ReadAll();
        Task Delete(PaperUpload paperUpload);
        Task<PaperUpload> Create(PaperUpload paperUpload);
        Task<PaperUpload> Update(PaperUpload paperUpload);
    }
}
