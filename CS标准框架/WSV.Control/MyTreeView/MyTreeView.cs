using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace WSV.Control.MyTreeView
{
    public class MyTreeView:TreeView
    {
        private object _SelectTag;
        private string _SelectValues,_SelectNodesValue;
        //要选定的节点的值
        public string SelectNodesValue
        {
            get { return _SelectNodesValue; }
            set { _SelectNodesValue = value; }
        }
        // 节点收缩后
        private void MyTreeView_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
            e.Node.SelectedImageIndex = 0;
        }
        // 节点展开后
        private void MyTreeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
            e.Node.SelectedImageIndex = 1;
        }
        // 节点选中后
        private void MyTreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode Node in e.Node.Nodes)
            {
                Node.Checked = e.Node.Checked;
            }
        }
        /// <summary>
        /// 给树绑定数据
        /// </summary>
        public void Binding(ref DataSet ds, string Foot)
        {
            this.Nodes.Clear();
            Binding(ref ds, Foot, null);
        }
        /// <summary>
        /// 给树绑定数据
        /// </summary>
        public void Binding(ref DataSet ds, string Foot, TreeNode ParentNode)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(236, 233, 216);
            ImageList ImgList = new ImageList();
            ImgList.Images.Add(global::WSV.Control.Properties.Resources.CollapsedFolder);
            ImgList.Images.Add(global::WSV.Control.Properties.Resources.ExpandedFolder);
            ImgList.Images.Add(global::WSV.Control.Properties.Resources.FeedTree);
            ImgList.Images.SetKeyName(0, "CollapsedFolder.ico");
            ImgList.Images.SetKeyName(1, "ExpandedFolder.ico");
            ImgList.Images.SetKeyName(2, "FeedTree.ico");
            this.ImageList = ImgList;
            this.AfterCollapse += new TreeViewEventHandler(MyTreeView_AfterCollapse);
            this.AfterExpand += new TreeViewEventHandler(MyTreeView_AfterExpand);
            this.AfterCheck += new TreeViewEventHandler(MyTreeView_AfterCheck);
            if (this.SelectedNode != null)
            {
                this._SelectTag = this.SelectedNode.Tag;
            }
            this.Nodes.Clear();

            if (ParentNode != null) { this.Nodes.Add(ParentNode); }
            DataBinding(ref ds, Foot, ParentNode);
            if (this.SelectedNode == null)
            {
                if (ParentNode != null) { this.SelectedNode = ParentNode; }
                else if (this.Nodes.Count > 0) { this.SelectedNode = this.Nodes[0]; }
            }
            this.SelectedNode.Expand();
        }
        private void DataBinding(ref DataSet ds, string Foot, TreeNode ParentNode)
        {
            DataTable dt = ds.Tables[0];
            string Filter = "";
            if (ParentNode == null) { Filter = "" + Foot + "='0'"; }
            else { Filter = "" + Foot + "='" + ParentNode.Tag + "'"; }
            DataRow[] RowList = dt.Select(Filter);
            foreach (DataRow dr in RowList)
            {
                TreeNode Node = new TreeNode();
                Node.Tag = dr[0].ToString();
                Node.Text = dr[1].ToString();
                if (!string.IsNullOrEmpty(_SelectNodesValue))
                {
                    ArrayList SelectList = ArrayList.Adapter(_SelectNodesValue.Split(','));
                    if (SelectList.Contains(Node.Tag))
                    {
                        Node.Checked = true;
                    }
                }
                if (dt.Select("" + Foot + "='" + dr[0] + "'").Length == 0)
                {
                    Node.ImageIndex = 2;
                    Node.SelectedImageIndex = 2;
                }
                if (ParentNode == null) { this.Nodes.Add(Node); }
                else { ParentNode.Nodes.Add(Node); }
                if (_SelectTag != null)
                {
                    if (_SelectTag.ToString() == Node.Tag.ToString()) { this.SelectedNode = Node; }
                }
                DataBinding(ref ds, Foot, Node);//递归调用，创建其他节点
            }
        }
        private void GetCheckNodes(TreeNodeCollection Nodes)
        {
            foreach (TreeNode Node in Nodes)
            {
                if (Node.Checked && Node.Nodes.Count == 0)
                {
                    _SelectValues += "," + Node.Tag;
                }
                if (Node.Nodes.Count > 0) { GetCheckNodes(Node.Nodes); }
            }
        }
        /// <summary>
        /// 获取选定的所有值
        /// </summary>
        public string SelectValues
        {
            get
            {
                _SelectValues = "";
                GetCheckNodes(this.Nodes);
                if (!string.IsNullOrEmpty(_SelectValues)){_SelectValues=_SelectValues.Substring(1);}
                return _SelectValues;
            }
        }
    }
}
