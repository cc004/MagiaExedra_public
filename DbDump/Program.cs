using System.Diagnostics;
using System.Xml.Linq;
using Crypto;
using Farm;
using MagiaClient;
using MagiaClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MstApiGetAbilityEffectTypeMstListRequest = MagiaClient.Models.MstApiGetAbilityEffectTypeMstListRequest;
using TitleApiGetTitleTopDataRequest = MagiaClient.Models.TitleApiGetTitleTopDataRequest;

namespace DbDump
{
    internal class Program
    {
        private static readonly Type[] mstModelRequestTypes =
        {
            typeof(MstApiGetItemMstListRequest),
typeof(MstApiGetCardMstListRequest),
typeof(MstApiGetCardLimitBreakMstListRequest),
typeof(MstApiGetSkillMstListRequest),
typeof(MstApiGetSkillLevelUpConditionMstListRequest),
typeof(MstApiGetCharacterAwakeMstListRequest),
typeof(MstApiGetCharacterMstListRequest),
typeof(MstApiGetCharacterProfileMstListRequest),
typeof(MstApiGetCharacterHeartMstListRequest),
typeof(MstApiGetCharacterHeartParamUpGroupMstListRequest),
typeof(MstApiGetCharacterHeartObjectRewardMstListRequest),
typeof(MstApiGetCharacterHeartLevelUpMstListRequest),
typeof(MstApiGetCharacterTeamMstListRequest),
typeof(MstApiGetStyleMstListRequest),
typeof(MstApiGetTowerMstListRequest),
typeof(MstApiGetQuestCategoryMstListRequest),
typeof(MstApiGetQuestMapMstListRequest),
typeof(MstApiGetQuestGroupMstListRequest),
typeof(MstApiGetQuestStageMstListRequest),
typeof(MstApiGetQuestConditionMstListRequest),
typeof(MstApiGetMissionTitleMstListRequest),
typeof(MstApiGetMissionTransitionMstListRequest),
typeof(MstApiGetSubscriptionMissionRewardMstListRequest),
typeof(MstApiGetMissionMstListRequest),
typeof(MstApiGetEnemyMstListRequest),
typeof(MstApiGetEnemyProfileMstListRequest),
typeof(MstApiGetQuestEnemyAppearanceMstListRequest),
typeof(MstApiGetQuestEnemySkillSetMstListRequest),
typeof(MstApiGetBreakMstListRequest),
typeof(MstApiGetAbilityEffectTypeMstListRequest),
typeof(MstApiGetSkillDetailMstListRequest),
typeof(MstApiGetQuestRewardMstListRequest),
typeof(MstApiGetFieldSeriesMstListRequest),
typeof(MstApiGetFieldStageMstListRequest),
typeof(MstApiGetAdvMstListRequest),
typeof(MstApiGetAdvTitleMstListRequest),
typeof(MstApiGetObjectReceiveTypeMstListRequest),
typeof(MstApiGetPayTypeMstListRequest),
typeof(MstApiGetTalismanMstListRequest),
typeof(MstApiGetTalismanParamMstListRequest),
typeof(MstApiGetTalismanParamEffectMstListRequest),
typeof(MstApiGetTalismanSeriesMstListRequest),
typeof(MstApiGetPassiveSkillMstListRequest),
typeof(MstApiGetPassiveSkillDetailMstListRequest),
typeof(MstApiGetLeaderSkillMstListRequest),
typeof(MstApiGetLeaderSkillDetailMstListRequest),
typeof(MstApiGetPvpRankingRewardMstListRequest),
typeof(MstApiGetPvpPointRewardMstListRequest),
typeof(MstApiGetUserTitleMstListRequest),
typeof(MstApiGetGuildTitleMstListRequest),
typeof(MstApiGetUserLevelUpMstListRequest),
typeof(MstApiGetShopSeriesMstListRequest),
typeof(MstApiGetShopMstListRequest),
typeof(MstApiGetShopDetailMstListRequest),
typeof(MstApiGetBannerMstListRequest),
typeof(MstApiGetBannerLabelMstListRequest),
typeof(MstApiGetHomeBannerMstListRequest),
typeof(MstApiGetHomeAppealMstListRequest),
typeof(MstApiGetTipsMstListRequest),
typeof(MstApiGetGveMstListRequest),
typeof(MstApiGetGveStageMstListRequest),
typeof(MstApiGetGveStageRewardMstListRequest),
typeof(MstApiGetMapGveMstListRequest),
typeof(MstApiGetMapGveAreaMstListRequest),
typeof(MstApiGetMapGvePointMstListRequest),
typeof(MstApiGetLoginBonusMstListRequest),
typeof(MstApiGetLoginBonusRewardMstListRequest),
typeof(MstApiGetStyleFigureMstListRequest),
typeof(MstApiGetStyleFigureStoryMstListRequest),
typeof(MstApiGetStyleParamUpTreeMstListRequest),
typeof(MstApiGetStyleParamUpMstListRequest),
typeof(MstApiGetStyleParamUpCostMstListRequest),
typeof(MstApiGetStyleParamUpEffectMstListRequest),
typeof(MstApiGetStyleLimitBreakMstListRequest),
typeof(MstApiGetStyleLimitBreakEffectMstListRequest),
typeof(MstApiGetStyleLevelUpMstListRequest),
typeof(MstApiGetStyleVoiceMstListRequest),
typeof(MstApiGetGvgPointRewardMstListRequest),
typeof(MstApiGetGvgRankingRewardMstListRequest),
typeof(MstApiGetChatStampMstListRequest),
typeof(MstApiGetBattleConditionMstListRequest),
typeof(MstApiGetBattleConditionSetMstListRequest),
typeof(MstApiGetEnemyConditionSetsAndActionMstListRequest),
typeof(MstApiGetDioramaBackgroundMstListRequest),
typeof(MstApiGetGvgMstListRequest),
typeof(MstApiGetSoundMstListRequest),
typeof(MstApiGetCollectionIllustMstListRequest),
typeof(MstApiGetCollectionIllustPieceMstListRequest),
typeof(MstApiGetCollectionParamUpMstListRequest),
typeof(MstApiGetCollectionParamUpLevelMstListRequest),
typeof(MstApiGetCollectionParamUpEffectMstListRequest),
typeof(MstApiGetCollectionConditionGroupMstListRequest),
typeof(MstApiGetCollectionConditionMstListRequest),
typeof(MstApiGetCollectionRewardMstListRequest),
typeof(MstApiGetStoryEventMstListRequest),
typeof(MstApiGetStoryEventQuestStageMstListRequest),
typeof(MstApiGetMiniTutorialMstListRequest),
typeof(MstApiGetStoryEventScenarioMstListRequest),
typeof(MstApiGetStoryEventScenarioRewardMstListRequest),
typeof(MstApiGetStoryEventBonusRateMstListRequest),
typeof(MstApiGetDungeonMstListRequest),
typeof(MstApiGetDungeonTypeMstListRequest),
typeof(MstApiGetDungeonRoomMstListRequest),
typeof(MstApiGetDungeonEventMstListRequest),
typeof(MstApiGetFieldStratumMstListRequest),
typeof(MstApiGetFieldPointMstListRequest),
typeof(MstApiGetBossDirectionMstListRequest),
typeof(MstApiGetGatheringLevelMstListRequest),
typeof(MstApiGetGatheringRewardMstListRequest),
typeof(MstApiGetScoreAttackMstListRequest),
typeof(MstApiGetScoreAttackStageMstListRequest),
typeof(MstApiGetScoreAttackHighScoreRewardMstListRequest),
typeof(MstApiGetScoreAttackTotalScoreRewardMstListRequest),
typeof(MstApiGetCalculationPointPolicyMstListRequest),
typeof(MstApiGetGuildMissionMstListRequest),
typeof(MstApiGetGuildMissionTransitionMstListRequest),
    };

