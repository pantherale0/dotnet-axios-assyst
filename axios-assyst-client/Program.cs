// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Define the serializer settings
Newtonsoft.Json.JsonSerializerSettings settings = new Newtonsoft.Json.JsonSerializerSettings() { NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore};

// Test an inherited action
Axios_Assyst.Actions.close close = new Axios_Assyst.Actions.close(0, "Test", 1000, 1, 1, false);
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(close));
Console.WriteLine();

// Test customFields
Axios_Assyst.Events.@event eventData = new Axios_Assyst.Events.@event();
eventData.customFields = new Axios_Assyst.Models._customFields() { customFieldShortCode = "TESTING", stringValue = "TEST" };
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(eventData, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();

// Test a movement
Axios_Assyst.Movements.movement movement = new Axios_Assyst.Movements.movement(32144, @"Testing\""", 13, 10);
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(movement, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();

// Test new userItem assignment
Axios_Assyst.userItems.userItem userItem = new Axios_Assyst.userItems.userItem(12, 1, 32888, 4, "Testing");
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(userItem, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();

// Test creation of a new event
eventData = new Axios_Assyst.Events.@event();
eventData.eventType = Axios_Assyst.Enums.eventTypeEnum.CHANGE;
eventData.subEventType = Axios_Assyst.Enums.subEventTypeEnum.SERVICEREQUEST;
eventData.remarks = "The computer name blah blah blah";
eventData.affectedUserId = 53942;
eventData.itemAId = 10301;
eventData.category = new Axios_Assyst.Models._category("shortCode", "MAINTENANCE");
eventData.shortDescription = "This would be the title";
eventData.seriousnessId = 16;
eventData.priority = new Axios_Assyst.Models._priority("shortCode", "LOW");
eventData.assignedServDeptId = 1;
Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(eventData, Newtonsoft.Json.Formatting.None, settings));
Console.WriteLine();