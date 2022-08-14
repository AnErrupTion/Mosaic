using Mosa.DeviceDriver;
using Mosa.DeviceDriver.ISA;
using Mosa.DeviceDriver.ScanCodeMap;
using Mosa.DeviceSystem;
using Mosa.DeviceSystem.PCI;
using Mosa.DeviceSystem.Service;
using Mosa.FileSystem.FAT;
using Mosa.Kernel.x86;
using Mosa.Runtime;
using Mosa.Runtime.Plug;
using Mosa.Runtime.x86;

namespace Mosaic;
public static class Program
{

  [Plug("Mosa.Runtime.StartUp::SetInitialMemory")]
  public static void SetInitialMemory()
  {
    KernelMemory.SetInitialMemory(Address.GCInitialMemory, 0x01000000);
  }

  public static void Main()
  {
    Kernel.Setup();

    Serial.SetupPort(Serial.COM1);
    IDT.SetInterruptHandler(ProcessInterrupt);

    var hardware = new HAL.Hardware();
    var DeviceService = new DeviceService();

    var serviceManager = new ServiceManager();
                var partitionService = new PartitionService();

    serviceManager.AddService(DeviceService);
    serviceManager.AddService(new DiskDeviceService());
    serviceManager.AddService(partitionService);
    serviceManager.AddService(new PCService());
    serviceManager.AddService(new PCIControllerService());
    serviceManager.AddService(new PCIDeviceService());

    DeviceSystem.Setup.Initialize(HAL, DeviceService.ProcessInterrupt);

    DeviceService.RegisterDeviceDriver(DeviceDriver.Setup.GetDeviceDriverRegistryEntries());
    DeviceService.Initialize(new X86System(), null);

                partitionService.CreatePartitionDevices();
  }

  public static void ProcessInterrupt(uint interrupt, uint errorCode)
  {
    if (interrupt >= 0x20 && interrupt < 0x30)
      DeviceSystem.HAL.ProcessInterrupt((byte)(interrupt - 0x20));
  }
}
