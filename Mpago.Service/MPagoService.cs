using MercadoPago.Client.Preference;
using MercadoPago.Config;
using MercadoPago.Resource.Preference;
using Mpago.Domain.Product;

namespace Mpago.Service
{
    public class MPagoService
    {
        public async Task<string> CreatePreference(SmartPhoneDTO smartp)
        {
            MercadoPagoConfig.AccessToken = "TEST-2060099604929771-070509-4fb2f73f5179e6b06972951dc6f8ef45-16763907";

            Preference resultPreference;
            try
            {
                //MercadoPagoConfig.PlatformId = "PLATFORM_ID";
                //MercadoPagoConfig.IntegratorId = "INTEGRATOR_ID";
                //MercadoPagoConfig.CorporationId = "CORPORATION_ID";

                // Crea el objeto de request de la preference
                var request = new PreferenceRequest
                {
                    Items = new List<PreferenceItemRequest>
                {
                    new PreferenceItemRequest
                    {
                        Id = smartp.Id,
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
                        Name = "Lalo Landa",
                        Phone = new MercadoPago.Client.Common.PhoneRequest { AreaCode = "11", Number = "2241061234" },
                        Address = new MercadoPago.Client.Common.AddressRequest { StreetName = "Falsa", StreetNumber = "123", ZipCode = "75620" },
                        Email = "ca_r_m2@hotmail.com",

                    },
                    PaymentMethods = new PreferencePaymentMethodsRequest
                    {

                    },
                    BackUrls = new PreferenceBackUrlsRequest
                    {
                        Failure = "https://cramos.dev/lab/ecommerce/fail",
                        Pending = "https://cramos.dev/lab/ecommerce/pending",
                        Success = "https://cramos.dev/lab/ecommerce/success"
                    },

                    ExternalReference = "ca_r_m@hotmail.com",
                    BinaryMode = true,
                    StatementDescriptor = "Test Checkout Pro",
                    AutoReturn = "approved"
                    //Expires = true,
                    //DateOfExpiration = DateTime.Now.AddDays(3),
                };

                // Crea la preferencia usando el client

                var client = new PreferenceClient();
                resultPreference = await client.CreateAsync(request);
            }
            catch (Exception ex)
            {
                return null;
            }

            return resultPreference.Id;
        }
    }
}
