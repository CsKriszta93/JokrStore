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
            if (!context.Description.Any())
                CreateDescription(context);
        }

        static void CreateSysReq(ApplicationDbContext context) {
            List<SysReq> sysReqList = new List<SysReq>
            {
                //Far Cry 2
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
                },

                //Far Cry
                new SysReq
                {
                    Id = Guid.Parse("6fa2e7ee-4d7e-45fa-a185-bbae5e385e8f"),
                    Ram = 256,
                    Storage = 4096,
                    DirectX = 9,
                    OpenGL = 1.4f,
                    Vulkan = 0
                },

                new SysReq
                {
                    Id = Guid.Parse("b2f487fc-eb6f-4f28-9f0a-f7d56bcb38f1"),
                    Ram = 512,
                    Storage = 4096,
                    DirectX = 9,
                    OpenGL = 1.4f,
                    Vulkan = 0
                },

                //Duke Nukem Forever
                new SysReq
                {
                    Id = Guid.Parse("32b785c1-3c4e-495b-9c48-53f0341533fd"),
                    Ram = 1024,
                    Storage = 12288,
                    DirectX = 9,
                    OpenGL = 0,
                    Vulkan = 0
                },

                new SysReq
                {
                    Id = Guid.Parse("c2f62d5d-86c2-4a33-bf8c-76bbdc7f9de4"),
                    Ram = 2048,
                    Storage = 12288,
                    DirectX = 9,
                    OpenGL = 0,
                    Vulkan = 0
                },

                //Doom
                new SysReq
                {
                    Id = Guid.Parse("b9bae0bc-886d-4fd8-9914-cc6aceec041a"),
                    Ram = 4,
                    Storage = 5,
                    DirectX = 0,
                    OpenGL = 0,
                    Vulkan = 0
                },

                //Doom 2016
                new SysReq
                {
                    Id = Guid.Parse("188f170d-b44f-44a7-a43b-08f11e1675e6"),
                    Ram = 8192,
                    Storage = 61440,
                    DirectX = 0,
                    OpenGL = 4.5f,
                    Vulkan = 0
                },

                new SysReq
                {
                    Id = Guid.Parse("dedf5c07-a72a-41da-8545-863abdf2ac14"),
                    Ram = 2048,
                    Storage = 61440,
                    DirectX = 0,
                    OpenGL = 0,
                    Vulkan = 1.1f
                },

                //Far Cry 3
                new SysReq
                {
                    Id = Guid.Parse("6933958e-cc7c-4857-8f01-ed3e8f1574b6"),
                    Ram = 1024,
                    Storage = 12288,
                    DirectX = 9,
                    OpenGL = 0,
                    Vulkan = 0
                },

                new SysReq
                {
                    Id = Guid.Parse("d2c227a4-80d6-4cd8-b9cc-51603efa57e0"),
                    Ram = 2048,
                    Storage = 12288,
                    DirectX = 10,
                    OpenGL = 0,
                    Vulkan = 0
                },

                //NFS High Stakes
                new SysReq
                {
                    Id = Guid.Parse("4e2a6248-d867-474b-9b48-6c44a751b5ae"),
                    Ram = 32,
                    Storage = 100,
                    DirectX = 6.1f,
                    OpenGL = 0,
                    Vulkan = 0
                },
            };

            context.SysReq.AddRange(sysReqList);
            context.SaveChanges();
        }

        static void CreateSysReqCPU(ApplicationDbContext context) {
            List<SysReqCPU> sysReqCPUList = new List<SysReqCPU>
            {
                //Far Cry 2
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
                },

                //Far Cry
                new SysReqCPU
                {
                    Id = Guid.Parse("8b8daf0d-88d7-42b7-a767-c05a0e83173d"),
                    SysReqId = Guid.Parse("6fa2e7ee-4d7e-45fa-a185-bbae5e385e8f"),
                    CPUId = Guid.Parse("02f11db1-93bd-4bbd-8b72-9def0cd3faf6")
                    
                },

                new SysReqCPU
                {
                    Id = Guid.Parse("72d2ead6-462f-4230-a665-a5be049c9814"),
                    SysReqId = Guid.Parse("b2f487fc-eb6f-4f28-9f0a-f7d56bcb38f1"),
                    CPUId = Guid.Parse("4b0452a2-14e7-4374-a78c-3f288ae9b113")
                },

                //Duke Nukem Forever
                new SysReqCPU
                {
                    Id = Guid.Parse("601f0544-7b6d-4467-99ae-985fbebaf52f"),
                    SysReqId = Guid.Parse("32b785c1-3c4e-495b-9c48-53f0341533fd"),
                    CPUId = Guid.Parse("26f86e2d-5497-44db-aa98-2a824cf7b605")
                    
                },

                new SysReqCPU
                {
                    Id = Guid.Parse("74a3ba71-77a8-4769-a385-04155df6d328"),
                    SysReqId = Guid.Parse("c2f62d5d-86c2-4a33-bf8c-76bbdc7f9de4"),
                    CPUId = Guid.Parse("232a0734-e7b5-4b41-be7d-385312abc20e")
                },

                //Doom
                new SysReqCPU
                {
                    Id = Guid.Parse("05e66f85-f57e-4a55-b1ab-5b0d885e84fa"),
                    SysReqId = Guid.Parse("b9bae0bc-886d-4fd8-9914-cc6aceec041a"),
                    CPUId = Guid.Parse("2e36c84d-1706-425b-96bc-ef41fc9d2b07")
                    
                },

                //Doom 2016
                new SysReqCPU
                {
                    Id = Guid.Parse("331040d3-0343-4aef-ad25-cf070f5dc19a"),
                    SysReqId = Guid.Parse("188f170d-b44f-44a7-a43b-08f11e1675e6"),
                    CPUId = Guid.Parse("bf871c36-cf7f-402b-940c-3f33dc8b5a3c")
                    
                },

                new SysReqCPU
                {
                    Id = Guid.Parse("d7459a1c-e249-47b6-8798-89b1f7529a0d"),
                    SysReqId = Guid.Parse("dedf5c07-a72a-41da-8545-863abdf2ac14"),
                    CPUId = Guid.Parse("232a0734-e7b5-4b41-be7d-385312abc20e")
                },

                //Far Cry 3
                new SysReqCPU
                {
                    Id = Guid.Parse("056e6f86-6e5c-4538-b48d-27aba7be285e"),
                    SysReqId = Guid.Parse("6933958e-cc7c-4857-8f01-ed3e8f1574b6"),
                    CPUId = Guid.Parse("1c1f421e-37d0-4a8e-9f48-244398c1e013")
                    
                },

                new SysReqCPU
                {
                    Id = Guid.Parse("27332b14-62c3-4b8d-9570-661ad9cfba76"),
                    SysReqId = Guid.Parse("d2c227a4-80d6-4cd8-b9cc-51603efa57e0"),
                    CPUId = Guid.Parse("232a0734-e7b5-4b41-be7d-385312abc20e")
                },

                //NFS High Stakes
                new SysReqCPU
                {
                    Id = Guid.Parse("3bf4ee9f-1bfa-4d01-9141-7e7986199fec"),
                    SysReqId = Guid.Parse("4e2a6248-d867-474b-9b48-6c44a751b5ae"),
                    CPUId = Guid.Parse("e94d04b3-897a-4ec7-bbcd-9ec3188cd67d")
                    
                }
            };

            context.SysReqCPU.AddRange(sysReqCPUList);
            context.SaveChanges();
        }

        static void CreateSysReqGPU(ApplicationDbContext context) {
            List<SysReqGPU> sysReqGPUList = new List<SysReqGPU>
            {
                //Far Cry 2
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
                },

                //Far Cry
                new SysReqGPU
                {
                    Id = Guid.Parse("1913a927-b9fb-429c-8b4d-178bb3a29e7f"),
                    SysReqId = Guid.Parse("6fa2e7ee-4d7e-45fa-a185-bbae5e385e8f"),
                    GPUId = Guid.Parse("a800e3c9-2e8d-4cce-b97e-81a2fcc60b05")
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("2c373dc9-ca18-4c3c-9216-82397867c155"),
                    SysReqId = Guid.Parse("b2f487fc-eb6f-4f28-9f0a-f7d56bcb38f1"),
                    GPUId = Guid.Parse("82259d49-2362-41b7-894f-85400d8b61f4")
                },

                //Duke Nukem Forever
                new SysReqGPU
                {
                    Id = Guid.Parse("e800d12f-1829-44b0-9eed-38a66675d383"),
                    SysReqId = Guid.Parse("32b785c1-3c4e-495b-9c48-53f0341533fd"),
                    GPUId = Guid.Parse("5e7bb8c5-c7c7-41cb-a647-cb16c421d95f")
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("11f9834a-4084-463c-8ab3-db1e3feacc85"),
                    SysReqId = Guid.Parse("c2f62d5d-86c2-4a33-bf8c-76bbdc7f9de4"),
                    GPUId = Guid.Parse("86e10eec-6a55-4050-b547-85a2496cd185")
                },

                //Doom
                new SysReqGPU
                {
                    Id = Guid.Parse("0821a25e-de11-4b68-bb6c-1295f78c2b82"),
                    SysReqId = Guid.Parse("b9bae0bc-886d-4fd8-9914-cc6aceec041a"),
                    GPUId = Guid.Parse("b651f59a-a0b7-4abf-9707-2062f4f980ab")
                },

                //Doom 2016
                new SysReqGPU
                {
                    Id = Guid.Parse("b2c8c30b-271d-4022-9d5b-3d53277b3865"),
                    SysReqId = Guid.Parse("188f170d-b44f-44a7-a43b-08f11e1675e6"),
                    GPUId = Guid.Parse("86e10eec-6a55-4050-b547-85a2496cd185")
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("4b86c663-9961-453c-a199-4608698c69d6"),
                    SysReqId = Guid.Parse("dedf5c07-a72a-41da-8545-863abdf2ac14"),
                    GPUId = Guid.Parse("86e10eec-6a55-4050-b547-85a2496cd185")
                },

                //Far Cry 3
                new SysReqGPU
                {
                    Id = Guid.Parse("bb018128-499b-448f-aad3-e6c99be1d59c"),
                    SysReqId = Guid.Parse("6933958e-cc7c-4857-8f01-ed3e8f1574b6"),
                    GPUId = Guid.Parse("82259d49-2362-41b7-894f-85400d8b61f4")
                },

                new SysReqGPU
                {
                    Id = Guid.Parse("b242917c-d103-45d6-988f-8a24cbc9ce03"),
                    SysReqId = Guid.Parse("d2c227a4-80d6-4cd8-b9cc-51603efa57e0"),
                    GPUId = Guid.Parse("82259d49-2362-41b7-894f-85400d8b61f4")
                },

                //NFS High stakes
                new SysReqGPU
                {
                    Id = Guid.Parse("9e55ad60-3d26-4c40-aa8e-0547f21552f7"),
                    SysReqId = Guid.Parse("4e2a6248-d867-474b-9b48-6c44a751b5ae"),
                    GPUId = Guid.Parse("b651f59a-a0b7-4abf-9707-2062f4f980ab")
                },


            };

            context.SysReqGPU.AddRange(sysReqGPUList);
            context.SaveChanges();
        }

        static void CreateSysReqOS(ApplicationDbContext context) {
            List<SysReqOS> sysReqOSList = new List<SysReqOS>
            {
                //Far Cry 2
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

                //Far Cry
                new SysReqOS
                {
                    Id = Guid.Parse("d86aafda-2385-4336-a95a-196fdedd8f8c"),
                    SysReqId = Guid.Parse("6fa2e7ee-4d7e-45fa-a185-bbae5e385e8f"),
                    OSId = Guid.Parse("e8be205b-ebe6-45a8-96ea-ab49b351f8c4")
                    
                },

                new SysReqOS
                {
                    Id = Guid.Parse("5e36d2b3-2f84-4339-ac11-3f699efdc737"),
                    SysReqId = Guid.Parse("b2f487fc-eb6f-4f28-9f0a-f7d56bcb38f1"),
                    OSId = Guid.Parse("8b8a1d13-3912-459a-9510-6c2a090728d7")
                },

                //Duke Nukem forever
                new SysReqOS
                {
                    Id = Guid.Parse("3f4d7935-ec78-4d68-aadd-b4651ad2b447"),
                    SysReqId = Guid.Parse("32b785c1-3c4e-495b-9c48-53f0341533fd"),
                    OSId = Guid.Parse("8b8a1d13-3912-459a-9510-6c2a090728d7")
                    
                },

                new SysReqOS
                {
                    Id = Guid.Parse("a88745df-c5c5-4f47-8917-24d56851fac2"),
                    SysReqId = Guid.Parse("c2f62d5d-86c2-4a33-bf8c-76bbdc7f9de4"),
                    OSId = Guid.Parse("b511fd17-c9e1-4106-accc-f448f19067d9")
                },

                //Doom
                new SysReqOS
                {
                    Id = Guid.Parse("3cbb3592-ddde-4f18-b914-a9e711f08047"),
                    SysReqId = Guid.Parse("b9bae0bc-886d-4fd8-9914-cc6aceec041a"),
                    OSId = Guid.Parse("9d5bc6e6-8f52-40fd-8245-d8765c000a9c")
                    
                },

                //Doom 2016
                new SysReqOS
                {
                    Id = Guid.Parse("e8c85364-e8a1-4334-b6dc-c91d85f5ddba"),
                    SysReqId = Guid.Parse("188f170d-b44f-44a7-a43b-08f11e1675e6"),
                    OSId = Guid.Parse("17555874-e618-4f14-b297-9d30487b73ca")
                    
                },

                new SysReqOS
                {
                    Id = Guid.Parse("65148ea1-041f-493e-b1a3-ef4b0311b2d5"),
                    SysReqId = Guid.Parse("dedf5c07-a72a-41da-8545-863abdf2ac14"),
                    OSId = Guid.Parse("121d9b92-f2e0-49e9-a17b-2271aca93eb9")
                },

                //Far Cry 3
                new SysReqOS
                {
                    Id = Guid.Parse("43a4a282-8a23-4212-9e4a-af9450d16393"),
                    SysReqId = Guid.Parse("6933958e-cc7c-4857-8f01-ed3e8f1574b6"),
                    OSId = Guid.Parse("8b8a1d13-3912-459a-9510-6c2a090728d7")
                    
                },

                new SysReqOS
                {
                    Id = Guid.Parse("f2a820f8-d261-480f-b9de-4e26605bb335"),
                    SysReqId = Guid.Parse("d2c227a4-80d6-4cd8-b9cc-51603efa57e0"),
                    OSId = Guid.Parse("121d9b92-f2e0-49e9-a17b-2271aca93eb9")
                },

                //NFS High Stakes
                new SysReqOS
                {
                    Id = Guid.Parse("4a854091-6415-4cc0-ac7f-0c374577b59a"),
                    SysReqId = Guid.Parse("4e2a6248-d867-474b-9b48-6c44a751b5ae"),
                    OSId = Guid.Parse("9d5bc6e6-8f52-40fd-8245-d8765c000a9c")
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
                    MinSysReqId = Guid.Parse("6fa2e7ee-4d7e-45fa-a185-bbae5e385e8f"),
                    RecSysReqId = Guid.Parse("b2f487fc-eb6f-4f28-9f0a-f7d56bcb38f1"),
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
                    MinSysReqId = Guid.Parse("32b785c1-3c4e-495b-9c48-53f0341533fd"),
                    RecSysReqId = Guid.Parse("c2f62d5d-86c2-4a33-bf8c-76bbdc7f9de4"),
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                },

                new Game
                {
                    Id = Guid.Parse("0f44c7e8-93bb-4480-9e52-25574ce530db"),
                    GameName = "Doom",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/doom/CoverArt.jpg",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(1993, 03, 01),
                    DownloadLink = "/assets/doom.exe",
                    DemoLink = "/assets/doom_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = Guid.Parse("b9bae0bc-886d-4fd8-9914-cc6aceec041a"),
                    RecSysReqId = null,
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                },

                new Game
                {
                    Id = Guid.Parse("0d75e570-83e1-4b7e-960e-023a664a227d"),
                    GameName = "Doom (2016)",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/Doom (2016)/CoverArt.jpg",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(2016, 03, 01),
                    DownloadLink = "/assets/doom2016.exe",
                    DemoLink = "/assets/doom2016_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = Guid.Parse("188f170d-b44f-44a7-a43b-08f11e1675e6"),
                    RecSysReqId = Guid.Parse("dedf5c07-a72a-41da-8545-863abdf2ac14"),
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                },

                new Game
                {
                    Id = Guid.Parse("478f47eb-4ccc-4d03-9ce2-21ee17566d22"),
                    GameName = "Far Cry 3",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/far_cry_3/CoverArt.jpeg",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(2012, 10, 01),
                    DownloadLink = "/assets/far_cry_3.exe",
                    DemoLink = "/assets/far_cry_3_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = Guid.Parse("6933958e-cc7c-4857-8f01-ed3e8f1574b6"),
                    RecSysReqId = Guid.Parse("d2c227a4-80d6-4cd8-b9cc-51603efa57e0"),
                    SysReqNotes = "",
                    Publish = new DateTime(2020, 05, 06),
                    State = 0,
                    ReleaseState = 0
                },

                new Game
                {
                    Id = Guid.Parse("0f96608b-c48d-4181-92e5-ffec430e5c4c"),
                    GameName = "NFS High Stakes",
                    UserId = context.Users.Single(u => u.UserName == "kriszta.csere").Id,
                    CoverArt = "/assets/images/games/NFS_High_Stakes/CoverArt.jpg",
                    Rate = 4.0f,
                    Price = 4000,
                    Release = new DateTime(1999, 09, 01),
                    DownloadLink = "/assets/nfs4.exe",
                    DemoLink = "/assets/nfs4_demo.exe",
                    NumOfDownloads = 0,
                    MinSysReqId = Guid.Parse("4e2a6248-d867-474b-9b48-6c44a751b5ae"),
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

        static void CreateDescription(ApplicationDbContext context)
        {
            List<Description> descriptionList = new List<Description>
            {
                //Far Cry 2
                new Description
                {
                    Id = Guid.Parse("2bba5f0d-4316-45fc-8c6f-494c65030145"),
                    GameId = Guid.Parse("ab0ecbb9-0034-4167-9255-a99caf469bca"),
                    Content = "Far Cry 2 is a sequel to the original Far Cry. The game features an open-ended experience. Players are able to ally with one or multiple factions, and to progress through the game world and missions as they see fit, resulting in a nonlinear style of gameplay commonly referred to as sandbox mode that allows the story to progress at their speed and in the order they choose.[3] Players can use a range of vehicles, including cars, trucks, boats and hang gliders,[4] to travel within the 50 km2 (19 sq mi) gameplay area. The playing styles range from head-on assaults to stealthy infiltrations and assassinations. The game takes place in a sprawling African landscape, with terrain ranging from desert to savannah to jungle.",
                    Language = 0
                },

                //Far Cry
                new Description
                {
                    Id = Guid.Parse("61627c60-46f9-48a7-b2a4-99c8bb07c62b"),
                    GameId = Guid.Parse("67ccd344-a37b-44e6-9ddd-10460b0257af"),
                    Content = "The tropical rain forest provides cover and concealment, of which the player and enemies can take advantage. Enemies react dynamically to the player's tactics and actions. If a lone mercenary spots a player, he occasionally runs for help, signaling reinforcements through use of flareguns. Enemies will work together to outmaneuver, outflank, surround, and provide suppressive fire, providing them a tactical advantage over the player, who, in turn, is able to spot and mark enemies on their minimap through use of special binoculars, which also grant the player the ability to listen to enemy conversations from afar, merely by pointing the binoculars in the direction of the enemies. Later in the gameplay, thermo binoculars can be used to locate the heat signatures of enemies, that would be otherwise concealed by foliage or darkness. ",
                    Language = 0
                },

                //Duke Nukem Forever
                new Description
                {
                    Id = Guid.Parse("36092343-6b18-40c7-ba85-3d3c95e2936d"),
                    GameId = Guid.Parse("65f35af2-1c86-406a-862d-33db6517366f"),
                    Content = "Duke Nukem Forever is an action-oriented first-person shooter. Players take control of Duke Nukem and navigate a series of levels which take place on Earth and beyond. The game allows players to interact with various in-game objects, including water coolers, urinals, and whiteboards, which allow players to draw their own images. The gameplay is similar in some respects to the first-person shooter games of the late 1990s and early 2000s, with each level culminating in a boss battle in which Duke has to fight and kill a large, significant alien. ",
                    Language = 0
                },

                //Doom
                new Description
                {
                    Id = Guid.Parse("e57050b7-e879-4a76-8705-f16e32c51c5e"),
                    GameId = Guid.Parse("0f44c7e8-93bb-4480-9e52-25574ce530db"),
                    Content = "Doom is a first-person shooter presented with early 3D graphics. The player controls an unnamed space marine—later termed the Doomguy—through a series of levels set in military bases on the moons of Mars and in Hell. To finish a level, the player must traverse through the area to reach a marked exit room. Levels are grouped together into named episodes, with the final level focusing on a boss fight with a particularly difficult enemy. While the environment is presented in a 3D perspective, the enemies and objects are instead 2D sprites presented from several preset viewing angles, a technique sometimes referred to as 2.5D graphics with its technical name called ray casting.",
                    Language = 0
                },

                //Doom 2016
                new Description
                {
                    Id = Guid.Parse("b367ac2f-2f85-4e73-b23f-31cf9e57dbe1"),
                    GameId = Guid.Parse("0d75e570-83e1-4b7e-960e-023a664a227d"),
                    Content = "According to the game's executive producer Marty Stratton, the key principles of Doom's single-player mode are \"badass demons, big effing guns, and moving really fast\".[1] The game allows players to perform movements such as double jumps and ledge climbs throughout levels of industrial and corporate fields of a Union Aerospace Corporation (UAC) research facility on Mars and then levels of Hell,[2] as the combat system puts emphasis upon momentum and speed.[3] The approach is known as \"push-forward combat\", which discourages players from taking cover behind obstacles or resting to regain health while playing from the Doom Slayer's perspective.",
                    Language = 0
                },

                //Far Cry 3
                new Description
                {
                    Id = Guid.Parse("23941f44-6532-451b-aee5-2825230d46b4"),
                    GameId = Guid.Parse("478f47eb-4ccc-4d03-9ce2-21ee17566d22"),
                    Content = "Far Cry 3 is a first-person shooter set on the fictional Rook Islands, a tropical archipelago controlled by bandits and pirates.[1] Players portray Jason Brody and can approach missions and objectives in a variety of ways. They can kill enemies by utilizing firearms such as assault rifles, sniper rifles, grenade launchers, rocket launchers, and explosives like land mines and grenades.[2] Alternatively, players can utilize stealth to avoid the attention of enemies. For instance, players can scout an enemy's outpost by using a camera to mark the locations of enemies,[3] or toss rocks to distract enemies.",
                    Language = 0
                },

                //NFS High Stakes
                new Description
                {
                    Id = Guid.Parse("4368fa94-df21-46f0-b35a-0fbafcfcd6ed"),
                    GameId = Guid.Parse("0f96608b-c48d-4181-92e5-ffec430e5c4c"),
                    Content = "The career system of this entry consists of two modes: \"Tournament\", straightforward series of races with certain cars; and \"Special Event\", similar to Tournament, but with various conditions such as with night driving or with a fully upgraded car. Completing races earns the player credits which are used to buy new cars for new events and to upgrade old cars to make events a little easier. Completing races also unlocks the tracks for single race purposes, and completing Tournament events unlocks the Special Event events. Beating all events of Tournament or Special Events will unlock one of two secret cars to purchase; the player also gets a free sample at the same time.",
                    Language = 0
                }
            };

            context.Description.AddRange(descriptionList);
            context.SaveChanges();
        }
    }
}
