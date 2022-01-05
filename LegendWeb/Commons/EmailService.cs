using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LegendWeb.Commons
{
    public static class EmailService
    {
        public static IRestResponse SendSimpleMessage(string name, string email, string subject, string body)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                new HttpBasicAuthenticator("api",
                                            "e28d6b5f77cf6b813f91d4a129c020f9-7005f37e-bd42967f");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandbox4cc6c217dcc6422d8dffa928f56d2cf2.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", $"{email} <{name}@sandbox4cc6c217dcc6422d8dffa928f56d2cf2.mailgun.org>");
            request.AddParameter("to", "fadeniayobami@gmail.com");
            request.AddParameter("subject", subject);
            request.AddParameter("text", body);
            request.Method = Method.POST;
            return client.Execute(request);
        }
    }
}
