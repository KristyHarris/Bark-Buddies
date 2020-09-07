﻿using BarkBuddies.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarkBuddies.Services
{
   public interface IAnimalsService
    {
        Task<ApiResponse> Get();
        Task<IActionResult> Create(Animal animal);

    }
}
