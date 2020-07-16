using System;
using System.Transactions;

namespace AmbientTXSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
                Transaction.Current.TransactionCompleted += (sender, e) =>
                {
                    ShowTx("completed", e.Transaction.TransactionInformation);
                };

                ShowTx("in tx", Transaction.Current.TransactionInformation);

             //   scope.Complete();
            }  // commit - rollback

            
        }

        static void ShowTx(string status, TransactionInformation info)
        {
            Console.WriteLine(status);
            Console.WriteLine(info.Status);
            Console.WriteLine(info.LocalIdentifier);
            Console.WriteLine(info.DistributedIdentifier);

        }
    }
}
