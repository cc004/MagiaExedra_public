namespace MagiaClient.Models;

using System;
using System.Collections.Generic;


public class WebPlayApiLoginLogResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class WebPlayApiGetUserMigrationInfoResponse : ResponseBase
{
    public int platform { get; set; }
    public string uniqueId { get; set; }
    public string xuid { get; set; }
    public string userVerify { get; set; }
}

public class WebPayApiPurchaseResponse : ResponseBase
{
    public string result { get; set; }
    public string url { get; set; }
    public string purchaseId { get; set; }
    public int code { get; set; }
    public string message { get; set; }
}

public class WebPayApiGetPurchaseResultResponse : ResponseBase
{
    public WebPayPurchaseResultRecord purchase { get; set; }
}

public class WebPayApiRestoreResponse : ResponseBase
{
    public string result { get; set; }
    public int code { get; set; }
    public string message { get; set; }
}

public class WebPayApiCancelLatestResponse : ResponseBase
{
    public string result { get; set; }
}

public class TitleApiGetTitleTopDataResponse : ResponseBase
{
    public TitleTitleViewData viewData { get; set; }
    public string privacyUrl { get; set; }
}

public class TermsApiGetUpdatedTermsResponse : ResponseBase
{
    public bool needAgree { get; set; }
    public List<TermsTermsInfo> termsList { get; set; }
}

public class TermsApiAgreeLatestTermsResponse : ResponseBase
{
    public bool needAgree { get; set; }
}

public class TermsApiAgreeChatTermsResponse : ResponseBase
{
    public UserUserDataRecord userData { get; set; }
}

public class TalismanApiGetTalismanListResponse : ResponseBase
{
    public List<TalismanTalismanDataRecord> talismanDataList { get; set; }
}

