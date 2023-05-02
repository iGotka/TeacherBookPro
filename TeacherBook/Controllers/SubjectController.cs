using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TeacherBook.Models;

namespace TeacherBook.Controllers
{
    internal class SubjectController
    {
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        public static List<Subject> GetSubject()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Subjects";
                Console.WriteLine(url);
                HttpResponseMessage response = client.GetAsync(url).Result;
                var content = response.Content.ReadAsStringAsync();
                var answer = JsonConvert.DeserializeObject<List<Subject>>(content.Result);
                return answer;
            }
        }
        /// <summary>
        /// POST
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static bool POSTSubject(Subject record)
        {
            string jsonStr = JsonConvert.SerializeObject(record);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonStr);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Subjects";
                Console.WriteLine(url);
                HttpResponseMessage response = client.PostAsync(url, byteContent).Result;
                return response.IsSuccessStatusCode;
            }
        }
        public static bool DeleteSubject(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{Manager.RootUrl}Subjects";
                HttpResponseMessage response = client.DeleteAsync($"url").Result;
                return response.IsSuccessStatusCode;
            }
        }
    }
}
