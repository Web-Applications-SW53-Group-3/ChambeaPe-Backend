using Microsoft.AspNetCore.SignalR;

namespace _1._API.Hubs
{
    // Clase para representar un mensaje
    public class Message
    {
        public string SenderUserId { get; set; }
        public string ReceiverUserId { get; set; }
        public string Text { get; set; }
        // Otros campos según tus necesidades
    }

    // Modificación en el ChatHub para manejar historiales de mensajes
    public class ChatHub : Hub
    {
        private readonly Dictionary<string, List<Message>> messageHistory = new Dictionary<string, List<Message>>();

        // ...

        public async Task SendMessage(string senderUserId, string receiverUserId, string messageText)
        {
            var message = new Message
            {
                SenderUserId = senderUserId,
                ReceiverUserId = receiverUserId,
                Text = messageText
            };

            // Guarda el mensaje en el historial
            SaveMessage(message);

            // Envía el mensaje al destinatario
            await Clients.Group(receiverUserId).SendAsync("ReceiveMessage", message);

            // También envía el mensaje de vuelta al remitente
            await Clients.Group(senderUserId).SendAsync("ReceiveMessage", message);
        }

        private void SaveMessage(Message message)
        {
            // Agrega el mensaje al historial
            if (!messageHistory.ContainsKey(message.SenderUserId))
            {
                messageHistory[message.SenderUserId] = new List<Message>();
            }

            messageHistory[message.SenderUserId].Add(message);

            // También puedes almacenar el mensaje en la dirección opuesta si lo deseas
        }

        public List<Message> GetMessageHistory(string userId)
        {
            // Obtiene el historial de mensajes del usuario
            if (messageHistory.ContainsKey(userId))
            {
                return messageHistory[userId];
            }

            return new List<Message>();
        }
    }
}
