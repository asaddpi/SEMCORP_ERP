using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AspNetCore.Reporting;
using TOCOMA_ERP_ClassLibrary.Models;
using System.Net.Http;
using System.Net.Http.Json;
using TOCOMA_ERP_System.Data;
using System.Globalization;

namespace TOCOMA_ERP_System.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RDLCReportController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly HttpClient Http;
        //SessionData sessiondata = new SessionData();
        Dictionary<string, string> parameters = new Dictionary<string, string>();
        public RDLCReportController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public List<ACC_VOUCHER_MODEL> GetPlanAndWork(string REFNO)
        {
            List<ACC_VOUCHER_MODEL> listPlanOperation = new List<ACC_VOUCHER_MODEL>();
            //listPlanOperation = Http.GetAsync(Utility.BaseUrl + "api/Setup/GetWorkScheduleBySuperAdmin");
            var response = Http.GetAsync(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + REFNO).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                //return responseContent.ReadFromJsonAsync<ACC_VOUCHER_MODEL>.ReadAsStringAsync().GetAwaiter().GetResult();
            }
            //return await Http.GetFromJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Setup/GetWorkScheduleBySuperAdmin");
            return listPlanOperation;
        }
        [HttpGet]
        [Route("GetPaymentReport/{refNo}/{Type}")]
        public IActionResult GetPlanAndScheduleReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            //List<ACC_VOUCHER_MODEL> voucher = new List<ACC_VOUCHER_MODEL>();
            //listdata.Add(SessionData.paymentDataList);
            //listdata = await Http.GetJsonAsync<List<ACC_VOUCHER_MODEL>>(Utility.BaseUrl + "api/Transection/GetACCVoucherByRefNo/" + refNo);
            //listdata = GetPlanAndWork(refNo);
            dt = lsttodt.ToDataTable(SessionData.paymentDataList);

            string mimetype = "";
            int extention = 1;
            //strResourcePath =Server.MapPath("~") + Path;
            //var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PlanAndScheduleReport.rdlc";
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PaymentVoucher.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();


            string debit_value ="";
            if (dt.Rows.Count > 0)
            {
                double voucher_total_value;
                voucher_total_value = Convert.ToDouble(dt.Rows[0].ItemArray[8].ToString());
                Inwords = NumberToWords.ConvertAmount(voucher_total_value);
                 debit_value = String.Format("{0:#,###,###.##}", voucher_total_value);


                parameters.Add("param", dt.Rows[0].ItemArray[1].ToString());
                parameters.Add("voucher_date", dt.Rows[0].ItemArray[7].ToString());
                parameters.Add("debit_total", debit_value);
                parameters.Add("credit_total", debit_value);
                parameters.Add("amount_in_word", Inwords);
                parameters.Add("narration", dt.Rows[0].ItemArray[9].ToString());
                parameters.Add("printed_date", current_date);
                parameters.Add("printed_time", current_time);
                if (Type == 1)
                { parameters.Add("voucherType", "Payment"); }
                else if (Type == 2)
                { parameters.Add("voucherType", "Receipt"); }
                else if (Type == 3)
                { parameters.Add("voucherType", "Journal"); }
                else if (Type == 4)
                { parameters.Add("voucherType", "Contra"); }



            }
            DataRow workRow = dt1.NewRow();
            string VOUCHER_TYPE = "";
            if (Type == 1)
            { VOUCHER_TYPE="Payment"; }
            else if (Type == 2)
            { VOUCHER_TYPE ="Receipt"; }
            else if (Type == 3)
            { VOUCHER_TYPE ="Journal"; }
            else if (Type == 4)
            { VOUCHER_TYPE ="Contra"; }
            
            //dt1.Columns.AddRange(new DataColumn[1] { new DataColumn("VOUCHER_TYPE") });
            //dt1.Columns.AddRange(new DataColumn[1] { new DataColumn("COMP_REF_NO") });
            dt1.Columns.AddRange(new DataColumn[7] { new DataColumn("VOUCHER_TYPE"), new DataColumn("COMP_REF_NO"), new DataColumn("COMP_VOUCHER_DATE")
                , new DataColumn("TOTAL_DEBIT"), new DataColumn("TOTAL_CREDIT"), new DataColumn("AMOUNT_IN_WORD"), new DataColumn("NARRATION") });
            //string COMP_REF_NO = dt.Rows[0].ItemArray[1].ToString();

            dt1.Rows.Add(VOUCHER_TYPE, dt.Rows[0].ItemArray[1].ToString()
                , dt.Rows[0].ItemArray[7].ToString()
                , debit_value, debit_value, Inwords, dt.Rows[0].ItemArray[9].ToString());
            

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetTrialBalanceReport")]
        public IActionResult GetTrialBalanceReport(string refNo, string Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_Trial_Balance_Report> listdata = new List<ACC_Trial_Balance_Report>();
            dt = lsttodt.ToDataTable(SessionData.trialBalanceList);
            string DR_TOTAL = "";
            string CR_TOTAL = "";
            decimal grd = 0;
            decimal grc = 0;
            foreach (var item in SessionData.trialBalanceList)
            {
                grd += Convert.ToDecimal(item.GR_DEBIT.Replace(",", ""));
                grc += Convert.ToDecimal(item.GR_CREDIT.Replace(",", ""));
                //grd += grd;
                //grc += grc;
            }
            DR_TOTAL = Convert.ToString(grd);
            CR_TOTAL = Convert.ToString(grc);
            //decimal drtotal = SessionData.trialBalanceList.Sum(x => Convert.ToDecimal(x.GR_DEBIT));
            //decimal crtotal = SessionData.trialBalanceList.Sum(x => Convert.ToDecimal(x.GR_CREDIT));
            DataRow workRow = dt1.NewRow();

            //DataColumn Col = dt1.Columns.Add("DR_TOTAL", typeof(String));



            //Add columns to DataTable.
            dt1.Columns.AddRange(new DataColumn[3] { new DataColumn("DR_TOTAL"), new DataColumn("CR_TOTAL"), new DataColumn("DATE") });

            //Set the Default Value.
            //dt.Columns["Id"].DefaultValue = 0;

            //Add rows to DataTable.
            dt1.Rows.Add(DR_TOTAL, CR_TOTAL, "31/01/2023");
            //dt.Rows.Add(1, "Mudassar Khan", "India");
            //dt.Rows.Add(null, "Suzanne Mathews", "France");
            //dt.Rows.Add(3, "Robert Schidner", "Russia");

            //Col.SetOrdinal(0); // set column to first position
            //workRow[0] = DR_TOTAL;
            //workRow[1] = CR_TOTAL;
            //dt1.Rows.Add(workRow);
            //dt1.Rows.Add(new Object[] { 1, "Smith" });
            //dt1.Rows.Add(new Object[] { 1, DR_TOTAL });

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\ACCTrialBalance.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //parameters.Add("dateFrom", SessionData.From_date);
            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);
            //parameters.Add("totalProfitLoss", totalprofitloss);
            LocalReport localReport3 = new LocalReport(path);

            localReport3.AddDataSource("DataSet1", dt);
            localReport3.AddDataSource("DataSet2", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport3.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }

        [HttpGet]
        [Route("GetBalanceSheetReport")]
        public IActionResult GetBalanceSheetReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            dt = lsttodt.ToDataTable(SessionData.balanceSheetList);

            string mimetype = "";
            int extention = 3;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\BalanceSheet.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //parameters.Add("dateFrom", System.DateTime.Now.ToShortDateString());
            //parameters.Add("profitLoss", totalprofitloss);
            //parameters.Add("dateTo", System.DateTime.Now.ToShortDateString());
            //parameters.Add("totalProfitLoss", totalprofitloss);
            LocalReport localReport1 = new LocalReport(path);

            localReport1.AddDataSource("dsBalanceSheet", dt);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport1.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        //[HttpGet]
        //[Route("GetProfitLossReport/{refNo}/{Type}")]

        //-----------
        [HttpGet]
        [Route("GetGeneralLedgerReport")]
        public IActionResult GetGeneralLedgerReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            dt = lsttodt.ToDataTable(SessionData.generalLedgerList);

            decimal _voucher_debit_total = SessionData.generalLedgerList.Sum(x => Convert.ToDecimal(x.VOUCHER_DEBIT_AMOUNT));
            decimal _voucher_creit_total = SessionData.generalLedgerList.Sum(x => Convert.ToDecimal(x.VOUCHER_CREDIT_AMOUNT));
            DataRow workRow = dt1.NewRow();
            string newFormat_From = DateTime.ParseExact(SessionData.From_date, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy");
            string newFormat_To = DateTime.ParseExact(SessionData.To_date, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy");
            string duration = "For The Period From " + newFormat_From + " To " + newFormat_To;

            dt1.Columns.AddRange(new DataColumn[6] { new DataColumn("LEDGER_NAME"), new DataColumn("OPEN_DR"), new DataColumn("OPEN_CR"), new DataColumn("TOTAL_DEBIT"), new DataColumn("TOTAL_CREDIT"), new DataColumn("DURATION") });
            if (Convert.ToInt64(SessionData.sessionLedgerModel.LEDGER_OPENING_BALANCE) < 0)
            {
                dt1.Rows.Add(SessionData.sessionLedgerModel.LEDGER_NAME, SessionData.sessionLedgerModel.LEDGER_OPENING_BALANCE, "", _voucher_debit_total, _voucher_creit_total, duration);
            }
            if (Convert.ToInt64(SessionData.sessionLedgerModel.LEDGER_OPENING_BALANCE) > 0)
            {
                dt1.Rows.Add(SessionData.sessionLedgerModel.LEDGER_NAME, "", SessionData.sessionLedgerModel.LEDGER_OPENING_BALANCE, _voucher_debit_total, _voucher_creit_total, duration);
            }
            if (Convert.ToInt64(SessionData.sessionLedgerModel.LEDGER_OPENING_BALANCE) == 0)
            {
                dt1.Rows.Add(SessionData.sessionLedgerModel.LEDGER_NAME, "", "", _voucher_debit_total, _voucher_creit_total, duration);
            }

            string mimetype = "";
            int extention = 3;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\GeneralLedger.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //parameters.Add("dateFrom", System.DateTime.Now.ToShortDateString());
            //parameters.Add("profitLoss", totalprofitloss);
            //parameters.Add("dateTo", System.DateTime.Now.ToShortDateString());
            //parameters.Add("totalProfitLoss", totalprofitloss);
            LocalReport localReport1 = new LocalReport(path);

            localReport1.AddDataSource("DataSet1", dt);
            localReport1.AddDataSource("DataSet2", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport1.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetProfitLossReport")]
        public IActionResult GetProfitLossReport(string refNo, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            dt = lsttodt.ToDataTable(SessionData.profitAndLossList);

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\ProfitAndLoss.rdlc";

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //parameters.Add("dateFrom", SessionData.From_date);
            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);

            //dt1.Rows[0][0] = SessionData.From_date;
            //dt1.Rows[0][2] = SessionData.To_date;

            //DataRow dr = dt1.NewRow();
            //dr[3]= "Some Value";
            //dt1.Rows.Add(dr);
            //d//t1.Rows[0]["ColumnName"] = "Your value";

            DataSet dtset = new DataSet("tbl1");
            DataTable dttable = new DataTable();
            DataTable dtprofitloss = new DataTable();
            //dttable = dtset.Tables(0);
            DataRow dr = dttable.NewRow();

            dttable.Columns.Add("DateFrom", typeof(string));
            dttable.Columns.Add("DateTo", typeof(string));
            dttable.Rows.Add(dttable.Columns);
            dttable.Rows[0]["DateFrom"] = SessionData.From_date;
            dttable.Rows[0]["DateTo"] = SessionData.To_date;
            dt1 = dttable;

            dtprofitloss.Columns.Add("Amount", typeof(string));
            dtprofitloss.Rows.Add(dtprofitloss.Columns);
            dtprofitloss.Rows[0]["Amount"] = totalprofitloss;
            dt2 = dtprofitloss;

            //foreach (DataRow row in dttable.Columns)
            //{
            //    //need to set value to NewColumn column
            //    //row["NewColumn"] = 0;   // or set it to some other value
            //    row["NewColumn"] = SessionData.From_date;
            //}

            //dr.ItemArray[0]= SessionData.From_date;
            //dr.ItemArray[2]= SessionData.To_date;

            //dttable.Columns = SessionData.From_date;
            ////dr["FromDate"] = SessionData.From_date;
            ////dr["ToDate"] = SessionData.To_date;

            //dtset.Tables[0].Rows.Add(dr);


            //dt1 = dtset.Tables[0];
            //dttable.Columns(0).It.Rows(4).Item(0) = "Updated Company Name"
            //DataSet1.Tables(0).Rows(4).Item(1) = "Seattle"

            LocalReport localReport2 = new LocalReport(path);

            localReport2.AddDataSource("dsProfitLoss", dt);
            localReport2.AddDataSource("DataSet1", dt1);
            localReport2.AddDataSource("DataSet2", dt2);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport2.Execute(RenderType.Pdf, ext, parameters);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetSalesDeliveryNote")]
        public IActionResult GetSalesDeliveryNote(string rptType, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<DeliveryNoteViewModel> listOrderView = new List<DeliveryNoteViewModel>();
            dt = lsttodt.ToDataTable(AppState.DeliveryItemDetails);
            listOrderView.Add(AppState.DeliveryItemDetails.FirstOrDefault());
            dt1 = lsttodt.ToDataTable(listOrderView);

            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters = new Dictionary<string, string>();
            ////string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            parameters.Add("dnno", AppState.deliveryNoteView.DELIVERY_NOTE_NO);
            parameters.Add("dndate", AppState.deliveryNoteView.DELIVERY_DATE);
            //parameters.Add("corporateAddress", AppState.salesOrderView.CORPORATE_ADDRESS);
            //parameters.Add("shippingProject", AppState.salesOrderView.SHIPPING_PROJECT_NAME);
            //parameters.Add("contactPerson", AppState.salesOrderView.CONTACT_PERSON_NAME);
            //parameters.Add("customerCode", AppState.salesOrderView.CUSTOMER_CODE);
            //parameters.Add("contactPhone", AppState.salesOrderView.CONTACT_PERSON_PHONE);
            //parameters.Add("poNumber", AppState.salesOrderView.PO_WO_NUMBER);
            //parameters.Add("podate", AppState.salesOrderView.PO_WO_DATE);
            ////parameters.Add("dateTo", SessionData.To_date);
            ////parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("dsSalesDeliveryNote", dt);
            localReport.AddDataSource("DataSet1", dt1);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }

        //Delivery Invoice SEMCORP

        [HttpGet]
        [Route("GetInvoice")]
        public IActionResult GetInvoice(string rptType, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<InvoiceViewModel> listOrderView = new List<InvoiceViewModel>();
            listOrderView.Add(AppState.invoiceView);
            dt = lsttodt.ToDataTable(listOrderView);
            listOrderView.Add(AppState.invoiceView);
            dt1 = lsttodt.ToDataTable(AppState.InvoiceDetails);

            DataRow workRow = dt2.NewRow();
            dt2.Columns.AddRange(new DataColumn[6] { new DataColumn("ACCOUNT_NAME"), new DataColumn("ACCOUNT_NUMBER")
                                                    , new DataColumn("ROUTING_NUMBER"), new DataColumn("BANK_NAME")
                                                    , new DataColumn("BRANCH"), new DataColumn("SWIFT") });
            dt2.Rows.Add("A/C NAME :  TOCOMA Limited "
                        , "A/C NUMBER : 2940901021000"
                        , "ROUTING NUMBER : 175276343"
                        , "BANK NAME : PUBALI BANK LIMITED"
                        , "BRANCH ADDRESS : SHANTINAGAR BRANCH"
                        , "SWIFT CODE :");

            //dt2.Columns.AddRange(new DataColumn[6] { new DataColumn("ACCOUNT_NAME"), new DataColumn("ACCOUNT_NUMBER")
            //                                        , new DataColumn("ROUTING_NUMBER"), new DataColumn("BANK_NAME")
            //                                        , new DataColumn("BRANCH"), new DataColumn("SWIFT") });
            //dt2.Rows.Add("A/C NAME : "
            //            , "A/C NUMBER : "
            //            , "ROUTING NUMBER : 175276343"
            //            , "BANK NAME : PUBALI BANK LIMITED"
            //            , "BRANCH ADDRESS : SHANTINAGAR BRANCH"
            //            , "SWIFT CODE :");


            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\Invoice.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            parameters.Add("innumber", AppState.InvoiceDetails.FirstOrDefault().INVOICE_NO);
            parameters.Add("indate", AppState.InvoiceDetails.FirstOrDefault().INVOICE_DATE);
            //parameters.Add("corporateAddress", AppState.salesOrderView.CORPORATE_ADDRESS);
            //parameters.Add("shippingProject", AppState.salesOrderView.SHIPPING_PROJECT_NAME);
            //parameters.Add("contactPerson", AppState.salesOrderView.CONTACT_PERSON_NAME);
            //parameters.Add("customerCode", AppState.salesOrderView.CUSTOMER_CODE);
            //parameters.Add("contactPhone", AppState.salesOrderView.CONTACT_PERSON_PHONE);
            //parameters.Add("poNumber", AppState.salesOrderView.PO_WO_NUMBER);
            //parameters.Add("podate", AppState.salesOrderView.PO_WO_DATE);
            ////parameters.Add("dateTo", SessionData.To_date);
            ////parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            localReport.AddDataSource("DataSet3",dt2);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }

        [HttpGet]
        [Route("GetSalesInvoice")]
        public IActionResult GetSalesInvoice(string rptType, int Type)
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<DeliveryNoteViewModel> salesOrder = new List<DeliveryNoteViewModel>();
            SalesOrderViewModel _salesOrder = new SalesOrderViewModel();
            List<SalesItemDetailsModel> salesItem = new List<SalesItemDetailsModel>();
            SalesItemDetailsModel salesItemModel = new SalesItemDetailsModel();
            salesOrder.Add(AppState.deliveryNoteView);
            SalesInvoiceSum salesinvoiceSum = new SalesInvoiceSum();
            List<SalesInvoiceSum> salesinvoiceSumList = new List<SalesInvoiceSum>();

            //_salesOrder.


            dt = lsttodt.ToDataTable(AppState.DeliveryItemDetails);
            //dt1 = lsttodt.ToDataTable(AppState.SalestermsConditionList);
            dt2 = lsttodt.ToDataTable(salesOrder);
            
            //decimal  total_without = AppState.salesItemDetails.Sum(x => Convert.ToDecimal(x.TOTAL_PRICE));
            //decimal  _AIT = AppState.salesItemDetails.Sum(x => Convert.ToDecimal(x.AIT));
            //decimal  _VAT = AppState.salesItemDetails.Sum(x => Convert.ToDecimal(x.VAT));
            //decimal total_with = total_without + _AIT + _VAT; //AppState.salesItemDetails.Sum(x => Convert.ToDecimal(x.AMOUNT));
            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }
            

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            //string totalwithoutaitvat = String.Format("{0:#,###,###.##}", Convert.ToString(total_without));
            //string ait = String.Format("{0:#,###,###.##}", Convert.ToString(_AIT));
            //string vat = String.Format("{0:#,###,###.##}", Convert.ToString(_VAT));
            //string totalwithAitVAT = String.Format("{0:#,###,###.##}", Convert.ToString(total_with));

            
            
            //salesinvoiceSum.TOTAL_WITHOUT_AIT_VAT = Convert.ToDecimal(totalwithoutaitvat);
            //salesinvoiceSum.TOTAL_WIT_AIT_VAT = Convert.ToDecimal(totalwithAitVAT);
            //salesinvoiceSum.TOTAL_AIT = Convert.ToDecimal(ait);
            //salesinvoiceSum.TOTAL_VAT = Convert.ToDecimal(vat);
            //salesinvoiceSum.NET_AMOUNT = total_with- Convert.ToDecimal(AppState.salesOrderView.DISCOUNT);
            //salesinvoiceSum.ADVANCE_PAID = Convert.ToDecimal(AppState.salesOrderView.ADVANCE_PAID);
            //salesinvoiceSum.TOTAL_NET_AMOUNT = salesinvoiceSum.NET_AMOUNT- Convert.ToDecimal(AppState.salesOrderView.ADVANCE_PAID);
            //salesinvoiceSum.DELIVERY_CHARGE =Convert.ToDecimal(AppState.salesOrderView.DELIVERY_CHARGE);
            salesinvoiceSum.GRAND_TOTAL = salesinvoiceSum.TOTAL_NET_AMOUNT+ salesinvoiceSum.DELIVERY_CHARGE;
            Inwords = NumberToWords.ConvertAmount(Convert.ToDouble(salesinvoiceSum.GRAND_TOTAL));
            salesinvoiceSum.GRAND_TOTAL_INWORD = Inwords;

            salesinvoiceSumList.Add(salesinvoiceSum);
            dt3 = lsttodt.ToDataTable(salesinvoiceSumList);
            //parameters.Add("totalwithoutaitvat", totalwithoutaitvat);
            //parameters.Add("aitTotal", ait);
            //parameters.Add("vatTotal", vat);
            //parameters.Add("gTotal", totalwithAitVAT);



            List<InvoiceReference> InvoiceReference = new List<InvoiceReference>();
            InvoiceReference invRefer = new InvoiceReference();
            //{AppState.salesOrderView.SALES_ORDER_NO,AppState.salesOrderView.QUOTATION_NO };
            //invRefer.SALES_ORDER_NO = AppState.salesOrderView.SALES_ORDER_NO;
            //invRefer.QUOTATION_NO = AppState.salesOrderView.QUOTATION_NO;
            //invRefer.CUSTOMER_CODE = AppState.salesOrderView.CUSTOMER_CODE;
            //invRefer.PO_WO_NUMBER = AppState.salesOrderView.PO_WO_NUMBER;
            //invRefer.PO_WO_DATE = AppState.salesOrderView.PO_WO_DATE;
            //invRefer.DELIVERY_DATE = AppState.salesOrderView.DELIVERY_DATE;
            //invRefer.DELIVERY_NOTE_NO = AppState.salesOrderView.DELIVERY_NOTE_NO;
            InvoiceReference.Add(invRefer);
            dt4 = lsttodt.ToDataTable(InvoiceReference);

            //parameters.Add("corporateAddress", AppState.salesOrderView.CORPORATE_ADDRESS);
            //parameters.Add("shippingProject", AppState.salesOrderView.SHIPPING_PROJECT_NAME);
            //parameters.Add("contactPerson", AppState.salesOrderView.CONTACT_PERSON_NAME);
            //parameters.Add("customerCode", AppState.salesOrderView.CUSTOMER_CODE);
            //parameters.Add("contactPhone", AppState.salesOrderView.CONTACT_PERSON_PHONE);
            //parameters.Add("poNumber", AppState.salesOrderView.PO_WO_NUMBER);
            //parameters.Add("podate", AppState.salesOrderView.PO_WO_DATE);

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt3);
            //localReport.AddDataSource("DataSet3", dt1);
            localReport.AddDataSource("DataSet4", "");
            localReport.AddDataSource("DataSet5", dt4);
            localReport.AddDataSource("DataSet6",dt2);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        public static DataTable CombineDataTables(params DataTable[] args)
        {
            return args.SelectMany(dt => dt.AsEnumerable()).CopyToDataTable();
        }
        //[HttpGet]
        //[Route("GetPurchaseOrderInvoiceLocal")]
        //public IActionResult GetPurchaseOrderInvoiceLocal()
        //{
        //    string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
        //    string current_time = System.DateTime.Now.ToShortTimeString().ToString();
        //    string Inwords = "";
        //    var dt = new DataTable();
        //    var dt1 = new DataTable();
        //    var dt2 = new DataTable();
        //    var dt3 = new DataTable();
        //    var DS = new DataSet();
        //    ListtoDataTable lsttodt = new ListtoDataTable();
        //    List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
        //    List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
        //    PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
        //    List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
        //    pOrderList.Add(AppState.porder);

        //    pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
        //    pl.PO_DATE = AppState.porder.PO_DATE;
        //    plList.Add(pl);

        //    dt = lsttodt.ToDataTable(AppState.porderDetails);
        //    dt2 = lsttodt.ToDataTable(AppState.termsConditionList);
        //    dt3 = lsttodt.ToDataTable(plList);
        //    //dt.Rows.Add(row);
        //    //DS = lsttodt.ToDataTable(AppState.termsConditionList);
        //    //dt3 = dt;
        //    //DS.Tables.Add(dt);
        //    //DS.Tables.Add(dt1);
        //    //DS.Tables.Add(dt2);
        //    //dt3 = DS.Tables[0];
        //    //dt3 = DS.Tables[1];
        //    //dt3 = DS.Tables[2];

        //    //for (int i=0;i<DS.Tables.Count;i++)
        //    //{
        //    //    dt3 += DS.Tables[i];
        //    //}


        //    string mimetype = "";
        //    int extention = 1;
        //    var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseInvoiceLocal.rdlc";
        //    //if (rptType=="1")
        //    //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
        //    //else if(rptType=="2")
        //    //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


        //    parameters = new Dictionary<string, string>();
        //    //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
        //    double voucher_total_value = 0;
        //    for (int k = 0; k < dt.Rows.Count; k++)
        //    { voucher_total_value += Convert.ToDouble(dt.Rows[k].ItemArray[8].ToString()); }
        //    Inwords = NumberToWords.ConvertAmount(voucher_total_value);
        //    string total = String.Format("{0:#,###,###.##}", voucher_total_value);




        //    parameters.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
        //    parameters.Add("supplierName", AppState.porder.VENDOR_NAME);
        //    parameters.Add("corporateAddress", AppState.porder.ADDRESS);
        //    parameters.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
        //    parameters.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);

        //    parameters.Add("podate", AppState.porder.PO_DATE);
        //    parameters.Add("consignee", AppState.porder.CONSIGNEE_NAME);
        //    parameters.Add("consigneeAddress", AppState.porder.ADDRESS);
        //    parameters.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
        //    parameters.Add("termsOfDelivery", AppState.porder.TERMS_OF_DELIVERY);
        //    parameters.Add("deliveryMode", AppState.porder.DELIVERY_MODE);
        //    parameters.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
        //    parameters.Add("paymentTerm", AppState.porder.PAYMENT_TERM);
        //    parameters.Add("paymentMode", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
        //    parameters.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);


        //    parameters.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
        //    parameters.Add("vendorContactNo", AppState.porder.CONTACT_NO);
        //    parameters.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);



        //    parameters.Add("A", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("B", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("C", AppState.porder.PAYMENT_MODE);
        //    parameters.Add("D", AppState.porder.PAYMENT_MODE);






        //    parameters.Add("inWord", Inwords);
        //    parameters.Add("grandTotal", total);

        //    //21







        //    //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

        //    //parameters.Add("dateTo", SessionData.To_date);
        //    //parameters.Add("profitLoss", totalprofitloss);



        //    LocalReport localReport4 = new LocalReport(path);

        //    localReport4.AddDataSource("DataSet1", dt);
        //    localReport4.AddDataSource("DataSet2", dt2);
        //    localReport4.AddDataSource("DataSet3", dt3);

        //    //localReport.AddDataSource("dsTermsAndConditions", dt1);

        //    int ext = (int)(DateTime.Now.Ticks >> 10);
        //    var result = localReport4.Execute(RenderType.Pdf, ext, parameters);

        //    //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
        //    return File(result.MainStream, "application/pdf");
        //}
        public class InvoiceReference
        {
            public string SALES_ORDER_NO { get; set; }
            public string QUOTATION_NO { get; set; }
            public string CUSTOMER_CODE { get; set; }
            public string PO_WO_NUMBER { get; set; }
            public string PO_WO_DATE { get; set; }
            public string DELIVERY_NOTE_NO { get; set; }
            public string DELIVERY_DATE { get; set; }
        }
        public class CandidateInfo
        {
            public int CandidateId { get; set; }
            public string Name { get; set; }
            public string CellNo { get; set; }
            public int Age { get; set; }
            //Add more properties here as you need them. Ex:
            public string GroupName { get; set; }
        }
        public class TotalTable
        {
            public string INWORD { get; set; }
            public string TOTAL_AMOUNT { get; set; }
        }

        [HttpGet]
        [Route("GetPurchaseOrderInvoiceLocal")]
        public IActionResult GetPurchaseOrderInvoiceLocal()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            PurchaseOrderDetailsEntity porD = new PurchaseOrderDetailsEntity();
            List<PurchaseOrderDetailsEntity> porDList = new List<PurchaseOrderDetailsEntity>();
            TotalTable t = new TotalTable();
            List<TotalTable> tList = new List<TotalTable>();
            pOrderList.Add(AppState.porder);

            

            //foreach (var item in AppState.porderDetails)
            //{
            //    porD = new PurchaseOrderDetailsEntity();
            //    porD.ITEM_NAME = item.ITEM_NAME;
            //    //porD.INWORDS=

            //    //porDList.Add(porD);
            //}
            
            dt1 = lsttodt.ToDataTable(AppState.porderDetails);
            dt2 = lsttodt.ToDataTable(AppState.packagingList);

            double voucher_total_value = 0;
            for (int k = 0; k < dt1.Rows.Count; k++)
            { voucher_total_value += Convert.ToDouble(dt1.Rows[k].ItemArray[9].ToString()); }
            Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            string total = String.Format("{0:#,###,###.##}", voucher_total_value);

            t.INWORD = Inwords;
            t.TOTAL_AMOUNT = total;

            tList.Add(t);
            dt3= lsttodt.ToDataTable(tList);


            pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            pl.PO_DATE = AppState.porder.PO_DATE;
            pl.VENDOR_NAME = AppState.porder.VENDOR_NAME;
            pl.REGISTERED_ADDRESS = AppState.porder.REGISTERED_ADDRESS;
            pl.QUOTATION_REFERANCE_NO = AppState.porder.QUOTATION_REFERANCE_NO;
            pl.QUOTATION_REFERANCE_DATE = AppState.porder.QUOTATION_REFERANCE_DATE;
            pl.CONSIGNEE_NAME = AppState.porder.CONSIGNEE_NAME;
            pl.ADDRESS = AppState.porder.ADDRESS;
            pl.CONTACT_PERSON_NAME = AppState.porder.CONTACT_PERSON_NAME;
            pl.CONTACT_NO = AppState.porder.CONTACT_NO;
            pl.VENDOR_CONTACT_EMAIL = AppState.porder.VENDOR_CONTACT_EMAIL;
            pl.CONTACT_PERSON_NAME_1 = AppState.porder.CONTACT_PERSON_NAME_1;
            pl.CONTACT_PERSON_CONTACT_NO_1 = AppState.porder.CONTACT_PERSON_CONTACT_NO_1;
            pl.CONATACT_PERSON_EMAIL_1 = AppState.porder.CONATACT_PERSON_EMAIL_1;
            pl.TERMS_OF_DELIVERY = AppState.porder.TERMS_OF_DELIVERY;
            pl.DELIVERY_MODE = AppState.porder.DELIVERY_MODE;
            pl.SHIPPING_ADDRESS = AppState.porder.SHIPPING_ADDRESS;
            pl.PAYMENT_TERM = AppState.porder.PAYMENT_TERM;
            pl.PAYMENT_MODE = AppState.porder.PAYMENT_MODE;
            //pl.INWORDS = Inwords;
            //pl.TOTAL_AMOUNT = total;
            plList.Add(pl);

            dt = lsttodt.ToDataTable(plList);
            

            
            //dt3 = lsttodt.ToDataTable(plList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseInvoiceL.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string>  parameters = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));





            //parameters.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
            //parameters.Add("supplierName", AppState.porder.VENDOR_NAME);
            //parameters.Add("corporateAddress", AppState.porder.ADDRESS);
            //parameters.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            //parameters.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);

            //parameters.Add("podate", AppState.porder.PO_DATE);
            //parameters.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            //parameters.Add("consigneeAddress", AppState.porder.ADDRESS);
            //parameters.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            //parameters.Add("termsOfDelivery", AppState.porder.TERMS_OF_DELIVERY);
            //parameters.Add("deliveryMode", AppState.porder.DELIVERY_MODE);
            //parameters.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            //parameters.Add("paymentTerm", AppState.porder.PAYMENT_TERM);
            //parameters.Add("paymentMode", AppState.porder.PAYMENT_MODE);
            //parameters.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            //parameters.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);


            //parameters.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            //parameters.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            //parameters.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);



            //parameters.Add("A", AppState.porder.PAYMENT_MODE);
            //parameters.Add("B", AppState.porder.PAYMENT_MODE);
            //parameters.Add("C", AppState.porder.PAYMENT_MODE);
            //parameters.Add("D", AppState.porder.PAYMENT_MODE);






            //parameters.Add("inWord", Inwords);
            //parameters.Add("grandTotal", total);

            //21







            //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport4 = new LocalReport(path);

            localReport4.AddDataSource("DataSet1", dt);
            localReport4.AddDataSource("DataSet2", dt1);
            localReport4.AddDataSource("DataSet3", dt2);
            localReport4.AddDataSource("DataSet4", dt3);

            //localReport.AddDataSource("dsTermsAndConditions", dt1);

            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport4.Execute(RenderType.Pdf, ext, parameters);

            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }


        [HttpGet]
        [Route("GetPurchaseOrderInvoiceInt")]
        public IActionResult GetPurchaseOrderInvoiceInt()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            pOrderList.Add(AppState.porder);

            pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            pl.PO_DATE = AppState.porder.PO_DATE;
            plList.Add(pl);
            pOrderList.Add(AppState.porder);
            dt = lsttodt.ToDataTable(plList);
            dt3 = lsttodt.ToDataTable(AppState.porderDetails);
            dt2 = lsttodt.ToDataTable(AppState.packagingList);
            dt4 = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseInvoiceInt.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string>  parameters1 = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            double voucher_total_value = 0;
            for (int k = 0; k < dt3.Rows.Count; k++)
            { voucher_total_value += Convert.ToDouble(dt3.Rows[k].ItemArray[8].ToString()); }
            Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            string total = String.Format("{0:#,###,###.##}", voucher_total_value);
            double grandTotal = voucher_total_value + AppState.porder.CARRING_WAY_COST;
            string Gtotal= String.Format("{0:#,###,###.##}", grandTotal);


            parameters1.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
            parameters1.Add("podate", AppState.porder.PO_DATE);
            parameters1.Add("supplierName", AppState.porder.VENDOR_NAME);
            parameters1.Add("corporateAddress", AppState.porder.ADDRESS);
            parameters1.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            parameters1.Add("consigneeAddress", AppState.porder.ADDRESS);
            parameters1.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            parameters1.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);
            parameters1.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            parameters1.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);
            parameters1.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            parameters1.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            parameters1.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            parameters1.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);
            parameters1.Add("ContainerSize", AppState.porder.CONTAINER_SIZE);
            parameters1.Add("deliveryTime", AppState.porder.DELIVERY_TIME);
            parameters1.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            parameters1.Add("paymentTerm", AppState.porder.INCOTERM);
            parameters1.Add("shipVia", AppState.porder.SHIP_VIA);
            parameters1.Add("countryOfOrigin", AppState.porder.COUNTRY_OF_ORIGIN);
            parameters1.Add("portofLoading", AppState.porder.PORT_OF_LOADING);
            parameters1.Add("portofDischarge", AppState.porder.PORT_OF_DISCHARGE);
            parameters1.Add("Currency", AppState.porder.CURRENCY);
            parameters1.Add("bin", AppState.porder.BIN);
            parameters1.Add("tin", AppState.porder.TIN);
            parameters1.Add("carringWayCost", Convert.ToString(AppState.porder.CARRING_WAY_COST));
            parameters1.Add("GRANDT", Gtotal);


            parameters1.Add("inWord", Inwords);
            parameters1.Add("grandTotal", total);

            //25



            //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport5 = new LocalReport(path);

            localReport5.AddDataSource("DataSet1", dt);
            localReport5.AddDataSource("DataSet2", dt);
            localReport5.AddDataSource("DataSet3", dt3);
            localReport5.AddDataSource("DataSet4", dt2);
            localReport5.AddDataSource("DataSet5", dt4);

            //localReport.AddDataSource("dsTermsAndConditions", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport5.Execute(RenderType.Pdf, ext, parameters1);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        //------------Sales Quotation
        [HttpGet]
        [Route("GetSalesQuotation")]
        public IActionResult GetSalesQuotation()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            var dt6 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<SalesQuotationView> pOrderList = new List<SalesQuotationView>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            
            //pOrderList.Add(AppState.salesQuotation);

            //pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            //pl.PO_DATE = AppState.porder.PO_DATE;
            //plList.Add(pl);
            pOrderList.Add(AppState.salesQuotation);
            dt = lsttodt.ToDataTable(pOrderList);
            if(AppState.salesQuotationitemList!=null)
            { dt1 = lsttodt.ToDataTable(AppState.salesQuotationitemList); }
                        
            if (AppState.SalestermsConditionList != null)
            { dt2 = lsttodt.ToDataTable(AppState.SalestermsConditionList); }

            if(AppState.usedProductList!=null)
            { dt6 = lsttodt.ToDataTable(AppState.usedProductList); }

            //dt2 = lsttodt.ToDataTable(AppState.SalestermsConditionList);
            //dt4 = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\Quotation.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters1 = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //double voucher_total_value = 0;
            //for (int k = 0; k < dt3.Rows.Count; k++)
            //{ voucher_total_value += Convert.ToDouble(dt3.Rows[k].ItemArray[8].ToString()); }
            //Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            //string total = String.Format("{0:#,###,###.##}", voucher_total_value);
            //double grandTotal = voucher_total_value + AppState.porder.CARRING_WAY_COST;
            //string Gtotal = String.Format("{0:#,###,###.##}", grandTotal);


            parameters1.Add("quotNo", AppState.salesQuotation.QUOTATION_NO);
            parameters1.Add("quotationDate", AppState.salesQuotation.QUOTATION_DATE);
            //parameters1.Add("podate", AppState.porder.PO_DATE);
            //parameters1.Add("supplierName", AppState.porder.VENDOR_NAME);
            //parameters1.Add("corporateAddress", AppState.porder.ADDRESS);
            //parameters1.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            //parameters1.Add("consigneeAddress", AppState.porder.ADDRESS);
            //parameters1.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            //parameters1.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);
            //parameters1.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            //parameters1.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);
            //parameters1.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            //parameters1.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            //parameters1.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            //parameters1.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);
            //parameters1.Add("ContainerSize", AppState.porder.CONTAINER_SIZE);
            //parameters1.Add("deliveryTime", AppState.porder.DELIVERY_TIME);
            //parameters1.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            //parameters1.Add("paymentTerm", AppState.porder.INCOTERM);
            //parameters1.Add("shipVia", AppState.porder.SHIP_VIA);
            //parameters1.Add("countryOfOrigin", AppState.porder.COUNTRY_OF_ORIGIN);
            //parameters1.Add("portofLoading", AppState.porder.PORT_OF_LOADING);
            //parameters1.Add("portofDischarge", AppState.porder.PORT_OF_DISCHARGE);
            //parameters1.Add("Currency", AppState.porder.CURRENCY);
            //parameters1.Add("bin", AppState.porder.BIN);
            //parameters1.Add("tin", AppState.porder.TIN);
            //parameters1.Add("carringWayCost", Convert.ToString(AppState.porder.CARRING_WAY_COST));
            //parameters1.Add("GRANDT", Gtotal);


            //parameters1.Add("inWord", Inwords);
            //parameters1.Add("grandTotal", total);

            //25



            //parameters.Add("contactPhone", AppState.porder.CONSIGNEE_NAME);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            localReport.AddDataSource("DataSet3", "");
            localReport.AddDataSource("DataSet4", dt2);
            localReport.AddDataSource("DataSet5", dt6);
            

            //localReport.AddDataSource("dsTermsAndConditions", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport.Execute(RenderType.Pdf, ext, parameters1);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        //------------Sales Quotation
        [HttpGet]
        [Route("GetCustomerAccount")]
        public IActionResult GetCustomerAccount()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<CustomerViewModel> customerViewList = new List<CustomerViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            customerViewList.Add(AppState.customerview);
            //pOrderList.Add(AppState.salesQuotation);

            //pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            //pl.PO_DATE = AppState.porder.PO_DATE;
            //plList.Add(pl);
            //pOrderList.Add(AppState.salesQuotation);
            dt = lsttodt.ToDataTable(AppState.CustomerAccountReportList);
            if (customerViewList != null)
            { dt1 = lsttodt.ToDataTable(customerViewList); }

            




            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\CustomerAccount.rdlc";
            Dictionary<string, string> parameters1 = new Dictionary<string, string>();
            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            //localReport.AddDataSource("DataSet2", dt1);
            //localReport.AddDataSource("DataSet3", "");
            //localReport.AddDataSource("DataSet4", dt2);
            //localReport.AddDataSource("DataSet5", "");           
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport.Execute(RenderType.Pdf, ext, parameters1);            
            return File(result.MainStream, "application/pdf");
        }
        [HttpGet]
        [Route("GetCustomerProfile")]
        public IActionResult GetCustomerProfile()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<CustomerViewModel> customerViewList = new List<CustomerViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();
            customerViewList.Add(AppState.customerViewModel);
            //pOrderList.Add(AppState.salesQuotation);

            //pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            //pl.PO_DATE = AppState.porder.PO_DATE;
            //plList.Add(pl);
            //pOrderList.Add(AppState.salesQuotation);
            dt = lsttodt.ToDataTable(customerViewList);
            //if (customerViewList != null)
            //{ dt1 = lsttodt.ToDataTable(customerViewList); }






            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\CustomerProfile.rdlc";
            Dictionary<string, string> parameters1 = new Dictionary<string, string>();
            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            //localReport.AddDataSource("DataSet2", dt1);
            //localReport.AddDataSource("DataSet2", dt1);
            //localReport.AddDataSource("DataSet3", "");
            //localReport.AddDataSource("DataSet4", dt2);
            //localReport.AddDataSource("DataSet5", "");           
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport.Execute(RenderType.Pdf, ext, parameters1);
            return File(result.MainStream, "application/pdf");
        }
        public class SalesInvoiceSum
        {
            public string GRAND_TOTAL_INWORD { get; set; }
            public decimal TOTAL_WITHOUT_AIT_VAT { get; set; }
            public decimal TOTAL_WIT_AIT_VAT { get; set; }
            public decimal TOTAL_AIT { get; set; }
            public decimal TOTAL_VAT { get; set; }
            public decimal DISCOUNT { get; set; }
            public decimal NET_AMOUNT { get; set; }
            public decimal ADVANCE_PAID { get; set; }
            public decimal TOTAL_NET_AMOUNT { get; set; }
            public decimal DELIVERY_CHARGE { get; set; }
            public decimal GRAND_TOTAL{ get; set; }
        }
        public class ListtoDataTable
        {
            public System.Data.DataTable ToDataTable<T>(List<T> items)
            {
                System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);

                //Get all the properties by using reflection
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }

                return dataTable;
            }
        }
        public class ListtoDataTable1
        {
            public List<System.Data.DataTable> ToDataTable<T>(List<T> items)
            {
                System.Data.DataTable dataTable = new System.Data.DataTable(typeof(T).Name);
                List<System.Data.DataTable> dataTable1 = new List<DataTable>();
                //Get all the properties by using reflection
                PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
                foreach (PropertyInfo prop in Props)
                {
                    //Setting column names as Property names
                    dataTable.Columns.Add(prop.Name);
                }
                foreach (T item in items)
                {
                    var values = new object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {

                        values[i] = Props[i].GetValue(item, null);
                    }
                    dataTable.Rows.Add(values);
                }
                dataTable1.Add(dataTable);
                return dataTable1;
            }
        }
        [HttpGet]
        [Route("GetProductImage")]
        public string GetImage()
        {
            var path = $"{this._webHostEnvironment.WebRootPath}\\images\\Products\\0034_WhatsApp Image 2022-03-07 at 2.03.17 PM.jpeg";
            //string path = @"D:\Project\Company All Project\TocomaERP\Project\TOCOMA\TOCOMA_ERP_System\TOCOMA_ERP_System\wwwroot\images\Products";
            return path;
        }

        //------
        [HttpGet]
        [Route("GetstockStatement")]
        public IActionResult GetstockStatement()
        {
            
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();          
            
            dt = lsttodt.ToDataTable(SessionData.stockStatementListReport);

            string mimetype = "";
            int extention = 1;
            //strResourcePath =Server.MapPath("~") + Path;
            //var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PlanAndScheduleReport.rdlc";
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\StockStatement.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            DataRow workRow = dt1.NewRow();
            //string newFormat_From = DateTime.ParseExact(SessionData.From_date, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy");
            //string newFormat_To = DateTime.ParseExact(SessionData.To_date, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy");
            //string duration = "For The Period From " + newFormat_From + " To " + newFormat_To;

            //dt1.Columns.AddRange(new DataColumn[1] { new DataColumn("DURATION") });
            //dt1.Rows.Add(duration);





            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }

        [HttpGet]
        [Route("GetBillTransectionView")]
        public IActionResult GetBillTransectionView()
        {
            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var DS = new DataSet();
            ListtoDataTable lsttodt = new ListtoDataTable();           
            TotalTable t = new TotalTable();
            List<TotalTable> tList = new List<TotalTable>();
            //dt1 = lsttodt.ToDataTable(AppState.porderDetails);
            //dt2 = lsttodt.ToDataTable(AppState.packagingList);
            dt = lsttodt.ToDataTable(SessionData.miscBillReqList);
            double voucher_total_value = 0;
            for (int k = 0; k < dt.Rows.Count; k++)
            { voucher_total_value += Convert.ToDouble(dt.Rows[k].ItemArray[8].ToString()); }
            Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            string total = String.Format("{0:#,###,###.##}", voucher_total_value);

            t.INWORD = Inwords;
            t.TOTAL_AMOUNT = total;

            tList.Add(t);
            dt3 = lsttodt.ToDataTable(tList);

            DataRow workRow = dt1.NewRow();
            

            dt1.Columns.AddRange(new DataColumn[1] { new DataColumn("IN_WARD") });
            dt1.Rows.Add(Inwords);
            string mimetype = "";
            int extention = 1;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\billreqReport.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            LocalReport localReport4 = new LocalReport(path);
            localReport4.AddDataSource("DataSet1", dt);
            localReport4.AddDataSource("DataSet2", dt1);
            //localReport4.AddDataSource("DataSet3", dt2);
            //localReport4.AddDataSource("DataSet4", dt3);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport4.Execute(RenderType.Pdf, ext, parameters);
            return File(result.MainStream, "application/pdf");
        }
        //------PurchaseRecord
        [HttpGet]
        [Route("GetPurchaseStatement")]
        public IActionResult GetPurchaseStatement()
        {

            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();

            dt = lsttodt.ToDataTable(SessionData.purchaseRecortList);

            string mimetype = "";
            int extention = 1;            
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\StockStatement.rdlc";
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            DataRow workRow = dt1.NewRow();
            //string newFormat_From = DateTime.ParseExact(SessionData.From_date, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy");
            //string newFormat_To = DateTime.ParseExact(SessionData.To_date, "yyyy'-'MM'-'dd", CultureInfo.InvariantCulture).ToString("dd'/'MM'/'yyyy");
            string duration = " From " + SessionData.From_date + " To " + SessionData.To_date;

            dt1.Columns.AddRange(new DataColumn[1] { new DataColumn("DURATION") });
            dt1.Rows.Add(duration);

            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
        //------PurchaseRecord
        [HttpGet]
        [Route("GetPurchaseOrder")]
        public IActionResult GetPurchaseOrder()
        {

            string current_date = System.DateTime.Now.Day + "/" + System.DateTime.Now.Month + "/" + System.DateTime.Now.Year;
            string current_time = System.DateTime.Now.ToShortTimeString().ToString();
            string Inwords = "";
            var dt = new DataTable();
            var dt1 = new DataTable();
            var dt2 = new DataTable();
            var dt3 = new DataTable();
            var dt4 = new DataTable();
            var DS = new DataSet();
            var dt6 = new DataTable();
            ListtoDataTable lsttodt = new ListtoDataTable();
            List<ACC_VOUCHER_MODEL> listdata = new List<ACC_VOUCHER_MODEL>();
            List<PurchaseOrderViewModel> pOrderList = new List<PurchaseOrderViewModel>();
            PurchaseInvoiceLocal pl = new PurchaseInvoiceLocal();
            List<PurchaseInvoiceLocal> plList = new List<PurchaseInvoiceLocal>();

            //pOrderList.Add(AppState.salesQuotation);

            //pl.PO_NUMBER_LONG_CODE = AppState.porder.PO_NUMBER_LONG_CODE;
            //pl.PO_DATE = AppState.porder.PO_DATE;
            //plList.Add(pl);
            pOrderList.Add(AppState.porder);
            dt = lsttodt.ToDataTable(pOrderList);
            if (AppState.porderDetailsList != null)
            { dt1 = lsttodt.ToDataTable(AppState.porderDetailsList); }

            if (AppState.SalestermsConditionList != null)
            { dt2 = lsttodt.ToDataTable(AppState.SalestermsConditionList); }

            if (AppState.usedProductList != null)
            { dt6 = lsttodt.ToDataTable(AppState.usedProductList); }

            //dt2 = lsttodt.ToDataTable(AppState.SalestermsConditionList);
            //dt4 = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt.Rows.Add(row);
            //DS = lsttodt.ToDataTable(AppState.termsConditionList);
            //dt3 = dt;
            //DS.Tables.Add(dt);
            //DS.Tables.Add(dt1);
            //DS.Tables.Add(dt2);
            //dt3 = DS.Tables[0];
            //dt3 = DS.Tables[1];
            //dt3 = DS.Tables[2];

            //for (int i=0;i<DS.Tables.Count;i++)
            //{
            //    dt3 += DS.Tables[i];
            //}


            string mimetype = "";
            int extention = 2;
            var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\PurchaseOrder.rdlc";
            //if (rptType=="1")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesDeliveryNote.rdlc"; }
            //else if(rptType=="2")
            //{ var path = $"{this._webHostEnvironment.WebRootPath}\\RDLC\\SalesInvoice.rdlc"; }


            Dictionary<string, string> parameters1 = new Dictionary<string, string>();
            //string totalprofitloss = String.Format("{0:#,###,###.##}", Convert.ToString(SessionData.TotalProfitLoss));
            //double voucher_total_value = 0;
            //for (int k = 0; k < dt3.Rows.Count; k++)
            //{ voucher_total_value += Convert.ToDouble(dt3.Rows[k].ItemArray[8].ToString()); }
            //Inwords = NumberToWords.ConvertAmount(voucher_total_value);
            //string total = String.Format("{0:#,###,###.##}", voucher_total_value);
            //double grandTotal = voucher_total_value + AppState.porder.CARRING_WAY_COST;
            //string Gtotal = String.Format("{0:#,###,###.##}", grandTotal);


            //parameters1.Add("poNumber", AppState.porder.PO_NUMBER_LONG_CODE);
            //parameters1.Add("podate", AppState.porder.PO_DATE);
            //parameters1.Add("supplierName", AppState.porder.VENDOR_NAME);
            //parameters1.Add("corporateAddress", AppState.porder.ADDRESS);
            //parameters1.Add("consignee", AppState.porder.CONSIGNEE_NAME);
            //parameters1.Add("consigneeAddress", AppState.porder.ADDRESS);
            //parameters1.Add("quotRefNo", AppState.porder.QUOTATION_REFERANCE_NO);
            //parameters1.Add("quotRefDate", AppState.porder.QUOTATION_REFERANCE_DATE);
            //parameters1.Add("contactPerson", AppState.porder.CONTACT_PERSON_NAME_1);
            //parameters1.Add("contactPhone", AppState.porder.CONTACT_PERSON_CONTACT_NO_1);
            //parameters1.Add("contactPersonEmail", AppState.porder.CONATACT_PERSON_EMAIL_1);
            //parameters1.Add("vendorContactPerson", AppState.porder.CONTACT_PERSON_NAME);
            //parameters1.Add("vendorContactNo", AppState.porder.CONTACT_NO);
            //parameters1.Add("vendorContactEmail", AppState.porder.VENDOR_CONTACT_EMAIL);
            //parameters1.Add("ContainerSize", AppState.porder.CONTAINER_SIZE);
            //parameters1.Add("deliveryTime", AppState.porder.DELIVERY_TIME);
            //parameters1.Add("shippingAddress", AppState.porder.SHIPPING_ADDRESS);
            //parameters1.Add("paymentTerm", AppState.porder.INCOTERM);
            //parameters1.Add("shipVia", AppState.porder.SHIP_VIA);
            //parameters1.Add("countryOfOrigin", AppState.porder.COUNTRY_OF_ORIGIN);
            //parameters1.Add("portofLoading", AppState.porder.PORT_OF_LOADING);
            //parameters1.Add("portofDischarge", AppState.porder.PORT_OF_DISCHARGE);
            //parameters1.Add("Currency", AppState.porder.CURRENCY);
            //parameters1.Add("bin", AppState.porder.BIN);
            //parameters1.Add("tin", AppState.porder.TIN);
            //parameters1.Add("carringWayCost", Convert.ToString(AppState.porder.CARRING_WAY_COST));
            //parameters1.Add("GRANDT", Gtotal);


            //parameters1.Add("inWord", Inwords);
            //parameters1.Add("grandTotal", total);

            //25



            parameters1.Add("poNumber", "POSEM"+AppState.porder.PO_NUMBER);
            parameters1.Add("poDate", AppState.porder.PO_DATE);

            //parameters.Add("dateTo", SessionData.To_date);
            //parameters.Add("profitLoss", totalprofitloss);



            LocalReport localReport = new LocalReport(path);

            localReport.AddDataSource("DataSet1", dt);
            localReport.AddDataSource("DataSet2", dt1);
            //localReport.AddDataSource("DataSet3", "");
            //localReport.AddDataSource("DataSet4", dt2);
            //localReport.AddDataSource("DataSet5", dt6);


            //localReport.AddDataSource("dsTermsAndConditions", dt1);
            int ext = (int)(DateTime.Now.Ticks >> 10);
            var result = localReport.Execute(RenderType.Pdf, ext, parameters1);
            //var result = localReport.Execute(RenderType.Pdf, extention, parameters, mimetype);
            return File(result.MainStream, "application/pdf");
        }
    }
}
