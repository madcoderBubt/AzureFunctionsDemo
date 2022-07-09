using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace AzureFunctionsDemo
{
    public static class GitMonitorApp
    {
        [FunctionName("GitMonitorApp")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Git Monitor App");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject<Rootobject>(requestBody);

            log.LogInformation(requestBody);

            return new OkResult();
        }
    }

    public class Rootobject
    {
        public Authorization authorization { get; set; }
        public string caller { get; set; }
        public string channels { get; set; }
        public Claims claims { get; set; }
        public string correlationId { get; set; }
        public string description { get; set; }
        public string eventDataId { get; set; }
        public Eventname eventName { get; set; }
        public Category category { get; set; }
        public DateTime eventTimestamp { get; set; }
        public string id { get; set; }
        public string level { get; set; }
        public string operationId { get; set; }
        public Operationname operationName { get; set; }
        public string resourceGroupName { get; set; }
        public Resourceprovidername resourceProviderName { get; set; }
        public Resourcetype resourceType { get; set; }
        public string resourceId { get; set; }
        public Status status { get; set; }
        public Substatus subStatus { get; set; }
        public DateTime submissionTimestamp { get; set; }
        public string subscriptionId { get; set; }
        public string tenantId { get; set; }
        public Properties properties { get; set; }
        public object[] relatedEvents { get; set; }
    }

    public class Authorization
    {
        public string action { get; set; }
        public string scope { get; set; }
    }

    public class Claims
    {
        public string aud { get; set; }
        public string iss { get; set; }
        public string iat { get; set; }
        public string nbf { get; set; }
        public string exp { get; set; }
        public string httpschemasmicrosoftcomclaimsauthnclassreference { get; set; }
        public string aio { get; set; }
        public string altsecid { get; set; }
        public string httpschemasmicrosoftcomclaimsauthnmethodsreferences { get; set; }
        public string appid { get; set; }
        public string appidacr { get; set; }
        public string httpschemasxmlsoaporgws200505identityclaimsemailaddress { get; set; }
        public string httpschemasxmlsoaporgws200505identityclaimssurname { get; set; }
        public string httpschemasxmlsoaporgws200505identityclaimsgivenname { get; set; }
        public string groups { get; set; }
        public string httpschemasmicrosoftcomidentityclaimsidentityprovider { get; set; }
        public string ipaddr { get; set; }
        public string name { get; set; }
        public string httpschemasmicrosoftcomidentityclaimsobjectidentifier { get; set; }
        public string puid { get; set; }
        public string rh { get; set; }
        public string httpschemasmicrosoftcomidentityclaimsscope { get; set; }
        public string httpschemasxmlsoaporgws200505identityclaimsnameidentifier { get; set; }
        public string httpschemasmicrosoftcomidentityclaimstenantid { get; set; }
        public string httpschemasxmlsoaporgws200505identityclaimsname { get; set; }
        public string uti { get; set; }
        public string ver { get; set; }
        public string wids { get; set; }
        public string xms_tcdt { get; set; }
    }

    public class Eventname
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Category
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Operationname
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Resourceprovidername
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Resourcetype
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Status
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Substatus
    {
        public string value { get; set; }
        public string localizedValue { get; set; }
    }

    public class Properties
    {
        public string statusCode { get; set; }
        public object serviceRequestId { get; set; }
        public string eventCategory { get; set; }
        public string entity { get; set; }
        public string message { get; set; }
        public string hierarchy { get; set; }
    }

}
