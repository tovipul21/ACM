namespace Acme.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces before each capital letter in a string
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpaces(this string source)
        {
            string result = string.Empty;

            if (!string.IsNullOrWhiteSpace(source))
            {
                // Solution 1
                //char[] arr = source.ToCharArray();

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    if (char.IsUpper(arr[i]) && i > 0)
                //    {
                //        result += " ";
                //    }

                //    result += arr[i];
                //}

                // Solution 2
                foreach (char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result = result.Trim();
                        result += " ";
                    }

                    result += letter;
                }
            }

            return result.Trim();
        }
    }
}