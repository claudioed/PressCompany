using System;
using System.Net.Http;
using System.Net.Mime;
using CloudNative.CloudEvents;
using Newtonsoft.Json;
using PressCompany.Advertisement.Model;

namespace PressCompany.Advertisement.Service
{
    public class AdvertisementRequestService : IAdvertisementRequestService
    {
        public Opportunity Request(AdvertisementRequest request)
        {
            var cloudEvent = new CloudEvent("com.example.myevent", new Uri("urn:example-com:mysource"))
            {
                DataContentType = new ContentType(MediaTypeNames.Application.Json),
                Data = JsonConvert.SerializeObject("hey there!")
            };

            var content = new CloudEventContent( cloudEvent,
                ContentMode.Structured,
                new JsonEventFormatter());

            var httpClient = new HttpClient();
            var result =  httpClient.PostAsync("", content);

            return null;
        }
    }
}