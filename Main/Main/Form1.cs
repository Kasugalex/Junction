using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Main
{
    public partial class Form1 : Form
    { 
        
        //无边框窗体Form
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        //隐藏输入框光标
        [DllImport("user32", EntryPoint = "HideCaret")]
        private static extern bool HideCaret(IntPtr hWnd);

        private void gPanelTitleBack_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            //移动无窗体控件
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MouseDown += new MouseEventHandler(this.gPanelTitleBack_MouseDown);
            GeneratePathUI(sender,e);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Junction(object sender, EventArgs e)
        {
            JunctionPath.Junction();
        }

        private void GeneratePathUI(object sender, EventArgs e)
        {
            if(Program.pathIndex >= 20)
            {
                MessageBox.Show("一次最多添加20个路径！","警告:",MessageBoxButtons.OK);
                return;
            }
            Continer.AutoScrollPosition = new Point(0, 0);
            PathUIGenerator pathUIGenerator = new PathUIGenerator(Continer);
            pathUIGenerator.startPath.GotFocus  += (s, a) => { HideCaret((s as TextBox).Handle); };
            pathUIGenerator.startPath.MouseDown += (s, a) => { HideCaret((s as TextBox).Handle); };
        }

        private void DeleteAllPath(object sender, EventArgs e)
        {
            Program.pathIndex = 0;
            Continer.Controls.Clear();
            PathUIGenerator pathUIGenerator = new PathUIGenerator(Continer);
        }
    }
}
