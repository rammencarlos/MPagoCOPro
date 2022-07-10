using Mpago.Domain;
using Mpago.Domain.Product;

namespace MPago.Data
{
    public class UserData
    {
        private static UserData _instance = null;

        /// <summary>
        /// Solo con fines de ejemplo claro...
        /// </summary>
        public UserDTO _user { get; set; }

        public UserData()
        {
        }

        public static UserData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserData();
                }
                return _instance;
            }
        }


    }

}