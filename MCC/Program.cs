using System.Diagnostics;
namespace MCC{class Program{static void Main(string[] args){ if (args.Length != 2) return; Process.Start($"steam://launch/{args[0]}/option{args[1]}");}}}
