using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.SignalR
{
    public class ChatHub : Hub
    // SignalR paketleri kullanımdan kalkmış, bu katman core katmanına bağlı olduğu için
    // core katmanındaki asp.net framework referance görüyor
    {
        public override Task OnConnectedAsync()
        {
            // Kullanıcıyı kendi kullanıcı adıyla tanımlanan bir gruba ekler
            Groups.AddToGroupAsync(Context.ConnectionId, Context.User.Identity.Name);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            // Kullanıcıyı kendi kullanıcı adıyla tanımlanan gruptan çıkarır
            Groups.RemoveFromGroupAsync(Context.ConnectionId, Context.User.Identity.Name);
            return base.OnDisconnectedAsync(exception);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public Task SendMessageToGroup(string sender, string receiver, string message)
        {
            return Clients.Group(receiver).SendAsync("ReceiveMessage", sender, message);
        }
    }
}
