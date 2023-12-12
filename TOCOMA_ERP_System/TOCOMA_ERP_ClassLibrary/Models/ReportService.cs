using AdvanceSoftware.VBReport8;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ReportService
    {
#pragma warning disable CS0649 // Field 'ReportService.webCellReport1' is never assigned to, and will always have its default value null
        private AdvanceSoftware.VBReport8.Web.WebCellReport webCellReport1;
#pragma warning restore CS0649 // Field 'ReportService.webCellReport1' is never assigned to, and will always have its default value null
#pragma warning disable CS0169 // The field 'ReportService.components' is never used
        private System.ComponentModel.IContainer components;
#pragma warning restore CS0169 // The field 'ReportService.components' is never used
#pragma warning disable CS0414 // The field 'ReportService.contentType' is assigned but its value is never used
        private string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
#pragma warning restore CS0414 // The field 'ReportService.contentType' is assigned but its value is never used
#pragma warning disable CS0414 // The field 'ReportService.fileName' is assigned but its value is never used
        private string fileName = "authors.xlsx";
#pragma warning restore CS0414 // The field 'ReportService.fileName' is assigned but its value is never used
        private ExcelApplication _ExcelCellReport;
        private CellReport _CellReport;
        DataSet NEW_DATASET = new DataSet();
        public CellReport CellReport
        {
            get { return _CellReport; }
            set { _CellReport = value; }
        }
        public ExcelApplication ExcelCellReport
        {
            get { return _ExcelCellReport; }
            set { _ExcelCellReport = value; }
        }
        public void output(ReportConfig config, DataSet DS)
        {
            webCellReport1.FileName = "Purchase_Report";
            webCellReport1.Report.Start();
            webCellReport1.Report.File();
            webCellReport1.Page.Start("Purchase", "1");

            webCellReport1.Page.End();
            webCellReport1.Report.End();
            MemoryStream memoryStream = new MemoryStream();
            webCellReport1.Report.SaveAs(memoryStream);
            contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            fileName = "authors.xlsx";
        }
        public void GENERATE_INVOICE(ReportConfig config, DataSet DS,string temp_path)
        {
            if (DS == null || DS.Tables[0].Rows.Count == 0)
            {
                return;
            }

            //webCellReport1.FileName = designFileName;
            //webCellReport1.Report.Start();
            //webCellReport1.Report.File();
            //webCellReport1.Page.Start(SheetName, PageCount);
            //string DateString = DS.Tables[1].Rows[0].ItemArray[10].ToString();
            //DateTime date = DateTime.Now;

            CellReport = config.CellReport;

            // テンプレート(デザインファイル)のパスをFileNameで指定します。
            CellReport.FileName = temp_path;//Constants.Template_Path + "\\" + config.TemplateFile;


            // Report.Start後にReport.Fileで帳票処理を開始します。
            CellReport.Report.Start();
            CellReport.Report.File();

            if (DS.Tables[0].Rows.Count > 0)
            {
                //Page.Startでデザインファイルのテンプレート(シート)を指定
                //CellReport.Page.Start(config.TemplateSheet, config.TemplatePage);
                #region test report

                //if (DS.Tables[1].Rows[0].ItemArray[13].ToString() == "110")
                //{
                //    CellReport.Page.Start(config.TemplateSheet, config.TemplatePage);
                //    CellReport.Cell("**PAGE_1**").Value = "PAGE1";
                //    CellReport.Page.End();

                //    config.TemplateSheet="Sheet2";
                //    CellReport.Page.Start(config.TemplateSheet, config.TemplatePage);
                //    CellReport.Cell("**PAGE_2**").Value = "PAGE2";

                //    CellReport.Page.End();
                //    config.TemplateSheet = "Sheet3";
                //    CellReport.Page.Start(config.TemplateSheet, config.TemplatePage);
                //    CellReport.Cell("**PAGE_3**").Value = "PAGE3";

                //}

                #endregion

                // セルにマッピングを行う
                // putCell(DS, DS.Tables[0].Columns.Count, Convert.ToInt32(DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim()));
                #region report1
                if (DS.Tables[5].Rows[0].ItemArray[13].ToString() == "1")
                {
                    config.TemplateSheet = "鏡";
                    config.TemplatePage = "1";
                    CellReport.Page.Start(config.TemplateSheet, config.TemplatePage);

#pragma warning disable CS0219 // The variable 'iPageOption' is assigned but its value is never used
                    int iPageOption = 1;
#pragma warning restore CS0219 // The variable 'iPageOption' is assigned but its value is never used

                    string strInvoice_Month = DS.Tables[5].Rows[0].ItemArray[14].ToString();


                    CellReport.Cell("**TODAY**").Value = "発行日：平成" + Convert.ToString(Convert.ToInt32(System.DateTime.Now.Year.ToString().Substring(2, 2)) + 12) + "年" + System.DateTime.Now.Month.ToString().PadLeft(2, '0') + "月" + System.DateTime.Now.Day.ToString().PadLeft(2, '0') + "日";

                    //CellReport.Cell("**ETC_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[0].ToString());
                    //CellReport.Cell("**ETC_DISC_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[1].ToString());
                    //CellReport.Cell("**ETC_TOTAL_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[2].ToString());
                    //CellReport.Cell("**SKT_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[3].ToString());
                    //CellReport.Cell("**SKT_DISC_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[4].ToString());
                    //CellReport.Cell("**SKT_TOTAL_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[5].ToString());
                    //CellReport.Cell("**ETC_SKT_TOTAL_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[6].ToString());
                    //CellReport.Cell("**ETC_SKT_DISC_TOTAL_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[7].ToString());
                    //CellReport.Cell("**ETC_SKT_G_TOTAL_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[8].ToString());

                    //CellReport.Cell("**PREVIOUS_INV_AMNT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[9].ToString());
                    //CellReport.Cell("**PREVIOUS_PAYMENT**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[10].ToString());
                    //CellReport.Cell("**PREVIOUS_BALANCE**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[11].ToString());
                    //CellReport.Cell("**GRAND_TOTAL**").Value = stringToNumber(DS.Tables[5].Rows[0].ItemArray[12].ToString());

                    CellReport.Cell("**SELECTED_MONTH**").Value = Convert.ToString("平成" + Convert.ToString(Convert.ToInt32(DS.Tables[5].Rows[0].ItemArray[14].ToString().Substring(2, 2)) + 12) + "年" + Convert.ToString(Convert.ToInt32(DS.Tables[1].Rows[0].ItemArray[14].ToString().Substring(4, 2))).PadLeft(2, '0') + "月分の組合事業ご利用額を。");

                    CellReport.Cell("**INVOICE_NUMBER**").Value = "請求書No.：" + DS.Tables[5].Rows[0].ItemArray[17].ToString() + DS.Tables[5].Rows[0].ItemArray[15].ToString() + "-" + DS.Tables[5].Rows[0].ItemArray[14].ToString();
                    CellReport.Cell("**INVOICE_BRANCH**").Value = DS.Tables[5].Rows[0].ItemArray[17].ToString() + "-" + DS.Tables[5].Rows[0].ItemArray[15].ToString().Substring(0, 4) + "-" + DS.Tables[5].Rows[0].ItemArray[15].ToString().Substring(5, 4) + "-" + DS.Tables[5].Rows[0].ItemArray[15].ToString().Substring(8, 4);
                    CellReport.Cell("**CUSTOMER_NAME**").Value = DS.Tables[5].Rows[0].ItemArray[16].ToString() + "  御中";
                    CellReport.Cell("**ZIP**").Value = DS.Tables[5].Rows[0].ItemArray[18].ToString();
                    CellReport.Cell("**ADDRESS**").Value = DS.Tables[5].Rows[0].ItemArray[19].ToString();
                    CellReport.Cell("**BANK_NAME**").Value = DS.Tables[5].Rows[0].ItemArray[20].ToString();
                    CellReport.Cell("**BANK_BRANCH_NAME**").Value = DS.Tables[5].Rows[0].ItemArray[21].ToString();
                    CellReport.Cell("**TYPE_ACCOUNT_NO**").Value = DS.Tables[5].Rows[0].ItemArray[22].ToString();
                    CellReport.Cell("**ACCOUNT_NAME**").Value = DS.Tables[5].Rows[0].ItemArray[23].ToString();


                    //CellReport.Cell("**M_EXPR_TOLL_CHARGED**").Value = stringToNumber(DS.Tables[1].Rows[0].ItemArray[9].ToString());
                    //CellReport.Cell("**HAN_EXPR_TOLL_CHARGED**").Value = stringToNumber(DS.Tables[1].Rows[0].ItemArray[10].ToString());
                    //CellReport.Cell("**M_ROAD_TOLL_CHARGED**").Value = stringToNumber(DS.Tables[1].Rows[0].ItemArray[11].ToString());
                    //CellReport.Cell("**TOTAL_TOLL_CHARGED**").Value = stringToNumber(DS.Tables[1].Rows[0].ItemArray[12].ToString());
                    //平成30年1月分の組合事業ご利用額を



                    CellReport.Page.End();

                    config.TemplateSheet = "部署別カード利用額集計表";
                    config.TemplatePage = "1";
                    CellReport.Page.Start(config.TemplateSheet, config.TemplatePage);

                    CellReport.Page.End();
                }
                #endregion

                

                

                


                // ページ処理の終了
                CellReport.Page.End();
            }
            CellReport.Report.End();
            //config.CellReport.Report.SavePDF(Constants.Invoice_Output_Path + "\\" + config.SaveFileName + ".pdf");


            //config.CellReport.Report.SavePDF(Constants.Invoice_Output_Path + "\\" + "請求書No.：" + DS.Tables[6].Rows[0].ItemArray[0].ToString() + "-" + DS.Tables[5].Rows[0].ItemArray[14].ToString() + ".pdf");
        }

    }
}
