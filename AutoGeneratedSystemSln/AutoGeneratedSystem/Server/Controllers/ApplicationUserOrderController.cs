﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoGeneratedSystem.Common.CustomAttributes;
using AutoGeneratedSystem.Common;

namespace AutoGeneratedSystem.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerOfEntity(entityName:Constants.EntityNames.ApplicationUserOrder,
        primaryKeyType:typeof(long))]
    public partial class ApplicationUserOrderController : ControllerBase
    {
    }
}
