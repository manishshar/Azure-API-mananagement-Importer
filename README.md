# Getting Started with Azure API mananagement Importer

This utility very handy and helpful in <b>importing modifications of huge api specification files like swagger, json, wadl to existing apis</b> on Azure API management service with <b>larger timeout support</b>.
In azure portal, when you try to upload new changes to existing apis with large files then apim service throws <b>504-Bad Gateway Timeout</b>. which is not very helpful when we really require to import. Hence, this tool will comes into the picture to save our time.

### Prerequisites

```
targeting .net framework 4.6.1
```

### First Look - APIM Importer

Below is a screenshot of apim importer. As an authentication, It requires api management service name and primary key of management api (Just need to enable Management API from [here](https://docs.microsoft.com/en-us/rest/api/apimanagement/apimanagementrest/api-management-rest#EnableRESTAPI)) and click GO.  

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/Apimimporter.png)


### Supported Specification Files
```
This currently supports <b>WSDL, WADL and OpenApi swagger </b> specification files. 
```

![Screenshot](https://github.com/manishkiet86/Azure-API-mananagement-Importer/blob/master/images/specificationtypes.png)



### Thank You!
