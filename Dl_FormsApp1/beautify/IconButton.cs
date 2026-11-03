using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Dl_FormsApp1.beautify {
    /// <summary>
    /// 图标+文字整体居中的按钮控件
    /// 用法：把按钮拖到窗体后，把类型换成 IconButton；或直接代码 new IconButton()
    /// </summary>
    public class IconButton : Button {
        private int _gap = 6;   // 图标和文字之间的间距(px)

        /// <summary>
        /// 图片和文字之间的间距，默认6
        /// </summary>
        public int ImageTextGap
        {
            get { return _gap; }
            set { _gap = value; Invalidate(); }
        }

        public IconButton()
        {
            // 默认去掉按钮自带的浮雕边框，更干净
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Graphics g = pevent.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 1. 画按钮背景（不调用 base.OnPaint，避免默认逻辑干扰）
            if (Enabled)
                g.FillRectangle(new SolidBrush(BackColor), ClientRectangle);
            else
                g.FillRectangle(new SolidBrush(Color.FromArgb(210, 210, 210)), ClientRectangle);

            // 2. 计算图标和文字的整体宽度
            System.Drawing.Image img = Image;
            Size textSize = TextRenderer.MeasureText(Text, Font);

            int iconW = img != null ? img.Width : 0;
            int iconH = img != null ? img.Height : 0;
            int totalW = iconW + (img != null ? _gap : 0) + textSize.Width;

            // 3. 整体水平居中
            int startX = (ClientSize.Width - totalW) / 2;
            int startY = (ClientSize.Height - Math.Max(iconH, textSize.Height)) / 2;

            // 4. 画图标（垂直居中）
            if (img != null)
            {
                int imgX = startX;
                int imgY = startY + (Math.Max(iconH, textSize.Height) - iconH) / 2;
                g.DrawImage(img, new Rectangle(imgX, imgY, iconW, iconH));
                startX += iconW + _gap;
            }

            // 5. 画文字（垂直居中）
            int textY = startY + (Math.Max(iconH, textSize.Height) - textSize.Height) / 2;
            TextRenderer.DrawText(g, Text, Font,
                new Point(startX, textY),
                ForeColor, TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix);
        }
    }
}
