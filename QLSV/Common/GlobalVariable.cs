using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;



namespace APIBanDienThoai.Common
{
    public class GlobalVariable
    {
        public const string url = "http://phonemushroom.somee.com/";
        public async Task<string> GetApiAsync(string posturl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage Response = await httpClient.GetAsync(posturl);
                if (Response.IsSuccessStatusCode)
                {
                    var responseJsonString = await Response.Content.ReadAsStringAsync();
                    return responseJsonString;
                } else
                {
                    return Response.ReasonPhrase;
                }
            }
        }
    }
}