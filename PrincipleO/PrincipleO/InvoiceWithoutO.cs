using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipleO
{
    /// <summary>
    /// Example without using the Open-Closed Principle
    /// </summary>
    public class InvoiceWithoutO
    {
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;
            if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            else if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            return finalAmount;
        }
    }
    public enum InvoiceType
    {
        FinalInvoice,
        ProposedInvoice
    };
}
