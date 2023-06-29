
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TensorRTSharp;

namespace ModelEngineConvert
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Nvinfer nvinfer = new Nvinfer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBestPt_Click(object sender, RoutedEventArgs e)
        {
           
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter = "onnx|*.onnx;";
            opnDlg.Title = "Open 权重文件";
            opnDlg.ShowHelp = false;
            opnDlg.Multiselect = false;

            if (opnDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              
                txtWightPath.Text = opnDlg.FileName;

                string onnxpath = txtWightPath.Text;

                txtExportPath.Text= onnxpath.Substring(0,onnxpath.LastIndexOf("\\"));

            }
        }

        private void btnFolderBrowser2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog FBD = new System.Windows.Forms.FolderBrowserDialog();
            FBD.Description = "请选择目录";
            if (FBD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtExportPath.Text = FBD.SelectedPath;
            }
        }

        private void miOpenTxtDir_Click(object sender, RoutedEventArgs e)
        {
            if (sender == null)
                return;
            System.Windows.Controls.MenuItem mi = sender as System.Windows.Controls.MenuItem;
            var cm = mi.Parent as System.Windows.Controls.ContextMenu;
            var txt = cm.PlacementTarget as System.Windows.Controls.TextBox;
            if (txt != null)
            {
                //My.Util.OpenDirectory.Open(txt.Text);
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            string onnxpath = txtWightPath.Text;
            //获取文件名称
            string onnxName = onnxpath.Substring(onnxpath.LastIndexOf("\\")+1);
            string enginepath = string.Format("{0}\\{1}", txtExportPath.Text, onnxName.Replace(".onnx", ".engine"));

            Nvinfer.onnx_to_engine(onnxpath, enginepath, AccuracyFlag.kFP16);
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
