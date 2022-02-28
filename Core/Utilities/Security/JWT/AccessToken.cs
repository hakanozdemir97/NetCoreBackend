using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Token anlamsız karakterlerden oluşan anahtar değeridir. (json web token)
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; } //Token bitiş zamanı
    }
}
