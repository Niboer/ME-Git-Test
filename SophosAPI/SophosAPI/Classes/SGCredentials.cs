using System;
using SophosAPI.Helper;

namespace SophosAPI.Classes
{
    public class SGCredentials
    {
        public string Username { get; set; } = "admin";
        public string Password { get; set; } = "nothing";
        public string Hostname { get; set; } = "localhost";
        public UInt16 Port { get; set; } = 4444;
        public Boolean HasOldCache { get; } = true;
        public SGObject[] ObjectCache { get; set; }

        public SGCredentials() { }

        public SGCredentials(string Username, string Password, string Hostname, UInt16 Port)
        {
            this.Username = Username;
            this.Password = Password;
            this.Hostname = Hostname;
            this.Port = Port;
        }

        public string GetConnectionString()
        {
            return ("https://" + Hostname + ":" + Port + "/api/");
        }

        public string GetAuthString ()
        {
            return (System.Text.Encoding.UTF8.ToBase64((Password + ":" + Username)));
        }
    }
}
