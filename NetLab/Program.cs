using System.Net;
using System.Net.NetworkInformation;

namespace NetLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ipProps = IPGlobalProperties.GetIPGlobalProperties();
            var ipStats = ipProps.GetIPv4GlobalStatistics();
            Console.WriteLine($"Входящие пакеты: {ipStats.ReceivedPackets}");
            Console.WriteLine($"Исходящие пакеты: {ipStats.OutputPacketRequests}");
            Console.WriteLine($"Отброшено входящих пакетов: {ipStats.ReceivedPacketsDiscarded}");
            Console.WriteLine($"Отброшено исходящих пакетов: {ipStats.OutputPacketsDiscarded}");
            Console.WriteLine($"Ошибки фрагментации: {ipStats.PacketFragmentFailures}");
            Console.WriteLine($"Ошибки восстановления пакетов: {ipStats.PacketReassemblyFailures}");
        }
    }
}
