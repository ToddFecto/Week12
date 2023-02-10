using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assessment9_IceAndFire_After.Models
{
    public class DAL
    {
        public static async Task<Character> GetCharacterById(int characterId)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.anapioficeandfire.com/api/");
            var responseTask = client.GetAsync($"characters/{characterId}");
            responseTask.Wait();

            var result = responseTask.Result;

            var readTask = result.Content.ReadAsAsync<Character>();
            readTask.Wait();

            var character = readTask.Result;

            return character;
        }
    }
}
