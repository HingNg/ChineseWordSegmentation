using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseWordSegmentation1
{
    class dictionaryAndFlags
    {
        private StreamReader reader;

        //构造函数
        //private void dictionaryAndFlags(StreamReader reader)
        //{ this.reader = reader; }

        public ArrayList makeDictionary(StreamReader src)
        {
            ArrayList dictionary=new ArrayList();
            try
            {
              //  src = new StreamReader("DicPOS.txt", UnicodeEncoding.GetEncoding("GB2312"));
                string line="";
                while (line != null)
                {
                    line = src.ReadLine();
                    dictionary.Add(line);
                }           
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex.Message);
            }
             return dictionary;       
        }
    }
}
