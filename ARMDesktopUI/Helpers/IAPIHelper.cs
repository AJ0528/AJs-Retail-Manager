﻿using ARMDesktopUI.Models;
using System.Threading.Tasks;

namespace ARMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}