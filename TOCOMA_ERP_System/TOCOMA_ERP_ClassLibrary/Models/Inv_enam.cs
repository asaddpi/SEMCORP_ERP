using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public enum Inv_enam
    {
           vtRECEIPT_VOUCHER = 1,
            vtPAYMENT_VOUCHER = 2,
            vtJOURNAL_VOUCHER = 3,
            vtCONTRA_VOUCHER = 4,
            vtCREDIT_NOTE = 5,
            vtDEBIT_NOTE = 6,
            vtDELIVERY_NOTE = 7,
            vtINVESTMENT = 8,

            //'vtPURCHASE_VOUCHER = 8
            vtSALES = 9,
            vtSALES_VOUCHER = 11,
            vtSALES_ORDER = 12,
            vtSALES_RETURN = 13,
            vtDELIVERY_ORDER = 14,
            vtSALES_CHALLAN = 15,
            vtSALES_INVOICE = 16,
            vtSALES_QUOTATION = 19,
            vtSALES_INVOICE_POS = 18,

            vtSTOCK_OPENING = 0,
            vtSTOCK_INWARD = 21,
            vtSTOCK_OUTWARD = 22,
            vtSTOCK_TRANSFER = 23,
            vtSTOCK_DAMAGE = 24,
            vtSTOCK_PHYSICAL = 25,
            vtSTOCK_MFG_CONSUMPTION = 26,
            vtSTOCK_MFG_FINISHED_GOODS = 27,
            vtSTOCK_MFG_VOUCHER = 29,
            vtSTOCK_MFG_PRODUCTION = 51,
            vtSTOCK_RETURN = 28,

            vtPURCHASE = 30,
            vtPURCHASE_ORDER = 31,
            vtPURCHASE_RETURN = 32,
            vtPURCHASE_INVOICE = 33,
            vtPURCHASE_RECEIVE = 34,
            vtSTOCK_REQUISITION = 40,

            vtHW_PRODUCT_RECEIVED = 41,
            vtHW_PRODUCT_REPLACEMENT = 42,
            vtHW_RETURN_SUPPLIER = 43,
            vtHW_RECEIVE_SUPPLIER = 44,
            vt_POS_MODULE = 10,
            vt_STOCK_ABSOVED = 66,
            vt_SALESSAMPLE = 17,
            vt_SAMPLE_CLASS = 50,
            
    }
}
