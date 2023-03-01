using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lightweight
{
    public class Param
    {
        public int h;
        public int s;
        public Bitmap pic;
    }

    public class ParamCloudlet1 : Param
    {
        public ParamCloudlet1()
        {
            h = 50;
            s = 1;
            pic = new Bitmap(@"C:\Users\MOJI\source\repos\kpz\Lightweight\Lightweight\1.png");
        }
    }
    public class ParamCloudlet2 : Param
    {
        public ParamCloudlet2()
        {
            h = 50;
            s = 2;
            pic = new Bitmap(@"C:\Users\MOJI\source\repos\kpz\Lightweight\Lightweight\2.png");
        }
    }
    public class ParamCloudlet3 : Param
    {
        public ParamCloudlet3()
        {
            h = 50;
            s = 3;
            pic = new Bitmap(@"C:\Users\MOJI\source\repos\kpz\Lightweight\Lightweight\3.png");
        }
    }
    public class ParamCloudlet4 : Param
    {
        public ParamCloudlet4()
        {
            h = 50;
            s = 4;
            pic = new Bitmap(@"C:\Users\MOJI\source\repos\kpz\Lightweight\Lightweight\4.png");
        }
    }
    public class Cloudlet
    {
        public int x, y;

        public Param p;

        public Cloudlet(int x, int y, Param p)
        {
            this.p = p;
            this.x = x;
            this.y = y;
        }
    }
}