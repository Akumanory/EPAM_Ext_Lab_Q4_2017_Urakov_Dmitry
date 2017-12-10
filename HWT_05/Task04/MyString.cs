namespace Task04
{
    using System.Text;

    public class MyString
    {
        public char[] ToCharArray(string str)
        {
            char[] charArr = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                charArr[i] = str[i];
            }

            return charArr;
        }

        public string ToUpper(string str)
        {
            char[] arr = ToCharArray(str);
            StringBuilder newstr = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = char.ToUpper(arr[i]);
                newstr.Append(arr[i]);
            }

            return newstr.ToString();
        }

        public string ToLower(string str)
        {
            char[] arr = ToCharArray(str);
            StringBuilder newstr = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = char.ToLower(arr[i]);
                newstr.Append(arr[i]);
            }

            return newstr.ToString();
        }

        public string Remove(string str, int startIndex, int count)
        {
            char[] arr = ToCharArray(str);
            StringBuilder newstr = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (i > (count + startIndex - 1) | i < startIndex)
                {
                    newstr.Append(str[i]);
                }
            }

            return newstr.ToString();
        }

        public string Replace(string str, char oldValue, char newValue)
        {
            char[] arr = ToCharArray(str);
            StringBuilder newstr = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                if (arr[i] == oldValue)
                {
                    arr[i] = newValue;
                }

                newstr.Append(arr[i]);
            }

            return newstr.ToString();
        }
    }
}
