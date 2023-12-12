using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvanceSoftware.VBReport8;

namespace TOCOMA_ERP_ClassLibrary.Models
{
    public class ReportConfig
    {
        // レポートオブジェクト
        private CellReport _CellReport;
        // テンプレートファイルのファイル名
        private string _TemplateFile;
        // テンプレートシート名
        private string _TemplateSheet;
        // テンプレートシートのページ数
        private string _TemplatePage;
        // 保存ファイル名
        private string _SaveFileName;
        // ヘッダーを開始する行番号
        private int _StartHeaderCol;
        // ヘッダーを終了する行番号
        private int _EndHeaderCol;
        // 繰り返す明細の行番号
        private int _RepeatCol;
        // 繰り返す明細の列数
        private int _RepeatRowNum;

        /// <summary>
        /// レポートオブジェクト
        /// 
        /// </summary>
        public CellReport CellReport
        {
            get { return _CellReport; }
            set { _CellReport = value; }
        }

        /// <summary>
        /// テンプレートファイルのファイル名
        /// 
        /// </summary>
        public string TemplateFile
        {
            get { return _TemplateFile; }
            set { _TemplateFile = value; }
        }

        /// <summary>
        /// テンプレートファイルのファイル名
        /// 
        /// </summary>
        public string TemplateSheet
        {
            get { return _TemplateSheet; }
            set { _TemplateSheet = value; }
        }

        /// <summary>
        /// テンプレートシートのページ数
        /// 明細を繰り返す場合は「1-99999」を設定
        /// それ以外の場合は、テンプレートシートの
        /// ページ数を設定
        /// 
        /// </summary>
        public string TemplatePage
        {
            get { return _TemplatePage; }
            set { _TemplatePage = value; }
        }

        /// <summary>
        /// 保存ファイル名
        /// 
        /// </summary>
        public string SaveFileName
        {
            get { return _SaveFileName; }
            set { _SaveFileName = value; }
        }

        /// <summary>
        // ヘッダーを開始する行番号
        /// 
        /// </summary>
        public int StartHeaderCol
        {
            get { return _StartHeaderCol; }
            set { _StartHeaderCol = value; }
        }

        /// <summary>
        // ヘッダーを終了する行番号
        /// 
        /// </summary>
        public int EndHeaderCol
        {
            get { return _EndHeaderCol; }
            set { _EndHeaderCol = value; }
        }

        /// <summary>
        // 繰り返す明細の行番号
        /// 
        /// </summary>
        public int RepeatCol
        {
            get { return _RepeatCol; }
            set { _RepeatCol = value; }
        }

        /// <summary>
        // 繰り返す明細の列数
        /// 
        /// </summary>
        public int RepeatRowNum
        {
            get { return _RepeatRowNum; }
            set { _RepeatRowNum = value; }
        }
    }
}
