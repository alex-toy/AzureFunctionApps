using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp2
{
    public class ProcessMyBlob
    {
        [FunctionName("ProcessMyBlob")]
        public void Run(
            [BlobTrigger("demo/{name}", Connection = "AzureWebJobsStorage")] Stream inputBlob,
            [Blob("output/{name}", FileAccess.Write, Connection = "AzureWebJobsStorage")] Stream outputBlob,
            string name, 
            ILogger log)
        {
            long len = inputBlob.Length;
            inputBlob.CopyTo(outputBlob);
        }
    }
}