        static async Task Main(string[] args)
        {
            var fmgr = new FarmManager();

            var gclient = fmgr.LoadAccountFromFile("test");
            await gclient.Login();

            var client = new GameClient(HttpClientFactory.Create(),
                gclient.PrivateKey,
                gclient.Uuid);

            // await client.RefreshToken();

            //client.SetVersion("1.0.2");

            var mgr = await AssetManager.CreateFromClient(client);

            if (Debugger.IsAttached)
                goto noasset;

            var i = 0;
            foreach (var item in mgr.Records)
            {
                i++;
                var name = item.name;
                var fn = item.root == "assetbundles/android" ? name + ".unity3d" : name;
                if (File.Exists(fn))
                {
                    var fi = new FileInfo(fn);
                    if (fi.Length == item.size || item.size == 0 && fi.Length != 0)
                        continue;
                    
                    Console.WriteLine($"{item.name} size mismatch: {fi.Length} != {item.size}");
                }

                var parent = Path.GetDirectoryName(name);
                if (!Directory.Exists(parent))
                    Directory.CreateDirectory(parent);
                try
                {
                    File.WriteAllBytes(fn, await mgr.Download(item));

                    Console.WriteLine($"{item.name} done ({i} for {mgr.Records.Length})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"failed to get resource: {item.name} ({i} for {mgr.Records.Length})");
                }
            }

            noasset:

            var root = new Dictionary<string, object>();

            foreach (var type in mstModelRequestTypes)
            {
                dynamic request = Activator.CreateInstance(type)!;

                //var request = new MstApiGetCollectionIllustMstListRequest();

                string url = request.Url;

                var key = url.Split("get_")[1].Split("_mst_list")[0].Trim();
                Console.WriteLine(key);
                var resp = await client.Request(request);

                root[key] = resp;
            }

            File.WriteAllText("master.json", JsonConvert.SerializeObject(root));
        }
    }
}
