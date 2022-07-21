using System.Drawing.Imaging;
using System.Net;
using System.Text;

namespace Japp.Util
{
    internal class ImageServices
    {
        private string _imageUrl;
        private Bitmap _bitmap;

        public ImageServices(string imageUrl)
        {
            this._imageUrl = imageUrl;
        }

        public void Download()
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(_imageUrl);
                _bitmap = new Bitmap(stream);
                stream.Flush();
                stream.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public Bitmap GetImage()
        {
            return _bitmap;
        }
        public void SaveImage(string filename, ImageFormat format)
        {
            if (_bitmap != null)
            {
                _bitmap.Save(filename, format);
            }
        }
        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static String Gethtmlform(string Url)
        {

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(Url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();
            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();
            myResponse.Close();

            return result;
        }
        public static string Captcharesult(Byte[] ImageByte, string key)
        {
            //POST
            try
            {
                ServicePointManager.Expect100Continue = false;
                var request = (HttpWebRequest)WebRequest.Create("http://azcaptcha.com/in.php");
                string base64string = Convert.ToBase64String(ImageByte);
                var postData = "method=base64&key=" + key + "&body=" + WebUtility.UrlEncode(base64string);
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                var response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                if (responseString.Contains("OK|"))
                {
                    //  GET
                    string captcha = "";

                    while (true)
                    {
                        captcha = Gethtmlform("http://azcaptcha.com/res.php?key=" + key + "&action=get&id=" + responseString.Split('|')[1]);
                        if (captcha == "CAPCHA_NOT_READY")
                        {
                            System.Threading.Thread.Sleep(5000);
                            continue;
                        }
                        if (captcha == "_")
                        {
                            System.Threading.Thread.Sleep(5000);
                            continue;
                        }
                        if (captcha.Contains("OK|"))
                        {
                            captcha = captcha.Replace("OK|", "");
                        }
                        return captcha;
                    }
                }
                else
                {
                    return "";
                }
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}
