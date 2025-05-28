# API.NET.AWS.Lambda
Api built in .NET using AWS Lambda

## Summary
[Install Lambda Tools](#install-lambda-tools)  
[Deploy](#deploy)  
[Create Function URL](#create-function-url)  
[Environment Variables](#environment-variables)  
[URL](#URL)
[Nuget Packages](#nuget-packages)  
[References](#references)


## Install Lambda Tools
```
dotnet tool install -g Amazon.Lambda.Tools
```

## Deploy
```
dotnet lambda deploy-function
```

### After choose dotnet8 fr runtine and later set name Function Name

![image](https://github.com/user-attachments/assets/ceba3f3e-33cb-46b6-80eb-70d3236654b8)

### Set Policy

![image](https://github.com/user-attachments/assets/a1c6e844-636e-4a01-81ee-5d79750829cb)

### Additional Information

![image](https://github.com/user-attachments/assets/dea8ae4d-96bb-4ce4-b08b-cb6c1078f9d1)

PS: With regard to this information, it is extremely important to pay attention to the handler. In traditional lambda functions, the handler is responsible for indicating the path to the application's input method. This does not apply in this approach to configuring web APIs as lambda functions. Instead, you only need to enter the name of the web API assembly.

For example: if the namespace of the web API controllers was Teste.API.Controllers, the handler would just be Teste.API.

### Console AWS
![image](https://github.com/user-attachments/assets/6b052d15-7441-4f08-a024-51b1e87497dc)


## Create Function URL

![image](https://github.com/user-attachments/assets/10cdf7af-ad4b-4b9c-a385-8f38d7eaa81c)


![image](https://github.com/user-attachments/assets/0df81d55-e18e-4cb3-9913-61249ae76810)

![image](https://github.com/user-attachments/assets/ad29f188-f6ed-49c3-99d1-bd1055eea8e3)

![image](https://github.com/user-attachments/assets/4d166f13-78ee-480f-b822-dfd89a7c8de4)


## Environment Variables

![image](https://github.com/user-attachments/assets/2f253c42-57b2-4ab4-a509-accedd39ae9d)

![image](https://github.com/user-attachments/assets/778ae6e9-fea3-4207-a292-146d7f594a06)

**Now we can see swagger**

![image](https://github.com/user-attachments/assets/7a328f81-ad73-4b68-af4e-f35a85b65047)


## URL
https://yie6sihsfqiaxesd2sqhazgxtq0ayzzc.lambda-url.us-east-1.on.aws/swagger/index.html

## Nuget Packages
https://www.nuget.org/packages/Amazon.Lambda.AspNetCoreServer.Hosting

## References
https://codewithmukesh.com/blog/hosting-aspnet-core-web-api-with-aws-lambda/
https://www.linkedin.com/pulse/guia-r%C3%A1pido-configura%C3%A7%C3%A3o-e-deploy-de-web-apis-net-6-como-de-oliveira/
