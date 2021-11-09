
using System;
using System.Text;
using System.Net;
using System.IO;

namespace SMS
{
    /*
    class First {
        static void Main(string[] args)
        {
            SMSSender sa = new SMSSender();
            sa.SendSMS("01792426831", "hello c# class");

        }
    }
    */
    public class SMSSender
    {
        private string userName = "tnrAdmin";
        private string password = "AccBddTNR91";
        private string address = "https://api.tnrsoft.com";
        private string port = "";
        private string result = "";
        private WebRequest request = null;
        private HttpWebResponse response = null;

        public SMSSender()
        {
            result = "";
            request = null;
            response = null;
        }
        public void SendSMS(string phone, string message)
        {
            try
            {
                //String message = "Hello C# Code";
                //String phone = "01792426831,01629711213";
                string url = "https://api.tnrsoft.com/send.php?token=sdjebf34ty47b4vcb4y4cec&phone=" + phone + "&message=" + System.Uri.EscapeUriString(message);
                request = WebRequest.Create(url);
                // Send the 'HttpWebRequest' and wait for response.
                response = (HttpWebResponse)request.GetResponse();
                Stream stream = response.GetResponseStream();
                Encoding ec = System.Text.Encoding.GetEncoding("utf-8");
                using (StreamReader reader = new
                System.IO.StreamReader(stream, ec))
                {
                    result = reader.ReadToEnd();
                    ///Console.WriteLine(result);
                    reader.Close();
                }
                stream.Close();
            }
            catch (Exception exp)
            {
                //Console.WriteLine(exp.ToString());
            }
            finally
            {
                if (response != null)
                    response.Close();
            }
        }
    }
}

