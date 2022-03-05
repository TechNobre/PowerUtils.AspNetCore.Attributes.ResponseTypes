﻿using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PowerUtils.AspNetCore.Attributes.ResponseTypes
{
    public class Response407ProxyAuthenticationRequiredAttribute : ProducesResponseTypeAttribute
    {
        public Response407ProxyAuthenticationRequiredAttribute(Type type) : base(type, StatusCodes.Status407ProxyAuthenticationRequired) { }
    }
}
