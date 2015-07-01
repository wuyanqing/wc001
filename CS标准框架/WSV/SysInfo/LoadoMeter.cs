using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WSV.BaseClass;
using WSV.Model.SysInfo;
using WSV.BLL.SysInfo;

namespace WSV.SysInfo
{
    public partial class LoadoMeter : Form
    {
        private string My_RunCode = "";//操作日志编号
        private long Id;
        public LoadoMeter()
        {
            InitializeComponent();
        }
        //窗口加载
        private void LoadoMeter_Load(object sender, EventArgs e)
        {
            My_RunCode = BLL.MyLog.DL_Run.Insert(this.Text);
            this.Btn_Add.Enabled = false;
            this.Btn_Edit.Enabled = true;
            this.Btn_Save.Enabled = true;
            Id = 0;
            DataBind();
        }
        //绑定数据
        private void DataBind()
        {
            this.Gv_LoadoMeter.AutoGenerateColumns = false;
            this.Gv_LoadoMeter.DataSource = LoadoMeterBLL.SelectAll("").Tables[0];
        }
        //添加
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.Btn_Add.Enabled = false;
            this.Btn_Edit.Enabled = true;
            this.Btn_Save.Enabled = true;
            Id = 0;
            this.Tb_TableNum.ReadOnly = false;
            ResetData();
        }
        //修改
        private void Gv_LoadoMeter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Btn_Edit.Enabled = false;
            this.Btn_Add.Enabled = true;
            this.Btn_Save.Enabled = true;
            this.Tb_TableNum.ReadOnly = true;
            int i = e.RowIndex;
            if (i >= 0)
            {
                DataGridViewCellCollection Dgc = this.Gv_LoadoMeter.Rows[i].Cells;
                Id = Convert.ToInt64(Dgc["Col_Id"].Value);
                this.Tb_TableNum.Text = Dgc["Col_TableNum"].Value.ToString();
                this.Tb_Name.Text = Dgc["Col_Name"].Value.ToString();
                this.Tb_Ip.Text = Dgc["Col_Ip"].Value.ToString();
                this.Tb_Port.Text = Dgc["Col_Port"].Value.ToString();
                this.Tb_Remark.Text = Dgc["Col_Remark"].Value.ToString();
            }
        }
        //保存
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            DC_LoadoMeter LoadoMeterItem = new DC_LoadoMeter();
            LoadoMeterItem.TableNum = this.Tb_TableNum.Text.Trim();
            LoadoMeterItem.Name = this.Tb_Name.Text.Trim();
            LoadoMeterItem.Ip = this.Tb_Ip.Text.Trim();
            LoadoMeterItem.Port = this.Tb_Port.Text.Trim();
            LoadoMeterItem.Remark = this.Tb_Remark.Text.Trim();
            if (LoadoMeterItem.TableNum == "")
            {
                Function.MessageWarning("请把数据填写完整！");
                return;
            }
            if (LoadoMeterItem.TableNum.Length > 3)
            {
                Function.MessageWarning("磅台号最大长度不能超过三位！");
                return;
            }
            if (Id == 0)
            {
                if (Function.CheckKey("DC_LoadoMeter", "TableNum", LoadoMeterItem.TableNum, 0))
                {
                    Function.MessageWarning("该编号已存在！");
                    return;
                }
                if (LoadoMeterBLL.Insert(LoadoMeterItem))
                {
                    Function.Message("添加成功！");
                    ResetData();
                    DataBind();
                }
            }
            else
            {
                LoadoMeterItem.Id = Id;
                if (LoadoMeterBLL.Update(LoadoMeterItem))
                {
                    Function.Message("修改成功！");
                    DataBind();
                }
            }
        }
        //删除
        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (Function.MessageYesNo("您确定要删除选中数据！"))
            {
                if (LoadoMeterBLL.Del(this.Gv_LoadoMeter.SelectValues("Col_Id")))
                {
                    Function.Message("删除成功！");
                    DataBind();
                }
            }
        }
        //设为本机
        private void Btn_SetLolal_Click(object sender, EventArgs e)
        {
            int i = this.Gv_LoadoMeter.SelectedRows[0].Index;
            DataGridViewCellCollection Dgc = this.Gv_LoadoMeter.Rows[i].Cells;
            DC_LoadoMeter LoadoMeterItem = new DC_LoadoMeter();
            LoadoMeterItem.TableNum=Dgc["Col_TableNum"].Value.ToString();
            if (LoadoMeterBLL.SetLocal(LoadoMeterItem))
            {
                Function.Message("已成功设置本机编号！");
            }
        }
        //刷新
        private void Btn_Fresh_Click(object sender, EventArgs e)
        {
            LoadoMeter_Load(sender, e);
            ResetData();
        }
        //退出
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //重置数据
        private void ResetData()
        {
            this.Tb_TableNum.Text = "";
            this.Tb_Name.Text = "";
            this.Tb_Ip.Text = "";
            this.Tb_Remark.Text = "";
        }
        //关闭
        private void LoadoMeter_FormClosed(object sender, FormClosedEventArgs e)
        {
            BLL.MyLog.DL_Run.Update(this.My_RunCode);//操作记录
        }
    }
}