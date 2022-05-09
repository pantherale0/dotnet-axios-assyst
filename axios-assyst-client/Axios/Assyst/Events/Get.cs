using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace axios_assyst_client.Axios.Assyst.Events
{

    /// <summary>
    /// Returns events from the Assyst API
    /// </summary>
    public class Get : HttpHandler
    { 
        public Get(HttpHandler handler) : base(handler.username, handler.password, handler.url) { }

        public Axios_Assyst.Models.Endpoints._event? GetEvent(int eventId, IEnumerable<Parameter>? optionalFields = null)
        {
            RestRequest request = new RestRequest("events/" + eventId, Method.Get);
            if (optionalFields != null) { request.AddOrUpdateParameters(optionalFields); }
            
            var response = base.Execute<Axios_Assyst.Models.Endpoints._event>(request);

            return response.Result.Data;
        }
    }
}
