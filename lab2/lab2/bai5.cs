using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab2
{
    public partial class bai5 : Form
    {
        public bai5()
        {
            InitializeComponent();
            ColumnHeader icon = new ColumnHeader();
            icon.Text = "";
            icon.Width = 20;
            icon.AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns.Add(icon);
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Name";
            columnHeader1.Width = 200; 
            columnHeader1.AutoResize(ColumnHeaderAutoResizeStyle.None); 
            listView1.Columns.Add(columnHeader1);

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Date modified";
            columnHeader2.Width = 150; 
            columnHeader2.AutoResize(ColumnHeaderAutoResizeStyle.None); 
            listView1.Columns.Add(columnHeader2);

            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Type";
            columnHeader3.Width = 150; 
            columnHeader3.AutoResize(ColumnHeaderAutoResizeStyle.None);
            listView1.Columns.Add(columnHeader3);

            ColumnHeader columnHeader4 = new ColumnHeader();
            columnHeader4.Text = "Size";
            columnHeader4.Width = 100; 
            columnHeader4.AutoResize(ColumnHeaderAutoResizeStyle.None); 
            listView1.Columns.Add(columnHeader4);
        }
        // use Window API to get file type
        static class NativeMethods
        {
            [StructLayout(LayoutKind.Sequential)]
            public struct SHFILEINFO
            {
                public IntPtr hIcon;
                public int iIcon;
                public uint dwAttributes;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
                public string szDisplayName;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
                public string szTypeName;
            };
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon
            public const uint FILE_ATTRIBUTE_NORMAL = 0x80;
            public const uint SHGFI_TYPENAME = 0x000000400;
            public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;


            [DllImport("C:\\Windows\\System32\\shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

            [DllImport("C:\\Windows\\System32\\user32.dll", SetLastError = true)]
            public static extern bool DestroyIcon(IntPtr hIcon);
            public static Icon GetFileIcon(string name, uint flags)
            {
                
                SHFILEINFO shfi = new SHFILEINFO();
                uint x = (uint)SHGetFileInfo(name,
                    FILE_ATTRIBUTE_NORMAL,
                    ref shfi,
                    (uint)System.Runtime.InteropServices.Marshal.SizeOf(shfi),
                    SHGFI_ICON | flags);
                Icon icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();
                DestroyIcon(shfi.hIcon);
                return icon;
                
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void display(string path)
        {
            listView1.Items.Clear();
            DirectoryInfo directInfo = new DirectoryInfo(path);
            FileInfo[] files = directInfo.GetFiles();
            DirectoryInfo[] directories = directInfo.GetDirectories("*");
            ImageList iconList = new ImageList();

            foreach (var dir in directories)
            {
                
                ListViewItem item = new ListViewItem();
                listView1.SmallImageList = iconList;
                item.ImageIndex = 0;
                item.SubItems.Add(dir.Name);
                item.SubItems.Add(dir.LastAccessTime.ToString());
                item.SubItems.Add("File folder");
                item.SubItems.Add("");
                try
                {
                    listView1.SmallImageList.Images.Add(NativeMethods.GetFileIcon(dir.FullName, NativeMethods.SHGFI_SMALLICON).ToBitmap());
                }
                catch
                {}
                //listView1.SmallImageList.Images.Add(NativeMethods.GetFileIcon(dir.FullName, NativeMethods.SHGFI_SMALLICON).ToBitmap());  
                item.ImageIndex = listView1.SmallImageList.Images.Count - 1;
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in files)
            {
                ListViewItem item = new ListViewItem();
                listView1.SmallImageList = iconList;
                item.ImageIndex = 0;
                item.SubItems.Add(file.Name);   
                item.SubItems.Add(file.LastAccessTime.ToString());
                // use Window API to get file type
                NativeMethods.SHFILEINFO info = new NativeMethods.SHFILEINFO();
                uint dwFileAttributes = NativeMethods.FILE_ATTRIBUTE_NORMAL;
                uint uFlags = (uint)(NativeMethods.SHGFI_TYPENAME | NativeMethods.SHGFI_USEFILEATTRIBUTES);
                NativeMethods.SHGetFileInfo(file.FullName, dwFileAttributes, ref info, (uint)Marshal.SizeOf(info), uFlags);
                item.SubItems.Add(info.szTypeName);

                BigInteger size = file.Length;
                size = size / 1024;
                item.SubItems.Add(size.ToString() + "KB");
                try
                {
                    listView1.SmallImageList.Images.Add(NativeMethods.GetFileIcon(file.FullName, NativeMethods.SHGFI_SMALLICON).ToBitmap());
                }
                catch { }

                item.ImageIndex = listView1.SmallImageList.Images.Count - 1;
                listView1.Items.Add(item);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            if (browser.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = browser.SelectedPath;
                display(browser.SelectedPath);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = textBox1.Text;
                string parentPath = Directory.GetParent(path).FullName;
                textBox1.Text = parentPath;
                display(parentPath);
            }
            catch
            {
                return;
            }
        }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            string type = item.SubItems[3].Text;
            string path = textBox1.Text + "\\" + item.SubItems[1].Text;
            if (type == "File folder")
            {
                display(path);
                textBox1.Text = path;
            }
            else
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
