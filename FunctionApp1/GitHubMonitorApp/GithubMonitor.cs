using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace GitHubMonitorApp
{
    public static class GithubMonitor
    {
        [FunctionName("GithubMonitor")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Our GithubMonitor processed an action.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();

            Rootobject data = JsonConvert.DeserializeObject<Rootobject>(requestBody);
            log.LogInformation(data.Sender.Login);
            log.LogInformation(data.Sender.Avatar_url);

            return new OkResult();
        }
    }
}
