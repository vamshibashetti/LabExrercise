using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Text.Json;
using RestSharp;

namespace RestClassLib
{
    public class APIClass
    {
        public static string GetMethod()
        {
            var client = new RestClient("https://reqres.in/ ");
            var request = new RestRequest();
            var response= client.Get(request);
            return (response.Content);
        }
         public static string PostMethod()
        {
            var client = new RestClient("https://reqres.in/ ");
            var request = new RestRequest();
            var response= client.Post(request);
            request.AddParameter("text/plain", "\"email\": \"george.mh@reqres.in\",\r\n \"first_name\": \"Georges\",\r\n \"last_name\": \"Bluths\",\r\n \"avatar\": \"https://reqres.in/img/faces/2-image.jpg\"", ParameterType.RequestBody);
            return (response.Content);

            
        }
        public static string DeleteMethod()
        {
            var client = new RestClient("https://reqres.in/ ");
            var request = new RestRequest();
            var response= client.Delete(request);
           
            return (response.Content);
        }
        public static string PutMethod()
        {
            var client = new RestClient("https://reqres.in/ ");
            var request = new RestRequest();
            var response= client.Put(request);
           
            return (response.Content);
        }

    }
}
