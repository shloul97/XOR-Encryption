using System;
using System.Security.Cryptography;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XOR_Encrypt
{
	class Program
	{

		public void XORencrypt()
		{
			string b = @"D:\moayad.txt"; //file will be Encrypt and Decrypt
			
			//string text = Convert.ToString(File);
			byte[] fileE = File.ReadAllBytes(b);
			string text = Convert.ToString(fileE);
			byte[] decrypted = Encoding.UTF8.GetBytes(text);
			string key = fileE.Length.ToString();
			//byte[] encrypted = new byte[decrypted.Length];

			for (int i = 0; i < fileE.Length; i++)
			{
				fileE[i] = (byte)(decrypted[i] ^ key[i % key.Length]);
			}
			//FileStream a = new FileStream(@"moayadE.txt", FileMode.CreateNew, FileAccess.ReadWrite);
			string a = @"D:\moayadE.txt"; //File Encrypted name <---------------
			File.WriteAllBytes(a, fileE);
			//string xored = System.Convert.ToBase64String(encrypted);

			//return encrypted;
		}
		public void XORdecrypt()
		{
			string b = @"D:\moayadE.txt"; //File Encrypted <---------------

			//string text = Convert.ToString(File);
			byte[] fileE = File.ReadAllBytes(b);
			string text = Convert.ToString(fileE);
			byte[] decrypted = Encoding.UTF8.GetBytes(text);
			string key = fileE.Length.ToString();
			//byte[] encrypted = new byte[decrypted.Length];

			for (int c = 0; c < fileE.Length; c++)
			{
				fileE[c] = (byte)((uint)fileE[c] ^ (uint)key[c % key.Length]);
			}
			//FileStream a = new FileStream(@"moayadE.txt", FileMode.CreateNew, FileAccess.ReadWrite);
			string a = @"D:\moayadb.txt"; //File Decrypted name <---------------
			File.WriteAllBytes(a, fileE);
			//string xored = System.Convert.ToBase64String(encrypted);

			//return encrypted;

			
		}
		static void Main(string[] args)
		{
			//FileStream s = new FileStream(@"D:\moayad.txt", FileMode.Open, FileAccess.Read);
			//string key = s.Length.ToString();
			Program a = new Program();
			a.XORencrypt();
			Program b = new Program();
			b.XORdecrypt();

		}
	}
}
