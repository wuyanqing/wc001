using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Control.Label
{
    public class Label : System.Windows.Forms.Label
    {
        public Label()
        {
            // 
            // TODO: 在此处添加构造函数逻辑 
            // 
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
        }


        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e)
        {
            Cursor.Current = Cursors.Default;
            Cursor.Current = Cursors.Hand;
            //System.Drawing.Font FS = new System.Drawing.Font(this.Font.FontFamily.Name, this.Font.Size, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font(this.Font.FontFamily.Name, this.Font.Size, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            //System.Drawing.Font aa = new System.Drawing.Font(this.Font.FontFamily.Name, this.Font.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Font = new System.Drawing.Font(this.Font.FontFamily.Name, this.Font.Size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            base.OnMouseLeave(e);
        }

        #region 私有变量
        private float _TScale = 0;
        private float _LScale = 0;
        #endregion

        #region 公共变量
        /// <summary>
        /// 控件对于top的比例
        /// </summary>
        [Description("控件对于top的比例.")]
        [Category("Appearance")]
        public float TScale { get { return _TScale; } set { _TScale = value; } }
        /// <summary>
        /// 控件对于left的比例
        /// </summary>
        [Description("控件对于left的比例.")]
        [Category("Appearance")]
        public float LScale { get { return _LScale; } set { _LScale = value; } }
        #endregion
    }
}
