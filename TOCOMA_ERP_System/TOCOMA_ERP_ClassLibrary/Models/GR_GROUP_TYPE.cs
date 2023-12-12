using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public enum GR_GROUP_TYPE
    {
        grBANKACCOUNTS = 100,
        grCash = 101,

        grCUSTOMER = 202,
        grSUPPLIER = 203,
        grSALES_REP = 204,
        grOTHER_LEDGER = 205,
        grFIXED_ASSET = 206,//    'Fixed Asset

        grDIRECT_EXPENSES = 213,//    'Trading
        grCOMPLEMENTARY_GOODS = 214,//    'Trading
        grOTHER_INCOME = 215,//    'Trading
        grFINISHED_PURCHASE = 216,//
        grPROFIT_AND_LOOS = 301,//
        grBRANCH_ACCOUNT = 217,//    'Previous 501 - Changed to 217
        grCONSIGNEE_ACOUNT = 502,//

        grPaymentMediaType=1 // Bank and Cash in Ledger

    }
}
