using System;
using System.Collections.Generic;
using System.Linq;
using Wallpaper.Services.Interfaces;
using Wallpaper.ViewModels;

namespace Wallpaper.Services.Implementations
{
    public class VkImageFactory : IImageFactory
    {
        private readonly string[] _images480X800 =
        {
            "https://pp.vk.me/c628629/v628629456/25236/V-DAlVsK1vc.jpg",
            "https://pp.vk.me/c622617/v622617456/4e4d7/tbvWXMhJTqw.jpg",
            "https://pp.vk.me/c622617/v622617456/4e4df/jl4KBRhdsKE.jpg",
            "https://pp.vk.me/c622617/v622617456/4e4e7/bAjWeNVmbvs.jpg",
            "https://pp.vk.me/c622617/v622617456/4e4ef/vhGPnD18ZlA.jpg",
            "https://pp.vk.me/c622617/v622617456/4e4f7/iKURBIVoizQ.jpg",
            "https://pp.vk.me/c622617/v622617456/4e4ff/m5_9mYikMkQ.jpg",
            "https://pp.vk.me/c622617/v622617456/4e523/u4hhFonADyY.jpg",
            "https://pp.vk.me/c622617/v622617456/4e52b/dTbl3W_E2C0.jpg",
            "https://pp.vk.me/c622617/v622617456/4e533/QrGZn3Dh7X0.jpg",
            "https://pp.vk.me/c622617/v622617456/4e53b/XYkvaX5X2pQ.jpg",
            "https://pp.vk.me/c622617/v622617456/4e543/qKyu-yZv_qo.jpg",
            "https://pp.vk.me/c622617/v622617456/4e54b/rU-rog9OzZc.jpg",
            "https://pp.vk.me/c622617/v622617456/4e553/2qstVEA1wYg.jpg",
            "https://pp.vk.me/c622617/v622617456/4e55b/V0NqisIiR78.jpg",
            "https://pp.vk.me/c622617/v622617456/4e563/xMah8ks2Whk.jpg",
            "https://pp.vk.me/c622617/v622617456/4e56b/ezA3eWEhQBk.jpg",
            "https://pp.vk.me/c622617/v622617456/4e573/AkeoYxoWMY0.jpg",
            "https://pp.vk.me/c622617/v622617456/4e57b/Qbqdj_jgLDI.jpg",
            "https://pp.vk.me/c622617/v622617456/4e583/AyogLql2zvk.jpg",
            "https://pp.vk.me/c622617/v622617456/4e58b/x-dU6nlp4Fg.jpg",
            "https://pp.vk.me/c622617/v622617456/4e593/ykiFwr4ovkQ.jpg",
            "https://pp.vk.me/c622617/v622617456/4e59b/6x3aLsBIRds.jpg",
            "https://pp.vk.me/c622617/v622617456/4e5b2/FaYTigHzdjo.jpg",
            "https://pp.vk.me/c622617/v622617456/4e5ba/ho4H6sn73J4.jpg",
            "https://pp.vk.me/c622617/v622617456/4e5c2/yBL3Hn3CchI.jpg",
            "https://pp.vk.me/c622617/v622617456/4e5ca/mtKiokhhijA.jpg",
            "https://pp.vk.me/c622617/v622617456/4e5d2/C7DPJbbzgpE.jpg",
            "https://pp.vk.me/c628629/v628629456/25335/k4ldXpLjG7M.jpg",
            "https://pp.vk.me/c628629/v628629456/25344/lM3NiuQpdYM.jpg",
            "https://pp.vk.me/c628629/v628629456/2534c/Zj5rdXfNggg.jpg",
            "https://pp.vk.me/c628629/v628629456/25354/joPr7sq8n8s.jpg",
            "https://pp.vk.me/c628629/v628629456/2535c/pEkOHb3dCLo.jpg",
            "https://pp.vk.me/c628629/v628629456/25364/xngsBOtZ_8M.jpg",
            "https://pp.vk.me/c628629/v628629456/2536c/F0pPwur0DZE.jpg",
            "https://pp.vk.me/c628629/v628629456/25374/QlVL_1qgdW8.jpg",
            "https://pp.vk.me/c628629/v628629456/2537c/NyP5YJcMSOo.jpg",
            "https://pp.vk.me/c628629/v628629456/25384/CulMH04s7AM.jpg",
            "https://pp.vk.me/c628629/v628629456/2538c/dUoMwcYdxIc.jpg",
            "https://pp.vk.me/c628629/v628629456/253a4/-z61Lfj1baM.jpg",
            "https://pp.vk.me/c628629/v628629456/253ac/vfR7iV3fd5E.jpg",
            "https://pp.vk.me/c628629/v628629456/253b4/63Jp6NtA7JQ.jpg",
            "https://pp.vk.me/c628629/v628629456/253bc/uH6mfmkvjSg.jpg",
            "https://pp.vk.me/c628629/v628629456/253c4/MPPM7kAsopM.jpg",
            "https://pp.vk.me/c628629/v628629456/253cc/3Dd9CMK4fBA.jpg",
            "https://pp.vk.me/c628629/v628629456/253d4/rzgWbNrWz6s.jpg",
            "https://pp.vk.me/c628629/v628629456/253dc/CGKMU4E0FhA.jpg",
            "https://pp.vk.me/c628629/v628629456/253e4/osUXmHg-zjA.jpg",
            "https://pp.vk.me/c628629/v628629456/253ec/r6bG8lUCnhY.jpg",
            "https://pp.vk.me/c628629/v628629456/253f4/IupBaSlzFcY.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb25/bWl3R5MIiZU.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb1d/5HJ_lhd0ovA.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb15/QP34vQJXbD0.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb0d/Q31YLq5u8mo.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb05/m144YzVvlC0.jpg",
            "https://pp.vk.me/c629324/v629324456/1eafd/98cX6DysAw0.jpg"
        };

