﻿using EazyTips.Repository;
using EazyTips.RestClient;
using System.Threading.Tasks;

namespace EazyTips.Client
{
    public class LoginService
    {
        RestClient<User> restClient = new RestClient<User>();

        public async Task<int> CheckLoginIfExists(string Phone, string Password)
        {
            int id = await restClient.checkLogin(Phone, Password);
            return id;
        }
    }
}
