using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena_Api
{
    class Base
    {

        public const string skypedatabase = "http://api.predator.wtf/lookup/?arguments=";
        public const string iptoskype = "http://api.predator.wtf/lookup/?arguments=";
        public const string emailtoskype = "http://api.predator.wtf/e2skype/?arguments=";
        public const string completegeoip = "http://api.predator.wtf/geoip/?arguments=";
        public const string hosttoip = "http://api.predator.wtf/host2ip/?arguments=";
        public const string iptohost = "http://api.predator.wtf/ip2host/?arguments=";
        public const string iptolocation = "http://api.predator.wtf/ip2loc/?arguments=";
        public const string iptoisp = "http://api.predator.wtf/ip2isp/?arguments=";

        //ATTENZIONE USARE http://api.predator.wtf/pcheck/?arguments=IP&port=PORTA
        public const string portcheck = "http://api.predator.wtf/pcheck/?arguments=";

        public const string portscanner = "http://api.predator.wtf/pscan/?arguments=";
        public const string dnslookup = "http://api.predator.wtf/dns/?arguments";
        public const string ipv4validator = "http://api.predator.wtf/ipv4/?arguments=";
        public const string ipv6validator = "http://api.predator.wtf/ipv6/?arguments=";
        public const string emailvalidator = "http://api.predator.wtf/emailv/?arguments=";
        public const string cloudflareresolver = "http://api.predator.wtf/cfresolve/?arguments=";
        public const string minecraftchecker = "http://api.predator.wtf/minecraft/?arguments=";
        public const string passwordgenerator = "http://api.predator.wtf/passgen/?arguments=";
        public const string wheaterapi = "http://api.predator.wtf/weather/?arguments=";
        public const string upordown = "http://api.predator.wtf/upordown/?arguments=";
        private static int cmd;

        static void Main(string[] args)
        {
            while (true)
            {
                string dato = "";
                string porta = "";
                Console.WriteLine("\nProgramma creato da FiloSpinato\n\nAthena-Api Menù\nInserisci il numero per eseguire un comando:\n");
                Console.WriteLine("1)  SkypeResolver - Prendi l'ip di una persona tramite il suo username");
                Console.WriteLine("2)  IpToSkype - Risali al nome utente di skype tramite un IP");
                Console.WriteLine("3)  EmailToSkype - Risali al nome utente di skype tramite un email");
                Console.WriteLine("4)  CompleteGeoIp - Risali a tutte le informazioni di un IP");
                Console.WriteLine("5)  HostToIp - Risali all'IP di un dominio");
                Console.WriteLine("6)  IpToHost - Risali ad un dominio tramite un IP");
                Console.WriteLine("7)  IpToLocation - Risali alla località di un IP");
                Console.WriteLine("8)  IpToIsp - Risali all'operatore di un IP");
                Console.WriteLine("9)  PortCheck - Controlli se una determinata porta è aperta in un IP");
                Console.WriteLine("10) PortScanner - Controlla una lista di porte comuni di un determinato IP");
                Console.WriteLine("11) DnsLookup - Risale a tutte le informazioni DNS di un dominio");
                Console.WriteLine("12) Ipv4Validator - Controlla se l'IPv4 inserito è valido");
                Console.WriteLine("13) Ipv6Validator - Controlla se l'IPv6 inserito è valido");
                Console.WriteLine("14) EmailValidator - Controlla se l'email inserita è valida");
                Console.WriteLine("15) CloudFlareResolver - Risolve l'ip originale dietro a CloudFlare");
                Console.WriteLine("16) MinecraftChecker - Controlla se un determinato nome utente è premium");
                Console.WriteLine("17) PasswordGenerator - Genera una password casuale");
                Console.WriteLine("18) WheaterApi - Restituisce la meteo di un paese");
                Console.Write("19) UpOrDown - Controlla se un sito web è offline oppure online\n\nComando: ");
                cmd = Convert.ToInt32(Console.ReadLine());
                if (cmd > 19 || cmd == 0)
                {
                    Console.WriteLine("Errore hai scelto un comando inesistente!");
                    System.Threading.Thread.Sleep(1000);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Comando numero: " + cmd + " selezionato\n");
            Console.ReadLine();
        }
    }
}
/*
                        string ip = message.Text.Replace(".lookup ", "");
                        string sito = "http://api.predator.wtf/geoip/?arguments=" + ip;
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sito);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            Stream receiveStream = response.GetResponseStream();
                            StreamReader readStream = null;

                            if (response.CharacterSet == null)
                            {
                                readStream = new StreamReader(receiveStream);
                            }
                            else
                            {
                                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                            }

                            string data = readStream.ReadToEnd();
                            data = data.Replace("<br>", "\n");

                            response.Close();
                            readStream.Close();

                            await Bot.SendTextMessageAsync(message.Chat.Id, data);
                        }
                    }
                    catch (Exception e)
                    {
                        await Bot.SendTextMessageAsync(message.Chat.Id, Convert.ToString(e));
                    }*/
