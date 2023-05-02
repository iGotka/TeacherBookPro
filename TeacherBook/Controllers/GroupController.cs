using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using TeacherBook.Models;

namespace TeacherBook.Controllers
{
    internal class GroupController
    {

        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        public static List<Group> GetGroup()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Groups";
                Console.WriteLine(url);
                HttpResponseMessage response = client.GetAsync(url).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Group>>(content.Result);
                return answer;
            }
        }
        /// <summary>
        /// POST
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static bool POSTGroup(Group record)
        {
            string jsonStr = JsonConvert.SerializeObject(record);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Groups";
                Console.WriteLine(url);
                HttpResponseMessage response = client.PostAsync(url, byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
        public static bool DeleteGroup(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Groups";
                HttpResponseMessage response = client.DeleteAsync($"url").Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
