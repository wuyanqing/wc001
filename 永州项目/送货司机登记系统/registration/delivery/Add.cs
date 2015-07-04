using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SpeechLib;

namespace delivery
{
    public partial class Add : Form
    {
        dal da = new dal();
        public allinformation allinformationFrom;
        RegistrationInfo registrationinformation = new RegistrationInfo();
        public Add()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Dispose();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            registrationinformation._carcode = txbcarcode.Text;
            registrationinformation._billno = txbbillno.Text;
            registrationinformation._phone = txbphone.Text;
            registrationinformation._daytime = DateTime.Now;
            registrationinformation._address = cobaddress.Text;
            registrationinformation._isSubmit = "0";
            registrationinformation._iswork = "1";
            registrationinformation._name = "送货司机";
            registrationinformation._state = "送货";
            registrationinformation._memo = "";
            registrationinformation._port = "1";
            string voices = "请" + txbcarcode.Text + "前去提交送货单！";
            string log = "";
            if (da.addRegistrationInfo(registrationinformation, out log))
            {
                Voice(voices);
                this.Dispose();
                DataTable dt = da.registrationInfo();
                allinformationFrom.dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show(log);
            }
        }
        /// <summary>
        /// 当未提交送货单车辆数<=2，语音提醒该车辆提交送货单
        /// </summary>0：未提交 1：已提交  2：卸货中  3 卸货完成
        /// <param name="voices"></param>
        public void Voice(string voices)
        {
            SpeechVoiceSpeakFlags SpFlags = SpeechVoiceSpeakFlags.SVSFlagsAsync;
            SpVoice Voice = new SpVoice();
            Voice.Speak(voices, SpFlags);
        }

    }
}
