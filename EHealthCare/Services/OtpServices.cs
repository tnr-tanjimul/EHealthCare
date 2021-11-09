using SMS;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHealthCare.Services
{
    public class OtpServices
    {
        public int GenerateOTP()
        {
            Random rand = new Random();
            return rand.Next(100001, 999999);
        }

        public void SendOTP(int otp, NameValueCollection logData)
        {
            string text = "Dear "+ logData["UserName"] + "\nYour Login OTP is "+otp+"\nFrom EHealthCare";
            SMSSender sms = new SMSSender();
            sms.SendSMS(logData["UserMobile"],text);

        }
    }
}
