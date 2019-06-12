using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Main
{
    class JunctionPath
    {
        public static void Junction()
        {
            Dictionary<string, string> paths = new Dictionary<string, string>();
            foreach (var basePanel in Program.panels)
            {
                string startPath = basePanel.Controls.Find("StartPath", false)[0].Text;
                string endPath = basePanel.Controls.Find("EndPath", false)[0].Text;
                if (string.IsNullOrEmpty(endPath))
                {
                    MessageBox.Show("源路径或目标路径不能为空！", "错误：");
                    return;
                }

                if (Directory.Exists(endPath))
                {
                    MessageBox.Show(string.Format("\"{0}\"路径已存在！链接已终止,请删除该目录后重新链接！", endPath), "错误：");
                    return;
                }

                if (!Directory.Exists(startPath))
                {
                    MessageBox.Show(string.Format("\"{0}\"路径不存在！链接已终止,请确认目录后重新链接！", startPath), "错误：");
                    return;
                }

                if (paths.ContainsValue(endPath))
                {
                    MessageBox.Show(string.Format("\"{0}\"路径已被填入！请输入新的目录！", endPath), "错误：");
                    return;
                }

                paths.Add(endPath, startPath);
            }

            WindowsJunction(paths);

        }

        private static void WindowsJunction(Dictionary<string, string> paths)
        {
            string Title = "rem mklink";
            string Templete = "mklink /j \"{0}\" \"{1}\"";

            //结尾加入删除自身的语句
            string deleteStr = @"del /f /s /q .\tmpJunction.bat";

            string dir = @".\";
            string fileName = "tmpJunction.bat";
            string tmpPath = dir + fileName;

            using (FileStream stream = new FileStream(tmpPath, FileMode.Append, FileAccess.Write))
            {
                StreamWriter writer = new StreamWriter(stream);

                writer.WriteLine(Title);

                foreach (var item in paths)
                {
                    string context = string.Format(Templete, item.Key, item.Value);
                    writer.WriteLine(context);
                }

                writer.WriteLine(deleteStr);
                writer.Flush();
            }

            string saveTxt = @".\HistroyJunction.txt";
            string saveTemplete = "链接起点:{0}    链接终点:{1}    链接时间:{2}";
            using (FileStream stream = new FileStream(saveTxt, FileMode.Append, FileAccess.Write))
            {
                StreamWriter writer = new StreamWriter(stream);

                //writer.WriteLine("链接历史记录：");

                foreach (var item in paths)
                {
                    string context = string.Format(saveTemplete, item.Value, item.Key, DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss"));
                    writer.WriteLine(context);
                }
                writer.Flush();
            }

            Process process = new Process();
            process.StartInfo.WorkingDirectory = dir;
            process.StartInfo.FileName = fileName;
            process.StartInfo.UseShellExecute = true;
            process.Start();

            MessageBox.Show("链接成功！");
        }

    }
}
