# Opayo Admin and Reporting API Client

Opayo have an Admin and Reporting API, this project is a client-application to access the API endpoints.

Usage:

```
var client = new OpayoAdminApiClient();
var request = new OpayoApiRequest(ApiCommandType.GetTransactionDetail, password, test, user, vendor);
var commandSpecificXml = "<vendortxcode>01Jan2010Transaction12345</vendortxcode>"; // see gettransactiondetail on the Opayo API
return await client.ProcessApiCommandAsync<TransactionDetail>(request, commandSpecificXml);
```

Opayo's documentation on their API:
https://developer-eu.elavon.com/docs/opayo-reporting-api
Similar documentation when it was owned by SagePay:
https://www.opayo.co.uk/file/1186/download-document/reportingandapiprotocol102v0.5.pdf

e.g.:
see gettransactiondetail at https://developer-eu.elavon.com/docs/opayo-reporting-api/reporting-commands/gettransactiondetail?query=getTransactionDetail