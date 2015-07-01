using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using WSV.Control.MyListItem;

namespace WSV.Control.MyListBox
{
    //自定义ListBox
    public class MyListBox : ListBox
    {
        public MyListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DrawItem += new DrawItemEventHandler(ListBoxDrawItem);
            this.ItemHeight = 25;
        }
        private DataSet _dataset = null;
        /// <summary>
        /// 设置数据源
        /// </summary>
        public DataSet dataset
        {
            set { _dataset = value; }
        }

        private string _text;
        /// <summary>
        /// 设置加载数据第一列名称,默认为第一列索引
        /// </summary>
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

        private string _value;
        /// <summary>
        /// 设置加载数据第二列名称,默认为第二列索引
        /// </summary>
        public string value
        {
            get { return _value; }
            set { _value = value; }

        }
        /// <summary>
        ///  获取或设置 MyListBox 中当前选定的项
        /// </summary>
        public new ListItem SelectedItem
        {
            get
            {
                ListItem item = null;
                int n = this.SelectedIndex;
                if (n != -1) { item = this.Items[n]; }
                return item;
            }
        }
        public object SelectedText
        {
            get
            {
                ListItem item = this.SelectedItem;
                return item != null ? item.text : "";
            }
        }
        public new object SelectedValue
        {
            get
            {
                ListItem item = this.SelectedItem;
                return item != null ? item.value : "";
            }
        }
        /// <summary>
        ///  根据值选中MyListBox中的项
        /// </summary>
        public void SelectedByValue(object value)
        {
            this.SelectedIndex = this.Items[value];
        }
        /// <summary>
        ///  返回MyListBox中的所有值
        /// </summary>
        public string AllValue
        {
            get
            {
                string Nid = "";
                for (int i = 0; i < this.Items.Count; i++)
                {
                    Nid += "," + this.Items[i].value;
                }
                if (!string.IsNullOrEmpty(Nid)) { Nid = Nid.Substring(1); }
                return Nid;
            }
        }
        /// <summary>
        ///  给MyListBox添加一个集合
        /// </summary>
        private ListBoxItems _Items;
        /// <summary>
        /// 取得项目集合
        /// </summary>
        public new ListBoxItems Items
        {
            get
            {
                if (_Items == null) { _Items = new ListBoxItems(this); }
                return _Items;
            }
        }
        /// <summary>
        ///  执行加载ListBox信息方法
        /// </summary>
        public new void DataBindings()
        {
            Binding();
        }
        /// <summary>
        ///  执行加载ListBox信息方法，默认第一列是文本，第二列是值
        /// </summary>
        /// <param name="dataSet">设置数据源</param>
        public new void DataBindings(DataSet dataset)
        {
            this._dataset = dataset;
            Binding();
        }
        /// <summary>
        ///  执行加载ListBox信息方法
        /// </summary>
        /// <param name="dataset">数据集</param>
        /// <param name="columnNameOne">键名称</param>
        /// <param name="columnNameTwo">键值</param>
        public new void DataBindings(DataSet dataset, string text, string value)
        {
            this._dataset = dataset;
            this._text = text;
            this._value = value;
            Binding();
        }
        /// <summary>
        /// 绑定数据项
        /// </summary>
        private void Binding()
        {
            if (_dataset == null) { return; }
            if (_dataset.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in _dataset.Tables[0].Rows)
                {
                    object row1 = null, row2 = null;
                    if (string.IsNullOrEmpty(text)) { row1 = row[0]; }
                    else { row1 = row[text]; }

                    if (string.IsNullOrEmpty(value)) { row2 = row[1]; }
                    else { row2 = row[value]; }
                    Items.Add(row1, row2);
                }
            }
        }
        private void ListBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            MyListBox Obj = ((MyListBox)sender);
            if (Obj.Items.Count == 0) { return; }
            int index = e.Index;//获取当前要进行绘制的行的序号，从0开始。
            Graphics g = e.Graphics;//获取Graphics对象。
            Rectangle bound = e.Bounds;//获取当前要绘制的行的一个矩形范围。
            string text = " " + Obj.Items[index].text.ToString();//获取当前要绘制的行的显示文本。

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                //如果当前行为选中行。
                //绘制选中时要显示的蓝色边框。
                g.DrawRectangle(Pens.Blue, bound.Left, bound.Top, bound.Width - 1, bound.Height - 1);
                Rectangle rect = new Rectangle(bound.Left + 2, bound.Top + 2, bound.Width - 4, bound.Height - 4);
                //绘制选中时要显示的蓝色背景。
                g.FillRectangle(Brushes.Blue, rect);
                //绘制显示文本。
                TextRenderer.DrawText(g, text, this.Font, rect, Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
            else
            {
                //GetBrush为自定义方法，根据当前的行号来选择Brush进行绘制。
                using (Brush brush = GetBrush(index))
                {
                    g.FillRectangle(brush, bound);//绘制背景色。
                }
                TextRenderer.DrawText(g, text, this.Font, bound, Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }
        private Brush GetBrush(int index)
        {
            Brush brush;
            if (index % 2 == 0) { brush = new SolidBrush(Color.LightGray); }
            else { brush = new SolidBrush(Color.White); }
            return brush;
        }
    }
    // 代表 ListBoxItems 中项的集合
    public class ListBoxItems : List<ListItem>
    {
        private ListBox owner;
        /// <summary>
        /// 初始化ItemsCollection的新实例
        /// </summary>
        /// <param name="owner">拥有该对象集合的 System.Windows.Forms.ListBox</param>
        public ListBoxItems() { }
        public ListBoxItems(ListBox owner)
        {
            this.owner = owner;
        }
        /// <summary>
        /// 向任务集中增加一个ListItem对象
        /// </summary>
        /// <param name="ListItem">ListItem对象</param>
        public new void Add(ListItem Item)
        {
            if (this[Item.value] == -1)
            {
                this.owner.Items.Add(Item.text);
                base.Add(Item);
            }
            if (this.owner.Items.Count > 0) { this.owner.SelectedIndex = 0; }
        }
        public void AddAt(ListItem Item, int index)
        {
            if (this[Item.value] == -1)
            {
                this.owner.Items.Insert(index, Item.text);
                base.Insert(index, Item);
                if (this.owner.Items.Count > 0) { this.owner.SelectedIndex = 0; }
            }
        }
        /// <summary>
        /// 向任务集中增加一个ListItem对象
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="item">值</param>
        public void Add(object key, object value)
        {
            ListItem Item = new ListItem(key, value);
            this.Add(Item);
        }
        public void AddAt(object key, object value, int index)
        {
            ListItem Item = new ListItem(key, value);
            this.AddAt(Item, index);
        }
        /// <summary>
        /// 向任务集中增加一个ListItem对象数组
        /// </summary>
        /// <param name="ListItem">ListItem对象数组</param>
        public void AddRange(ListItem[] Item)
        {
            if (Item == null) { return; }
            if (Item.Length <= 0) { return; }
            for (int i = 0; i < Item.Length; i++)
            {
                this.Add(Item[i]);
            }
        }
        /// <summary>
        /// 向任务集中增加一个ListItem对象数组
        /// </summary>
        /// <param name="key">键数组</param>
        /// <param name="item">值数组</param>
        public void AddRange(object[] _key, object[] value)
        {
            if (_key == null || value == null) { return; }
            if (_key.Length <= 0 || value.Length <= 0) { return; }
            if (_key.Length != value.Length) { return; }
            for (int i = 0; i < _key.Length; i++)
            {
                this.Add(_key[i], value[i]);
            }
        }
        /// <summary>
        /// 从 MyListBox 中移除所有项
        /// </summary>
        public new void Clear()
        {
            this.owner.Items.Clear();
            base.Clear();
        }
        /// <summary>
        /// 检索指定的项在集合中的索引
        /// </summary>
        /// <param name="value">一个对象，它表示要在集合中查找的项</param>
        /// <returns>项在集合内从零开始的索引；否则为 -1</returns>
        public new int IndexOf(ListItem item)
        {
            if (item == null) { return -1; }
            return base.IndexOf(item);
        }
        /// <summary>
        /// 移除 MyListBox 中指定索引处的项
        /// </summary>
        /// <param name="value">要移除的项的索引</param>
        public new void RemoveAt(int index)
        {
            if (this.owner == null) { return; }
            if (this.owner.Items.Count <= 0) { return; }
            if ((index < 0) || (index >= this.Count)) { return; }
            this.owner.Items.RemoveAt(index);
            base.RemoveAt(index);
        }
        /// <summary>
        /// 从 ListItem 中移除指定的项
        /// </summary>
        /// <param name="index">要从列表移除的 ListItem</param>
        public new void Remove(ListItem Item)
        {
            int index = this.IndexOf(Item);
            if (index != -1) { this.RemoveAt(index); }
        }

        public new ListItem this[int index]
        {
            set { base[index] = value; }
            get { return base[index]; }
        }
        public int this[object value]
        {
            get
            {
                int index = -1;
                for (int i = 0; i < this.Count; i++)
                {
                    if (this[i].value.ToString() == value.ToString())
                    {
                        index = i;
                        break;
                    }
                }
                return index;
            }
        }
    }
}
