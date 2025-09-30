using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gatya.ViewModel;

namespace gatya.Model
{
    public class gatyaModel
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public gatyaModel() 
        {
            Width = 100;
            Height = 100;
        }
        public event EventHandler<gatyaEventArgs> meretChanged;

        public void setWidth(int num)
        {
            if (num >= 10 && num <= 200)
            {
                Width = num;
                Meret();
            }
        }
        public void setHeight(int num)
        {
            if (num >= 10 && num <= 200)
            {
                Height = num;
                Meret();
            }
        }

        public void Meret()
        {
            if ((Height * Width) < 2500) 
            {
               meretChanged.Invoke(this, new gatyaEventArgs("small"));
                  
                
            }
            else if((Height * Width) < 10000)
            {
                meretChanged.Invoke(this, new gatyaEventArgs("medium"));
            }
            else if ((Height * Width) < 40000) 
            {
                meretChanged.Invoke(this, new gatyaEventArgs("large"));
            }
            else
            {
                meretChanged.Invoke(this, new gatyaEventArgs("InValid"));
            }
        }
    }
}