        private readonly string[] _images768x1280 = {
            "https://pp.vk.me/c629324/v629324456/1eb38/qJkumEkAhPM.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb41/zbsIUjikOMc.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb4a/whIcqes_JmM.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb53/rITl9x6vllQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb5c/ZCVSyUFyW74.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb65/A8OzSmj98TM.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb6e/3U6G-ccGyKM.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb80/HhObCT1lfUo.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb89/g0K4ZrDn5JQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb92/GMXCpjlSrRk.jpg",
            "https://pp.vk.me/c629324/v629324456/1eb9b/cuBH8bS0gjw.jpg",
            "https://pp.vk.me/c629324/v629324456/1eba4/cNCdN-X9JSI.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebad/roOPxoo5bY0.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebb6/As-0AmczxUE.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebbf/5moWyN0y_gY.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebc8/KbwH-g4wqLE.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebd1/26A3gOcKc6M.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebda/b8kU9vGDRC8.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebe3/_EhvqcOgzro.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebec/nM9V_PtMmFk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebf5/qaclSbQkxyU.jpg",
            "https://pp.vk.me/c629324/v629324456/1ebfe/pWYKP9HDylY.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec07/kSbLhUqfRIM.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec10/MReLmsTwdIw.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec19/9SvpG4Ax4B0.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec22/f2_voUQBPAc.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec34/J9bmb5WPDVM.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec3d/1LmRWeLOILE.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec46/ePNsBjMyuNs.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec4f/Gb0eABJlNnw.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec58/5mPC6zi1SNk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec61/q01M8tKw45s.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec6a/F0sKSJ3grfc.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec7c/EUofWZPh4Fc.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec85/SPnxPiG9YKk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec8e/NivfX4KHkTI.jpg",
            "https://pp.vk.me/c629324/v629324456/1ec97/YGK6YCQk2bg.jpg",
            "https://pp.vk.me/c629324/v629324456/1eca0/cKrKsxEt02o.jpg",
            "https://pp.vk.me/c629324/v629324456/1eca9/OsB8qQsv-1s.jpg",
            "https://pp.vk.me/c629324/v629324456/1ecb2/--NiU-jI3r4.jpg",
            "https://pp.vk.me/c629324/v629324456/1ecbb/-5LLpmv6lFE.jpg",
            "https://pp.vk.me/c629324/v629324456/1ecc4/KMCJu3ky5rc.jpg",
            "https://pp.vk.me/c629324/v629324456/1eccd/s6aLiaGlDWk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ecdf/91qxHljh4Vw.jpg",
            "https://pp.vk.me/c629324/v629324456/1ece8/u0fM477THLY.jpg",
            "https://pp.vk.me/c629324/v629324456/1ecf1/w-79uBXmj-k.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed03/tn7axuyAsLQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed0c/LxySlcX5tdk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed15/8Im9jUZeYQs.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed1e/dasmE5Z6Guw.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed27/FDofi3ImLcg.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed30/i993p2bYbOg.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed39/It4sfxMiFdk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed42/PzJG6PoaVNw.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed63/ufzBlKm_iSs.jpg",
            "https://pp.vk.me/c629324/v629324456/1ed73/3iqgnQ-kYVY.jpg",
        };

