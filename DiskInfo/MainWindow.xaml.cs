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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiskInfo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string disk = textBox.Text.ToString();
            ShowDiskInfo(disk);
        }

        private void ShowDiskInfo(string disk)
        {
            try
            {
                DriveInfo drive = new DriveInfo(disk);
                String allInfo = disk + " 盘的的详细信息:\r\n" + "空间总量为:" + drive.TotalSize + "bit" + "\r\n可用空间为：" + drive.TotalFreeSpace + "bit" + "\r\n文件系统名称为：" + drive.DriveFormat + "\r\n驱动类型为：" + drive.DriveType + "\r\n驱动器的根目录为： " + drive.RootDirectory;
                diskInfoBlock.Text = allInfo;
            }
            catch(Exception e)
            {
                MessageBox.Show("磁盘信息查询出错，错误信息为:" + e.Message + "请输入正确磁盘盘符。");
            }
            

        }
    }
}
