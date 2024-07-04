using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.SignalR;

namespace Infrastructure.SignalR
{
    public class ChatHub : Hub
    {
      

        public async Task SendMessage(string user, string message, string room)
        {
            var currentTime = DateTime.Now;
            string time;
/*
            if (currentTime.Date == DateTime.Today)
            {
                // Mesaj bugünkü tarihte gönderilmişse sadece saat
                time = currentTime.ToString("HH:mm", CultureInfo.InvariantCulture);
            }
            else
            {
                // Mesaj önceki günlerde gönderilmişse tarih ve saat
                time = currentTime.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            }*/

            await Clients.Group(room).SendAsync("ReceiveMessage", user, message, room, currentTime);
        }

        public async Task JoinRoom(string room, string user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, room);



            await Clients.Caller.SendAsync("ReceiveMessage", "Sistem", $"Hoşgeldin {user}, en kısa sürede operatörlerimizden birine bağlanıcaksınız!");

            await Clients.OthersInGroup(room).SendAsync("ReceiveMessage", "Sistem", $"{user} konuşmaya bağlandı.");
        }

        public async Task LeaveRoom(string room,string user)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, room);

            await Clients.OthersInGroup(room).SendAsync("ReceiveMessage", "Sistem", $"{user} odadan çıktı.");
        }

        public async Task CreateRoom(string room)
        {
            // Bu metot oda oluşturma işlemini gerçekleştirir ve tüm admin client'larına bildirir
            await Clients.All.SendAsync("RoomCreated", room);
        }

        public async Task StartTyping(string user, string room)
        {
            await Clients.OthersInGroup(room).SendAsync("UserTyping", user);
        }

        public async Task StopTyping(string user, string room)
        {
            await Clients.OthersInGroup(room).SendAsync("UserStoppedTyping", user);
        }

    }
}