        private readonly string[] _images720x1280 =
        {
            "https://pp.vk.me/c629324/v629324456/1ee1e/a1MYEe-AlZ4.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee27/spDJJs2Izhw.jpg",
            "https://pp.vk.me/c629324/v629324456/1f033/Flp0HulKSEA.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee39/V1PiunmTJlM.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee42/XivfgpJwgaU.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee4b/MqDjS-15mxQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee54/9riipxA7Aw8.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee5d/SEvPxIo5yMU.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee66/rzqSwEAg4OU.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee6f/TyjtRNXpyCc.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee78/0yZmg1HiHSs.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee81/keIebLF6AdI.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee8a/-xv-dT2U8tQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee93/rpBn9pWNglI.jpg",
            "https://pp.vk.me/c629324/v629324456/1ee9c/vKu_6scMqnM.jpg",
            "https://pp.vk.me/c629324/v629324456/1eea5/9TfYbIGu8bk.jpg",
            "https://pp.vk.me/c629324/v629324456/1eeae/7KDzMDY0q6Q.jpg",
            "https://pp.vk.me/c629324/v629324456/1eeb7/6qqJgJ2cZH0.jpg",
            "https://pp.vk.me/c629324/v629324456/1eec0/GegWPJT0_gw.jpg",
            "https://pp.vk.me/c629324/v629324456/1eec9/cgJBiTnUlTk.jpg",
            "https://pp.vk.me/c629324/v629324456/1eed9/WdOe-0kUj18.jpg",
            "https://pp.vk.me/c629324/v629324456/1eee2/Al_xVsJoTfc.jpg",
            "https://pp.vk.me/c629324/v629324456/1eeeb/7r5AoD-5l7M.jpg",
            "https://pp.vk.me/c629324/v629324456/1eef4/8YSwIB8gc18.jpg",
            "https://pp.vk.me/c629324/v629324456/1eefd/5J3YnQETWFA.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef06/VoTPQAtAm2A.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef0f/9720rF57cuc.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef18/5U1wC3R5A7c.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef21/FhrrlpHM43w.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef2a/PddVuAGeTGk.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef33/dBynqi9EYhI.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef3c/7ByY6oCzORE.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef45/9nJQq-bKa7A.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef4e/QKJt1eIqOmM.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef57/OlU1j71U5q0.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef60/fRuNOpJ2wJA.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef69/9jqQkObDF7Y.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef72/sOYjzA_X0tQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef7b/siWmV27Nr_U.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef84/CS8aOSxYCPQ.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef96/oR7LJfASoiE.jpg",
            "https://pp.vk.me/c629324/v629324456/1ef9f/QYITtrEb_wI.jpg",
            "https://pp.vk.me/c629324/v629324456/1efa8/9KM2UjqEHE0.jpg",
            "https://pp.vk.me/c629324/v629324456/1efb1/JPKEucy58vo.jpg",
            "https://pp.vk.me/c629324/v629324456/1efba/0SUks-50JJw.jpg",
            "https://pp.vk.me/c629324/v629324456/1efc3/PB65fMX5FOs.jpg",
            "https://pp.vk.me/c629324/v629324456/1efcc/xR_r0IqHJvo.jpg",
            "https://pp.vk.me/c629324/v629324456/1efde/tYrPUXYkvpw.jpg",
            "https://pp.vk.me/c629324/v629324456/1efe7/wLn41frYNnE.jpg",
            "https://pp.vk.me/c629324/v629324456/1eff0/BmwsCdNDQFc.jpg",
            "https://pp.vk.me/c629324/v629324456/1eff9/AA6-mCfOk0E.jpg",
            "https://pp.vk.me/c629324/v629324456/1f002/EWZ7_T6m0Mo.jpg",
            "https://pp.vk.me/c629324/v629324456/1f00b/fTeqy0ER2LY.jpg",
            "https://pp.vk.me/c629324/v629324456/1f018/X34hpUxZHrk.jpg",
            "https://pp.vk.me/c629324/v629324456/1f021/JLGLSeJOw1s.jpg",
            "https://pp.vk.me/c629324/v629324456/1f02a/0ayszbUGOVY.jpg"
        };

