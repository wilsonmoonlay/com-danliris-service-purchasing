﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentReports
{
    public class MutationBPCentralViewModel
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string SupplierType { get; set; }
        public string UnitQtyName { get; set; }
        public double BeginQty { get; set; }
        public double ReceiptQty { get; set; }
        public double ExpenditureQty { get; set; }
        public double AdjustmentQty { get; set; }
        public double LastQty { get; set; }
        public double OpnameQty { get; set; }
        public double Diff { get; set; }
    }

    public class MutationBPCentralViewModelTemp
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public bool SupplierType { get; set; }
        public string UnitQtyName { get; set; }
        public double BeginQty { get; set; }
        public double ReceiptQty { get; set; }
        public double ExpenditureQty { get; set; }
    }
}
