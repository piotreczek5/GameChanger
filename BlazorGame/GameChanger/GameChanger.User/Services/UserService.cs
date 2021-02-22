using GameChanger.GameUser.EntityFramework.Domain;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GameChanger.GameUser.Services
{
    public class UserService : IUserService
    {
        private HttpClient _httpClient { get; }

        public UserService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri(@"http://localhost:50528");
            httpClient.DefaultRequestHeaders.Add("User-Agent", "BlazorServer");
            _httpClient = httpClient;
        }

        public async Task<GameChangerUser> LoginAsync(GameChangerUser user)
        {
            user.PasswordHash = user.PasswordHash;
            string serializedUser = JsonConvert.SerializeObject(user);

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "api/Users/Login");
            requestMessage.Content = new StringContent(serializedUser);

            requestMessage.Content.Headers.ContentType
                = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = await _httpClient.SendAsync(requestMessage);

            var responseStatusCode = response.StatusCode;
            var responseBody = await response.Content.ReadAsStringAsync();

            var returnedUser = JsonConvert.DeserializeObject<GameChangerUser>(responseBody);

            return await Task.FromResult(returnedUser);
        }

        private static string Encrypt(string password)
        {
            var provider = MD5.Create();
            string salt = "dawdawgawf2123asd@123";
            byte[] bytes = provider.ComputeHash(Encoding.UTF32.GetBytes(salt + password));
            return BitConverter.ToString(bytes).Replace("-", "").ToLower();
        }
    }
}
