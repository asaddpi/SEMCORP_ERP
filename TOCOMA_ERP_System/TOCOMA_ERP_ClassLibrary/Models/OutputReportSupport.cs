using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AdvanceSoftware.VBReport8;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public static class OutputReportSupport
    {
        public static ReportConfig GetReportConfig(PrintInformationOutputItem item)
        {
            return GetReportConfig(item.dataSet);
        }

        public static ReportConfig GetReportConfig2(ReportOutPutClass item)
        {
            return GetReportConfig(item.dataSet);
        }

        public static ReportConfig GetReportConfig(DataSet _DS)
        {
            ReportConfig config = new ReportConfig();

            config.CellReport = new CellReport();
            //switch (_DS)
            //{
            int TOTAL_PAGE = 0;
            if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "1")
            {
                if (_DS.Tables[0].Rows.Count > 0)
                {
                    TOTAL_PAGE = (int)((_DS.Tables[0].Rows.Count / 18) + 1);
                    //TOTAL_PAGE = (int)((dataTable.Rows.Count + 35 - 1) / 35);
                }
                // ご請求書
                config.TemplateFile = "Reports\\Sales_Report.xlsx";//Inspection_Report
                //config.SaveFileName = "リース期間満了のご案内" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1-" + Convert.ToString(TOTAL_PAGE);//"1-5";
                config.TemplateSheet = "Sales";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "2")
            {
                if (_DS.Tables[0].Rows.Count > 0)
                {
                    TOTAL_PAGE = (int)((_DS.Tables[0].Rows.Count / 5) + 1);
                    //TOTAL_PAGE = (int)((dataTable.Rows.Count + 35 - 1) / 35);
                }
                config.TemplateFile = "Reports\\Purchase_Report.xlsx";
                config.TemplatePage = "1-" + Convert.ToString(TOTAL_PAGE);//"1-5";
                config.TemplateSheet = "Purchase";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "3")
            {
                if (_DS.Tables[0].Rows.Count > 0)
                {
                    TOTAL_PAGE = (int)((_DS.Tables[0].Rows.Count / 5) + 1);
                    //TOTAL_PAGE = (int)((dataTable.Rows.Count + 35 - 1) / 35);
                }
                config.TemplateFile = "Reports\\Stock_Report.xlsx";
                config.TemplatePage = "1-" + Convert.ToString(TOTAL_PAGE);//"1-5";
                config.TemplateSheet = "Stock";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "4")
            {
                if (_DS.Tables[0].Rows.Count > 0)
                {
                    TOTAL_PAGE = (int)((_DS.Tables[0].Rows.Count / 5) + 1);
                    //TOTAL_PAGE = (int)((dataTable.Rows.Count + 35 - 1) / 35);
                }
                config.TemplateFile = "Reports\\Transaction_Report.xlsx";
                config.TemplatePage = "1-" + Convert.ToString(TOTAL_PAGE);//"1-5";
                config.TemplateSheet = "Transaction";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "5")
            {
                if (_DS.Tables[0].Rows.Count > 0)
                {
                    TOTAL_PAGE = (int)((_DS.Tables[0].Rows.Count / 5) + 1);
                    //TOTAL_PAGE = (int)((dataTable.Rows.Count + 35 - 1) / 35);
                }
                config.TemplateFile = "Reports\\Expenditure_Report.xlsx";
                config.TemplatePage = "1-" + Convert.ToString(TOTAL_PAGE);//"1-5";
                config.TemplateSheet = "Expenditure";
            }

            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "6") // Farmer Identity Report
            {
                if (_DS.Tables[0].Rows.Count > 0)
                {
                    TOTAL_PAGE = (int)((_DS.Tables[0].Rows.Count / 29));
                }
                config.TemplateFile = "Reports\\Farmer_Identification_information.xlsx";
                //config.SaveFileName = "リース物件返還先のご案内" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1-" + Convert.ToString(TOTAL_PAGE);
                config.TemplateSheet = "Farmer_Identity";
            }

            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "7")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\Seed_Sale_Receipt.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "Seed_Sale_Receipt";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "8")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\Service_Charge.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "Service_Charge";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "9")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\Lori_Chalan.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "LorryChallan";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "10")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\Collected_Seed_Receipt.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "CollectedSeed";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "11")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\CG_Form_25.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "CG25";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "12")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\Collection_Center_CG_form_20.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "CG20";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "13")
            {
                // 内容証明（NBリース契約）
                config.TemplateFile = "Reports\\Final_Report.xlsx";
                //config.SaveFileName = "内容証明" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1-2";
                config.TemplateSheet = "Final_Report";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "8")
            {
                // 督促通知
                config.TemplateFile = "支払依頼書.xlsx";
                //config.SaveFileName = "支払依頼書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "支払依頼書";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "9")
            {
                // 督促通知
                config.TemplateFile = "物件代金支払明細書_09.xlsx";
                //config.SaveFileName = "BPリース物件代金支払明細書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "BPリース物件代金支払明細書";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "10")
            {
                // 督促通知
                config.TemplateFile = "解約委任状_10.xlsx";
                //config.SaveFileName = "解約委任状" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "解約委任状";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "11")
            {
                // 督促通知
                config.TemplateFile = "契約内容開示書_11.xlsx";
                //config.SaveFileName = "契約内容開示書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "契約内容開示書";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "12")
            {
                // 督促通知
                config.TemplateFile = "解約申込書_12.xlsx";
                //config.SaveFileName = "解約申込書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "解約申込書";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "13")
            {
                // 督促通知
                config.TemplateFile = "請求書_13.xlsx";
                //config.SaveFileName = "請求書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "請求書";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "14")
            {
                // 督促通知
                config.TemplateFile = "請求書_14.xlsx";
                //config.SaveFileName = "請求書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "請求書";
            }
            else if (_DS.Tables[1].Rows[0].ItemArray[0].ToString().Trim() == "15")
            {
                // 督促通知
                config.TemplateFile = "物件返却依頼書_15.xlsx";
                //config.SaveFileName = "物件返却依頼書" + frmExpirYnReleasing.report_file_name;
                config.TemplatePage = "1";
                config.TemplateSheet = "物件返却依頼書";
            }

            return config;
        }
    }
}
