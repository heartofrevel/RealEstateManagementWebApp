using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionComponent
{
    public class AgeException:ApplicationException
    {
         private string errormsg;

        public AgeException()
        {
        }

        public AgeException(string errmsg)
        {
            errormsg = errmsg;
        }

        public string Errormsg
        {
            get
            {
                return errormsg;
            }

            set
            {
                errormsg = value;
            }
        }
       
    }
    public class CheckAge
    {
        public void Check(int age)
        {
            if (age < 18)
            {
                throw new AgeException("Age should be greater than 18");

            }
        }

    }
}
