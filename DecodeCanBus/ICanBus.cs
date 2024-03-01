namespace Imecar.LV_BMS.V2.Can_Bus_Interface.Common
{
  
    public interface ICanBusMessage
    {
        void Decode(byte[] data);
    }
}
