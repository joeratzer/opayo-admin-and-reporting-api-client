# Opayo Admin and Reporting API Client

Opayo have an Admin and Reporting API, this project is a client application to access the API endpoints.

Opayo's own documentation:
https://developer-eu.elavon.com/docs/opayo-reporting-api

Usage:

```
var client = new OpayoAdminApiClient();
var request = new OpayoApiRequest(ApiCommandType.GetTransactionDetail, password, test, user, vendor);
var commandSpecificXml = "<vendortxcode>01Jan2010Transaction12345</vendortxcode>"; // e.g., see gettransactiondetail at https://developer-eu.elavon.com/docs/opayo-reporting-api/reporting-commands/gettransactiondetail?query=getTransactionDetail
return await client.ProcessApiCommandAsync<TransactionDetail>(request, commandSpecificXml);
```

The code has ```TransactionDetail``` as an example, but the other return-types will need to be in your own project.
