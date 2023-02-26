using Joe.Opayo.Admin.Api.Client.Models;
using Joe.Opayo.Admin.Api.Client.Models.Enums;
using Joe.Opayo.Admin.Api.Client.Models.Responses;

namespace Joe.Opayo.Admin.Api.Client.Test.Console
{
    internal class Program
    {
        public static void Main(string[]? args)
        {
            if (args == null || args.Length < 5)
            {
                WriteUsage();
                return;
            }

            try
            {
                var transactionResult = GetTransactionDetail(bool.Parse(args[0]),
                    args[1],
                    args[2],
                    args[3],
                    args[4]);

                System.Console.WriteLine($"Result: {transactionResult}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Exception: {ex.Message}.");
            }
        }

        private static void WriteUsage()
        {
            System.Console.WriteLine($"Console App to return Transaction Details. Usage: run with 5 parameters: {Environment.NewLine}" +
                                     $"1) true/false, if true then use the test environment {Environment.NewLine}" +
                                     $"2) API username {Environment.NewLine}" +
                                     $"3) API user-password {Environment.NewLine}" +
                                     $"4) vendor-name {Environment.NewLine}" +
                                     "5) command-specific xml. E.g. <vendortxcode>1234567890</vendortxcode>");
        }

        private static TransactionDetail GetTransactionDetail(bool test,
            string user,
            string password,
            string vendor,
            string ourTransactionCode)
        {
            var client = new OpayoAdminApiClient(test);
            return client.ProcessApiCommandAsync<TransactionDetail>(new OpayoApiRequest(ApiCommandType.GetTransactionDetail, password, user, vendor),
                ourTransactionCode).Result;
        }
    }
}