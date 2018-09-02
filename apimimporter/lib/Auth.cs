using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace apimimporter.lib
{
    public class Auth
    {
        public static string SaSTokengenerated { get; set; }
        public static void createToken(string key, string id = "integration", int days = 1)
        {

            DateTime expiry = DateTime.UtcNow.AddDays(days);

            using (var encoder = new HMACSHA512(Encoding.UTF8.GetBytes(key)))
            {
                string dataToSign = id + "\n" + expiry.ToString("O", CultureInfo.InvariantCulture);
                string x = string.Format("{0}\n{1}", id, expiry.ToString("O", CultureInfo.InvariantCulture));
                var hash = encoder.ComputeHash(Encoding.UTF8.GetBytes(dataToSign));
                var signature = Convert.ToBase64String(hash);
                string encodedToken = string.Format("uid={0}&ex={1:o}&sn={2}", id, expiry, signature);
                SaSTokengenerated = encodedToken;
            }

        }

    }
}
