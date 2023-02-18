
# A simple console App to test the API client with the GetTransactionDetail endpoint 
https://developer-eu.elavon.com/docs/opayo-reporting-api/reporting-commands/gettransactiondetail?query=getTransactionDetail

Usage: run with 5 parameters
1) true/false to determining if the test Opayo environment is used
2) API username
3) API user-password
4) vendor-name
5) command-specific xml (VendorTxCode for GetTransactionDetail)

Example: Joe.Opayo.Admin.Api.Client.Test.Console "true" "test-user" "test-password" "test-vendor-name" "<vendortxcode>ABC-123-4567-8901-P-202302181252</vendortxcode>"
