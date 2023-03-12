using System;
using Newtonsoft.Json.Linq;

namespace KanyeRon
{
	public class Quote
	{

        private HttpClient _client;

        public Quote(HttpClient client)
        {
            _client = client;
        }


        public string Kanye()
		{
            

            var kanyeURL = "https://api.kanye.rest/";

            var kanyeRespone = _client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeRespone).GetValue("quote").ToString();


           return kanyeQuote;

            
        }

        public string Ron()
        {
            

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronRespone = _client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronRespone).ToString().Replace('[', ' ').Replace(']', ' ').Trim();


            return ronQuote;
        }
	}
}

