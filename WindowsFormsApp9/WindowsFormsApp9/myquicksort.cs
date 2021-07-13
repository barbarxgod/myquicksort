using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //referansımızı ekledik

namespace WindowsFormsApp9
{
    class myquicksort:Button //button sınıfından miras alıyoruz
    {
        public myquicksort(IContainer container)//yapıcı metodumuzu yazıyoruz
        {
            container.Add(this);
        }
        Point konum;
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }
    }
}