public class TalismanApiTalismanLevelUpResponse : ResponseBase
{
    public TalismanTalismanDataRecord talismanData { get; set; }
    public List<long> deletedTalismanDataIds { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class TalismanApiTalismanSellResponse : ResponseBase
{
    public List<long> deletedTalismanDataIds { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class TalismanApiSetTalismanProtectResponse : ResponseBase
{
    public TalismanTalismanDataRecord talismanData { get; set; }
}

public class ServerApiGetTimeZoneInfoResponse : ResponseBase
{
    public string timezone { get; set; }
    public int offsetSeconds { get; set; }
}

public class ServerApiCertHashListResponse : ResponseBase
{
    public List<string> sslHashList { get; set; }
}

public class SerialCampaignApiInputSerialCodeResponse : ResponseBase
{
    public string viewText { get; set; }
}

public class SerialCampaignApiPreAppLinkResponse : ResponseBase
{
    public string viewText { get; set; }
}

public class SampleApiHttpConnectResponse : ResponseBase
{
    public string replyText { get; set; }
}

public class NotificationApiRegisterResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiSetOsResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiSetLanguageResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiSetRegionResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiSetTimezoneResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiUnsetOsResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiUnsetRegionResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiUnsetLanguageResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiUnsetTimezoneResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiSetTagResponse : ResponseBase
{
    public bool result { get; set; }
}

public class NotificationApiUnsetTagResponse : ResponseBase
{
    public bool result { get; set; }
}

public class MstApiGetItemMstListResponse : ResponseBase
{
    public List<ItemItemMstRecord> mstList { get; set; }
}

public class MstApiGetCardMstListResponse : ResponseBase
{
    public List<CardCardMstRecord> mstList { get; set; }
}

public class MstApiGetCardLimitBreakMstListResponse : ResponseBase
{
    public List<CardCardLimitBreakMstRecord> mstList { get; set; }
}

public class MstApiGetSkillMstListResponse : ResponseBase
{
    public List<SkillSkillMstRecord> mstList { get; set; }
}

public class MstApiGetSkillLevelUpConditionMstListResponse : ResponseBase
{
    public List<SkillSkillLevelUpConditionMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterAwakeMstListResponse : ResponseBase
{
    public List<CharacterCharacterAwakeMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterMstListResponse : ResponseBase
{
    public List<CharacterCharacterMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterProfileMstListResponse : ResponseBase
{
    public List<CharacterCharacterProfileMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterHeartMstListResponse : ResponseBase
{
    public List<CharacterCharacterHeartMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterHeartParamUpGroupMstListResponse : ResponseBase
{
    public List<CharacterCharacterHeartParamUpGroupMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterHeartObjectRewardMstListResponse : ResponseBase
{
    public List<CharacterCharacterHeartObjectRewardMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterHeartLevelUpMstListResponse : ResponseBase
{
    public List<CharacterCharacterHeartLevelUpMstRecord> mstList { get; set; }
}

public class MstApiGetCharacterTeamMstListResponse : ResponseBase
{
    public List<CharacterCharacterTeamMstRecord> mstList { get; set; }
}

public class MstApiGetStyleMstListResponse : ResponseBase
{
    public List<StyleStyleMstRecord> mstList { get; set; }
}

public class MstApiGetTowerMstListResponse : ResponseBase
{
    public List<TowerTowerMstRecord> mstList { get; set; }
}

public class MstApiGetQuestCategoryMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestCategoryMstRecord> mstList { get; set; }
}

public class MstApiGetQuestMapMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestMapMstRecord> mstList { get; set; }
}

public class MstApiGetQuestGroupMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestGroupMstRecord> mstList { get; set; }
}

public class MstApiGetQuestStageMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestStageMstRecord> mstList { get; set; }
}

public class MstApiGetQuestConditionMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestConditionMstRecord> mstList { get; set; }
}

public class MstApiGetMissionTitleMstListResponse : ResponseBase
{
    public List<MissionMissionTitleMstRecord> mstList { get; set; }
}

public class MstApiGetMissionTransitionMstListResponse : ResponseBase
{
    public List<MissionMissionTransitionMstRecord> mstList { get; set; }
}

public class MstApiGetSubscriptionMissionRewardMstListResponse : ResponseBase
{
    public List<MissionSubscriptionMissionRewardMstRecord> mstList { get; set; }
}

public class MstApiGetMissionMstListResponse : ResponseBase
{
    public List<MissionMissionMstRecord> mstList { get; set; }
}

public class MstApiGetEnemyMstListResponse : ResponseBase
{
    public List<QuestOutGameEnemyMstRecord> mstList { get; set; }
}

public class MstApiGetEnemyProfileMstListResponse : ResponseBase
{
    public List<QuestOutGameEnemyProfileMstRecord> mstList { get; set; }
}

public class MstApiGetQuestEnemyAppearanceMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestEnemyAppearanceMstRecord> mstList { get; set; }
}

public class MstApiGetQuestEnemySkillSetMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestEnemySkillSetMstRecord> mstList { get; set; }
}

public class MstApiGetBreakMstListResponse : ResponseBase
{
    public List<QuestOutGameBreakMstRecord> mstList { get; set; }
}

public class MstApiGetAbilityEffectTypeMstListResponse : ResponseBase
{
    public List<SkillAbilityEffectTypeMstRecord> mstList { get; set; }
}

public class MstApiGetSkillDetailMstListResponse : ResponseBase
{
    public List<SkillSkillDetailMstRecord> mstList { get; set; }
}

public class MstApiGetQuestRewardMstListResponse : ResponseBase
{
    public List<QuestOutGameQuestRewardMstRecord> mstList { get; set; }
}

public class MstApiGetFieldSeriesMstListResponse : ResponseBase
{
    public List<ExplorationFieldSeriesMstRecord> mstList { get; set; }
}

public class MstApiGetFieldStageMstListResponse : ResponseBase
{
    public List<ExplorationFieldStageMstRecord> mstList { get; set; }
}

public class MstApiGetAdvMstListResponse : ResponseBase
{
    public List<ExplorationAdvMstRecord> mstList { get; set; }
}

public class MstApiGetAdvTitleMstListResponse : ResponseBase
{
    public List<ExplorationAdvTitleMstRecord> mstList { get; set; }
}

public class MstApiGetObjectReceiveTypeMstListResponse : ResponseBase
{
    public List<ObjectObjectReceiveTypeMstRecord> mstList { get; set; }
}

public class MstApiGetPayTypeMstListResponse : ResponseBase
{
    public List<ObjectPayTypeMstRecord> mstList { get; set; }
}

public class MstApiGetTalismanMstListResponse : ResponseBase
{
    public List<TalismanTalismanMstRecord> mstList { get; set; }
}

public class MstApiGetTalismanParamMstListResponse : ResponseBase
{
    public List<TalismanTalismanParamMstRecord> mstList { get; set; }
}

public class MstApiGetTalismanParamEffectMstListResponse : ResponseBase
{
    public List<TalismanTalismanParamEffectMstRecord> mstList { get; set; }
}

public class MstApiGetTalismanSeriesMstListResponse : ResponseBase
{
    public List<TalismanTalismanSeriesMstRecord> mstList { get; set; }
}

public class MstApiGetPassiveSkillMstListResponse : ResponseBase
{
    public List<SkillPassiveSkillMstRecord> mstList { get; set; }
}

public class MstApiGetPassiveSkillDetailMstListResponse : ResponseBase
{
    public List<SkillPassiveSkillDetailMstRecord> mstList { get; set; }
}

public class MstApiGetLeaderSkillMstListResponse : ResponseBase
{
    public List<SkillLeaderSkillMstRecord> mstList { get; set; }
}

public class MstApiGetLeaderSkillDetailMstListResponse : ResponseBase
{
    public List<SkillLeaderSkillDetailMstRecord> mstList { get; set; }
}

public class MstApiGetPvpRankingRewardMstListResponse : ResponseBase
{
    public List<PvpPvpRankingRewardMstRecord> mstList { get; set; }
}

public class MstApiGetPvpPointRewardMstListResponse : ResponseBase
{
    public List<PvpPvpPointRewardMstRecord> mstList { get; set; }
}

public class MstApiGetUserTitleMstListResponse : ResponseBase
{
    public List<UserTitleUserTitleMstRecord> mstList { get; set; }
}

public class MstApiGetGuildTitleMstListResponse : ResponseBase
{
    public List<GuildGuildTitleMstRecord> mstList { get; set; }
}

public class MstApiGetUserLevelUpMstListResponse : ResponseBase
{
    public List<UserUserLevelUpMstRecord> mstList { get; set; }
}

public class MstApiGetShopSeriesMstListResponse : ResponseBase
{
    public List<ShopShopSeriesMstRecord> mstList { get; set; }
}

public class MstApiGetShopMstListResponse : ResponseBase
{
    public List<ShopShopMstRecord> mstList { get; set; }
}

public class MstApiGetShopDetailMstListResponse : ResponseBase
{
    public List<ShopShopDetailMstRecord> mstList { get; set; }
}

public class MstApiGetBannerMstListResponse : ResponseBase
{
    public List<HomeBannerMstRecord> mstList { get; set; }
}

public class MstApiGetBannerLabelMstListResponse : ResponseBase
{
    public List<HomeBannerLabelMstRecord> mstList { get; set; }
}

public class MstApiGetHomeBannerMstListResponse : ResponseBase
{
    public List<HomeHomeBannerMstRecord> mstList { get; set; }
}

public class MstApiGetHomeAppealMstListResponse : ResponseBase
{
    public List<HomeHomeAppealMstRecord> mstList { get; set; }
}

public class MstApiGetTipsMstListResponse : ResponseBase
{
    public List<TipsTipsMstRecord> mstList { get; set; }
}

public class MstApiGetGveMstListResponse : ResponseBase
{
    public List<GveGveMstRecord> mstList { get; set; }
}

public class MstApiGetGveStageMstListResponse : ResponseBase
{
    public List<GveGveStageMstRecord> mstList { get; set; }
}

public class MstApiGetGveStageRewardMstListResponse : ResponseBase
{
    public List<GveGveStageRewardMstRecord> mstList { get; set; }
}

public class MstApiGetMapGveMstListResponse : ResponseBase
{
    public List<MapGveMapGveMstRecord> mstList { get; set; }
}

public class MstApiGetMapGveAreaMstListResponse : ResponseBase
{
    public List<MapGveMapGveAreaMstRecord> mstList { get; set; }
}

public class MstApiGetMapGvePointMstListResponse : ResponseBase
{
    public List<MapGveMapGvePointMstRecord> mstList { get; set; }
}

public class MstApiGetLoginBonusMstListResponse : ResponseBase
{
    public List<LoginBonusLoginBonusMstRecord> mstList { get; set; }
}

public class MstApiGetLoginBonusRewardMstListResponse : ResponseBase
{
    public List<LoginBonusLoginBonusRewardMstRecord> mstList { get; set; }
}

public class MstApiGetStyleFigureMstListResponse : ResponseBase
{
    public List<StyleStyleFigureMstRecord> mstList { get; set; }
}

public class MstApiGetStyleFigureStoryMstListResponse : ResponseBase
{
    public List<StyleStyleFigureStoryMstRecord> mstList { get; set; }
}

public class MstApiGetStyleParamUpTreeMstListResponse : ResponseBase
{
    public List<StyleStyleParamUpTreeMstRecord> mstList { get; set; }
}

public class MstApiGetStyleParamUpMstListResponse : ResponseBase
{
    public List<StyleStyleParamUpMstRecord> mstList { get; set; }
}

public class MstApiGetStyleParamUpCostMstListResponse : ResponseBase
{
    public List<StyleStyleParamUpCostMstRecord> mstList { get; set; }
}

public class MstApiGetStyleParamUpEffectMstListResponse : ResponseBase
{
    public List<StyleStyleParamUpEffectMstRecord> mstList { get; set; }
}

public class MstApiGetStyleLimitBreakMstListResponse : ResponseBase
{
    public List<StyleStyleLimitBreakMstRecord> mstList { get; set; }
}

public class MstApiGetStyleLimitBreakEffectMstListResponse : ResponseBase
{
    public List<StyleStyleLimitBreakEffectMstRecord> mstList { get; set; }
}

public class MstApiGetStyleLevelUpMstListResponse : ResponseBase
{
    public List<StyleStyleLevelUpMstRecord> mstList { get; set; }
}

public class MstApiGetStyleVoiceMstListResponse : ResponseBase
{
    public List<StyleStyleVoiceMstRecord> mstList { get; set; }
}

public class MstApiGetGvgPointRewardMstListResponse : ResponseBase
{
    public List<GvgGvgPointRewardMstRecord> mstList { get; set; }
}

public class MstApiGetGvgRankingRewardMstListResponse : ResponseBase
{
    public List<GvgGvgRankingRewardMstRecord> mstList { get; set; }
}

public class MstApiGetChatStampMstListResponse : ResponseBase
{
    public List<ChatChatStampMstRecord> mstList { get; set; }
}

public class MstApiGetBattleConditionMstListResponse : ResponseBase
{
    public List<QuestBattleBattleConditionMstRecord> mstList { get; set; }
}

public class MstApiGetBattleConditionSetMstListResponse : ResponseBase
{
    public List<QuestBattleBattleConditionSetMstRecord> mstList { get; set; }
}

public class MstApiGetEnemyConditionSetsAndActionMstListResponse : ResponseBase
{
    public List<QuestBattleEnemyConditionSetsAndActionMstRecord> mstList { get; set; }
}

public class MstApiGetDioramaBackgroundMstListResponse : ResponseBase
{
    public List<CollectionDioramaBackgroundMstRecord> mstList { get; set; }
}

public class MstApiGetLive2DParamMstListResponse : ResponseBase
{
    public List<CollectionLive2DParamMstRecord> mstList { get; set; }
}

public class MstApiGetGvgMstListResponse : ResponseBase
{
    public List<GvgGvgMstRecord> mstList { get; set; }
}

public class MstApiGetSoundMstListResponse : ResponseBase
{
    public List<SoundSoundMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionIllustMstListResponse : ResponseBase
{
    public List<CollectionCollectionIllustMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionIllustPieceMstListResponse : ResponseBase
{
    public List<CollectionCollectionIllustPieceMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionParamUpMstListResponse : ResponseBase
{
    public List<CollectionCollectionParamUpMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionParamUpLevelMstListResponse : ResponseBase
{
    public List<CollectionCollectionParamUpLevelMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionParamUpEffectMstListResponse : ResponseBase
{
    public List<CollectionCollectionParamUpEffectMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionConditionGroupMstListResponse : ResponseBase
{
    public List<CollectionCollectionConditionGroupMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionConditionMstListResponse : ResponseBase
{
    public List<CollectionCollectionConditionMstRecord> mstList { get; set; }
}

public class MstApiGetCollectionRewardMstListResponse : ResponseBase
{
    public List<CollectionCollectionRewardMstRecord> mstList { get; set; }
}

public class MstApiGetStoryEventMstListResponse : ResponseBase
{
    public List<StoryEventStoryEventMstRecord> mstList { get; set; }
}

public class MstApiGetStoryEventQuestStageMstListResponse : ResponseBase
{
    public List<StoryEventStoryEventQuestStageMstRecord> mstList { get; set; }
}

public class MstApiGetMiniTutorialMstListResponse : ResponseBase
{
    public List<TutorialMiniTutorialMstRecord> mstList { get; set; }
}

public class MstApiGetStoryEventScenarioMstListResponse : ResponseBase
{
    public List<StoryEventStoryEventScenarioMstRecord> mstList { get; set; }
}

public class MstApiGetStoryEventScenarioRewardMstListResponse : ResponseBase
{
    public List<StoryEventStoryEventScenarioRewardMstRecord> mstList { get; set; }
}

public class MstApiGetStoryEventBonusRateMstListResponse : ResponseBase
{
    public List<StoryEventStoryEventBonusRateMstRecord> mstList { get; set; }
}

public class MstApiGetDungeonMstListResponse : ResponseBase
{
    public List<DungeonDungeonMstRecord> mstList { get; set; }
}

public class MstApiGetDungeonTypeMstListResponse : ResponseBase
{
    public List<DungeonDungeonTypeMstRecord> mstList { get; set; }
}

public class MstApiGetDungeonRoomMstListResponse : ResponseBase
{
    public List<DungeonDungeonRoomMstRecord> mstList { get; set; }
}

public class MstApiGetDungeonEventMstListResponse : ResponseBase
{
    public List<DungeonDungeonEventMstRecord> mstList { get; set; }
}

public class MstApiGetFieldStratumMstListResponse : ResponseBase
{
    public List<ExplorationFieldStratumMstRecord> mstList { get; set; }
}

public class MstApiGetFieldPointMstListResponse : ResponseBase
{
    public List<ExplorationFieldPointMstRecord> mstList { get; set; }
}

public class MstApiGetBossDirectionMstListResponse : ResponseBase
{
    public List<ExplorationBossDirectionMstRecord> mstList { get; set; }
}

public class MstApiGetGatheringLevelMstListResponse : ResponseBase
{
    public List<GatheringGatheringLevelMstRecord> mstList { get; set; }
}

public class MstApiGetGatheringRewardMstListResponse : ResponseBase
{
    public List<GatheringGatheringRewardMstRecord> mstList { get; set; }
}

public class MstApiGetScoreAttackMstListResponse : ResponseBase
{
    public List<ScoreAttackScoreAttackMstRecord> mstList { get; set; }
}

public class MstApiGetScoreAttackStageMstListResponse : ResponseBase
{
    public List<ScoreAttackScoreAttackStageMstRecord> mstList { get; set; }
}

public class MstApiGetScoreAttackHighScoreRewardMstListResponse : ResponseBase
{
    public List<ScoreAttackScoreAttackHighScoreRewardMstRecord> mstList { get; set; }
}

public class MstApiGetScoreAttackTotalScoreRewardMstListResponse : ResponseBase
{
    public List<ScoreAttackScoreAttackTotalScoreRewardMstRecord> mstList { get; set; }
}

public class MstApiGetCalculationPointPolicyMstListResponse : ResponseBase
{
    public List<CalcPointCalculationPointPolicyMstRecord> mstList { get; set; }
}

public class MstApiGetGuildMissionMstListResponse : ResponseBase
{
    public List<GuildMissionGuildMissionMstRecord> mstList { get; set; }
}

public class MstApiGetGuildMissionTransitionMstListResponse : ResponseBase
{
    public List<GuildMissionGuildMissionTransitionMstRecord> mstList { get; set; }
}

public class MapGveApiGetTopInfoResponse : ResponseBase
{
    public UserUserParamDataRecord userParamData { get; set; }
    public MapGveMapGveUserDataRecord mapGveUserData { get; set; }
    public MapGveMapGveGuildDataRecord mapGveGuildData { get; set; }
    public List<MapGveMapGveRankingRecord> rankingInfo { get; set; }
}

public class MapGveApiReachPointResponse : ResponseBase
{
    public MapGveMapGveUserDataRecord mapGveUserData { get; set; }
    public MapGveMapGveGuildDataRecord mapGveGuildData { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class LoginApiLoginResponse : ResponseBase
{
    public string sessionId { get; set; }
    public long userId { get; set; }
    public int status { get; set; }
    public int banType { get; set; }
}

public class InAppSnsApiCreateLoginUrlResponse : ResponseBase
{
    public string url { get; set; }
    public string state { get; set; }
}

public class InAppSnsApiGetAccessTokenResponse : ResponseBase
{
    public InAppSnsAccessToken token { get; set; }
}

public class HariboteChatApiGetMessageDataListResponse : ResponseBase
{
    public List<HariboteChatMessageDataRecord> messageDataList { get; set; }
}

public class HariboteChatApiSendMessageResponse : ResponseBase
{
    public HariboteChatMessageDataRecord messageData { get; set; }
}

public class FirestoreApiCreateTokenResponse : ResponseBase
{
    public string token { get; set; }
}

public class ExplorationBattleApiInitializeStageV4Response : ResponseBase
{
    public int initializeStatus { get; set; }
    public QuestBattleQuestRoomData questRoomData { get; set; }
    public bool isFirstBattle { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class ExplorationBattleApiFinalizeStageForUserV4Response : ResponseBase
{
    public QuestBattleResult result { get; set; }
    public int beforeLevel { get; set; }
    public int afterLevel { get; set; }
    public int beforeExp { get; set; }
    public int afterExp { get; set; }
    public int beforeStamina { get; set; }
    public ExplorationFieldStageUserDataRecord fieldStageUserData { get; set; }
    public List<int> acquiredQuestRewardMstIds { get; set; }
    public List<int> acquiredOtherCollectionQuestRewardMstIds { get; set; }
    public bool canReplay { get; set; }
    public int remainPlayCount { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<ItemItemDataRecord> keyItemDataList { get; set; }
    public List<CharacterCharacterLevelUpInfo> characterLevelUpInfoList { get; set; }
    public List<StyleStyleLevelUpInfo> styleLevelUpInfoList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public List<int> achievedConditionGroupIds { get; set; }
    public CollectionFieldStageCollectionInfo fieldStageCollectionInfo { get; set; }
    public List<TutorialFeatureRelease> featureReleaseList { get; set; }
    public int nextBattleQuestStageMstId { get; set; }
    public int nextBattleFieldPointMstId { get; set; }
    public bool isFirstClear { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
    public bool isStoreReview { get; set; }
    public int acquiredRewardMoney { get; set; }
}

public class ExplorationBattleApiGetExplorationInfoResponse : ResponseBase
{
    public ExplorationBattleStageInfo stageInfo { get; set; }
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
}

public class ExplorationBattleApiRetireResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class DebugUserApiRecoverStaminaResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class DebugSubscriptionApiIsValidSubscriptionResponse : ResponseBase
{
    public bool isValid { get; set; }
}

public class DebugSubscriptionApiDoSubscribeForceResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class ConfigApiGetConfigResponse : ResponseBase
{
    public LoginBonusLoginBonusConfig loginBonusConfig { get; set; }
    public CharacterCharacterConfig characterConfig { get; set; }
    public CardCardConfig cardConfig { get; set; }
    public CollectionCollectionConfig collectionConfig { get; set; }
    public StyleStyleConfig styleConfig { get; set; }
    public PvpPvpConfig pvpConfig { get; set; }
    public TalismanTalismanConfig talismanConfig { get; set; }
    public MissionMissionConfig missionConfig { get; set; }
    public GuildGuildConfig guildConfig { get; set; }
    public GveGveConfig gveConfig { get; set; }
    public PresentPresentBoxConfig presentBoxConfig { get; set; }
    public UserUserConfig userConfig { get; set; }
    public QuestOutGameQuestConfig questConfig { get; set; }
    public TutorialTutorialConfig tutorialConfig { get; set; }
    public TowerTowerConfig towerConfig { get; set; }
    public PartyPartyConfig partyConfig { get; set; }
    public ShopSubscriptionConfig subscriptionConfig { get; set; }
    public StoryEventStoryEventConfig storyEventConfig { get; set; }
    public ChatChatConfig chatConfig { get; set; }
    public ConfigFirestoreConfig firestoreConfig { get; set; }
    public TermsTermsConfig termsConfig { get; set; }
    public GatheringGatheringConfig gatheringConfig { get; set; }
    public GvgGvgConfig gvgConfig { get; set; }
    public ScoreAttackScoreAttackConfig scoreAttackConfig { get; set; }
    public ConfigAppResourceConfig appResourceConfig { get; set; }
    public bool isPreRelease { get; set; }
}

public class AppVersionApiGetReviewVersionDataResponse : ResponseBase
{
    public bool isReviewVersion { get; set; }
}

public class AkamaiApiCreateTokenResponse : ResponseBase
{
    public string token { get; set; }
}

public class TowerApiGetTowerTopResponse : ResponseBase
{
    public TowerUserTowerDataRecord userTowerData { get; set; }
    public TowerSkipFloorDataRecord skipFloorData { get; set; }
    public List<QuestOutGameUserQuestStageDataRecord> userQuestStageDataList { get; set; }
}

public class TowerApiRecoverySkipNumResponse : ResponseBase
{
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public TowerUserTowerDataRecord userTowerData { get; set; }
}

public class TowerApiSkipQuestBattleResponse : ResponseBase
{
    public QuestBattleResult result { get; set; }
    public int beforeLevel { get; set; }
    public int afterLevel { get; set; }
    public int beforeExp { get; set; }
    public int afterExp { get; set; }
    public int beforeStamina { get; set; }
    public QuestOutGameUserQuestStageDataRecord userQuestStageData { get; set; }
    public List<int> acquiredQuestRewardMstIds { get; set; }
    public bool canReplay { get; set; }
    public int remainPlayCount { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<ItemItemDataRecord> keyItemDataList { get; set; }
    public List<CharacterCharacterLevelUpInfo> characterLevelUpInfoList { get; set; }
    public List<StyleStyleLevelUpInfo> styleLevelUpInfoList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public TowerUserTowerDataRecord userTowerData { get; set; }
    public int acquiredRewardMoney { get; set; }
}

public class StyleApiGetStyleDataListResponse : ResponseBase
{
    public List<StyleStyleDataRecord> styleDataList { get; set; }
}

public class StyleApiStyleLevelUpResponse : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public StyleStyleLevelUpInfo styleLevelUpInfo { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class StyleApiStyleLevelUpVer2Response : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public StyleStyleLevelUpInfo styleLevelUpInfo { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class StyleApiStyleSkillLevelUpResponse : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class StyleApiStyleSpecialAttackSkillLevelUpResponse : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class StyleApiStyleLimitBreakResponse : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class StyleApiOpenStyleParamUpTreeResponse : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class StyleApiStyleParamUpResponse : ResponseBase
{
    public StyleStyleDataRecord styleData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class StyleApiUpdateAlreadyViewResponse : ResponseBase
{
    public List<StyleStyleDataRecord> styleDataList { get; set; }
}

public class StoryEventApiGetTopResponse : ResponseBase
{
    public List<StoryEventStoryEventDataRecord> storyEventDataList { get; set; }
    public List<StoryEventStoryEventInfo> storyEventInfoList { get; set; }
    public List<int> questStageMstIdList { get; set; }
    public List<QuestOutGameUserQuestStageDataRecord> userQuestStageDataList { get; set; }
    public List<QuestOutGameUserQuestGroupDataRecord> userQuestGroupOpenDataList { get; set; }
    public List<int> storyEventScenarioMstIdList { get; set; }
    public List<int> clearStoryEventScenarioMstIdList { get; set; }
    public List<int> scoreAttackMstIdList { get; set; }
    public List<ScoreAttackUserScoreAttackDataRecord> userScoreAttackDataList { get; set; }
    public bool enableEventMissionBadge { get; set; }
}

public class StoryEventApiGetArchiveEventListResponse : ResponseBase
{
    public List<StoryEventStoryEventDataRecord> storyEventDataList { get; set; }
    public List<StoryEventStoryEventInfo> storyEventInfoList { get; set; }
    public List<int> questStageMstIdList { get; set; }
    public List<QuestOutGameUserQuestStageDataRecord> userQuestStageDataList { get; set; }
    public List<QuestOutGameUserQuestGroupDataRecord> userQuestGroupOpenDataList { get; set; }
    public List<int> storyEventScenarioMstIdList { get; set; }
    public List<int> clearStoryEventScenarioMstIdList { get; set; }
}

public class StoryEventApiOpenStoryResponse : ResponseBase
{
    public List<QuestOutGameUserQuestGroupDataRecord> userQuestGroupOpenDataList { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class StoryEventApiScenarioReadResponse : ResponseBase
{
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class StoryEventApiRecoverPlayableCountResponse : ResponseBase
{
    public StoryEventStoryEventDataRecord storyEventData { get; set; }
}

public class ShopApiGetShopListResponse : ResponseBase
{
    public List<ShopShopCountDataRecord> shopCountDataList { get; set; }
}

public class ShopApiBuyResponse : ResponseBase
{
    public ShopBuyViewData viewData { get; set; }
    public ShopShopCountDataRecord shopCountData { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class ShopApiGetShopPaymentMstListResponse : ResponseBase
{
    public List<ShopShopPaymentMstRecord> shopPaymentMstList { get; set; }
    public List<ShopShopPaymentBonusRewardMstRecord> shopPaymentBonusRewardMstList { get; set; }
}

public class ScoreAttackApiGetScoreAttackTopResponse : ResponseBase
{
    public int selfRanking { get; set; }
    public ScoreAttackUserScoreAttackDataRecord userScoreAttackData { get; set; }
}

public class ScoreAttackApiGetRankingInfoResponse : ResponseBase
{
    public int selfRanking { get; set; }
    public List<ScoreAttackRankingInfo> rankingInfoList { get; set; }
    public ScoreAttackUserScoreAttackDataRecord userScoreAttackData { get; set; }
}

public class ScoreAttackApiInitializeStageResponse : ResponseBase
{
    public int initializeStatus { get; set; }
    public ScoreAttackScoreAttackRoomData scoreAttackRoomData { get; set; }
    public QuestOutGameUserQuestStageDataRecord userQuestStageData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class ScoreAttackApiGetScoreAttackInfoResponse : ResponseBase
{
    public ScoreAttackStageInfo stageInfo { get; set; }
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
}

public class ScoreAttackApiFinalizeStageForUserResponse : ResponseBase
{
    public QuestBattleResult result { get; set; }
    public int questStageMstId { get; set; }
    public ScoreAttackScoreInfo scoreInfo { get; set; }
    public bool isHighScoreUpdated { get; set; }
    public int selfRanking { get; set; }
    public ScoreAttackUserScoreAttackDataRecord beforeUserScoreAttackData { get; set; }
    public ScoreAttackUserScoreAttackDataRecord afterUserScoreAttackData { get; set; }
    public List<int> acquiredScoreAttackHighScoreRewardMstIds { get; set; }
    public List<int> acquiredScoreAttackTotalScoreRewardMstIds { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public PartyPartyDataRecord partyData { get; set; }
}

public class ScoreAttackApiRetireResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class PvpApiGetPvpTopResponse : ResponseBase
{
    public PvpPvpTopInfo pvpTopInfo { get; set; }
}

public class PvpApiGetRankingInfoResponse : ResponseBase
{
    public int mode { get; set; }
    public int selfRanking { get; set; }
    public List<PvpRankingInfo> rankingInfoList { get; set; }
}

public class PvpApiGetCandidateEnemyUserListResponse : ResponseBase
{
    public PvpPvpUserInfo selfUserInfo { get; set; }
    public List<PvpPvpUserInfo> candidateEnemyUserInfoList { get; set; }
}

public class PvpApiGetEnemyUserInfoResponse : ResponseBase
{
    public PvpPvpUserInfo enemyUserInfo { get; set; }
    public int leaderStyleMstId { get; set; }
    public List<PartyCharacterBuildDetail> characterBuildDetailList { get; set; }
}

public class PvpApiInitializeStageResponse : ResponseBase
{
    public string roomId { get; set; }
}

public class PvpApiRetireResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class PvpApiGetPvpInfoResponse : ResponseBase
{
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<QuestBattleBattleUnit> enemyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
    public List<PartyCharacterBuildDetail> enemyCharacterBuildDetailList { get; set; }
    public int limitSecond { get; set; }
}

public class PvpApiFinalizeStageResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class PvpApiFinalizeStageForUserResponse : ResponseBase
{
    public int addBasePvpPoint { get; set; }
    public int addBonusPvpPoint { get; set; }
    public int addRelativelyBonusPoint { get; set; }
    public int addBattleTurnBonusPoint { get; set; }
    public int addAliveBonusPoint { get; set; }
    public int addWinStreakBonusPoint { get; set; }
    public PvpPointInfo pointInfo { get; set; }
    public int relativelyLevel { get; set; }
    public int resultRound { get; set; }
    public int aliveCount { get; set; }
    public int afterPvpPoint { get; set; }
    public int winStreakCount { get; set; }
    public int beforeRanking { get; set; }
    public int afterRanking { get; set; }
    public int leastNextRewardPoint { get; set; }
    public List<PvpRewardInfo> pointRewardList { get; set; }
}

public class PvpApiGetMatchHistoryResponse : ResponseBase
{
    public List<PvpMatchHistory> matchHistoryList { get; set; }
}

public class PvpApiGetMatchDetailHistoryResponse : ResponseBase
{
    public PvpMatchHistory matchHistory { get; set; }
    public List<PvpCharacterBuildInfo> offenseCharacterBuildInfoList { get; set; }
    public List<PvpCharacterBuildInfo> defenseCharacterBuildInfoList { get; set; }
}

public class PvpApiGetMatchCharacterBuildDetailResponse : ResponseBase
{
    public int leaderStyleMstId { get; set; }
    public List<PartyCharacterBuildDetail> characterBuildDetailList { get; set; }
}

public class PvpApiGetRankingUserCharacterBuildDetailResponse : ResponseBase
{
    public int leaderStyleMstId { get; set; }
    public List<PartyCharacterBuildDetail> characterBuildDetailList { get; set; }
}

public class UserTitleApiGetUserTitleDataListResponse : ResponseBase
{
    public List<UserTitleUserTitleDataRecord> userTitleDataList { get; set; }
}

public class UserApiGetUserDataResponse : ResponseBase
{
    public UserUserDataRecord userData { get; set; }
}

public class UserApiGetUserParamDataResponse : ResponseBase
{
    public UserUserParamDataRecord userParamData { get; set; }
}

public class UserApiGetInitDataListResponse : ResponseBase
{
    public List<CardCardDataRecord> cardDataList { get; set; }
    public List<PartyCharacterBuildDataRecord> characterBuildDataList { get; set; }
    public List<CharacterCharacterDataRecord> characterDataList { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public List<StyleStyleDataRecord> styleDataList { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
    public UserUserDataRecord userData { get; set; }
}

public class UserApiGetUserProfileDataResponse : ResponseBase
{
    public UserUserProfileDataRecord userProfileData { get; set; }
    public string playerId { get; set; }
    public string createdTime { get; set; }
}

public class UserApiGetOtherUserProfileDataResponse : ResponseBase
{
    public UserUserParamDataRecord otherUserParamData { get; set; }
    public UserUserProfileDataRecord otherUserProfileData { get; set; }
    public string otherUserPlayerId { get; set; }
    public List<CharacterUseCharacterRankingRecord> useCharacterRankingList { get; set; }
    public int altogetherMissionNum { get; set; }
    public int characterNum { get; set; }
    public int styleNum { get; set; }
    public int pvpRank { get; set; }
    public GuildGuildDataRecord guildData { get; set; }
    public GuildGuildRequestDataRecord guildRequestData { get; set; }
    public PartyPartyDataRecord otherPartyData { get; set; }
    public List<PartyCharacterBuildDataRecord> otherCharacterBuildDataList { get; set; }
    public List<CharacterCharacterDataRecord> otherCharacterDataList { get; set; }
    public List<StyleStyleDataRecord> otherStyleDataList { get; set; }
    public List<CardCardDataRecord> otherCardDataList { get; set; }
    public List<TalismanTalismanDataRecord> otherTalismanDataList { get; set; }
    public CollectionCollectionParamUpAchieveDataRecord otherCollectionParamUpAchieveData { get; set; }
    public string createdTime { get; set; }
}

public class UserApiSetNameResponse : ResponseBase
{
    public UserUserParamDataRecord userParamData { get; set; }
}

public class UserApiSetCommentResponse : ResponseBase
{
    public UserUserProfileDataRecord userProfileData { get; set; }
}

public class UserApiSetFavoriteInfoResponse : ResponseBase
{
    public UserUserProfileDataRecord userProfileData { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class UserApiSetDisplayUserTitleResponse : ResponseBase
{
    public UserUserProfileDataRecord userProfileData { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class UserApiSetStaminaRecoverResponse : ResponseBase
{
    public UserUserParamDataRecord userParamData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class UserApiSaveOptionResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class UserApiLoadOptionResponse : ResponseBase
{
    public bool paymentAlert { get; set; }
    public bool battleDirectionSkip { get; set; }
    public bool battleActionTimeView { get; set; }
}

public class UserApiUserSearchResponse : ResponseBase
{
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<UserUserProfileDataRecord> userProfileDataList { get; set; }
    public List<UserUserDisplayInfo> userDisplayInfoList { get; set; }
}

public class UserApiGetUserSubscriptionDataResponse : ResponseBase
{
    public List<UserUserSubscriptionDataRecord> userSubscriptionDataList { get; set; }
}

public class UserApiGetUserDisplayInfoListResponse : ResponseBase
{
    public List<UserUserDisplayInfo> userDisplayInfoList { get; set; }
}

public class UserApiInitConfigResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class UserApiAccountDeleteResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class UserApiStoreReviewResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class UserApiGetPlayerIdResponse : ResponseBase
{
    public string playerId { get; set; }
}

public class PresentApiGetPresentDataListResponse : ResponseBase
{
    public List<PresentPresentDataRecord> presentDataList { get; set; }
}

public class PresentApiGetReceivedHistoryResponse : ResponseBase
{
    public List<PresentPresentDataRecord> presentDataList { get; set; }
}

public class PresentApiGetNoReceivedPresentNumResponse : ResponseBase
{
    public int num { get; set; }
}

public class PresentApiReceiveResponse : ResponseBase
{
    public int expireTimeOverNum { get; set; }
    public List<PresentPresentDataRecord> receivedPresentDataList { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class MissionApiGetMissionDataListResponse : ResponseBase
{
    public int currentMissionTitleMstId { get; set; }
    public List<MissionMissionDataRecord> missionDataList { get; set; }
    public List<string> enableSubscriptionLabel { get; set; }
    public List<int> rewardReceivableMissionTypeList { get; set; }
    public List<GuildMissionGuildMissionDataRecord> guildMissionDataList { get; set; }
    public GuildGuildUserDataRecord guildUserData { get; set; }
    public bool enableComebackButton { get; set; }
}

public class MissionApiReceiveResponse : ResponseBase
{
    public List<MissionMissionDataRecord> missionDataList { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<MissionreceivedObjectData> receivedObjectDataList { get; set; }
    public int currentMissionTitleMstId { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public List<int> rewardReceivableMissionTypeList { get; set; }
}

public class TutorialApiUpdateTutorialStepResponse : ResponseBase
{
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class TutorialApiGetMiniTutorialDataResponse : ResponseBase
{
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class TutorialApiExecMiniTutorialResponse : ResponseBase
{
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class TutorialApiGetPrologueBattleInfoResponse : ResponseBase
{
    public int questStageMstId { get; set; }
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
}

public class TutorialApiSkipTutorialToGachaResponse : ResponseBase
{
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class ItemApiGetItemDataListResponse : ResponseBase
{
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class ItemApiGetItemDataListByItemMstIdListResponse : ResponseBase
{
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class ItemApiUseItemResponse : ResponseBase
{
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class ItemApiSellItemResponse : ResponseBase
{
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class HomeApiGetHomeInfoResponse : ResponseBase
{
    public HomeHomeViewData viewData { get; set; }
    public List<HomeLoginBonusRecord> loginBonusDataList { get; set; }
    public UserUserProfileDataRecord userProfileData { get; set; }
    public UserComebackUserDataRecord comebackUserData { get; set; }
    public long questBattleRoomId { get; set; }
    public bool backGroundPlay { get; set; }
    public long explorationBattleRoomId { get; set; }
    public long gveRoomId { get; set; }
    public string pvpRoomId { get; set; }
    public string gvgRoomId { get; set; }
    public long scoreAttackRoomId { get; set; }
    public List<int> achievedConditionGroupIds { get; set; }
    public List<UserUserSubscriptionDataRecord> userSubscriptionDataList { get; set; }
    public List<int> finishedMiniTutorialNumberList { get; set; }
    public string bgmCueSheetName { get; set; }
    public string bgmCueName { get; set; }
    public string gatheringTime { get; set; }
    public UserUserLevelUpInfo userLevelUpInfo { get; set; }
    public GatheringUserGatheringDataRecord userGatheringData { get; set; }
    public int nextChallengeFieldStageMstId { get; set; }
}

public class GvgApiGetTopResponse : ResponseBase
{
    public GvgGvgGuildInfo gvgGuildInfo { get; set; }
    public GvgGvgEnemyGuildInfo gvgEnemyGuildInfo { get; set; }
    public List<GvgMatchTopInfo> allyMatchTopInfoList { get; set; }
    public List<GvgMatchTopInfo> enemyMatchTopInfoList { get; set; }
    public int day { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string preLeagueStartTime { get; set; }
    public string preLeagueEndTime { get; set; }
    public string leagueStartTime { get; set; }
    public string leagueEndTime { get; set; }
    public string resourceName { get; set; }
    public bool canPlayTodayBattle { get; set; }
    public int eventStateType { get; set; }
}

public class GvgApiGetMatchHistoryResponse : ResponseBase
{
    public List<GvgMatchHistory> matchHistoryList { get; set; }
}

public class GvgApiGetMatchDetailHistoryResponse : ResponseBase
{
    public GvgMatchHistory matchHistory { get; set; }
    public List<PvpCharacterBuildInfo> allyCharacterBuildInfoList { get; set; }
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<PvpCharacterBuildInfo> enemyCharacterBuildInfoList { get; set; }
    public List<QuestBattleBattleUnit> enemyBattleUnitList { get; set; }
}

public class GvgApiGetMatchCharacterBuildDetailResponse : ResponseBase
{
    public List<PartyCharacterBuildDetail> characterBuildDetailList { get; set; }
}

public class GvgApiGetCandidateEnemyUserListResponse : ResponseBase
{
    public string enemyGuildName { get; set; }
    public long enemyGuildDataId { get; set; }
    public int enemyGuildTitleMstId { get; set; }
    public int allyAttackUserCount { get; set; }
    public int enemyAttackUserCount { get; set; }
    public int allyGuildPoint { get; set; }
    public int enemyGuildPoint { get; set; }
    public List<GvgMatchInfo> matchInfoList { get; set; }
    public bool canPlayAdditionalBattle { get; set; }
}

public class GvgApiGetRankingInfoResponse : ResponseBase
{
    public List<GvgRankingInfo> rankingInfoList { get; set; }
}

public class GvgApiGetLeagueMatchResultsResponse : ResponseBase
{
    public List<GvgLeagueMatchResultInfo> leagueMatchResultsList { get; set; }
    public List<GvgLeagueMatchGuildInfo> gvgGuildInfoList { get; set; }
}

public class GvgApiGetEnemyUserInfoResponse : ResponseBase
{
    public GvgMatchInfo enemyUserInfo { get; set; }
    public List<PartyCharacterBuildDetail> characterBuildDetailList { get; set; }
}

public class GvgApiGetTrialEnemyUserInfoResponse : ResponseBase
{
    public GvgMatchInfo enemyUserInfo { get; set; }
    public List<PartyCharacterBuildDetail> characterBuildDetailList { get; set; }
}

public class GvgApiInitializeStageResponse : ResponseBase
{
    public string gvgRoomId { get; set; }
    public GvgStageInfo stageInfo { get; set; }
}

public class GvgApiGetGvgInfoResponse : ResponseBase
{
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<QuestBattleBattleUnit> enemyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
    public List<PartyCharacterBuildDetail> enemyCharacterBuildDetailList { get; set; }
    public int limitSecond { get; set; }
}

public class GvgApiRetireResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class GvgApiGetTrialGvgInfoResponse : ResponseBase
{
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<QuestBattleBattleUnit> enemyBattleUnitList { get; set; }
    public GvgStageInfo stageInfo { get; set; }
}

public class GvgApiGetTrialCandidateEnemyUserListResponse : ResponseBase
{
    public List<GvgMatchInfo> matchInfoList { get; set; }
}

public class GvgApiFinalizeStageForUserResponse : ResponseBase
{
    public int addBasePoint { get; set; }
    public int addRelativelyBonusPoint { get; set; }
    public int addBattleTurnBonusPoint { get; set; }
    public int addAliveBonusPoint { get; set; }
    public int relativelyLevel { get; set; }
    public int resultRound { get; set; }
    public int aliveCount { get; set; }
    public int addPoint { get; set; }
    public int totalPoint { get; set; }
    public int totalGuildPoint { get; set; }
}

public class GveApiGetTopResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public int gveMstId { get; set; }
    public string topResourceName { get; set; }
}

public class GveApiGetGuildInfoResponse : ResponseBase
{
    public GveGveGuildDataRecord gveGuildData { get; set; }
    public GveGveUserDataRecord gveUserData { get; set; }
    public List<GveGveStageDataRecord> gveStageDataList { get; set; }
    public List<GveGveUserStageDataRecord> gveUserStageDataList { get; set; }
    public GveGveGuildChainDataRecord gveGuildChainData { get; set; }
}

public class GveApiGetRankingInfoResponse : ResponseBase
{
    public int selfRanking { get; set; }
    public List<GveRankingInfo> rankingInfoList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GveApiGetGveHistoryResponse : ResponseBase
{
    public List<GveGveHistoryInfo> gveHistoryList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GveApiInitializeStageResponse : ResponseBase
{
    public int hp { get; set; }
    public QuestBattleQuestRoomData questRoomData { get; set; }
    public bool isChallengedFirstBattle { get; set; }
    public List<GveGuildMemberCharacter> guildMemberCharacterList { get; set; }
}

public class GveApiGetGveInfoResponse : ResponseBase
{
    public QuestBattleStageInfo stageInfo { get; set; }
    public GveGveStageDataRecord gveStageData { get; set; }
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
}

public class GveApiAddDamageResponse : ResponseBase
{
    public int hp { get; set; }
    public int breakCount { get; set; }
    public bool isBreakBonus { get; set; }
    public List<GveGveUserChainDataRecord> gveUserChainList { get; set; }
    public List<GveGveHistoryInfo> gveHistoryList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GveApiFinalizeStageForUserResponse : ResponseBase
{
    public int rewardMedalNum { get; set; }
    public int hp { get; set; }
    public List<int> acquiredGveStageRewardMstIds { get; set; }
    public MapGveMapGveUserDataRecord mapGveUserData { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class GveApiRetireResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class GuildApiAppointGuildSubMasterResponse : ResponseBase
{
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
}

public class GuildApiApproveJoinRequestResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiApproveScoutResponse : ResponseBase
{
    public long guildDataId { get; set; }
}

public class GuildApiCancelJoinRequestResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiCancelScoutResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiGuildNameSearchResponse : ResponseBase
{
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiConditionalGuildSearchResponse : ResponseBase
{
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiRecommendedGuildSearchResponse : ResponseBase
{
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiCreateGuildResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public GuildGuildUserDataRecord guildUserData { get; set; }
}

public class GuildApiDenyJoinRequestResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiDenyScoutResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiExpelGuildMemberResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiGetApplyingJoinRequestListByGuildResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiGetApplyingJoinRequestListByUserResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiGetApplyingScoutListByGuildResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiGetApplyingScoutListByUserResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiGetGuildDataResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public GuildGuildUserDataRecord guildUserDataForGuildMaster { get; set; }
    public UserUserParamDataRecord guildMasterUserParamData { get; set; }
    public GuildGuildUserDataRecord myGuildUserData { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public GuildGuildRequestDataRecord guildRequestData { get; set; }
}

public class GuildApiGetGuildTopInfoResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<GuildGuildTitleDataRecord> guildTitleDataList { get; set; }
    public int applyingJoinRequestCount { get; set; }
    public List<GuildGuildActivityDataRecord> guildActivityDataList { get; set; }
    public bool enableGveBadge { get; set; }
    public bool enableGveParticipationBadge { get; set; }
    public bool enableGvgBadge { get; set; }
}

public class GuildApiGetGuildMemberListResponse : ResponseBase
{
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
}

public class GuildApiJoinRequestResponse : ResponseBase
{
    public bool autoJoined { get; set; }
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiLeaveGuildResponse : ResponseBase
{
    public long guildDataId { get; set; }
    public GuildGuildUserDataRecord guildUserData { get; set; }
}

public class GuildApiMigrateGuildMasterResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
}

public class GuildApiMigrateGuildSubMasterResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
}

public class GuildApiRemoveGuildResponse : ResponseBase
{
    public long guildDataId { get; set; }
    public GuildGuildUserDataRecord guildUserData { get; set; }
}

public class GuildApiRemoveGuildSubMasterResponse : ResponseBase
{
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
}

public class GuildApiGetCandidateScoutUserListResponse : ResponseBase
{
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiScoutResponse : ResponseBase
{
    public List<GuildGuildRequestDataRecord> guildRequestDataList { get; set; }
    public List<GuildGuildDataRecord> guildDataList { get; set; }
    public List<GuildGuildUserDataRecord> guildUserDataList { get; set; }
    public List<UserUserParamDataRecord> userParamDataList { get; set; }
}

public class GuildApiSetGuildBasicSettingsResponse : ResponseBase
{
    public GuildGuildDataRecord guildData { get; set; }
}

public class GuildApiInstantJoinRequestResponse : ResponseBase
{
    public long guildDataId { get; set; }
}

public class GuildApiGetGuildTitleDataListResponse : ResponseBase
{
    public List<GuildGuildTitleDataRecord> guildTitleDataList { get; set; }
}

public class GatheringApiGetGatheringTopResponse : ResponseBase
{
    public List<ObjectObjectViewData> rewardList { get; set; }
    public GatheringUserGatheringDataRecord userGatheringData { get; set; }
}

public class GatheringApiReceiveRewardResponse : ResponseBase
{
    public List<ObjectObjectViewData> receivedRewardList { get; set; }
    public GatheringUserGatheringDataRecord userGatheringData { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class GatheringApiShortcutGatheringResponse : ResponseBase
{
    public List<ObjectObjectViewData> receivedRewardList { get; set; }
    public GatheringUserGatheringDataRecord userGatheringData { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class GachaApiGetGachaTopResponse : ResponseBase
{
    public GachaGachaTopViewData viewData { get; set; }
}

public class GachaApiGachaExecResponse : ResponseBase
{
    public List<GachaGachaCountDataRecord> gachaCountDataList { get; set; }
    public List<ObjectObjectViewData> gachaGainBonusList { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public GachaGachaRecord gachaRecord { get; set; }
    public GachaGachaSeriesRecord gachaSeriesRecord { get; set; }
    public List<GachaPickUpInfo> pickUpInfoList { get; set; }
    public bool isCeilingPointAchieved { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public bool isStoreReview { get; set; }
}

public class GachaApiUpdateAlreadyViewResponse : ResponseBase
{
    public List<int> newBadgeGachaSeriesMstIdList { get; set; }
}

public class QuestOutGameApiGetUserQuestStageListResponse : ResponseBase
{
    public List<int> questStageMstIdList { get; set; }
    public List<QuestOutGameUserQuestStageDataRecord> userQuestStageDataList { get; set; }
    public List<QuestOutGameUserQuestGroupDataRecord> userQuestGroupOpenDataList { get; set; }
}

public class QuestOutGameApiOpenQuestGroupResponse : ResponseBase
{
    public QuestOutGameUserQuestGroupDataRecord userQuestGroupOpenData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class QuestOutGameApiGetUserTrainingQuestDataListResponse : ResponseBase
{
    public List<QuestOutGameUserQuestTrainingDataRecord> userQuestTrainingDataList { get; set; }
}

public class QuestOutGameApiSetUserTrainingQuestRankUpEffectResponse : ResponseBase
{
    public List<QuestOutGameUserQuestTrainingDataRecord> userQuestTrainingDataList { get; set; }
}

public class QuestOutGameApiGetUserQuestCharacterHeartListResponse : ResponseBase
{
    public QuestOutGameUserQuestCharacterHeartDataRecord userQuestCharacterHeartData { get; set; }
    public List<QuestOutGameUserQuestCharacterHeartPartySaveDataRecord> userQuestCharacterHeartPartySaveDataList { get; set; }
}

public class CollectionApiGetCollectionDataListResponse : ResponseBase
{
    public List<CollectionCollectionDataRecord> collectionDataList { get; set; }
    public List<CollectionCollectionIllustAchieveDataRecord> collectionIllustAchieveDataList { get; set; }
    public List<CollectionFieldStageCollectionInfo> fieldStageCollectionInfoList { get; set; }
    public bool isMagiaRecordLinkedUser { get; set; }
}

public class CollectionApiGetCollectionParamUpAchieveDataListResponse : ResponseBase
{
    public List<CollectionCollectionParamUpAchieveDataRecord> collectionParamUpAchieveDataList { get; set; }
    public bool isMagiaRecordLinkedUser { get; set; }
}

public class CollectionApiUpdateAlreadyViewResponse : ResponseBase
{
    public List<CollectionCollectionDataRecord> collectionDataList { get; set; }
    public List<CardCardDataRecord> cardDataList { get; set; }
}

public class CollectionApiEndCompleteProgressResponse : ResponseBase
{
    public CollectionCollectionParamUpAchieveDataRecord collectionParamUpAchieveData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class CollectionApiGetMagiaRecordCollectionInfoResponse : ResponseBase
{
    public List<CollectionMagiaRecordCharacterMstRecord> magiaRecordCharacterMstList { get; set; }
    public List<CollectionMagiaRecordMemoriaMstRecord> magiaRecordMemoriaMstList { get; set; }
}

public class CollectionApiAdvReadResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class CollectionApiGetCollectionIllustAchieveDataResponse : ResponseBase
{
    public CollectionCollectionIllustAchieveDataRecord collectionIllustAchieveData { get; set; }
}

public class CollectionApiViewNewCollectionIllustEffectResponse : ResponseBase
{
    public CollectionCollectionIllustAchieveDataRecord collectionIllustAchieveData { get; set; }
}

public class ChatApiCreateGroupChatRoomResponse : ResponseBase
{
    public ChatChatRoomInfo chatRoomInfo { get; set; }
    public List<long> uninvitedUserIdList { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class ChatApiAddUserToGroupChatRoomResponse : ResponseBase
{
    public List<long> uninvitedUserIdList { get; set; }
}

public class ChatApiDeleteUserByGroupChatRoomResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class ChatApiLeaveGroupChatRoomResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class ChatApiCreateDirectChatRoomResponse : ResponseBase
{
    public ChatChatRoomInfo chatRoomInfo { get; set; }
    public string deleteRoomDocumentId { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class ChatApiLeaveDirectChatRoomResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class ChatApiApproveEnterChatRoomResponse : ResponseBase
{
    public bool isSuccess { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class ChatApiGetChatBlockUserListResponse : ResponseBase
{
    public List<UserUserDisplayInfo> userDisplayInfoList { get; set; }
}

public class ChatApiBlockChatUserResponse : ResponseBase
{
    public bool isSuccess { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class ChatApiUnblockChatUserResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class ChatApiSearchChatUserResponse : ResponseBase
{
    public List<UserUserDisplayInfo> userDisplayInfoList { get; set; }
}

public class PartyApiGetPartyDataListResponse : ResponseBase
{
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class PartyApiGetCharacterBuildDataListResponse : ResponseBase
{
    public List<PartyCharacterBuildDataRecord> characterBuildDataList { get; set; }
}

public class PartyApiSavePartyResponse : ResponseBase
{
    public PartyPartyDataRecord partyData { get; set; }
    public List<PartyCharacterBuildDataRecord> characterBuildDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class PartyApiSavePartyLeaderResponse : ResponseBase
{
    public PartyPartyDataRecord partyData { get; set; }
}

public class PartyApiSavePartyNameResponse : ResponseBase
{
    public PartyPartyDataRecord partyData { get; set; }
}

public class PartyApiSavePartyRoleResponse : ResponseBase
{
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class PartyApiSavePartyForRecommendResponse : ResponseBase
{
    public PartyPartyDataRecord partyData { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class PartyApiGetRecommendPartyDataResponse : ResponseBase
{
    public PartyPartyDataRecord recommendPartyData { get; set; }
}

public class PartyApiGetRecommendSubStyleResponse : ResponseBase
{
    public List<int> recommendSubStyleMstIdList { get; set; }
}

public class PartyApiGetRecommendCardResponse : ResponseBase
{
    public List<long> recommendCardDataIdList { get; set; }
    public List<long> recommendSubCardDataIdList { get; set; }
}

public class PartyApiRemovePartyResponse : ResponseBase
{
    public long partyDataId { get; set; }
}

public class PartyApiSavePartyCardResponse : ResponseBase
{
    public PartyPartyDataRecord partyData { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class PartyApiSavePartySubStyleResponse : ResponseBase
{
    public PartyPartyDataRecord partyData { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class CharacterApiGetCharacterListResponse : ResponseBase
{
    public List<CharacterCharacterDataRecord> characterDataList { get; set; }
}

public class CharacterApiCharacterAwakeResponse : ResponseBase
{
    public CharacterCharacterDataRecord characterData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class CharacterApiCharacterLevelUpResponse : ResponseBase
{
    public CharacterCharacterDataRecord characterData { get; set; }
    public List<CharacterCharacterLevelUpInfo> characterLevelUpInfoList { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class CharacterApiCharacterHeartLevelUpResponse : ResponseBase
{
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public CharacterCharacterHeartLevelUpInfo characterHeartLevelUpInfo { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class CardApiGetCardListResponse : ResponseBase
{
    public List<CardCardDataRecord> cardDataList { get; set; }
}

public class CardApiCardLimitBreakResponse : ResponseBase
{
    public CardCardDataRecord cardData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<long> deletedCardDataIds { get; set; }
}

public class CardApiCardSellResponse : ResponseBase
{
    public List<long> deletedCardDataIds { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class CardApiSetCardProtectResponse : ResponseBase
{
    public CardCardDataRecord cardData { get; set; }
}

public class CardApiUpdateAlreadyViewResponse : ResponseBase
{
    public List<CardCardDataRecord> cardDataList { get; set; }
}

public class CardApiCardPassiveSkillLevelUpResponse : ResponseBase
{
    public CardCardDataRecord cardData { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
}

public class QuestBattleApiInitializeStageResponse : ResponseBase
{
    public int initializeStatus { get; set; }
    public QuestBattleQuestRoomData questRoomData { get; set; }
    public QuestOutGameUserQuestStageDataRecord userQuestStageData { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public bool isNotUseStaminaFirstClear { get; set; }
}

public class QuestBattleApiGetQuestInfoResponse : ResponseBase
{
    public QuestBattleStageInfo stageInfo { get; set; }
    public List<QuestBattleBattleUnit> allyBattleUnitList { get; set; }
    public List<PartyCharacterBuildDetail> allyCharacterBuildDetailList { get; set; }
    public int repeatNum { get; set; }
}

public class QuestBattleApiFinalizeStageForUserResponse : ResponseBase
{
    public QuestBattleResult result { get; set; }
    public int beforeLevel { get; set; }
    public int afterLevel { get; set; }
    public int beforeExp { get; set; }
    public int afterExp { get; set; }
    public int beforeStamina { get; set; }
    public QuestOutGameUserQuestStageDataRecord userQuestStageData { get; set; }
    public List<int> acquiredQuestRewardMstIds { get; set; }
    public bool canReplay { get; set; }
    public int remainPlayCount { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<ItemItemDataRecord> keyItemDataList { get; set; }
    public List<CharacterCharacterLevelUpInfo> characterLevelUpInfoList { get; set; }
    public List<StyleStyleLevelUpInfo> styleLevelUpInfoList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public int eventItemObjectReceiveType { get; set; }
    public int eventItemId { get; set; }
    public int baseEventItemNum { get; set; }
    public int addBonusEventItemNum { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
    public QuestOutGameUserQuestTrainingDataRecord userQuestTrainingData { get; set; }
    public StoryEventStoryEventDataRecord storyEventData { get; set; }
    public List<CharacterCharacterHeartLevelUpInfo> characterHeartLevelUpInfoList { get; set; }
    public QuestOutGameUserQuestCharacterHeartDataRecord userQuestCharacterHeartData { get; set; }
    public QuestOutGameUserQuestCharacterHeartPartySaveDataRecord userQuestCharacterHeartPartySaveData { get; set; }
    public bool canQuestCharacterHeartNextStage { get; set; }
    public TowerUserTowerDataRecord userTowerData { get; set; }
    public int acquiredRewardMoney { get; set; }
}

public class QuestBattleApiRetireResponse : ResponseBase
{
    public bool isSuccess { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class QuestBattleApiSkipQuestBattleResponse : ResponseBase
{
    public QuestBattleResult result { get; set; }
    public int beforeLevel { get; set; }
    public int afterLevel { get; set; }
    public int beforeExp { get; set; }
    public int afterExp { get; set; }
    public int beforeStamina { get; set; }
    public QuestOutGameUserQuestStageDataRecord userQuestStageData { get; set; }
    public List<int> acquiredQuestRewardMstIds { get; set; }
    public bool canReplay { get; set; }
    public int remainPlayCount { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<ItemItemDataRecord> keyItemDataList { get; set; }
    public List<CharacterCharacterLevelUpInfo> characterLevelUpInfoList { get; set; }
    public List<StyleStyleLevelUpInfo> styleLevelUpInfoList { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public int eventItemObjectReceiveType { get; set; }
    public int eventItemId { get; set; }
    public int baseEventItemNum { get; set; }
    public int addBonusEventItemNum { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
    public QuestOutGameUserQuestTrainingDataRecord userQuestTrainingData { get; set; }
    public StoryEventStoryEventDataRecord storyEventData { get; set; }
    public List<CharacterCharacterHeartLevelUpInfo> characterHeartLevelUpInfoList { get; set; }
    public QuestOutGameUserQuestCharacterHeartDataRecord userQuestCharacterHeartData { get; set; }
    public QuestOutGameUserQuestCharacterHeartPartySaveDataRecord userQuestCharacterHeartPartySaveData { get; set; }
    public int acquiredRewardMoney { get; set; }
}

public class QuestBattleApiGetBackGroundInfoResponse : ResponseBase
{
    public QuestBattleQuestRoomData questRoomData { get; set; }
    public QuestOutGameUserQuestStageDataRecord userQuestStageData { get; set; }
}

public class ExplorationApiGetTopInfoV4Response : ResponseBase
{
    public bool isFirstEntry { get; set; }
    public ExplorationFieldStageUserDataRecord fieldStageUserData { get; set; }
    public List<CollectionCollectionDataRecord> collectionDataList { get; set; }
}

public class ExplorationApiReachFieldPointResponse : ResponseBase
{
    public ExplorationFieldStageUserDataRecord fieldStageUserData { get; set; }
}

public class ExplorationApiOccurDungeonEventResponse : ResponseBase
{
    public ExplorationFieldStageUserDataRecord fieldStageUserData { get; set; }
}

public class ExplorationApiDungeonStartResponse : ResponseBase
{
    public bool isSuccess { get; set; }
}

public class ExplorationApiDungeonGoalResponse : ResponseBase
{
    public ExplorationFieldStageUserDataRecord fieldStageUserData { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
    public List<int> acquiredQuestRewardMstIds { get; set; }
    public List<int> achievedConditionGroupIds { get; set; }
    public CollectionFieldStageCollectionInfo fieldStageCollectionInfo { get; set; }
    public List<PartyPartyDataRecord> partyDataList { get; set; }
    public TutorialMiniTutorialDataRecord miniTutorialData { get; set; }
}

public class ExplorationApiResetDungeonProgressResponse : ResponseBase
{
    public ExplorationFieldStageUserDataRecord fieldStageUserData { get; set; }
}

public class ExplorationApiGetEnableStageListResponse : ResponseBase
{
    public List<int> fieldStageMstIdList { get; set; }
}

public class ExplorationApiGetStageMstListResponse : ResponseBase
{
    public List<ExplorationFieldStratumMstRecord> fieldStratumMstList { get; set; }
    public List<ExplorationFieldPointMstRecord> fieldPointMstList { get; set; }
    public List<DungeonDungeonMstRecord> dungeonMstList { get; set; }
    public List<DungeonDungeonRoomMstRecord> dungeonRoomMstList { get; set; }
    public List<DungeonDungeonEventMstRecord> dungeonEventMstList { get; set; }
    public List<CollectionCollectionConditionGroupMstRecord> collectionConditionGroupMstList { get; set; }
    public List<CollectionCollectionConditionMstRecord> collectionConditionMstList { get; set; }
    public List<CollectionCollectionDataRecord> collectionDataList { get; set; }
}

public class ExplorationApiGetDungeonMstListResponse : ResponseBase
{
    public DungeonDungeonTypeMstRecord dungeonTypeMst { get; set; }
    public List<DungeonDungeonRoomMstRecord> dungeonRoomMstList { get; set; }
    public List<DungeonDungeonEventMstRecord> dungeonEventMstList { get; set; }
}

public class ExplorationApiGetFieldStageCollectionInfoListResponse : ResponseBase
{
    public List<ExplorationQuestMapEffectedInfo> questMapEffectedInfoList { get; set; }
    public List<CollectionFieldStageCollectionInfo> fieldStageCollectionInfoList { get; set; }
    public List<CollectionCollectionIllustAchieveDataRecord> collectionIllustAchieveDataList { get; set; }
}

public class ExplorationApiUpdateUserQuestMapEffectedDataResponse : ResponseBase
{
    public bool result { get; set; }
}

