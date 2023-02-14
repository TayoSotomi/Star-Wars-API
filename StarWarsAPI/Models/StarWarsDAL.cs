using Newtonsoft.Json;
using System.Net;

namespace StarWarsAPI.Models
{
    public class StarWarsDAL
    {
        public static StarwarsModel GetStarWars(string input)
        {
            //Adjust here
            //setup
            string url = $"https://swapi.dev/api/people/?search={input}";
            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            //save the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //convert to C#
            StarwarsModel result = JsonConvert.DeserializeObject<StarwarsModel>(JSON);
            return result;
        }

       
    }
}
