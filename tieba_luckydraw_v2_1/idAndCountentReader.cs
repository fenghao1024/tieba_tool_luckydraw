using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

////// just for baidu teiba reply
namespace BMX_TieBarTool
{
    class idAndCountentReader
    {
        idAndCountentReader()
        {

        }
        ~idAndCountentReader()
        {

        }

        public static string getID(string data, string key,ref int startIndex)
        {
            if (key.Length > data.Length || data == null)
            {
                return null;
            }

            char quotationMark = '\"';

            int id_index = 0;

            List<char> destStr_stack = new List<char>();
            char[] charData = data.ToCharArray();
            char[] charKey = key.ToCharArray();

            id_index = findStr(data, key, startIndex);
            if (id_index == -1)
                return null;

            // find data in quotation mark
            id_index += key.Length;
            do
            {
                
            } while (charData[id_index++] != quotationMark);
            do
            {
                destStr_stack.Add(charData[id_index++]);
            } while (charData[id_index] != quotationMark);

            string userID = new string(destStr_stack.ToArray());
            
            return userID;
        }


        /// <summary>
        /// delete html angleBracket...
        /// </summary>
        /// <param name="data"></param>
        /// 
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static string getContent(string data, char[] shouldRemoveChar, ref int startIndex)
        {
            if (startIndex > data.Length || data == null)
            {
                return null;
            }

            List<char> destStr_stack = new List<char>();
            char[] charData = data.ToCharArray();
            //char[] charKey = key.ToCharArray();

            char leftAngleBracket = '<';
            char rightAngleBracket = '>';
            //char x = '\r';

            bool isContent = false;
            
            for (int i = startIndex; i < data.Length; i++)
            {
                bool quickCoutinue = false;

                if (shouldRemoveChar != null)
                {
                    foreach (char removeChar in shouldRemoveChar)
                    {
                        if (removeChar == charData[i])
                        {
                            quickCoutinue = true;
                            break;
                        }
                    }
                }
                if (quickCoutinue)
                    continue;
                if (charData[i] == leftAngleBracket)
                {
                    isContent = false;
                    continue;
                }
                if (charData[i] == rightAngleBracket)
                {
                    isContent = true;
                    continue;
                }
                if (isContent)
                {
                    destStr_stack.Add(charData[i]);
                }
            }
            
            string content = new string(destStr_stack.ToArray());

            return content;
        }

        public static string[] getAllID(string data, string key)
        {
            string[] allUserID = new string[3];

            return allUserID;
        }

        public static string[] getAllContent(string data, string key)
        {
            string[] allContent = new string[1];

            return allContent;
        }

        public static string getSegment(string data, string startKey, string endKey, ref int startIndex)
        {
            if (startKey.Length > data.Length || endKey.Length > data.Length || (startKey.Length + endKey.Length) > data.Length || data == null)
            {
                return null;
            }

            List<char> charSegment = new List<char>();
            char[] charData = data.ToCharArray();

            int index_start = findStr(data, startKey, startIndex);
            int index_end = -1;
            if (index_start != -1)
            {
                index_end = findStr(data, endKey, index_start);
                if (index_end == -1)
                    return null;
            }
            else
            {
                return null;
            }

            int end = index_end;
            int start = index_start + startKey.Length;
            for (int i = index_start; i < end; i++)
            {
                charSegment.Add(charData[i]);
            }

            startIndex = index_end;

            string tempStr = new string(charSegment.ToArray());            

            return tempStr;
        }

        private int nowFlag = 0;
        public int htmlReaderNowFlag
        {
            set { nowFlag = value; }
            get { return  nowFlag; }
        }

        private int dataLength = 0;
        public int htmlCharCount
        {
            get { return dataLength; }
        }

        /// <summary>
        /// return last char of key index in data;
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        public static int findStr(string data, string key, int startIndex)
        {
            if (key.Length > data.Length || startIndex > data.Length)
            {
                return -1;
            }
            //int index = 0;

            char[] charData = data.ToCharArray();
            char[] charKey = key.ToCharArray();

            bool isFinded = false;
            for (int i = startIndex; i <= data.Length - key.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (charData[i + j] == charKey[j])
                    {
                        isFinded = true;
                    }
                    else
                    {
                        isFinded = false;
                        break;
                    }
                }// end once find

                if (isFinded)
                {
                    return i;
                }

            }// final
            return -1;
        }
    }
}
