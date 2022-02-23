using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Newtonsoft.Json;
using RestSharp;

namespace shopify
{
    public class ApiRequest
    {
        private const string BaseUrl = "https://opendata.usac.org/resource/";
        public async Task<T> SendRequestAsync<T>(RestRequest restRequest)
        {
            var restClient = new RestClient(BaseUrl);
            var restResponse = await restClient.ExecuteAsync<T>(restRequest);
            return restResponse.Data;
        }

        public List<EmergencyConnectivityFund> GetOpenDataAsync(int index = 0, int limit = 5000)
        {
            var restRequest = new RestRequest($"nkde-wkir.json?$limit={limit}&$offset={index * limit}", Method.Get);
            return new ApiRequest().SendRequestAsync<List<EmergencyConnectivityFund>>(restRequest).Result;
        }

    }

}
