using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RMS.DL
{
    public interface IPhotoDL
    {
        Image LoadImage(int userID);
        void UpdateImage(int userID, byte[] photo);
        void SaveImage(int userID);
    }
}