using System;

namespace CheckOddType {
    class Program {
        static void Main(string[] args) {
            dynamic master = Activator.CreateInstance(Type.GetTypeFromProgID("IMAPI2.MsftDiscMaster2"));
            foreach (string uniqueId in master) {
                dynamic recorder = Activator.CreateInstance(Type.GetTypeFromProgID("IMAPI2.MsftDiscRecorder2"));
                recorder.InitializeDiscRecorder(uniqueId);
                Console.WriteLine("{0}:", recorder.VolumePathNames[0]);
                foreach (int id in recorder.SupportedFeaturePages)
                    Console.WriteLine("    0x{0:X2}", id);
            }
        }
    }
}
