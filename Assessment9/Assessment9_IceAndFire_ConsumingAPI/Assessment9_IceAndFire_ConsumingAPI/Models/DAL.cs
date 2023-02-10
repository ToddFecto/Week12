using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assessment9_IceAndFire_ConsumingAPI.Models
{
    public class DAL
    {
        private static HttpClient client = null;
        private static HttpClient GetHttpClient()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://anapioficeandfire.com");
            }
            return client;
        }

        public static async Task<Character> GetAllCharacters(string name)
        {
            string path = $"/api/characters";

            var connection = await GetHttpClient().GetAsync(path);
            Character result = await connection.Content.ReadAsAsync<Character>();

            return result;
        }
        public static async Task<string> GetSpecificCharacter(string name)
        {
            string path = $"/api/characters/?name=Daenerys%20Targaryen,Jon%20Snow,Drogo,Margaery%20Tyrell,Tyrion%20Lannister";

            var connection = await GetHttpClient().GetAsync(path);
            Character result = await connection.Content.ReadAsAsync<Character>();

            return result.name;
        }

    }
}
