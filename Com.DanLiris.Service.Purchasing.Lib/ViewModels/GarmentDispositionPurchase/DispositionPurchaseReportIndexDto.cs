﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentDispositionPurchase
{
    public class DispositionPurchaseReportIndexDto
    {
        public DispositionPurchaseReportIndexDto(List<DispositionPurchaseReportTableDto> data, int page, int total)
        {
            Data = data;
            Page = page;
            Total = total;
        }

        public List<DispositionPurchaseReportTableDto> Data { get; set; }
        public int Page { get; set; }
        public int Total { get; set; }
    }
}
