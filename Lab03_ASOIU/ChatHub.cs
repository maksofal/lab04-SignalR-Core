using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Lab03_ASOIU
{
    public class ChatHub : Hub
    {
        private readonly Random rand = new Random();
        
        public async Task Send(string message)
        {
            int[] randArray = new int[11];
            for (int i = 0; i < 11; i++)
            {
                randArray[i] = rand.Next(0,100);
            }
            await Clients.All.SendAsync("Receive", randArray);
        }
    }
    
    
}    