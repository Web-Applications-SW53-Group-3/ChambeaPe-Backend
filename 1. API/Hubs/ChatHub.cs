using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography;
using System.Text;

namespace _1._API.Hubs
{
    public class Message
    {
        //Fecha y hora
        public string senderUserId { get; set; }
        public string receiverUserId { get; set; }
        public string text { get; set; }
    }

    public class ChatHub : Hub
    {
        private readonly Dictionary<string, List<Message>> messageHistory = new Dictionary<string, List<Message>>();


        public async Task SendMessage(string senderUserId, string receiverUserId, string groupId, string messageText)
        {
            var message = new Message
            {
                senderUserId = senderUserId,
                receiverUserId = receiverUserId,
                text = messageText
            };

            //SaveMessage(message);

            await Clients.Group(groupId).SendAsync("ReceiveMessage", message);
        }

        //private void SaveMessage(Message message)
        //{
        //    
        //    if (!messageHistory.ContainsKey(message.SenderUserId))
        //    {
        //        messageHistory[message.SenderUserId] = new List<Message>();
        //    }

        //    messageHistory[message.SenderUserId].Add(message);
        //}

        //public List<Message> GetMessageHistory(string userId)
        //{
        //    
        //    if (messageHistory.ContainsKey(userId))
        //    {
        //        return messageHistory[userId];
        //    }

        //    return new List<Message>();
        //}

        public async Task<string> JoinGroup(string senderUserId, string receiverUserId)
        {
            string group = GetGroupForUser(senderUserId, receiverUserId);

            await Groups.AddToGroupAsync(Context.ConnectionId, group);

            return group;
        }

        public async Task LeaveGroup(string senderUserId, string receiverUserId)
        {
            string group = GetGroupForUser(senderUserId, receiverUserId);

            await Groups.RemoveFromGroupAsync(Context.ConnectionId, group);
        }

        private string GetGroupForUser(string senderUserId, string receiverUserId)
        {
            return GenerateChatId(senderUserId, receiverUserId);
        }

        private string GenerateChatId(string senderUserId, string receiverUserId)
        {
            string[] sortedIds = { senderUserId, receiverUserId };
            Array.Sort(sortedIds);

            string concatenatedIds = string.Join("_", sortedIds);

            string hashedId = ComputeSha256Hash(concatenatedIds);

            return hashedId;
        }

        private string ComputeSha256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);

                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
