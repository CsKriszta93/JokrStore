using JOKRStore.DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Seed.TestSeed {
    public partial class TestSeed {
        public static void SeedGames(ApplicationDbContext context)
        {
            if (!context.SysReq.Any())
                CreateSysReq(context);
            if (!context.Games.Any())
                CreateGames(context);
            if (!context.SysReqCPU.Any())
                CreateSysReqCPU(context);
            if (!context.SysReqGPU.Any())                
                CreateSysReqGPU(context);
            if (!context.SysReqOS.Any())
                CreateSysReqOS(context);
        }

        static void CreateSysReq(ApplicationDbContext context) {
            List<SysReq> sysReqList = new List<SysReq>
            {
                new SysReq
                {
                    Id = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    Ram = 1024,
                    Storage = 12288,
                    DirectX = 9,
                    OpenGL = 0,
                    Vulkan = 0
                },

                new SysReq
                {
                    Id = Guid.Parse("9bffef14-63ff-4680-883f-f63c4ad0b99a"),
                    Ram = 2048,
                    Storage = 12288,
                    DirectX = 10,
                    OpenGL = 0,
                    Vulkan = 0
                }
            };

            context.SysReq.AddRange(sysReqList);
            context.SaveChanges();
        }

        static void CreateSysReqCPU(ApplicationDbContext context) {
            List<SysReqCPU> sysReqCPUList = new List<SysReqCPU>
            {
                new SysReqCPU
                {
                    Id = Guid.Parse("88f02d6f-f6ce-43a1-8247-05640b1786e8"),
                    SysReqId = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013")
                    
                },

                new SysReqCPU
                {
                    Id = Guid.Parse("6fe3c3d9-734b-49bd-9da2-4d9a54250fd2"),
                    SysReqId = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    CPUId = Guid.Parse("4b0452a2-14e7-4374-a78c-3f288ae9b113")
                },

                new SysReqCPU
                {
                    Id = Guid.Parse("28ce18f9-2a4c-4c18-8802-7bb787b2185c"),
                    SysReqId = Guid.Parse("9bffef14-63ff-4680-883f-f63c4ad0b99a"),
                    CPUId = Guid.Parse("633d5951-58c5-499f-afac-fec93a952951")
                }
            };

            context.SysReqCPU.AddRange(sysReqCPUList);
            context.SaveChanges();
        }

        static void CreateSysReqGPU(ApplicationDbContext context) {
            List<SysReqGPU> sysReqGPUList = new List<SysReqGPU>
            {
                new SysReqGPU
                {
                    Id = Guid.Parse("35bba189-360a-4afd-99af-16da5cb2dd79"),
                    SysReqId = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    GPUId = Guid.Parse("a800e3c9-2e8d-4cce-b97e-81a2fcc60b05")
                    
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("e44bf526-e814-4df0-8e60-88f6f1ca4490"),
                    SysReqId = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    GPUId = Guid.Parse("5e7bb8c5-c7c7-41cb-a647-cb16c421d95f")
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("ee83ac5a-ba81-4972-afee-944553fbc6e7"),
                    SysReqId = Guid.Parse("9bffef14-63ff-4680-883f-f63c4ad0b99a"),
                    GPUId = Guid.Parse("82259d49-2362-41b7-894f-85400d8b61f4")
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("9b6a4de3-d991-467a-8129-ef8d136343cb"),
                    SysReqId = Guid.Parse("9bffef14-63ff-4680-883f-f63c4ad0b99a"),
                    GPUId = Guid.Parse("86e10eec-6a55-4050-b547-85a2496cd185")
                }
            };

            context.SysReqGPU.AddRange(sysReqGPUList);
            context.SaveChanges();
        }

        static void CreateSysReqOS(ApplicationDbContext context) {
            List<SysReqOS> sysReqOSList = new List<SysReqOS>
            {
                new SysReqOS
                {
                    Id = Guid.Parse("ba3b3d0a-cff4-49cc-8f02-8e29a8bce2a3"),
                    SysReqId = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    OSId = Guid.Parse("8b8a1d13-3912-459a-9510-6c2a090728d7")
                    
                },

                new SysReqOS
                {
                    Id = Guid.Parse("ba3b3d0a-cff4-49cc-8f02-8e29a8bce2a4"),
                    SysReqId = Guid.Parse("9bffef14-63ff-4680-883f-f63c4ad0b99a"),
                    OSId = Guid.Parse("b511fd17-c9e1-4106-accc-f448f19067d9")
                },
            };

            context.SysReqOS.AddRange(sysReqOSList);
            context.SaveChanges();
        }

        static void CreateGames(ApplicationDbContext context) {
            List<Game> gameList = new List<Game>
            {
                new Game
                {
                    Id = Guid.Parse("ab0ecbb9-0034-4167-9255-a99caf469bca"),
                    GameName = "Far Cry 2",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/far_cry_2/CoverArt.jpg",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(2008, 04, 01),
                    DownloadLink = "/assets/fary_cry_2.exe",
                    DemoLink = "/assets/fary_cry_2_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = Guid.Parse("b14db6e3-8a03-4460-8702-e42a019a19f2"),
                    RecSysReqId = Guid.Parse("9bffef14-63ff-4680-883f-f63c4ad0b99a"),
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                },

                new Game
                {
                    Id = Guid.Parse("67ccd344-a37b-44e6-9ddd-10460b0257af"),
                    GameName = "Far Cry",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/far_cry/CoverArt.jpg",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(2004, 04, 01),
                    DownloadLink = "/assets/fary_cry.exe",
                    DemoLink = "/assets/fary_cry_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = null,
                    RecSysReqId = null,
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                },

                new Game
                {
                    Id = Guid.Parse("65f35af2-1c86-406a-862d-33db6517366f"),
                    GameName = "Duke Nukem Forever",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/duke_forever/CoverArt.png",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(2011, 04, 01),
                    DownloadLink = "/assets/duke_forever.exe",
                    DemoLink = "/assets/duke_forever_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = null,
                    RecSysReqId = null,
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                }
            };

            context.Games.AddRange(gameList);
            context.SaveChanges();
        }
    }
}
