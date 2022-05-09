using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace axios_assyst_client.Axios.Assyst
{
    public class HttpHandler
    {
        RestClient internalClient = null;
        string _username;
        string _password;
        string _url;

        public string username { get { return _username; } }
        public string password { get { return _password; } }
        public string url { get { return _url; } }
        public RestClient assystClient { get { return internalClient; } }

        public HttpHandler(string username, string password, string url)
        {
            internalClient = new RestClient(url);
            internalClient.AcceptedContentTypes = new[] { "application/json" };
            internalClient.Authenticator = new RestSharp.Authenticators.HttpBasicAuthenticator(username, password);
            _username = username;
            _password = password;
            _url = url;
        }

        public Task<RestSharp.RestResponse<T>> Execute<T>(RestRequest req)
        {
            return assystClient.ExecuteAsync<T>(req);
        }

        public Task<RestSharp.RestResponse> Execute(RestRequest req)
        {
            return assystClient.ExecuteAsync(req);
        }
    }
}
