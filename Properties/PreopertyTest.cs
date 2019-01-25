using System;

namespace Properties
{
    public class PreopertyTest
    {
        public int Id {
            set
            {
                if (value < 0)
                    throw new Exception("Not alllowd value");

                Id = value;
            }

            get
            {
                return Id;
            }


        }

        public string EmailId {
           
            get; // if u remove this Email Id will not be accessible to anyone.
            set;
        }


    }
}
