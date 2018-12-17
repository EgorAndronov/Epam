using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5.To_Int_Or_Not_To_Int
{
    public static class StringExpension
    {
        public static bool IsPositiveInteger(this string elem)
        {
            int indexE = 0;
            int indexComma = 0;

            if (!(elem[0] == '+' || elem[0] == '-' || ((int)elem[0] >= 48 & (int)elem[0] <= 57)))
            {
                return false;
            }

            for (int i = 1; i < elem.Length; i++)
            {
                if (!((int)elem[i] >= 48 & (int)elem[i] <= 57))
                {
                    if (elem[i] == ',')
                    {
                        indexComma = i + 1;
                        break;
                    }

                    if (((elem[i] == 'E') || elem[i] == 'e') && (i != elem.Length - 1) && (i != 0))
                    {
                        indexE = i + 1;
                        break;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (indexComma != 0)
            {
                if (!((int)elem[indexComma] >= 48 & (int)elem[indexComma] <= 57))
                {
                    return false;
                }

                for (int i = indexComma + 1; i < elem.Length; i++)
                {
                    if (!((int)elem[i] >= 48 & (int)elem[i] <= 57))
                    {
                        if (((elem[i] == 'E') || elem[i] == 'e') && (i != elem.Length - 1) && (i != 0))
                        {
                            indexE = i + 1;
                            break;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            if (indexE != 0)
            {
                int num = 0;
                for (int i = indexE; i < elem.Length; i++)
                {
                    if (!((int)elem[i] >= 48 & (int)elem[i] <= 57))
                    {
                        return false;
                    }
                    else
                    {
                        num = (num * 10) + (int)elem[i] - 48;
                    }
                }

                if (((indexE - 1 - indexComma) > num) && (indexComma != 0))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
