using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ItemEntity
    {
        public int ITEM_ID { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string SHORT_DESCRIPTION { get; set; }
        public string LONG_DESCRIPTION { get; set; }
        public int CATEGORY_ID { get; set; }
        public int SUBCATEGORY_ID { get; set; }
        public int BRAND_ID { get; set; }
        public string BRAND_NAME { get; set; }
        public string ITEM_TYPE { get; set; }
        public string MODEL { get; set; }
        public int RELATED_ITEM_ID { get; set; }
        public string ITEM_IMAGE { get; set; }
        public string APPLICATION_IMAGE { get; set; }
        public string APPLICATION_VIDEO_1 { get; set; }

        public string ITEM_FORM_APPEARANCE { get; set; }
        public int VENDOR_ID { get; set; }
        public int UNIT_ID { get; set; }
        public string UNIT_NAME { get; set; }
        public string SHELF_LIFE { get; set; }
        public string ITEM_BATCH_NO { get; set; }
        public string COVERAGE_CONSUMPTION { get; set; }
        public string DOSAGE { get; set; }
        public string MAID_IN_COUNTRY { get; set; }
        public string IMPORT_FROM { get; set; }
        public string BRAND_ORIGIN_COUNTRY { get; set; }
        public string ITEM_KEYWORD { get; set; }
        public int APPLICATION_AREA_ID { get; set; }
        public string APPLICATION_AREA { get; set; }
        public string RELATED_ITEMS { get; set; }
        public string FEATURES_AND_BENEFITS { get; set; }
        public string SEWSTIVENESS { get; set; }
        public string TYPE_OF_INVENTORY { get; set; }
        public string ITEM_SPECIALTY { get; set; }
        public string PACK_TYPE { get; set; }
        public string ITEM_COLOR { get; set; }
        public decimal ITEM_PRICE { get; set; }
        public int COLOR_ID { get; set; }
        public string PACK_SIZE { get; set; }
        public string UOM { get; set; }
        public double ITEM_PURCHASE_PRICE { get; set; }
        public double ITEM_SALE_PRICE { get; set; }
        public decimal STOCKITEM_OPENING_BALANCE { get; set; }
        public decimal STOCKITEM_OPENING_RATE { get; set; }
        public decimal STOCKITEM_OPENING_VALUE { get; set; }
        public int BUSINESS_ID { get; set; }
        public bool Status { get; set; }
        public string msg { get; set; }
        public int OperationType { get; set; }

        public List<ItemEntity> relateditemList { get; set; }
    }
}
