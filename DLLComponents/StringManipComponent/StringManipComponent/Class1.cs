using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringManipComponent
{
    public class StringManip
    {
        public string s1;
        public string s2;
        public string s3;

        //Get And Set 

        public string S1 {

            get {
                return s1;
            }
            set {
                s1 = value;
            }
        }

        public string S2 {
            get {
                return s2;

            }
            set {
                s2 = value;

            }
        }

        public string S3 {
            get {
                return s3;
            }
            set {
                s3 = value;
            }
        
        }

        //String Concatenation
        public string StrConcat(string a, string b)
        {
            string c = string.Concat(a.Trim(), " ");
            s1 = string.Concat(c, b.Trim());
            return s1;
        }

        //Extracting First Name
        public string StrSplit(string a)
        {

            string[] split = a.Split(new Char[] { ' ', ',', '.', ':', '\t' });
            return split[0];
        }


    }
}
