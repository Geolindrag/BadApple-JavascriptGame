using System;
using System.Net;
using System.Diagnostics;


namespace BasicHTTPServer
{
    class Program
    {
        static void Main(string[] args)
        {
            
            HttpListener server = new HttpListener();
            server.IgnoreWriteExceptions = true;
            server.Prefixes.Add("http://localhost:8000/");
            server.Start();
            Console.WriteLine("Server started,Opening your browser...\nYou can close the server and this app by pressing \"CTRL+C\"");
            Process.Start(new ProcessStartInfo("http://localhost:8000/index.html") { UseShellExecute = true});

            while (true)
            {
                HttpListenerContext ctx = server.GetContext();
                HttpListenerResponse resp = ctx.Response;
                HttpListenerRequest req = ctx.Request;
                string page = Directory.GetCurrentDirectory()+"\\BadAppleJS" +req.RawUrl;
                if (page == string.Empty) page = "index.html";
                FileStream webpage = new FileStream(page,FileMode.Open,FileAccess.Read);
                byte[] buffer = new byte[webpage.Length];
                webpage.Read(buffer, 0, (int)webpage.Length);
                resp.ContentLength64 = buffer.Length;
                Stream stream = resp.OutputStream;
                try
                {
                    stream.Write(buffer, 0, buffer.Length);
                }catch
                {
                    stream.Dispose();
                }
                
                ctx.Response.Close();
                resp.Close();
                webpage.Close();
           }
        }
    }
}