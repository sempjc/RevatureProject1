using System;

namespace App.Library
{
    public class Customer
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name of the Customer.</value>
        public string FirstName 
        {
            get => FirstName;
            set => SetStringIfValid(value, FirstName);
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name of the customer.</value>
        public string LastName  
        { 
            get => LastName; 
            set => SetStringIfValid(value, LastName);
        }

        /// <summary>
        /// Gets or sets the prefered location.
        /// </summary>
        /// <value>The prefered location where user will made orders.</value>
        public string PreferedLocation
        {
            get => PreferedLocation;
            set => SetStringIfValid(value, PreferedLocation);
        }

        /// <summary>
        /// Gets or sets the last time ordered.
        /// </summary>
        /// <value>The last time customer make an ordered.</value>
        public DateTime LastTimeOrdered { get; set; }

        /// <summary>
        /// Check if value is an empty string.
        /// </summary>
        /// <returns>
        ///     <c>true</c>, if empty string is found, 
        ///     <c>false</c> otherwise.
        /// </returns>
        /// <param name="s">S.</param>
        private Boolean IsEmptyString(string s)
        {
            return s == "" ? true : false;
        }

        /// <summary>
        /// Prints the exception message.
        /// </summary>
        /// <param name="e">E.</param>
        private void PrintExceptionMsg(Exception e) 
        {
            Console.WriteLine($"{e.GetType().Name}: {e.Message}");
        }

        /// <summary>
        /// Sets the string if valid.
        /// </summary>
        /// <param name="s">S.</param>
        /// <param name="field">Property.</param>
        private void SetStringIfValid(string s, string field )
        {
            try
            {
                if (IsEmptyString(s))
                {
                    throw new ArgumentException(
                        String.Format("Empty value is not valid"), s
                    );
                }
                field = s;
            }
            catch(ArgumentException e)
            {
                PrintExceptionMsg(e);
            }
        }
    }
}