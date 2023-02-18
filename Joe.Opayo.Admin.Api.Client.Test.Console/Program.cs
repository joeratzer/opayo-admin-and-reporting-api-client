using Joe.Opayo.Admin.Api.Client.Model;
using Joe.Opayo.Admin.Api.Client.Model.Enums;
using Joe.Opayo.Admin.Api.Client.Model.Responses;

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
                var result = GetTransactionDetail(bool.Parse(args[0]),
                    args[1],
                    args[2],
                    args[3],
                    args[4]);

                System.Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Exception: {ex.Message}.");
            }
        }

        private static void WriteUsage()
        {
            System.Console.WriteLine("Console App to return Transaction Details. " +
                                     "Usage: run with 5 parameters - " +
                                     "1) true/false for test environment, " +
                                     "2) API username, " +
                                     "3) API user-password, " +
                                     "4) vendor-name, " +
                                     "5) command-specific xml. E.g. <vendortxcode>1234567890</vendortxcode>");
        }

        private static TransactionDetail GetTransactionDetail(bool test,
            string user,
            string password,
            string vendor,
            string ourTransactionCode)
        {
            var client = new OpayoAdminApiClient();
            return client.ProcessApiCommandAsync<TransactionDetail>(new OpayoApiRequest(ApiCommandType.GetTransactionDetail, password, test, user, vendor),
                ourTransactionCode).Result;
        }
    }
}