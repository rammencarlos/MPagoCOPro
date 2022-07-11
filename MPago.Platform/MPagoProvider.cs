using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;
using Mpago.Domain.Product;
namespace MPago.Platform
{
    public class MPagoProvider
    {
        public async Task<string> CreatePreference(SmartPhoneDTO smartp)
        {
            MercadoPagoConfig.AccessToken = "APP_USR-1159009372558727-072921-8d0b9980c7494985a5abd19fbe921a3d-617633181";
            MercadoPagoConfig.IntegratorId = "dev_24c65fb163bf11ea96500242ac130004";

            var request = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                    {
                        new PreferenceItemRequest
                        {
                            Id = "1234",
                            Title = smartp.Name,
                            PictureUrl = smartp.UrlImage,
                            Description = "Dispositivo móvil de Tienda e-commerce",
                            CategoryId = "entertainment",
                            Quantity = smartp.Quantity,
                            CurrencyId = "MXN",
                            UnitPrice = smartp.Price,
                        }
                    },
                Payer = new PreferencePayerRequest
                {
                    Name = "Lalo",
                    Surname = "Landa",
                    Phone = new MercadoPago.Client.Common.PhoneRequest { AreaCode = "11", Number = "2241061234" },
                    Address = new MercadoPago.Client.Common.AddressRequest { StreetName = "Falsa", StreetNumber = "123", ZipCode = "75620" },
                    Email = "test_user_81131286@testuser.com",
                },
                PaymentMethods = new PreferencePaymentMethodsRequest
                {
                    Installments = 6,
                    ExcludedPaymentMethods = new List<PreferencePaymentMethodRequest>
                        {
                            new PreferencePaymentMethodRequest
                            {
                                Id = "Visa"
                            }
                        }
                },
                BackUrls = new PreferenceBackUrlsRequest
                {
                    Failure = "https://cramos.dev/lab/ecommerce/status/fail",
                    Pending = "https://cramos.dev/lab/ecommerce/status/pending",
                    Success = "https://cramos.dev/lab/ecommerce/status/success",
                },
                ExternalReference = "ca_r_m@hotmail.com",
                BinaryMode = true,
                StatementDescriptor = "MP-test",
                AutoReturn = "approved",
                Expires = true,
                ExpirationDateFrom = DateTime.Now,
                ExpirationDateTo= DateTime.Now.AddHours(72),
                //NotificationUrl = "https://eonwd6mkekcmmh3.m.pipedream.net",
                NotificationUrl = "https://cramos.dev/lab/ecommerce/api/notification",
            };

            // Crea la preferencia usando el client

            var client = new PreferenceClient();
            Preference resultPreference = await client.CreateAsync(request);

            return resultPreference.InitPoint;
        }

        public async Task<string> CreatePreference2(SmartPhoneDTO smartp)
        {
            MercadoPagoConfig.AccessToken = "APP_USR-1159009372558727-072921-8d0b9980c7494985a5abd19fbe921a3d-617633181";
            MercadoPagoConfig.IntegratorId = "dev_24c65fb163bf11ea96500242ac130004";

            var payer = new PreferencePayerRequest
            {

            };

            var request = new PreferenceRequest
            {
                Items = new List<PreferenceItemRequest>
                    {
                        new PreferenceItemRequest
                        {
                            Id = "1234",
                            Title = smartp.Name,
                            PictureUrl = smartp.UrlImage,
                            Description = "Dispositivo móvil de Tienda e-commerce",
                            CategoryId = "entertainment",
                            Quantity = smartp.Quantity,
                            CurrencyId = "MXN",
                            UnitPrice = smartp.Price,
                        }
                    },
                Payer = new PreferencePayerRequest
                {
                    Name = "Lalo",
                    Surname = "Landa",
                    Phone = new MercadoPago.Client.Common.PhoneRequest { AreaCode = "11", Number = "2241061234" },
                    Address = new MercadoPago.Client.Common.AddressRequest { StreetName = "Falsa", StreetNumber = "123", ZipCode = "75620" },
                    Email = "test_user_81131286@testuser.com",
                },
                PaymentMethods = new PreferencePaymentMethodsRequest
                {
                    Installments = 6,
                    ExcludedPaymentMethods = new List<PreferencePaymentMethodRequest>
                        {
                            new PreferencePaymentMethodRequest
                            {
                                Id = "Visa"
                            }
                        }
                },
                BackUrls = new PreferenceBackUrlsRequest
                {
                    Failure = "https://cramos.dev/lab/ecommerce/status/fail",
                    Pending = "https://cramos.dev/lab/ecommerce/status/pending",
                    Success = "https://cramos.dev/lab/ecommerce/status/success",
                },
                ExternalReference = "ca_r_m@hotmail.com",
                BinaryMode = true,
                StatementDescriptor = "MP-test",
                AutoReturn = "approved",
                Expires = true,
                ExpirationDateFrom = DateTime.Now,
                ExpirationDateTo = DateTime.Now.AddHours(72),
                //NotificationUrl = "https://eonwd6mkekcmmh3.m.pipedream.net",
                NotificationUrl = "https://cramos.dev/lab/ecommerce/api/notification",
            };

            // Crea la preferencia usando el client

            var client = new PreferenceClient();
            Preference resultPreference = await client.CreateAsync(request);

            return resultPreference.InitPoint;
        }
    }
}
