using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulFire.Middleware
{

    public class AuthMiddleware
    {
        private readonly RequestDelegate _next;
        
        public AuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string authHeader = httpContext.Request.Headers["Authorization"];
            if (authHeader != null)
            {
                //string auth = authHeader.Split(new char[] { ' ' })[1];
                //Encoding encoding = Encoding.GetEncoding("UTF-8");
                //var usernameAndPassword = encoding.GetString(Convert.FromBase64String(auth));
                //string username = usernameAndPassword.Split(new char[] { ':' })[0];
                //string password = usernameAndPassword.Split(new char[] { ':' })[1];


                var token = authHeader;
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(token);
                var username = jsonToken.Claims.ToList();
                if (token== "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2MzgxNjkxNTcsImlzcyI6Imh0dHBzOi8vMTkyLjE2OC4zMS4xMzoxNjI2MyIsImF1ZCI6Imh0dHBzOi8vMTkyLjE2OC4zMS4xMzoxNjI2MyJ9.m6LBP4CGThuY69VKvqJY0Be9aeGUWQkdqDGqMPd6PZo")
                {
                    await _next(httpContext);
                }
                else
                {
                    httpContext.Response.StatusCode = 401;
                    return;
                }
            }
            else
            {
                httpContext.Response.StatusCode = 401;
                return;
            }
        }
    }
}
