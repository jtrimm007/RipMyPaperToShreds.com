using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RipMyPaperToShreds.com.Services.Hubs
{
    public class ShredsHub : Hub
    {
        public async Task SendToAll(string message)
        {
            await Clients.All.SendAsync("ShredUpdated", message);
        }
    }
}
