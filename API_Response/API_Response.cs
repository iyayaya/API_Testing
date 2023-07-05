using RestSharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APIResponse
{
    public class API_Response
    {
        public CategoryList GetUsers()
        {
            var restClient = new RestClient("https://api.tmsandbox.co.nz");
            var restRequest = new RestRequest("/v1/Categories/6329/Details.json?catalogue=false", Method.Get);

            RestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var users = JsonConvert.DeserializeObject<CategoryList>(content);
            return users;
        }
    }
}