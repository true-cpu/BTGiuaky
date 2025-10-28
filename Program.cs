using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string plaintext = "hello";

            int bitSize = 16;

            RSA rsa = new RSA(bitSize);

            Console.WriteLine(" p: " + rsa.p);
            Console.WriteLine(" q: " + rsa.q);
            Console.WriteLine(" N: " + rsa.N);
            Console.WriteLine(" phi: " + rsa.phi);
            Console.WriteLine(" e: " + rsa.e);
            Console.WriteLine(" d: " + rsa.d);
            Console.WriteLine(" PublicKey (e,N): " + rsa.e + ", " + rsa.N);
            Console.WriteLine(" PrivateKey (d,N): " + rsa.d + ", " + rsa.N);

            Console.WriteLine(" plaintext: " + plaintext);

            BigInteger[] encryptedValues = rsa.Encrypt(plaintext);
            Console.Write(" Encrypted values: ");
            foreach (BigInteger encryptedValue in encryptedValues)
            {
                Console.Write(encryptedValue + " ");
            }

            // Giải mã
            string decryptedText = rsa.Decrypt(encryptedValues);
            //rsa.Decrypt(encryptedValues);
            Console.WriteLine("\n Decrypted text: " + decryptedText);

            Console.