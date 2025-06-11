using ArmDot.Client;

// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Hardware id: {Api.GetCurrentMachineHardwareId(Api.Hardware.CPU | Api.Hardware.HDD | Api.Hardware.Motherboard)}");
