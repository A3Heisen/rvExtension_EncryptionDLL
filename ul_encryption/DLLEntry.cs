using RGiesecke.DllExport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ul_encryption
{
    public class DllEntry // This can be named anything you like
    {
        // This 2 line are IMPORTANT and if changed will stop everything working
        // To send a string back to ARMA append to the output StringBuilder, ARMA outputSize limit applies!
    
        [DllExport("RVExtension", CallingConvention = CallingConvention.Winapi)]
        public static void RVExtension(StringBuilder output, int outputSize, [MarshalAs(UnmanagedType.LPStr)] string function)
        {
            string Error_Invalid_Command = "UL Encryption >> ERROR >> Invalid Command";
            string Error_Invalid_ArrayStrLength = "UL Encryption >> ERROR >> Invalid Str Array Length";

            string[] stringParts = function.Split(':');

            if (stringParts.Length < 2)
            {
                output.Append(Error_Invalid_ArrayStrLength);
            }
            else
            {
                switch (stringParts[0].ToLower())
                {
                    case "sha256":
                        output.Append(Sha256(stringParts[1]));
                        break;
                    default:
                        output.Append(Error_Invalid_Command);
                        break;
                };
            };
            outputSize--;

            //output.Append(stringParts[0]);
            // Reverses the input string
            //char[] arr = function.ToCharArray();
           // Array.Reverse(arr);
           // string result = new string(arr);
            //output.Append(Sha256(function));
        }

        static string Sha256(string randomString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
