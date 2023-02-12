# Azure Function Apps

Serverless is powerful and flexible way of delivering fast and scalable solutions in Azure.

## Intro to Azure Functions - What they are and how to create and deploy them

### Create Anonymous Http Trigger

<img src="/pictures/http.png" title="http trigger"  width="500">

- Run it locally :
<img src="/pictures/http2.png" title="http trigger run locally"  width="800">

- Create a new **Function App** in **VS Code** :
<img src="/pictures/new_fa.png" title="new function app"  width="400">
<img src="/pictures/new_fa2.png" title="new function app"  width="800">


### Create Webhook

- Add a **Webhook** in **Github** :
<img src="/pictures/webhook.png" title="webhook"  width="800">

- Now do a push on that repo :
<img src="/pictures/webhook2.png" title="webhook"  width="800">
<img src="/pictures/webhook3.png" title="webhook"  width="800">

- See the result on the logs :
<img src="/pictures/webhook4.png" title="webhook"  width="800">
<img src="/pictures/webhook5.png" title="webhook"  width="800">





## Introduction for serverless programming

### Create Function App in the portal

<img src="/pictures/function_app.png" title="function app"  width="500">
<img src="/pictures/function_app2.png" title="function app"  width="500">
<img src="/pictures/function_app3.png" title="function app"  width="800">

### Create Function App in Visual Studio HTTP Trigger

<img src="/pictures/function_app_vs.png" title="function app"  width="600">
<img src="/pictures/function_app_vs2.png" title="function app"  width="600">
<img src="/pictures/function_app_vs3.png" title="function app"  width="600">
<img src="/pictures/function_app_vs4.png" title="function app"  width="600">
<img src="/pictures/function_app_vs5.png" title="function app"  width="800">

### Create Function App in Visual Studio Blob Trigger

<img src="/pictures/function_app_blob.png" title="function app"  width="400">

- Now upload a file to the demo container :
<img src="/pictures/upload.png" title="upload a file to the demo container"  width="800">

- And you should see it immediately in the output container :
<img src="/pictures/output.png" title="file appearing the output container"  width="800">



## Azure App Configuration

### Create App Configuration

- Create App Configuration
<img src="/pictures/app_conf.png" title="app configuration"  width="500">

- Create **Key Value**
<img src="/pictures/key_value.png" title="key value"  width="800">

- Create **Feature**
<img src="/pictures/feature.png" title="feature"  width="800">

- Create Console App
```
Microsoft.Extensions.Configuration.AzureAppConfiguration
```
<img src="/pictures/console_app.png" title="console app"  width="800">

- Create **MVC Application**

Observe the app is configured according to setting in App config :
<img src="/pictures/mvc_app.png" title="MVC app"  width="800">

- Create **Event Grid** with **Logic App**
<img src="/pictures/logic_app.png" title="logic app"  width="800">

- After modifying paramenters in the **App Configuration**, observe event in the **Logic App** :
<img src="/pictures/logic_app_event.png" title="logic app event"  width="800">
<img src="/pictures/logic_app_event2.png" title="logic app event"  width="800">



## Azure App Service Deployment Center
https://www.youtube.com/watch?v=iItt8bQtVHE


