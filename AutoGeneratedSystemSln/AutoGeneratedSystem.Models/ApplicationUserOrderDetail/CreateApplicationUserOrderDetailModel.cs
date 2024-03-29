﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AutoGeneratedSystem.Common.CustomAttributes;
using AutoGeneratedSystem.Common;

namespace AutoGeneratedSystem.Models.ApplicationUserOrderDetail
{
    public class CreateApplicationUserOrderDetailModel
    {
        [Required]
        [JunctionTable(entityName:Constants.EntityNames.ApplicationUserOrder,
            displayTextFieldName:nameof(Models.ApplicationUserOrder.ApplicationUserOrderModel.ApplicationUserOrderId),
            valueFieldName: nameof(Models.ApplicationUserOrder.ApplicationUserOrderModel.ApplicationUserOrderId))]
        public long? ApplicationUserOrderId { get; set; }
        [Required]
        [JunctionTable(entityName:Constants.EntityNames.Product,
            displayTextFieldName:nameof(Models.Product.ProductModel.Name),
            valueFieldName: nameof(Models.Product.ProductModel.ProductId))]
        public long? ProductId { get; set; }
        [Required]
        public int? Quantity { get; set; }
        [Required]
        public decimal? LineTotal { get; set; }
    }
}
