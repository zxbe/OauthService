﻿using JiYun.AuthorizationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiYun.AuthorizationService.Repositories.IOC
{
    public interface ITokenInfoRepository
    {
        Task<bool> Add(TokenInfo tokenInfo);
        Task<bool> Modify(string ID, string refreshToken);
    }
}
