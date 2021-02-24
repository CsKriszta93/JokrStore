using JOKRStore.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Seed.TestSeed
{
    public partial class TestSeed
    {
        private static readonly DateTime TEST_RELEASE_DATA = new DateTime(2012, 01, 01);

        public static void SeedHardware(ApplicationDbContext context)
        {
            if (!context.CPUs.Any())
            {
                CreateCPUs(context);
            }

            if (!context.GPUs.Any())
            {
                CreateGPUs(context);
            }

            if (!context.OSes.Any())
            {
                CreateOses(context);
            }

            if (!context.Configs.Any())
            {
                CreateConfigs(context);
            }
        }

        private static void CreateCPUs(ApplicationDbContext context)
        {
            List<CPU> cpuList = new List<CPU>
            {
                new CPU
                {
                    Id = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013"),
                    Architect = "Conroe",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 1600,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Core 2 Duo E4200"
                },

                new CPU
                {
                    Id = Guid.Parse("26f86e2d-5497-44db-aa98-2a824cf7b605"),
                    Architect = "Conroe",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 1800,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Core 2 Duo E4300"
                },

                new CPU
                {
                    Id = Guid.Parse("232a0734-e7b5-4b41-be7d-385312abc20e"),
                    Architect = "Conroe",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 2600,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Core 2 Duo E4700"
                },

                new CPU
                {
                    Id = Guid.Parse("4b0452a2-14e7-4374-a78c-3f288ae9b113"),
                    Architect = "Smithfield",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 2660,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Pentium D 805"
                },

                new CPU
                {
                    Id = Guid.Parse("bf871c36-cf7f-402b-940c-3f33dc8b5a3c"),
                    Architect = "Conroe",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 2400,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Core 2 Duo E4600"
                },

                new CPU
                {
                    Id = Guid.Parse("02f11db1-93bd-4bbd-8b72-9def0cd3faf6"),
                    Architect = "Prescott",
                    Cache = 1,
                    Cores = 1,
                    Freqency = 3200,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Pentium 4 HT 540"
                },

                new CPU
                {
                    Id = Guid.Parse("77bc81e7-e295-46e7-bda5-e808154b1f34"),
                    Architect = "Conroe",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 2000,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Core 2 Duo E4400"
                },

                new CPU
                {
                    Id = Guid.Parse("633d5951-58c5-499f-afac-fec93a952951"),
                    Architect = "Conroe",
                    Cache = 2,
                    Cores = 2,
                    Freqency = 2200,
                    Release = TEST_RELEASE_DATA,
                    Manufacturer = Model.Enums.CPUManufacturer.Intel,
                    Name = "Core 2 Duo E4500"
                }
            };

            context.CPUs.AddRange(cpuList);
            context.SaveChanges();
        }

        private static void CreateGPUs(ApplicationDbContext context)
        {
            List<GPU> gpuList = new List<GPU>
            {
                new GPU
                {
                    Id = Guid.Parse("a800e3c9-2e8d-4cce-b97e-81a2fcc60b05"),
                    Name = "Geforce 6800",
                    Architect = "NV40",
                    Release = TEST_RELEASE_DATA,
                    MemorySize = 256,
                    ShaderModel = 3,
                    DirectX = 9,
                    OpenGl = 2.1f,
                    Vulkan = 0,
                    MemoryFreqency = 350,
                    CoreFrequency = 325,
                    Shaders = 0,
                    Buswidth = 256,
                    Bandwidth = 32400,
                    PixelFillRate = 3900,
                    TextureFillRate = 3900,
                    Manufacturer = Model.Enums.GPUManufacturer.Nvidia
                },

                new GPU
                {
                    Id = Guid.Parse("82259d49-2362-41b7-894f-85400d8b61f4"),
                    Name = "Geforce 8600 GTS",
                    Architect = "NV40",
                    Release = TEST_RELEASE_DATA,
                    MemorySize = 256,
                    ShaderModel = 4,
                    DirectX = 10,
                    OpenGl = 3.3f,
                    Vulkan = 0,
                    MemoryFreqency = 1000,
                    CoreFrequency = 675,
                    Shaders = 1450,
                    Buswidth = 128,
                    Bandwidth = 32000,
                    PixelFillRate = 5400,
                    TextureFillRate = 10800,
                    Manufacturer = Model.Enums.GPUManufacturer.Nvidia
                },

                new GPU
                {
                    Id = Guid.Parse("86e10eec-6a55-4050-b547-85a2496cd185"),
                    Name = "Radeon X1900 GT",
                    Architect = "R580",
                    Release = TEST_RELEASE_DATA,
                    MemorySize = 256,
                    ShaderModel = 3,
                    DirectX = 9,
                    OpenGl = 2.1f,
                    Vulkan = 0,
                    MemoryFreqency = 575,
                    CoreFrequency = 600,
                    Shaders = 0,
                    Buswidth = 256,
                    Bandwidth = 38400,
                    PixelFillRate = 6144,
                    TextureFillRate = 6144,
                    Manufacturer = Model.Enums.GPUManufacturer.AMD
                },

                 new GPU
                {
                    Id = Guid.Parse("5e7bb8c5-c7c7-41cb-a647-cb16c421d95f"),
                    Name = "Radeon X1650",
                    Architect = "NV40",
                    Release = TEST_RELEASE_DATA,
                    MemorySize = 256,
                    ShaderModel = 3,
                    DirectX = 9,
                    OpenGl = 2.1f,
                    Vulkan = 0,
                    MemoryFreqency = 400,
                    CoreFrequency = 635,
                    Shaders = 0,
                    Buswidth = 128,
                    Bandwidth = 12800,
                    PixelFillRate = 2000,
                    TextureFillRate = 2000,
                    Manufacturer = Model.Enums.GPUManufacturer.AMD
                }
            };

            context.GPUs.AddRange(gpuList);
            context.SaveChanges();
        }

        private static void CreateOses(ApplicationDbContext context)
        {
            List<OS> osList = new List<OS>
            {
                new OS
                {
                    Id = Guid.Parse("121d9b92-f2e0-49e9-a17b-2271aca93eb9"),
                    Name = "Windows 8",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 6,
                    MinorVer = 2
                },

                new OS
                {
                    Id = Guid.Parse("808edf76-c0af-4db1-ab62-5e58c1e5e53b"),
                    Name = "Windows 10",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 10,
                    MinorVer = 0
                },

                new OS
                {
                    Id = Guid.Parse("2a552ab7-208e-4f5b-9fd1-6127de9d9aa4"),
                    Name = "Windows 8.1",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 6,
                    MinorVer = 3
                },

                new OS
                {
                    Id = Guid.Parse("6f7fc978-9c10-46c1-8f52-61c912807eba"),
                    Name = "Windows 2000",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 5,
                    MinorVer = 0
                },

                new OS
                {
                    Id = Guid.Parse("8b8a1d13-3912-459a-9510-6c2a090728d7"),
                    Name = "Windows XP",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 5,
                    MinorVer = 1
                },

                new OS
                {
                    Id = Guid.Parse("17555874-e618-4f14-b297-9d30487b73ca"),
                    Name = "Windows 7",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 6,
                    MinorVer = 1
                },

                new OS
                {
                    Id = Guid.Parse("b511fd17-c9e1-4106-accc-f448f19067d9"),
                    Name = "Windows VISTA",
                    Group = Model.Enums.OSGroup.Windows,
                    MajorVer = 6,
                    MinorVer = 0
                },
            };

            context.OSes.AddRange(osList);
            context.SaveChanges();
        }

        //TODO: létre kell hozni új teszt usereket, mert egy-egy kapcsolat van a user és config között
        private static void CreateConfigs(ApplicationDbContext context)
        {
            var krisztaUserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id;
            var joakimUserId = context.Users.Single(u => u.UserName == "joakim.szabo").Id;

            List<Config> configList = new List<Config>
            {
                new Config
                {
                    Id = Guid.Parse("8f13b84d-8dc4-4132-744c-08d73ba474fa"),
                    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013"),
                    RAM = 2048,
                    GPUId = Guid.Parse("5e7bb8c5-c7c7-41cb-a647-cb16c421d95f"),
                    GPUSize = 0,
                    OSId = Guid.Parse("17555874-e618-4f14-b297-9d30487b73ca"),
                    Others = "",
                    UserId = krisztaUserId
                },

                //new Config
                //{
                //    Id = Guid.Parse("3df51d01-5c3d-41bb-a73d-08d73ba7e4f0"),
                //    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013"),
                //    RAM = 2048,
                //    GPUId = Guid.Parse("5e7bb8c5-c7c7-41cb-a647-cb16c421d95f"),
                //    GPUSize = 0,
                //    OSId = Guid.Parse("17555874-e618-4f14-b297-9d30487b73ca"),
                //    Others = "",
                //    UserId = krisztaUserId
                //},

                new Config
                {
                    Id = Guid.Parse("498f1118-2b0f-46b6-2f5c-08d73c5ba0b7"),
                    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013"),
                    RAM = 2048,
                    GPUId = Guid.Parse("a800e3c9-2e8d-4cce-b97e-81a2fcc60b05"),
                    GPUSize = 0,
                    OSId = Guid.Parse("2a552ab7-208e-4f5b-9fd1-6127de9d9aa4"),
                    Others = "",
                    UserId = joakimUserId
                },

                //new Config
                //{
                //    Id = Guid.Parse("186e479a-4012-4bf0-faf8-08d73d29a72d"),
                //    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013"),
                //    RAM = 2048,
                //    GPUId = Guid.Parse("86e10eec-6a55-4050-b547-85a2496cd185"),
                //    GPUSize = 0,
                //    OSId = Guid.Parse("17555874-e618-4f14-b297-9d30487b73ca"),
                //    Others = "",
                //    UserId = joakimUserId
                //},

                // new Config
                //{
                //    Id = Guid.Parse("2a3efce9-e8e4-432f-9478-0951d250f3f2"),
                //    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013"),
                //    RAM = 2048,
                //    GPUId = Guid.Parse("82259d49-2362-41b7-894f-85400d8b61f4"),
                //    GPUSize = 0,
                //    OSId = Guid.Parse("b511fd17-c9e1-4106-accc-f448f19067d9"),
                //    Others = "",
                //    UserId = joakimUserId
                //},
            };

            context.Configs.AddRange(configList);
            context.SaveChanges();
        }
    }
}