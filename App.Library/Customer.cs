using System;

namespace App.Library
{
    public class Customer
    {
        public string FirstName 
        { 
            get 
            {
                return FirstName; 
            }

            set
            {
                try
                {
                    IsEmptyString(value);
                    FirstName = value;
                }
                catch(ArgumentException e )
                {
                    PrintExceptionMsg(e);
                }
            } 
        }

        public string LastName  
        { 
            get
            {
                return LastName; 
            }

            set 
            {
               try
                {
                    IsEmptyString(value);
                    LastName = value;
                }
                catch (ArgumentException e)
                {
                    PrintExceptionMsg(e);
                }
            }
        }

        public string PreferedLocation 
        { 
            get
            {
                return PreferedLocation;
            }

            set
            {
                try
                {
                    IsEmptyString(value);
                    PreferedLocation = value;
                }
                catch (ArgumentException e)
                {
                    PrintExceptionMsg(e);
                }
            }
        }

        public DateTime LastTimeOrdered { get; set; }

        private Boolean IsEmptyString(string s)
        {
            if( s == "")
            {
                throw new ArgumentException(
                    String.Format($"Empty value is not valid"), s
                );
            }
            return true;
        }

        private void PrintExceptionMsg(Exception e) 
        {
            Console.WriteLine($"{e.GetType().Name}: {e.Message}");
        }
    }
}
