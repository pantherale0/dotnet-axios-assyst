// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

// Define the serializer settings
Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings() { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore};

// Test an inherited action
Axios_Assyst.Actions.close close = new Axios_Assyst.Actions.close(0, "Test", 1000, 1, 1, false);
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(close));
Console.WriteLine();

// Test customFields
Axios_Assyst.Models.Endpoints._event eventData = new Axios_Assyst.Models.Endpoints._event();
eventData.customFields = new Axios_Assyst.Models.Common._customFields[2];
eventData.customFields[0] = new Axios_Assyst.Models.Common._customFields { customFieldShortCode = "LOOKUP", customLookupValueShortCode = "SYSTEM" };
eventData.customFields[1] = new Axios_Assyst.Models.Common._customFields { customFieldShortCode = "NAME", stringValue = "JOHN" };
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(eventData, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();

// Test a movement
Axios_Assyst.Models.Endpoints._movement movement = new Axios_Assyst.Models.Endpoints._movement(32144, @"Testing\""", 13, 10);
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(movement, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();

// Test new userItem assignment
Axios_Assyst.userItems.userItem userItem = new Axios_Assyst.userItems.userItem(12, 1, 32888, 4, "Testing");
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(userItem, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();

// Test creation of a new event
eventData = new Axios_Assyst.Models.Endpoints._event();
eventData.eventType = Axios_Assyst.Enums.eventTypeEnum.INCIDENT;
eventData.remarks = "This would be the description";
eventData.affectedUser = new Axios_Assyst.Models.Lookups._resource { resolvingParameters = new Axios_Assyst.Models.Lookups._resolvingParameters[2] };
Console.WriteLine("Enter shortCode: ");
eventData.affectedUser.resolvingParameters[0] = new Axios_Assyst.Models.Lookups._resolvingParameters { parameterName = "shortCode", parameterValue = Console.ReadLine() };
Console.WriteLine("Enter staffNumber: ");
eventData.affectedUser.resolvingParameters[1] = new Axios_Assyst.Models.Lookups._resolvingParameters { parameterName = "staffNumber", parameterValue = Console.ReadLine() };
eventData.itemAId = 10301;
eventData.category = new Axios_Assyst.Models.Common._category("shortCode", "MAINTENANCE");
eventData.shortDescription = "This would be the title";
eventData.seriousnessId = 16;
eventData.priority = new Axios_Assyst.Models.Common._priority("shortCode", "LOW");
eventData.assignedServDeptId = 1;
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(eventData, Newtonsoft.Json.Formatting.Indented, settings));
Console.WriteLine();

// Test creation of a new sendEmail action
Axios_Assyst.Actions.emailUser sendEmail = new Axios_Assyst.Actions.emailUser(1234, "TEST EMAIL CONTENTS", 1, 1);
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(sendEmail, Newtonsoft.Json.Formatting.Indented, settings));


axios_assyst_client.Axios.Assyst.HttpHandler handler = new axios_assyst_client.Axios.Assyst.HttpHandler("test", "test", "https://example.com/assystREST/v2");
axios_assyst_client.Axios.Assyst.Events.Get get = new axios_assyst_client.Axios.Assyst.Events.Get(handler);