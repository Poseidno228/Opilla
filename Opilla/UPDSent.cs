using Opilla.WineStyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace Opilla
{
    static class UPDSent
    {
        static IPAddress Address = Dns.GetHostAddresses(Dns.GetHostName())[0];
        static int port = 8090;
        public static void Send() 
        {
            Console.WriteLine("Open connection");
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse("192.168.0.105"), port);
            Console.WriteLine("Start sending");
            string s = Serialize(GetBeers().Result);
            Console.WriteLine(s);
            socket.SendTo(Encoding.UTF8.GetBytes(s), point);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
            Console.WriteLine("Finish");
        }
        static async Task<List<Opilla>> GetBeers()
        {
            return await new Task<List<Opilla>>(()=> {
                return new List<Opilla>()
            {
                new Novus<KorifeiWineStyle>("Опілля Корифей",0.5, "Скляна пляшка"),
                new Novus<Jugulevskoe>("Опілля Жигулівське",0.5, "Скляна пляшка"),
                new Novus<Classic>("Опілля Класичне",0.5, "Скляна пляшка"),
                new Classic("Опілля Класичне",0.5, "Скляна пляшка"),
                new Classic("Опілля Класичне", 1, "Пластикова пляшка"),
                new Jugulevskoe("Опілля Жигулівське", 0.5, "Скляна пляшка"),
                new Jugulevskoe("Опілля Жигулівське", 1, "Пластикова пляшка"),
                new KorifeiWineStyle("Опілля Корифей", 0.5, "Скляна пляшка"),
                new KorifeiWineStyle("Опілля Корифей", 1, "Пластикова пляшка")
            };
            });
        }
        public static string Serialize(List<Opilla> list)
        {
            return JsonSerializer.Serialize(list, typeof(List<Opilla>), new JsonSerializerOptions()
            {
                WriteIndented = true,
            });
        }
    }
}
