using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrincipleO.InvoiceWithO;

namespace PrincipleO
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000)
        }
    }
}
