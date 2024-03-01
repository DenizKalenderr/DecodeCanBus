using Imecar.LV_BMS.V2.Can_Bus_Interface.Common;
using System.ComponentModel;

namespace Imecar.LV_BMS.V2.Can_Bus_Interface.Messages
{
    public class IM_LVBMS_BalancingRequest : Common.Common, ICanBusMessage 
    {
        private bool _CSC_Assing;
        private ushort _CscThresholdVoltage;
        string path = @"C:\Users\imesp15\source\repos\DecodeCanBus\DecodeCanBus\Path\IM_CSC_SensorCAN_v1.dbc";

        public bool CSC_Assing
        {
            get { return _CSC_Assing; }
            set
            {
                if (value != _CSC_Assing)
                {
                    _CSC_Assing = value;
                    OnPropertyChanged("CSC_Assing");
                }
            }
        }

        public ushort CscThresholdVoltage
        {
            get { return _CscThresholdVoltage; }
            set
            {
                if (value != _CscThresholdVoltage)
                {
                    _CscThresholdVoltage = value;
                    OnPropertyChanged("CscThresholdVoltage");
                }
            }
        }

       
        public void Decode(byte[] data)
        {
            CSC_Assing = data[0] != 0;
            CscThresholdVoltage = (ushort)((data[4] << 8) + data[0]);

        }

        static void Main(string[] args)
        {

            var message = new IM_LVBMS_BalancingRequest();

            Console.WriteLine("BmsBalancing: " + message.CSC_Assing);
            Console.WriteLine("BmsThresholdVoltage: " + message.CscThresholdVoltage);

            Console.ReadLine();
        }
    }
}
