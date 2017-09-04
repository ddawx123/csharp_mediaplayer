using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class winForm : Form
    {
        public winForm()
        {
            InitializeComponent();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false; //禁止选择多个文件
            dialog.Title = "请选择需要播放的媒体文件"; //设置文件选择框标题
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file_path = dialog.FileName;
                if (MessageBox.Show("您确认要打开媒体文件：" + file_path, "操作确认", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    //MessageBox.Show("启动播放");
                    axWMP.URL = file_path;
                    //axWMP.openPlayer(file_path);
                }
                else
                {
                    file_path = "";
                }
            }
        }

        private void 关于AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 内容CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 索引IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 搜索SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 自定义CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 选项OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 撤消UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 重复RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 打印预览VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            breakOperate();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void breakOperate()
        {
            MessageBox.Show("开发中的功能，暂未开放。");
        }
    }
}
