namespace SRT_Ticketor
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbDepart = new System.Windows.Forms.TextBox();
            this.tbArrival = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnChangeStation = new System.Windows.Forms.Button();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnStop = new System.Windows.Forms.Button();
            this.cbVIPRoom = new System.Windows.Forms.CheckBox();
            this.cbNormalRoom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(24, 240);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(202, 53);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "가입전화번호:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD:";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(110, 23);
            this.tbID.MaxLength = 11;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(116, 21);
            this.tbID.TabIndex = 1;
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(110, 52);
            this.tbPW.MaxLength = 30;
            this.tbPW.Name = "tbPW";
            this.tbPW.Size = new System.Drawing.Size(116, 21);
            this.tbPW.TabIndex = 2;
            this.tbPW.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "예매 날짜:";
            // 
            // dtPicker
            // 
            this.dtPicker.CustomFormat = "yyyy-MM-dd";
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(110, 82);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(101, 21);
            this.dtPicker.TabIndex = 3;
            this.dtPicker.Value = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "여정경로: 직통";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "인원정보: 성인 1명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "좌석정보: 전체/일반";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "차종구분: 전체";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "출발 시간:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(219, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 12);
            this.label9.TabIndex = 13;
            this.label9.Text = "~";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(287, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "출발역";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(409, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "도착역";
            // 
            // tbDepart
            // 
            this.tbDepart.Location = new System.Drawing.Point(277, 52);
            this.tbDepart.MaxLength = 7;
            this.tbDepart.Name = "tbDepart";
            this.tbDepart.Size = new System.Drawing.Size(63, 21);
            this.tbDepart.TabIndex = 6;
            // 
            // tbArrival
            // 
            this.tbArrival.Location = new System.Drawing.Point(397, 52);
            this.tbArrival.MaxLength = 7;
            this.tbArrival.Name = "tbArrival";
            this.tbArrival.Size = new System.Drawing.Size(63, 21);
            this.tbArrival.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "->";
            // 
            // btnChangeStation
            // 
            this.btnChangeStation.Location = new System.Drawing.Point(346, 52);
            this.btnChangeStation.Name = "btnChangeStation";
            this.btnChangeStation.Size = new System.Drawing.Size(43, 23);
            this.btnChangeStation.TabIndex = 12;
            this.btnChangeStation.Text = "<->";
            this.btnChangeStation.UseVisualStyleBackColor = true;
            this.btnChangeStation.Click += new System.EventHandler(this.btnChangeStation_Click);
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "HH:mm";
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(110, 105);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(101, 21);
            this.dtStart.TabIndex = 4;
            this.dtStart.Value = new System.DateTime(2023, 12, 8, 0, 0, 0, 0);
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "HH:mm";
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(239, 109);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(101, 21);
            this.dtEnd.TabIndex = 5;
            this.dtEnd.Value = new System.DateTime(2023, 12, 7, 15, 43, 58, 0);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(248, 240);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(202, 53);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // cbVIPRoom
            // 
            this.cbVIPRoom.AutoSize = true;
            this.cbVIPRoom.Checked = true;
            this.cbVIPRoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVIPRoom.Location = new System.Drawing.Point(375, 87);
            this.cbVIPRoom.Name = "cbVIPRoom";
            this.cbVIPRoom.Size = new System.Drawing.Size(72, 16);
            this.cbVIPRoom.TabIndex = 8;
            this.cbVIPRoom.Text = "특실예매";
            this.cbVIPRoom.UseVisualStyleBackColor = true;
            // 
            // cbNormalRoom
            // 
            this.cbNormalRoom.AutoSize = true;
            this.cbNormalRoom.Checked = true;
            this.cbNormalRoom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNormalRoom.Location = new System.Drawing.Point(375, 112);
            this.cbNormalRoom.Name = "cbNormalRoom";
            this.cbNormalRoom.Size = new System.Drawing.Size(72, 16);
            this.cbNormalRoom.TabIndex = 9;
            this.cbNormalRoom.Text = "일반예매";
            this.cbNormalRoom.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 305);
            this.Controls.Add(this.cbNormalRoom);
            this.Controls.Add(this.cbVIPRoom);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btnChangeStation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbArrival);
            this.Controls.Add(this.tbDepart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Name = "Form1";
            this.Text = "SRT Ticketor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDepart;
        private System.Windows.Forms.TextBox tbArrival;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnChangeStation;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox cbVIPRoom;
        private System.Windows.Forms.CheckBox cbNormalRoom;
    }
}

