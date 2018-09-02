# Getting Started with Azure API mananagement Importer

This utility very handy and helpful in <b>importing modifications of huge api specification files like swagger, json, wadl to existing apis</b> on Azure API management service with <b>larger timeout support</b>.
In azure portal, when you try to upload new changes to existing apis with large files then apim service throws <b>504-Bad Gateway Timeout</b>. which is not very helpful when we really require to import. Hence, this tool will comes into the picture to save our time.

### First Look - APIM Importer

Below is a screenshot of apim importer. As an authentication, It requires api management service name and primary key of management api (Just need to enable Management API from [here](https://docs.microsoft.com/en-us/rest/api/apimanagement/apimanagementrest/api-management-rest#EnableRESTAPI)) and click GO.  

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/Apimimporter.png)


### Prerequisites

```
targeting .net framework 4.6.1
```

### Supported Specification Files
```
This currently supports <b>WSDL, WADL and OpenApi swagger </b> specification files. 
```

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/specificationtypes.png)


### For more details

### Reason of 504 Bad Gateway Timeout
The main reason of getting this error because the import operation on existing apis in azure operation took more time than as expected due to huge operations list which leds to cross portal default timeout and did not complete within alloted time. Hence, portal throws this error.

### Generic error we got in Azure Portal

Lets consider a scenario, we have an enterprise api service with large number of operation in portal which requires maintainance in terms of operations

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/existingApi.png)

Now, We are going to import our specification file to existing api

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/existingApiImport.png)

but here we got below error.

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/PortalError.png)


This behavior is due to by design. So as a workaround we can trigger Http operation for apim service directly over <b>xyz.management.azure-api.net</b> (time consuming) or upgrade our Api management service sku (costly). Also, In this scenario powershell and direct calls to management.core.net will not work.    

However, <b>APIMImporter</b> utility will help in this to get rid of this import timeout issues or you can use it independently too. 

Happy Coding!
### Thank You!
