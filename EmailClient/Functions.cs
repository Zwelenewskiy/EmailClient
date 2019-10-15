using System.Text.RegularExpressions;
using EmailClient.Classes;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;

namespace EmailClient
{
    public static class Functions
    {
        private static readonly int PORT = 8005; 
        private static readonly string HOST = "127.0.0.1"; 

        public enum Action
        {
            getEmails,
            sendEmail,
            changeEmail
        }

        public static object UserAction(UserActionParams parameters)
        {
            switch (parameters.action)
            {
                case Action.getEmails:
                    return JsonConvert.DeserializeObject<List<Email>>(SendMessage("getEmails", null));

                case Action.sendEmail:
                    if (SendMessage("sendEmail", JsonConvert.SerializeObject(parameters.email)) == "OK")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case Action.changeEmail:
                    if (SendMessage("changeEmail", JsonConvert.SerializeObject(parameters.email)) == "OK")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }

            return null;
        }

        /// <summary>
        /// Отправляет сообщение серверу
        /// </summary>
        /// <param name="message">тело сообщения</param>
        /// <param name="type">тип сообщения</param>
        private static string SendMessage(string type, string message)
        {
            message = JsonConvert.SerializeObject(new Request()
            {
                type = type,
                data = message
            });

            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(HOST), PORT);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Connect(ipPoint);
            byte[] data = Encoding.Unicode.GetBytes(message);
            socket.Send(data);

            data = new byte[8192]; 
            string server_asnwer = null;
            int bytes = 0; 
            do
            {
                bytes = socket.Receive(data, data.Length, 0);
                server_asnwer += Encoding.Unicode.GetString(data, 0, bytes);
            }
            while (socket.Available > 0);

            socket.Shutdown(SocketShutdown.Both);
            socket.Close();

            return server_asnwer;
        }

        /// <summary>
        /// Проверяет корректность введенного email'а
        /// </summary>
        public static bool CheckEmail(string email)
        {
            return Regex.IsMatch(email, "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.[a-z]{2,6}$", RegexOptions.IgnoreCase);
        }
    }
}
