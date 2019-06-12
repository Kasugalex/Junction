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

        private Panel basePanel;

        private Label startLabel;
        public  TextBox startPath;
        private PictureBox addIcon1;
        private Label endLabel;
        private TextBox endPath;
        private PictureBox deleteIcon;

        public PathUIGenerator(Control root)
        {
            this.root = root;

            //超过13就要生成滑动条了
            int index = ++Program.pathIndex;

            basePanel = new Panel()
            {
                AutoSize = false,
                BackColor = Color.Transparent,
                Location = new Point(0, 5 + (index - 1) * 35),
                Size = new Size(root.Width,40)
            };

            startLabel = new Label()
            {
                AutoSize = false,
                Location = new Point(20, 5),
                Text = "源路径:",
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(82, 27),
                Font = new Font("微软雅黑",12)

            };

            startPath = new TextBox()
            {
                Name = "StartPath",
                Location = new Point(startLabel.Location.X + startLabel.Size.Width + 5, startLabel.Location.Y + 5),
                Size = new Size(244, 21),
                ReadOnly = true
            };

            addIcon1 = new PictureBox()
            {
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Add"),
                Size = new Size(25, 25),
                Location = new Point(startPath.Location.X + startPath.Size.Width + 6,startPath.Location.Y - 4),
                Cursor = Cursors.Hand
            };
            addIcon1.MouseClick += (s, e) =>
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择路径";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;

                    startPath.Text = path;

                    string targetPath = endPath.Text;
                }
            };

            deleteIcon = new PictureBox()
            {
                BackgroundImageLayout = ImageLayout.Zoom,
                BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Delete"),
                Size = new Size(21, 21),
                Location = new Point(12, startPath.Location.Y - 2),
                Cursor = Cursors.Hand
            };

            endLabel = new Label()
            {
                AutoSize = false,
                Location = new Point(addIcon1.Location.X + addIcon1.Size.Width + 75, startLabel.Location.Y),
                Text = "目标路径:",
                TextAlign = ContentAlignment.MiddleRight,
                Size = new Size(82, 27),
                Font = new Font("微软雅黑", 12)

            };

            endPath = new TextBox()
            {
                Name = "EndPath",
                Location = new Point(endLabel.Location.X + endLabel.Size.Width + 5, endLabel.Location.Y + 5),
                Size = new Size(244, 21)
            };

            AddToRoot(deleteIcon);
            AddToRoot(startPath);
            AddToRoot(startLabel);
            AddToRoot(addIcon1);
            AddToRoot(endPath);
            AddToRoot(endLabel);


            deleteIcon.MouseClick += (e, a) =>
            {
                root.Controls.Remove(basePanel);
                Program.pathIndex--;

                List<Control> panels = Program.panels;
                panels.Remove(basePanel);

                int sort = 1;
                //刷新UI
                foreach (var panel in panels)
                {
                    panel.Location = new Point(0, 5 + (sort - 1) * 35);
                    sort++;
                }
            };

            root.Controls.Add(basePanel);

            Program.panels.Add(basePanel);
        }

        private void AddToRoot(Control f)
        {
            basePanel.Controls.Add(f);
        }

    }
}
