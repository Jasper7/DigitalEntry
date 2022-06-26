using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using DigitalEntry.Models;
using Newtonsoft.Json;

namespace DigitalEntry.Services
{
    public static class ApiService
    {
        const string _apiUrl = "https://9007-46-18-203-145.eu.ngrok.io/api";

        static HttpClient _client;

        static ApiService()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("ngrok-skip-browser-warning", "1");
        }

        public static async Task<bool> CheckCode(string code)
        {
            var url = $"{_apiUrl}/CodeCheck/{code}";
            var result = await _client.GetStringAsync(url);
            var isAllow = Convert.ToBoolean(result);

            return isAllow;
        }

        public static async Task<List<ParentModel>> GetParentsForChild()
        {
            var url = $"{_apiUrl}/Parents/1";
            var result = await _client.GetStringAsync(url);
            var resultList = JsonConvert.DeserializeObject<List<ParentModel>>(result);

            return resultList;
        }


        public static async Task<List<AccessHistoryModel>> GetAccessHistory()
        {
            var url = $"{_apiUrl}/AccessHistory";
            var result = await _client.GetStringAsync(url);
            var resultList = JsonConvert.DeserializeObject<List<AccessHistoryModel>>(result);

            return resultList;
        }

        public static async Task<List<ChildModel>> GetChilds()
        {
            var url = $"{_apiUrl}/Childs";
            var result = await _client.GetStringAsync(url);
            var resultList = JsonConvert.DeserializeObject<List<ChildModel>>(result);

            return resultList;
        }

        public static async Task<List<EnterHistoryModel>> GetChildsHistory()
        {
            var url = $"{_apiUrl}/ChildHistory";
            var result = await _client.GetStringAsync(url);
            var resultList = JsonConvert.DeserializeObject<List<EnterHistoryModel>>(result);

            return resultList;
        }
    }
}