﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using TakeAwaySignalR.WebApi.DAL;

namespace TakeAwaySignalR.WebApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly Context _context;

        public SignalRHub(Context context)
        {
            _context = context;
        }

        public async Task TotalDeliveryCount()
        {
            var value = _context.Deliveries.Count();
            await Clients.All.SendAsync("RecieveTotalDeliveryCount", value);
        }

        public async Task TotalDeliveryCountStatusByYolda()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Yolda").Count();
            await Clients.All.SendAsync("RecieveTotalDeliveryCountStatusByYolda", value);
        }

        public async Task TotalDeliveryCountStatusByHazirlaniyor()
        {
            var value = _context.Deliveries.Where(x => x.Status == "Hazirlaniyor").Count();
            await Clients.All.SendAsync("RecieveTotalDeliveryCountStatusByHazirlaniyor", value);
        }
    }
}
