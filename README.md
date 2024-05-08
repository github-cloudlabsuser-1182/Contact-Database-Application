ARM Template Documentation
This Azure Resource Manager (ARM) template deploys a Web App to Azure App Service. The template includes two main resources: a Web App and an App Service Plan.
Resources
App Service Plan
The App Service Plan is a container for hosting Web Apps. Here are the details for the App Service Plan in this template:
•	Type: Microsoft.Web/serverfarms
•	API Version: 2021-02-01
•	Name: contact-database-app-plan
•	Location: The location is dynamically set to the location of the resource group.
•	SKU: The SKU defines the tier, size, family, and capacity of the App Service Plan. In this template, the SKU is set to the Free tier (F1), with a capacity of 1.
•	Properties: The name of the App Service Plan is set in the properties.
Web App
The Web App is the application that will be hosted in the App Service Plan. Here are the details for the Web App in this template:
•	Type: Microsoft.Web/sites
•	API Version: 2021-02-01
•	Name: contact-database-app-github-cloudlabsuser-1182
•	Location: The location is dynamically set to the location of the resource group.
•	Properties: The serverFarmId property is set to the resource ID of the App Service Plan. This associates the Web App with the App Service Plan.
•	Depends On: This property is set to the name of the App Service Plan. This means that the App Service Plan must be created before the Web App.
Deployment
To deploy this ARM template, you can use Azure CLI, PowerShell, or the Azure portal. Please note that the actual deployment may require additional parameters or settings based on your Azure environment and the specifics of your application.
