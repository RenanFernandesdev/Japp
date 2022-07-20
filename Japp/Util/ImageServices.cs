using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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


    }
}
