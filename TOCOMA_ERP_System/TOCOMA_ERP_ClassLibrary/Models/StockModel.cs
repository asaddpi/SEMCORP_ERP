using System;
using System.Collections.Generic;
using System.Text;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class StockModel : Stock_Details_Model
    {
#pragma warning disable CS0108 // 'StockModel.STOCK_ID' hides inherited member 'Stock_Details_Model.STOCK_ID'. Use the new keyword if hiding was intended.
        public string STOCK_ID { get; set; }
#pragma warning restore CS0108 // 'StockModel.STOCK_ID' hides inherited member 'Stock_Details_Model.STOCK_ID'. Use the new keyword if hiding was intended.
        public string PO_NO { get; set; }
        public string TRANSECTION_DATE { get; set; }
        public string DESCRIPTION { get; set; }
        public int CUSTOMER_SUPPLIER_ID { get; set; }
        public string CUSTOMER_SUPPLIER { get; set; }
#pragma warning disable CS0108 // 'StockModel.STOCK_IN_QUANTITY' hides inherited member 'Stock_Details_Model.STOCK_IN_QUANTITY'. Use the new keyword if hiding was intended.
        public string STOCK_IN_QUANTITY { get; set; }
#pragma warning restore CS0108 // 'StockModel.STOCK_IN_QUANTITY' hides inherited member 'Stock_Details_Model.STOCK_IN_QUANTITY'. Use the new keyword if hiding was intended.
        public string DOCUMENTS_NO { get; set; }
        public DateTime DOCUMENT_DATE { get; set; }
        public string GATE_PASS_NO { get; set; }
        public string INVOICE_NO { get; set; }
        public DateTime INVOICE_DATE { get; set; }
        public string DELIVERY_NOTE_NO { get; set; }
#pragma warning disable CS0108 // 'StockModel.STOCK_OUT_QUANTITY' hides inherited member 'Stock_Details_Model.STOCK_OUT_QUANTITY'. Use the new keyword if hiding was intended.
        public string STOCK_OUT_QUANTITY { get; set; }
#pragma warning restore CS0108 // 'StockModel.STOCK_OUT_QUANTITY' hides inherited member 'Stock_Details_Model.STOCK_OUT_QUANTITY'. Use the new keyword if hiding was intended.
#pragma warning disable CS0108 // 'StockModel.WAREHOUSE_ID' hides inherited member 'Stock_Details_Model.WAREHOUSE_ID'. Use the new keyword if hiding was intended.
        public int WAREHOUSE_ID { get; set; }
#pragma warning restore CS0108 // 'StockModel.WAREHOUSE_ID' hides inherited member 'Stock_Details_Model.WAREHOUSE_ID'. Use the new keyword if hiding was intended.
#pragma warning disable CS0108 // 'StockModel.REMARKS' hides inherited member 'Stock_Details_Model.REMARKS'. Use the new keyword if hiding was intended.
        public string REMARKS { get; set; }
#pragma warning restore CS0108 // 'StockModel.REMARKS' hides inherited member 'Stock_Details_Model.REMARKS'. Use the new keyword if hiding was intended.
        public string RECEIVE_BY { get; set; }
        public string BATCH_NO { get; set; }
        public string EXPIRY_DATE { get; set; }
        public string GOOD_RECEIVE_NOTE { get; set; }
        
    }
}
