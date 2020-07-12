using System.Diagnostics;
namespace MCC
{
    class Program{
        static void Main(string[] args)
        {
            // if (args.Length != 2)
            //     return;
            Process.Start($"steam://launch/976730/option0");
            // 976730 0
            // Process.Start($"steam://launch/{args[0]}/option{args[1]}");
            // arg0 is the game steam appID; arg1 is the launch option, most games don't use it. 
            // for MCC, option0 is retail, option1 is EAC disabled
        }
    }
}
