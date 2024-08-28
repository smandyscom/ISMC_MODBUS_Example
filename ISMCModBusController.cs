

using NModbus;
using NModbus.IO;
using NModbus.Serial;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    class ISMCModBusController
    {
        enum ISMC_MODBUS_ADDRESS : ushort
        {
            /// <summary>
            /// Read-only
            /// </summary>
            STATUS_WORD = 0x6041,


            CONTROL_WORD = 0x6040,
            MODE_OF_OPERATION = 0x6060,

            /// <summary>
            /// Homing
            /// </summary>
            HOME_METHOD = 0x6098,
            HOME_OFFSET = 0x607C,
            HOME_SPEED = 0x6099,
            HOME_ACC_DEC = 0x609A,
        }

        private IModbusMaster _master = null;
        private SerialPort _serial_port;

        private ushort _status_word;
        private ushort _control_word;

        /// <summary>
        /// STATUS WORD in properties
        /// </summary>
        public bool StatusReadyToSwitchOn
        {
            get
            {
                return (_status_word & (1 << 0)) != 0; // bit 0
            }
        }
        public bool StatusSwitchOn
        {
            get
            {
                return (_status_word & (1 << 1)) != 0; // bit 1
            }
        }
        public bool StatusOperationEnabled
        {
            get
            {
                return (_status_word & (1 << 2)) != 0; // bit 2
            }
        }
        public bool StatusFault
        {
            get
            {
                return (_status_word & (1 << 3)) != 0; // bit 3
            }
        }
        public bool StatusTargetReached
        {
            get
            {
                return (_status_word & (1 << 10)) != 0; // bit 10
            }
        }

        private uint _bitwiseSetup(uint input, byte position, bool value)
        {
            if(value)
            {
                //SET
                return input | (uint)(1 << position);
            }
            else
            {
                //UNSET
                return input & (uint)~(1 << position);
            }
        }

        public bool ControlSwitchOn
        {
            set
            {
                this._bitwiseSetup(this._control_word, 0, value);
            }
        }
        public bool ControlEnableVoltage
        {
            set
            {
                this._bitwiseSetup(this._control_word, 1, value);
            }
        }
        public bool ControlQuickStop
        {
            set
            {
                this._bitwiseSetup(this._control_word, 2, value);
            }
        }
        public bool ControlEnableOperation
        {
            set
            {
                this._bitwiseSetup(this._control_word, 3, value);
            }
        }
        public bool ControlFaultReset
        {
            set
            {
                this._bitwiseSetup(this._control_word, 7, value);
            }
        }

        public ISMCModBusController()
        {
            return;
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void ConnectModbusRTUMaster(string PrimarySerialPortName = "COM4")
        {
            this._serial_port = new SerialPort(PrimarySerialPortName);

            // configure serial port
            this._serial_port.BaudRate = 9600;
            this._serial_port.DataBits = 8;
            this._serial_port.Parity = Parity.None;
            this._serial_port.StopBits = StopBits.One;
            this._serial_port.Open();


            var factory = new ModbusFactory();
            IModbusMaster master = factory.CreateRtuMaster(this._serial_port);
        }

        /// <summary>
        ///     Simple Modbus serial RTU master write holding registers example.
        /// </summary>
        public void ModbusSerialRtuMasterWriteRegisters()
        {
           byte slaveId = 1;
           ushort startAddress = 100;
           ushort[] registers = new ushort[] { 1, 2, 3 };

           // write three registers
           this._master.WriteMultipleRegisters(slaveId, startAddress, registers);
        }

        public void UpdateStatusWord()
        {
            this._status_word = this._master.ReadHoldingRegisters(1, (ushort)ISMC_MODBUS_ADDRESS.STATUS_WORD, 0)[0];
        }

        public void OverrideControlWord()
        {
            this._master.WriteSingleRegister(1, (ushort)ISMC_MODBUS_ADDRESS.CONTROL_WORD, this._control_word);
        }

        /// <summary>
        /// 设置【6060h：Mode of operations】为 6（homing mode）；
        ///②设置【6098h：Homing method】，设置范围为 1~35（详细细节参见 DS402 标准）；
        ///③设置【607Ch：Homing offset】，设置原点偏移；
        ///④设置【6099h Sub-01：Homing speeds】，修改 Homing 过程中寻找限位开关的速
        ///度（单位：cnt/s）；
        ///⑤设置【6099h Sub-02：Homing speeds】，修改 Homing 过程中寻找零位的速度（单
        ///位:cnt/s）；
        ///⑥设置【609Ah：Homing acceleration】，设置回零加减速度（单位：cnt/s^2）；
        /// </summary>
        public void OverrideHMParameters()
        {
            
        }


        public void OverrideSoftTouchParameters()
        {

        }
    }
}
