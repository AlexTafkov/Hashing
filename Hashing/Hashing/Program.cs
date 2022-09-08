using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace Hashing
{
    class Program
    {
        public static class Hashing
        {
            public static string ToSHA256(string s)
            {
                using var sha256 = SHA256.Create();
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));
                var sb = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
        
        public class Downloads
        {
            public string filesInDownloads;
            public string extensions;
            public string hashes;
            
        }
        


        static int count = 0;
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Fogy\Downloads";
            var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            var dir = new DirectoryInfo(@"C:\Users\Fogy\Downloads");
            var allExtensions = dir.EnumerateFiles("*.*", SearchOption.AllDirectories)
            .Select(f => f.Extension);

           
                
                
            foreach (var file in files)
            {
                   var info = new FileInfo(file);

                   var MB = info.Length / 1024;

                    Downloads d1 = new Downloads();

                    d1.filesInDownloads = file;
                    //d1.extensions = ext;
                    d1.hashes = Hashing.ToSHA256(file);

                    //Console.WriteLine($"{d1.filesInDownloads} {d1.hashes} ___NUMBER: {count++} ___ SIZE: {MB}Mbs ___ FILE TYPE {d1.extensions}");

                    //Console.WriteLine($"{file} {Hashing.ToSHA256(file)} ___ NUMBER: {count++} ___ SIZE: {MB}Mbs ___ FILE TYPE: {ext}");
                    break;
         
            }

            foreach (var file in files)
            {
                Console.WriteLine(file);
                foreach (var file in files)
                {
                    Console.WriteLine(ext);
                    break;
                }
            }
            foreach (var file in files)
            {
                Console.WriteLine(Hashing.ToSHA256(file));
            }
            foreach (var file in files)
            {
                Console.WriteLine(count++);
            }
            foreach (var file in files)
            {
                var info = new FileInfo(file);
                var MB = info.Length / 1024;
                Console.WriteLine(MB);
            }
            foreach (string ext in allExtensions)
            foreach (var file in files)
            {
                Console.WriteLine(ext);
                    break;
            }
            
        }
   
    }
}
