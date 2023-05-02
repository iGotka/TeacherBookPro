using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TeacherBook.Models;

namespace TeacherBook.Controllers
{
     public class UserController
    {

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <returns></returns>
        public static User Auth(string login, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Users/{login}/{password}";
                Console.WriteLine(url);
                HttpResponseMessage response = client.GetAsync(url).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<User>(content.Result);
                return answer;
            }
        }
        /// <summary>
        /// POST
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static bool POSTSUser(User record)
        {
            string jsonStr = JsonConvert.SerializeObject(record);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Users";
                Console.WriteLine(url);
                HttpResponseMessage response = client.PostAsync(url, byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
        public static bool DeleteUser(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Users";
                HttpResponseMessage response = client.DeleteAsync($"url").Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
