using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ISMCModBusController _controller = new ISMCModBusController();

        public Form1()
        {
            InitializeComponent();
        }


        private void _labelTurnGreenRed(Label _label,bool value)
        {
            if(value)
            {
                _label.BackColor = Color.Green;
            }
            else
            {
                _label.BackColor = Color.Red;
            }
        }

        /// <summary>
        /// Timer timeout event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataPolling(object sender, EventArgs e)
        {
            _controller.UpdateStatusWord();

            /// Update STATUS
            /// 
            _labelTurnGreenRed(labelEnableDisable, _controller.StatusSwitchOn);
            _labelTurnGreenRed(labelFault, !_controller.StatusFault);
            _labelTurnGreenRed(labelTargetReached, _controller.StatusTargetReached);

            // Update VALUES
        }

        private void connectModbus(object sender, EventArgs e)
        {
            _controller.ConnectModbusRTUMaster(textBoxComPort.Text);
            timerPolling.Enabled = true;
        }

        private void ControlChanged(object sender, EventArgs e)
        {
            if (!_controller.IsModbusMasterReady)
                return;

            _controller.ControlEnableOperation = radioButtonEnableOn.Checked;
            _controller.ControlFaultReset = radioButtonResetOn.Checked;
            _controller.ControlQuickStop = radioButtonEmgOn.Checked;

            _controller.OverrideControlWord();
        }
    }
}
