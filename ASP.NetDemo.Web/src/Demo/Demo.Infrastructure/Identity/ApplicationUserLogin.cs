﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Identity
{
    public class ApplicationUserLogin
        : IdentityUserLogin<Guid>
    {
    }
}
