using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    class PathUIGenerator
    {
        private Control root;
        public PathUIGenerator(Control root)
        {
            this.root = root;
            //超过13就要生成滑动条了
            int index = ++Program.pathIndex;
            Label startLabel = new Label()
            {
                AutoSize = false,
                Location = new Point(20, 72 + (index - 1) * 35),
                Text = "源路径:",
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(82, 27),
                Font = new Font("微软雅黑",12)

            };

            TextBox startPath = new TextBox()
            {
                Location = new Point(startLabel.Location.X + startLabel.Size.Width + 5 ,startLabel.Location.Y + 5),
                Size = new Size(244, 21)
            };

            PictureBox addIcon1 = new PictureBox()
            {
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Add"),
                Size = new Size(25, 25),
                Location = new Point(startPath.Location.X + startPath.Size.Width + 6,startPath.Location.Y - 4)
            };
            addIcon1.MouseClick += (s, e) =>
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择路径";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    startPath.Text = dialog.SelectedPath;
                }
            };
            AddToRoot(startPath);
            AddToRoot(startLabel);
            AddToRoot(addIcon1);

            Label endLabel = new Label()
            {
                AutoSize = false,
                Location = new Point(addIcon1.Location.X + addIcon1.Size.Width + 50, startLabel.Location.Y),
                Text = "目标路径:",
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(82, 27),
                Font = new Font("微软雅黑", 12)

            };

            TextBox endPath = new TextBox()
            {
                Location = new Point(endLabel.Location.X + endLabel.Size.Width + 5, endLabel.Location.Y + 5),
                Size = new Size(244, 21)
            };

            PictureBox addIcon2 = new PictureBox()
            {
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Add"),
                Size = new Size(25, 25),
                Location = new Point(endPath.Location.X + endPath.Size.Width + 6, endPath.Location.Y - 4)
            };

            addIcon2.MouseClick += (s, e) =>
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择路径";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    endPath.Text = dialog.SelectedPath;
                }
            };
            AddToRoot(endPath);
            AddToRoot(endLabel);
            AddToRoot(addIcon2);

            Console.WriteLine("OK");

        }

        private void AddToRoot(Control f)
        {
            root.Controls.Add(f);
        }

    }
}
