using System.Net;

string ipv4 = Dns.GetHostAddresses(Dns.GetHostName())[1].ToString();
Console.WriteLine(ipv4);