        private readonly string[] _images750x1334 =
        {
            "https://pp.userapi.com/c837421/v837421956/3d05f/4IqeGSuWIt8.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d069/qP1MhVWkMS0.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d073/8NtEZNXs8Ok.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d07d/NfTN-HaA5qE.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d09b/G0SH-J5bCVg.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0a5/ZAJWAsjSWbo.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0af/OYPhv14_Yxc.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0b9/j0keyGzPHps.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0c3/IMTtBx_crrk.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0cd/WLoziRJR6fY.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0d7/3LqQ_Ij7_xM.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0e1/KU5rdu7pS4A.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0eb/Z-OVuz9vZzc.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0f5/G8APFjg-hoo.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d0ff/RsXYypy5Z_8.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d109/el99waAUrpk.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d113/JMVNrA2Fe4A.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d11d/xdpKbr7nCpo.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d127/Puc7w_lJcTg.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d131/zxFOV0T9j-M.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d13b/C4cBKuMx8oU.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d145/e05TlC3Eorw.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d14f/O9insRNqp0A.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d159/E7TFisKS95E.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d163/B75VmukRmHM.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d16d/5Ucn2ZObHGQ.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d177/BM_-ZDgxlSk.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d181/kjOJmB7bl5s.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d18b/WsO8TpBIY7E.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d195/9SRZSDXEnNM.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d19f/8XU6ZMWFW2s.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1a9/479oD4RcW9M.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1b3/UPlP8OAEI78.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1bd/haBKDQbjrRE.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1c7/zOcvetKG4fI.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1d1/mB4yhUQ4OjI.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1db/SRpPRLPn0W0.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1e5/nmFBgq7JYpg.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1ef/f2okR_Lrjjo.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d1f9/sgV-mpD-Owc.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d203/odXmG60dt6k.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d20d/r0Qic68ssJM.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d217/_gRE1Nc9TnM.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d221/2VFSJYBTBHE.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d22b/L3meEb8meA0.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d235/rCIpb0T6vFA.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d23f/Wf6F9U_V1tg.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d249/hqIs7TAQmmA.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d253/eBvsz59frkI.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d25d/Xsu9MIBmBJs.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d267/lPXDuNwtLYk.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d271/l00RdB7TLQM.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d27b/J9iGNxFjCZw.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d285/ms3rUKrF3S4.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d28f/U0V9he0xlSE.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d299/9jwGszuH8O0.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d2a3/XhUUNqMd5Bo.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d2ad/BOoAe3PhA7c.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d2b7/bL2G_yoiIx4.jpg",
            "https://pp.userapi.com/c837421/v837421956/3d05f/4IqeGSuWIt8.jpg",
        };

        private readonly IScreenService _screenService;

        public VkImageFactory(IScreenService screenService)
        {
            _screenService = screenService;
        }

        public IEnumerable<ImageItemViewModel> GetImageViewModels()
        {            
            var screenWidth = _screenService.Width;
            var screenHeight = _screenService.Height;
            if (screenWidth == 480 && screenHeight == 800)
            {
                return _images480X800.Select(i => new ImageItemViewModel{ ImageUrl = i});
            }

            if (screenWidth == 768 && screenHeight == 1280)
            {
                return _images768x1280.Select(i => new ImageItemViewModel { ImageUrl = i });
            }

            if (screenWidth == 720 && screenHeight == 1280)
            {
                return _images720x1280.Select(i => new ImageItemViewModel { ImageUrl = i });
            }

            if (screenWidth == 750 && screenHeight == 1334)
            {
                return _images720x1280.Select(i => new ImageItemViewModel { ImageUrl = i });
            }

            var aspectRatio = (double) screenHeight / (double) screenWidth;
            if (Math.Abs(aspectRatio - 1.667) > Math.Abs(aspectRatio - 1.778))
            {
                return _images750x1334.Select(i => new ImageItemViewModel { ImageUrl = i });
            }
            
            return _images768x1280.Select(i => new ImageItemViewModel { ImageUrl = i });
        }
    }

}
