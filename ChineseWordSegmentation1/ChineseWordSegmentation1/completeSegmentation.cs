using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;


namespace ChineseWordSegmentation1
{
    class completeSegmentation
    {
        private string segResult = "";

        #region 第一种方法做出单词词典
        static StreamReader srcWord = new StreamReader("DicPOS.txt", UnicodeEncoding.GetEncoding("GB2312"));
        static dictionaryAndFlags dicWord = new dictionaryAndFlags();
        ArrayList wordDictionay = dicWord.makeDictionary(srcWord);
        #endregion

        #region 第一种方法做出词性词典
        static StreamReader srcTag = new StreamReader("DicPOS_tag.txt", UnicodeEncoding.GetEncoding("GB2312"));
        static dictionaryAndFlags dicTag = new dictionaryAndFlags();
        ArrayList tagDictionay = dicTag.makeDictionary(srcTag);
        #endregion
        //private ArrayList wordDictionary;
        //static public ArrayList WordDictionary
        //{
        //        StreamReader src = new StreamReader("DicPOS.txt", UnicodeEncoding.GetEncoding("GB2312"));
        //        dictionaryAndFlags dic = new dictionaryAndFlags();
        //        wordDictionary = dic.makeDictionary(src);
            
        //}
        public string forwoardSegmentation(string incomeString)
        {
            int wordLength=incomeString.Length;
            int ID = 0,flags=0;
            for (int i = 0; i < incomeString.Length;i++ )
            { 
                foreach (string temp in wordDictionay)
                {
                    if (temp != null)
                    {
                        string tempString = incomeString.Substring(0, wordLength);
                        if (temp.Equals(tempString))
                        {  flags = 1; 
                            break;}
                        else
                        {
                            ID++;
                            if (ID == wordDictionay.Count - 1)
                            { wordLength--;
                                ID = 0;}
                        }
                    }
                }
                if (flags == 1)   
                    break;
            }
            segResult += incomeString.Substring(0, wordLength)+"/"+tagDictionay[ID];
            incomeString = incomeString.Substring(wordLength,incomeString.Length-wordLength);
            if(incomeString != "")
                forwoardSegmentation(incomeString);//recurrent  key point;
            return segResult;
        }        
    }
}
