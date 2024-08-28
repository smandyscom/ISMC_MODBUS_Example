namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radioButtonEnableOn = new System.Windows.Forms.RadioButton();
            this.radioButtonEnableOff = new System.Windows.Forms.RadioButton();
            this.radioButtonResetOn = new System.Windows.Forms.RadioButton();
            this.radioButtonResetOff = new System.Windows.Forms.RadioButton();
            this.labelEnableDisable = new System.Windows.Forms.Label();
            this.labelFault = new System.Windows.Forms.Label();
            this.labelTargetReached = new System.Windows.Forms.Label();
            this.timerPolling = new System.Windows.Forms.Timer(this.components);
            this.radioButtonEmgOn = new System.Windows.Forms.RadioButton();
            this.radioButtonEmgOff = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxComPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPositionActualInternalValue = new System.Windows.Forms.TextBox();
            this.textBoxPositionError = new System.Windows.Forms.TextBox();
            this.textBoxVelocityActualValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPositionDemandInternalValue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTorqueActualValue = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonEnableOn
            // 
            this.radioButtonEnableOn.AutoSize = true;
            this.radioButtonEnableOn.Location = new System.Drawing.Point(14, 13);
            this.radioButtonEnableOn.Name = "radioButtonEnableOn";
            this.radioButtonEnableOn.Size = new System.Drawing.Size(47, 16);
            this.radioButtonEnableOn.TabIndex = 0;
            this.radioButtonEnableOn.TabStop = true;
            this.radioButtonEnableOn.Text = "使能";
            this.radioButtonEnableOn.UseVisualStyleBackColor = true;
            this.radioButtonEnableOn.CheckedChanged += new System.EventHandler(this.ControlChanged);
            // 
            // radioButtonEnableOff
            // 
            this.radioButtonEnableOff.AutoSize = true;
            this.radioButtonEnableOff.Location = new System.Drawing.Point(106, 12);
            this.radioButtonEnableOff.Name = "radioButtonEnableOff";
            this.radioButtonEnableOff.Size = new System.Drawing.Size(47, 16);
            this.radioButtonEnableOff.TabIndex = 1;
            this.radioButtonEnableOff.TabStop = true;
            this.radioButtonEnableOff.Text = "禁能";
            this.radioButtonEnableOff.UseVisualStyleBackColor = true;
            this.radioButtonEnableOff.CheckedChanged += new System.EventHandler(this.ControlChanged);
            // 
            // radioButtonResetOn
            // 
            this.radioButtonResetOn.AutoSize = true;
            this.radioButtonResetOn.Location = new System.Drawing.Point(14, 56);
            this.radioButtonResetOn.Name = "radioButtonResetOn";
            this.radioButtonResetOn.Size = new System.Drawing.Size(85, 16);
            this.radioButtonResetOn.TabIndex = 2;
            this.radioButtonResetOn.TabStop = true;
            this.radioButtonResetOn.Text = "故障清除On";
            this.radioButtonResetOn.UseVisualStyleBackColor = true;
            this.radioButtonResetOn.CheckedChanged += new System.EventHandler(this.ControlChanged);
            // 
            // radioButtonResetOff
            // 
            this.radioButtonResetOff.AutoSize = true;
            this.radioButtonResetOff.Location = new System.Drawing.Point(106, 55);
            this.radioButtonResetOff.Name = "radioButtonResetOff";
            this.radioButtonResetOff.Size = new System.Drawing.Size(87, 16);
            this.radioButtonResetOff.TabIndex = 3;
            this.radioButtonResetOff.TabStop = true;
            this.radioButtonResetOff.Text = "故障清除Off";
            this.radioButtonResetOff.UseVisualStyleBackColor = true;
            this.radioButtonResetOff.CheckedChanged += new System.EventHandler(this.ControlChanged);
            // 
            // labelEnableDisable
            // 
            this.labelEnableDisable.AutoSize = true;
            this.labelEnableDisable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnableDisable.Location = new System.Drawing.Point(198, 13);
            this.labelEnableDisable.Name = "labelEnableDisable";
            this.labelEnableDisable.Size = new System.Drawing.Size(88, 14);
            this.labelEnableDisable.TabIndex = 4;
            this.labelEnableDisable.Text = "綠:使能/紅:禁能";
            // 
            // labelFault
            // 
            this.labelFault.AutoSize = true;
            this.labelFault.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFault.Location = new System.Drawing.Point(198, 56);
            this.labelFault.Name = "labelFault";
            this.labelFault.Size = new System.Drawing.Size(124, 14);
            this.labelFault.TabIndex = 5;
            this.labelFault.Text = "紅:故障狀態/綠:無故障";
            // 
            // labelTargetReached
            // 
            this.labelTargetReached.AutoSize = true;
            this.labelTargetReached.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTargetReached.Location = new System.Drawing.Point(198, 137);
            this.labelTargetReached.Name = "labelTargetReached";
            this.labelTargetReached.Size = new System.Drawing.Size(124, 14);
            this.labelTargetReached.TabIndex = 6;
            this.labelTargetReached.Text = "綠:目標抵達/紅:未到達";
            // 
            // timerPolling
            // 
            this.timerPolling.Tick += new System.EventHandler(this.dataPolling);
            // 
            // radioButtonEmgOn
            // 
            this.radioButtonEmgOn.AutoSize = true;
            this.radioButtonEmgOn.Location = new System.Drawing.Point(14, 97);
            this.radioButtonEmgOn.Name = "radioButtonEmgOn";
            this.radioButtonEmgOn.Size = new System.Drawing.Size(61, 16);
            this.radioButtonEmgOn.TabIndex = 7;
            this.radioButtonEmgOn.TabStop = true;
            this.radioButtonEmgOn.Text = "急停On";
            this.radioButtonEmgOn.UseVisualStyleBackColor = true;
            this.radioButtonEmgOn.CheckedChanged += new System.EventHandler(this.ControlChanged);
            // 
            // radioButtonEmgOff
            // 
            this.radioButtonEmgOff.AutoSize = true;
            this.radioButtonEmgOff.Location = new System.Drawing.Point(106, 97);
            this.radioButtonEmgOff.Name = "radioButtonEmgOff";
            this.radioButtonEmgOff.Size = new System.Drawing.Size(63, 16);
            this.radioButtonEmgOff.TabIndex = 8;
            this.radioButtonEmgOff.TabStop = true;
            this.radioButtonEmgOff.Text = "急停Off";
            this.radioButtonEmgOff.UseVisualStyleBackColor = true;
            this.radioButtonEmgOff.CheckedChanged += new System.EventHandler(this.ControlChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTorqueActualValue);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxPositionDemandInternalValue);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxVelocityActualValue);
            this.panel1.Controls.Add(this.textBoxPositionError);
            this.panel1.Controls.Add(this.textBoxPositionActualInternalValue);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelEnableDisable);
            this.panel1.Controls.Add(this.radioButtonEmgOff);
            this.panel1.Controls.Add(this.radioButtonEnableOn);
            this.panel1.Controls.Add(this.radioButtonEmgOn);
            this.panel1.Controls.Add(this.radioButtonEnableOff);
            this.panel1.Controls.Add(this.labelTargetReached);
            this.panel1.Controls.Add(this.radioButtonResetOn);
            this.panel1.Controls.Add(this.labelFault);
            this.panel1.Controls.Add(this.radioButtonResetOff);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 382);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "通訊連接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.connectModbus);
            // 
            // textBoxComPort
            // 
            this.textBoxComPort.Location = new System.Drawing.Point(95, 13);
            this.textBoxComPort.Name = "textBoxComPort";
            this.textBoxComPort.Size = new System.Drawing.Size(100, 22);
            this.textBoxComPort.TabIndex = 11;
            this.textBoxComPort.Text = "COM4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "位置反饋[cnt]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "位置誤差[cnt]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "速度反饋[cnt/s]";
            // 
            // textBoxPositionActualInternalValue
            // 
            this.textBoxPositionActualInternalValue.Location = new System.Drawing.Point(95, 212);
            this.textBoxPositionActualInternalValue.Name = "textBoxPositionActualInternalValue";
            this.textBoxPositionActualInternalValue.ReadOnly = true;
            this.textBoxPositionActualInternalValue.Size = new System.Drawing.Size(197, 22);
            this.textBoxPositionActualInternalValue.TabIndex = 12;
            // 
            // textBoxPositionError
            // 
            this.textBoxPositionError.Location = new System.Drawing.Point(95, 242);
            this.textBoxPositionError.Name = "textBoxPositionError";
            this.textBoxPositionError.ReadOnly = true;
            this.textBoxPositionError.Size = new System.Drawing.Size(197, 22);
            this.textBoxPositionError.TabIndex = 13;
            // 
            // textBoxVelocityActualValue
            // 
            this.textBoxVelocityActualValue.Location = new System.Drawing.Point(95, 292);
            this.textBoxVelocityActualValue.Name = "textBoxVelocityActualValue";
            this.textBoxVelocityActualValue.ReadOnly = true;
            this.textBoxVelocityActualValue.Size = new System.Drawing.Size(197, 22);
            this.textBoxVelocityActualValue.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "位置指令[cnt]";
            // 
            // textBoxPositionDemandInternalValue
            // 
            this.textBoxPositionDemandInternalValue.Location = new System.Drawing.Point(95, 184);
            this.textBoxPositionDemandInternalValue.Name = "textBoxPositionDemandInternalValue";
            this.textBoxPositionDemandInternalValue.ReadOnly = true;
            this.textBoxPositionDemandInternalValue.Size = new System.Drawing.Size(197, 22);
            this.textBoxPositionDemandInternalValue.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "電流反饋[A]";
            // 
            // textBoxTorqueActualValue
            // 
            this.textBoxTorqueActualValue.Location = new System.Drawing.Point(95, 334);
            this.textBoxTorqueActualValue.Name = "textBoxTorqueActualValue";
            this.textBoxTorqueActualValue.ReadOnly = true;
            this.textBoxTorqueActualValue.Size = new System.Drawing.Size(197, 22);
            this.textBoxTorqueActualValue.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxComPort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonEnableOn;
        private System.Windows.Forms.RadioButton radioButtonEnableOff;
        private System.Windows.Forms.RadioButton radioButtonResetOn;
        private System.Windows.Forms.RadioButton radioButtonResetOff;
        private System.Windows.Forms.Label labelEnableDisable;
        private System.Windows.Forms.Label labelFault;
        private System.Windows.Forms.Label labelTargetReached;
        private System.Windows.Forms.Timer timerPolling;
        private System.Windows.Forms.RadioButton radioButtonEmgOn;
        private System.Windows.Forms.RadioButton radioButtonEmgOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxComPort;
        private System.Windows.Forms.TextBox textBoxVelocityActualValue;
        private System.Windows.Forms.TextBox textBoxPositionError;
        private System.Windows.Forms.TextBox textBoxPositionActualInternalValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPositionDemandInternalValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTorqueActualValue;
        private System.Windows.Forms.Button button2;
    }
}

