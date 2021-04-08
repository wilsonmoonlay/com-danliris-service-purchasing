using Com.DanLiris.Service.Purchasing.Lib.Models.GarmentInvoiceModel;
using System;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentInternNoteViewModel
{
    public class InternalNoteInvoiceDto
    {
        public InternalNoteInvoiceDto(string invoiceNo, DateTimeOffset invoiceDate, string productNames, int categoryId, string categoryName, string paymentMethod, int invoiceId, string deliveryOrdersNo, string billsNo, string paymentBills, double amount, bool useVAT, bool isPayVAT, bool useIncomeTax, bool isPayTax, double incomeTaxRate)
        {
            Invoice = new InvoiceDto(invoiceNo, invoiceDate, productNames, categoryId, categoryName, paymentMethod, invoiceId, deliveryOrdersNo, billsNo, paymentBills, amount, useVAT, isPayVAT, useIncomeTax, isPayTax, incomeTaxRate);
        }

        public InvoiceDto Invoice { get; set; }
    }
}