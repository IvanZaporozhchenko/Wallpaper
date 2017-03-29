using System.Collections.Generic;

namespace Wallpaper.Services.Implementations
{
    public class VkImageService : IImageService
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

        public IEnumerable<string> GetImageUrls(int screenWidth, int screenHeight)
        {
            var result = new List<string>();
            if (screenWidth == 480 && screenHeight == 800)
            {
                result.AddRange(_images480X800);
            }

            if (screenWidth == 768 && screenHeight == 1280)
            {
                result.AddRange(_images768x1280);
            }

            if (screenWidth == 720 && screenHeight == 1280)
            {
                result.AddRange(_images720x1280);
            }

            return result;
        }
    }

}
