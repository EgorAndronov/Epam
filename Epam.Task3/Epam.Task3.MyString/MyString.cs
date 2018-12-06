using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.MyString
{
    public class MyString
    {
        private char[] charArray = new char[16];
        private int length = new int();

        public MyString(string str)
        {
            while (this.charArray.Length < str.Length)
            {
                this.charArray = new char[this.charArray.Length * 2];
            }

            for (int i = 0; i < str.Length; i++)
            {
                this.charArray[i] = str[i];
                this.Length++;
            }
        }

        public int Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                this.length = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.charArray.Length;
            }
        }

        public char this[int index]
        {
            get
            {
                return this.charArray[index];
            }

            set
            {
                this.charArray[index] = value;
            }
        }

        public bool Compare(MyString str)
        {
            if (this.Length != str.Length)
            {
                return false;
            }
            else
            {
                for (var i = 0; i < this.Length; i++)
                {
                    if (this.charArray[i] != str[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool Find(char chr)
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (char.ToUpper(this.charArray[i]) == char.ToUpper(chr))
                {
                    return true;
                }
            }

            return false;
        }

        public string ConvertToString()
        {
            return new string(this.charArray, 0, this.Length);
        }
    }
}
