using Mpago.Domain.Product;

namespace MPago.Data
{
    public class SmartPhoneData
    {
        private static SmartPhoneData _instance = null;

        /// <summary>
        /// Solo con fines de ejemplo claro...
        /// </summary>
        public List<SmartPhoneDTO> _products { get; set; }

        public SmartPhoneData()
        {
            _products = new List<SmartPhoneDTO>()
            {
                new SmartPhoneDTO
                        {
                            Id = "a123",
                            Name = "Ipad Pro 500",
                            Price = 50.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/ipad01.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "b123",
                            Name = "Samsung S22+",
                            Price = 60.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/s22.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "c123",
                            Name = "Samsung Tab 9",
                            Price = 70.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/tab9.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "d123",
                            Name = "In-Ear Bose SoundSport",
                            Price = 30.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/abose.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "e123",
                            Name = "GoPro - Fusion 360",
                            Price = 55.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/gopro.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "f123",
                            Name = "Beats by Dr. Dre Wireless Headphones",
                            Price = 15.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/beats.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "g123",
                            Name = "GoPro - HERO7 Black HD Waterproof Action",
                            Price = 32.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/gopro7.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "h123",
                            Name = "Apple Watch Series 3",
                            Price = 63.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/applewatch.png"
                        },
                new SmartPhoneDTO
                        {
                            Id = "i123",
                            Name = "Lenovo - 330-15IKBR 15.6",
                            Price = 101.99m,
                            Quantity = 1,
                            UrlImage = "https://cramos.dev/lab/images/lenovo.png"
                        }

            };



        }

        public static SmartPhoneData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SmartPhoneData();
                }
                return _instance;
            }
        }


    }

}