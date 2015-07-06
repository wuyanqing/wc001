using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace Control.PowerTreeView
{
    public class PowerTreeView : System.Windows.Forms.TreeView
    {
        public PowerTreeView()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.CheckBoxes = true;
        }
        //选定内容改变时
        protected override void OnAfterSelect(TreeViewEventArgs e)
        {
            string s = "";
            s = e.Node.Text.Remove(0, e.Node.Text.IndexOf("]", 0) + 1);
            m_SelectText = s;
            base.OnAfterSelect(e);

        }
        //选中节点复选框发生
        protected override void OnBeforeCheck(TreeViewCancelEventArgs e)
        {
            SelectAllNodes(e.Node.Nodes, e.Node.Checked);
            base.OnBeforeCheck(e);
        }
        private string m_SelectText = "";
        public string SelectText { get { return m_SelectText; } set { m_SelectText = value; } }

        private DataSet ds;
        public DataSet DataSet { get { return ds; } set { ds = value; RootNode((TreeNode)null); } }

        //private int len = 2;
        public void RootNode(TreeNode pNode)
        {
            if (ds == null)
                return;
            DataView dvTree = new DataView(ds.Tables[0]);
            //dvTree.RowFilter = "len(Code)=" + len.ToString();
            dvTree.RowFilter = "Parent_Code=0";//Rank=1";
            foreach (DataRowView Row in dvTree)
            {
                TreeNode Node = this.Nodes.Add(Row["Code"].ToString(), "[" + Row["Code"].ToString() + "]" + Row["Name"].ToString(), 1);
                //AddNode(Node, len);
                AddNode(Node);
            }
            this.ExpandAll();
            if (m_SelectName.Trim() == "")
                return;
            foreach (TreeNode nt in this.Nodes)
            {
                if (nt.Name == SelectStringByLen(2))
                {
                    this.SelectedNode = nt;
                    if (m_SelectName.Length > 2)
                        Select(nt);
                    return;
                }

            }

        }
        //public void AddNode(TreeNode pNode, int len)
        //{           
        //    //len = len + 2;
        //    DataView dvTree = new DataView(ds.Tables[0]);
        //    //dvTree.RowFilter = "len(Code)=" + len.ToString() + "and Code like '" + pNode.Name + "%'";
        //    dvTree.RowFilter = "Parent_Code=" + pNode.Name; ;
        //    foreach (DataRowView Row in dvTree)
        //    {
        //        TreeNode Node = pNode.Nodes.Add(Row["Code"].ToString(), "[" + Row["Code"].ToString() + "]" + Row["Name"].ToString(), 0);
        //        AddNode(Node, len);
        //    }
        //}
        public void AddNode(TreeNode pNode)
        {
            //len = len + 2;
            DataView dvTree = new DataView(ds.Tables[0]);
            //dvTree.RowFilter = "len(Code)=" + len.ToString() + "and Code like '" + pNode.Name + "%'";
            dvTree.RowFilter = "Parent_Code='" + pNode.Name + "'";
            foreach (DataRowView Row in dvTree)
            {
                TreeNode Node = pNode.Nodes.Add(Row["Code"].ToString(), "[" + Row["Code"].ToString() + "]" + Row["Name"].ToString(), 1);
                AddNode(Node);
            }
        }

        private void Select(TreeNode Ptn)
        {
            foreach (TreeNode tn in Ptn.Nodes)
            {
                if (tn.Name == m_SelectName.Substring(0, SelectLen))
                {

                    this.SelectedNode = tn;
                    if (SelectLen == m_SelectName.Length)
                        return;
                    SelectLen = SelectLen + 2;
                    Select(tn);

                }
            }
        }
        int SelectLen = 4;
        private string SelectStringByLen(int myLen)
        {
            return m_SelectName.Substring(0, myLen);
        }
        /// <summary>
        /// 根据获得的SelecName选中节点
        /// </summary>
        private string m_SelectName = "";
        public string SelectName
        {
            get { return m_SelectName; }
            set { if ((value.Length % 2) != 0) { m_SelectName = ""; } else { m_SelectName = value; } }
        }

        private void SelectAllNodes(TreeNodeCollection Nds, bool Selected)
        {
            foreach (TreeNode node in Nds)
            {
                if (node.Checked == Selected)
                {
                    node.Checked = !Selected;
                }
                SelectAllNodes(node.Nodes, Selected);
            }
        }
        //private void Btn_SelectAll_Click(object sender, System.EventArgs e)
        //{
        //    SelectAllNodes(TreeView1.Nodes, false);
        //}
    }
}
