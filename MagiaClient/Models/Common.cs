namespace MagiaClient.Models;

using System;
using System.Collections.Generic;

public class WebPayPurchaseResultRecord : object
{
    public string purchaseId { get; set; }
    public int status { get; set; }
}

public class TitleTitleViewData : object
{
    public bool isMaintenance { get; set; }
    public bool isDbMaintenance { get; set; }
    public string maintenanceMessage { get; set; }
    public string dbMaintenanceForAnnounceText { get; set; }
}

public class TermsTermsInfo : object
{
    public int termsNum { get; set; }
    public string text { get; set; }
}

public class UserUserDataRecord : object
{
    public long userId { get; set; }
    public string uuid { get; set; }
    public string playerId { get; set; }
    public int banType { get; set; }
    public int osType { get; set; }
    public int storeType { get; set; }
    public string language { get; set; }
    public string region { get; set; }
    public string timezone { get; set; }
    public int termsNumIos { get; set; }
    public int termsNumAndroid { get; set; }
    public int termsNumWindows { get; set; }
    public int termsNumBrowser { get; set; }
    public int termsNumChat { get; set; }
}

public class TalismanTalismanDataRecord : object
{
    public long userId { get; set; }
    public long talismanDataId { get; set; }
    public int talismanMstId { get; set; }
    public int level { get; set; }
    public int mainParamMstId { get; set; }
    public int sub1ParamMstId { get; set; }
    public int sub2ParamMstId { get; set; }
    public int sub3ParamMstId { get; set; }
    public int sub4ParamMstId { get; set; }
    public string createdTime { get; set; }
    public bool isProtect { get; set; }
}

public class UserUserParamDataRecord : object
{
    public long userId { get; set; }
    public string name { get; set; }
    public string nameUpdatedTime { get; set; }
    public int missionClearCount { get; set; }
    public long money { get; set; }
    public long totalMoney { get; set; }
    public int level { get; set; }
    public int exp { get; set; }
    public long totalExp { get; set; }
    public int stamina { get; set; }
    public string staminaUpdatedTime { get; set; }
    public int recoveryCount { get; set; }
    public string recoveryResetTime { get; set; }
    public int gemRecoveryCount { get; set; }
    public string gemRecoveryResetTime { get; set; }
    public long pvpWin { get; set; }
    public long pvpLose { get; set; }
    public double pvpWinRate { get; set; }
    public int favoriteStyleMstId { get; set; }
    public int tutorialStep { get; set; }
    public string tutorialFinishTime { get; set; }
    public string recentLoginTime { get; set; }
    public string recentStoreReviewTime { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int maxPartyPower { get; set; }
    public int clearedFieldStageMstId { get; set; }
    public int accountStatus { get; set; }
}

public class PartyPartyDataRecord : object
{
    public long userId { get; set; }
    public long partyDataId { get; set; }
    public string name { get; set; }
    public int partyType { get; set; }
    public bool isQuest { get; set; }
    public bool isPvp { get; set; }
    public bool isExploration { get; set; }
    public bool isMapGve { get; set; }
    public bool isScoreAttack { get; set; }
    public int member1 { get; set; }
    public int cardMstId1 { get; set; }
    public string subStyleMstIds1 { get; set; }
    public int member2 { get; set; }
    public int cardMstId2 { get; set; }
    public string subStyleMstIds2 { get; set; }
    public int member3 { get; set; }
    public int cardMstId3 { get; set; }
    public string subStyleMstIds3 { get; set; }
    public int member4 { get; set; }
    public int cardMstId4 { get; set; }
    public string subStyleMstIds4 { get; set; }
    public int member5 { get; set; }
    public int cardMstId5 { get; set; }
    public string subStyleMstIds5 { get; set; }
    public int leaderStyleMstId { get; set; }
    public int partyPower { get; set; }
    public int partyIndex { get; set; }
}

public class ItemItemMstRecord : object
{
    public int itemMstId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int type { get; set; }
    public int detailType { get; set; }
    public int effectType { get; set; }
    public int effectValue { get; set; }
    public int effectValue2 { get; set; }
    public int rarity { get; set; }
    public bool canSell { get; set; }
    public int price { get; set; }
    public bool canUse { get; set; }
    public int sortOrder { get; set; }
    public int maxNum { get; set; }
    public int validDays { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string transitionSceneName { get; set; }
    public string resourceName { get; set; }
    public bool isConversion { get; set; }
}

public class CardCardMstRecord : object
{
    public int cardMstId { get; set; }
    public string name { get; set; }
    public string illustrator { get; set; }
    public string source { get; set; }
    public int rarity { get; set; }
    public int element { get; set; }
    public int passiveSkill1 { get; set; }
    public int passiveSkill2 { get; set; }
    public int passiveSkill3 { get; set; }
    public string resourceName { get; set; }
    public int characterMstId { get; set; }
    public string unlockTypeCsv { get; set; }
    public string unlockIdCsv { get; set; }
    public int advPosition { get; set; }
    public string releaseTime { get; set; }
}

public class CardCardLimitBreakMstRecord : object
{
    public int cardLimitBreakMstId { get; set; }
    public int cardMstId { get; set; }
    public int limitBreakCount { get; set; }
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
}

public class SkillSkillMstRecord : object
{
    public int skillMstId { get; set; }
    public int skillUniqueId { get; set; }
    public int level { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int type { get; set; }
    public int sp { get; set; }
    public string hitEffectResourceName { get; set; }
    public string balloonText { get; set; }
    public string iconName { get; set; }
    public string directionName { get; set; }
    public string cueSheetName { get; set; }
    public string cueName { get; set; }
    public bool isEmphasize { get; set; }
    public string additionalCueName { get; set; }
    public string skillButtonIcon { get; set; }
}

public class SkillSkillLevelUpConditionMstRecord : object
{
    public int skillLevelUpConditionMstId { get; set; }
    public int skillLevelUpType { get; set; }
    public int rarity { get; set; }
    public int minLevel { get; set; }
    public int conditionType { get; set; }
    public int conditionValue { get; set; }
    public int useMoney { get; set; }
    public int itemMstId1 { get; set; }
    public int itemNum1 { get; set; }
    public int itemMstId2 { get; set; }
    public int itemNum2 { get; set; }
    public int itemMstId3 { get; set; }
    public int itemNum3 { get; set; }
}

public class CharacterCharacterAwakeMstRecord : object
{
    public int characterAwakeMstId { get; set; }
    public int awakeLevel { get; set; }
    public int addHp { get; set; }
    public int addAtk { get; set; }
    public int addDef { get; set; }
    public int rateHp { get; set; }
    public int rateAtk { get; set; }
    public int rateDef { get; set; }
}

public class CharacterCharacterMstRecord : object
{
    public int characterMstId { get; set; }
    public string name { get; set; }
    public int awakeItemMstId { get; set; }
    public string iconResourceName { get; set; }
    public string colorCode { get; set; }
}

public class CharacterCharacterProfileMstRecord : object
{
    public int characterMstId { get; set; }
    public string description { get; set; }
    public string characterVoice { get; set; }
    public string schoolName { get; set; }
    public string age { get; set; }
    public string weapon { get; set; }
    public string gift { get; set; }
    public string weakPoint { get; set; }
    public int seriesId { get; set; }
    public int regionId { get; set; }
    public int teamId1 { get; set; }
    public int teamId2 { get; set; }
    public int sortOrder { get; set; }
}

public class CharacterCharacterHeartMstRecord : object
{
    public int characterHeartMstId { get; set; }
    public int characterMstId { get; set; }
    public int paramUpGroupId { get; set; }
    public int objectRewardGroupId { get; set; }
}

public class CharacterCharacterHeartParamUpGroupMstRecord : object
{
    public int characterHeartParamUpGroupMstId { get; set; }
    public int paramUpGroupId { get; set; }
    public int heartLevel { get; set; }
    public int styleParamUpEffectMstId { get; set; }
}

public class CharacterCharacterHeartObjectRewardMstRecord : object
{
    public int characterHeartObjectRewardMstId { get; set; }
    public int objectRewardGroupId { get; set; }
    public int heartLevel { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
}

public class CharacterCharacterHeartLevelUpMstRecord : object
{
    public int characterHeartLevelUpMstId { get; set; }
    public int heartLevel { get; set; }
    public int heartLevelUpExp { get; set; }
}

public class CharacterCharacterTeamMstRecord : object
{
    public int characterTeamMstId { get; set; }
    public string name { get; set; }
    public int sortOrder { get; set; }
}

public class StyleStyleMstRecord : object
{
    public int styleMstId { get; set; }
    public string name { get; set; }
    public int styleFigureMstId { get; set; }
    public int rarity { get; set; }
    public int specialAttackMstId { get; set; }
    public int normalAttack { get; set; }
    public int skill1 { get; set; }
    public int passiveSkill1 { get; set; }
    public int limitBreakPassiveSkill1 { get; set; }
    public int subPassiveSkill { get; set; }
    public int leaderSkill { get; set; }
    public int hp { get; set; }
    public int ep { get; set; }
    public int recoveryEpRate { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int speed { get; set; }
    public int criticalRate { get; set; }
    public int criticalDamageRate { get; set; }
    public int breakDamageRate { get; set; }
    public int healRate { get; set; }
    public int effectHitRate { get; set; }
    public int effectParryRate { get; set; }
    public int fireDamageRate { get; set; }
    public int aquaDamageRate { get; set; }
    public int forestDamageRate { get; set; }
    public int lightDamageRate { get; set; }
    public int darkDamageRate { get; set; }
    public int neutralDamageRate { get; set; }
    public int fireResistRate { get; set; }
    public int aquaResistRate { get; set; }
    public int forestResistRate { get; set; }
    public int lightResistRate { get; set; }
    public int darkResistRate { get; set; }
    public int neutralResistRate { get; set; }
    public int element { get; set; }
    public int role { get; set; }
    public int paramUpGroupId { get; set; }
    public string resourceName { get; set; }
    public string releaseTime { get; set; }
    public bool isCollectionDisp { get; set; }
}

public class TowerTowerMstRecord : object
{
    public int towerMstId { get; set; }
    public int eventType { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int reprintNum { get; set; }
}

public class QuestOutGameQuestCategoryMstRecord : object
{
    public int questCategoryMstId { get; set; }
    public string name { get; set; }
    public string resourceName { get; set; }
}

public class QuestOutGameQuestMapMstRecord : object
{
    public int questMapMstId { get; set; }
    public int questCategoryMstId { get; set; }
    public string name { get; set; }
    public int conditionGroupId { get; set; }
    public int openFlagMiniTutorialNumber { get; set; }
    public int openEffectFlagMiniTutorialNumber { get; set; }
}

public class QuestOutGameQuestGroupMstRecord : object
{
    public int questGroupMstId { get; set; }
    public int questCategoryMstId { get; set; }
    public int questMapMstId { get; set; }
    public int groupType { get; set; }
    public string name { get; set; }
    public string resourceName { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int sortOrder { get; set; }
    public int priorityTerm { get; set; }
    public int dailyBattleClearLimit { get; set; }
    public string playableWeekDays { get; set; }
    public int keyQuestType { get; set; }
    public int keyItemMstId { get; set; }
    public int reprintNum { get; set; }
}

public class QuestOutGameQuestStageMstRecord : object
{
    public int questStageMstId { get; set; }
    public int questGroupMstId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string detail { get; set; }
    public int difficulty { get; set; }
    public int useStamina { get; set; }
    public int prevQuestStageMstId { get; set; }
    public int conditionGroupId { get; set; }
    public string resourceName { get; set; }
    public string recommendationElementCsv { get; set; }
    public int recommendationPartyPower { get; set; }
    public int rewardGroupId { get; set; }
    public int firstClearRewardGroupId { get; set; }
    public int exp { get; set; }
    public int firstClearExp { get; set; }
    public int money { get; set; }
    public int firstClearMoney { get; set; }
    public int characterExp { get; set; }
    public int styleExp { get; set; }
    public int firstClearStyleExp { get; set; }
    public int characterHeartExp { get; set; }
    public string bgmCueSheetName { get; set; }
    public string bgmCueName { get; set; }
    public string stagePrefabName { get; set; }
    public int judgeResultType { get; set; }
    public int judgeResultValue { get; set; }
    public int beforeBattleScenarioMstId { get; set; }
    public int afterBattleScenarioMstId { get; set; }
    public string endDirectionName { get; set; }
    public string overrideComponentPrefabName { get; set; }
    public int isAutoModeOff { get; set; }
    public int element { get; set; }
    public int recommendationElement { get; set; }
}

public class QuestOutGameQuestConditionMstRecord : object
{
    public int questConditionMstId { get; set; }
    public int conditionGroupId { get; set; }
    public int conditionType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
}

public class MissionMissionTitleMstRecord : object
{
    public int missionTitleMstId { get; set; }
    public int prevMissionTitleMstId { get; set; }
    public string title { get; set; }
    public int priority { get; set; }
    public string featuredRewardResourceName { get; set; }
}

public class MissionMissionTransitionMstRecord : object
{
    public int missionTransitionMstId { get; set; }
    public int missionMstId { get; set; }
    public string transitionSceneName { get; set; }
    public int transitionSceneParam { get; set; }
}

public class MissionSubscriptionMissionRewardMstRecord : object
{
    public int missionMstId { get; set; }
    public string subscriptionLabel { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class MissionMissionMstRecord : object
{
    public int missionMstId { get; set; }
    public int missionTitleMstId { get; set; }
    public int sortOrder { get; set; }
    public int missionType { get; set; }
    public int category { get; set; }
    public int missionUniqueId { get; set; }
    public int missionUniquePriority { get; set; }
    public bool isOverCount { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
    public int resetType { get; set; }
    public int resetCycle { get; set; }
    public int triggerType { get; set; }
    public int conditionType { get; set; }
    public int conditionObjectId { get; set; }
    public int conditionObjectId2 { get; set; }
    public int conditionCount { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
}

public class QuestOutGameEnemyMstRecord : object
{
    public int enemyMstId { get; set; }
    public int enemyUniqueId { get; set; }
    public string name { get; set; }
    public string runesName { get; set; }
    public int enemyType { get; set; }
    public int size { get; set; }
    public string modelPrefabName { get; set; }
    public string iconResourceName { get; set; }
    public string cueSheetName { get; set; }
    public string appearEffectPrefabName { get; set; }
    public bool isCollectionDisp { get; set; }
    public bool canRotateModel { get; set; }
    public int unlockType { get; set; }
    public string releaseTime { get; set; }
    public bool isNoVisualDeath { get; set; }
}

public class QuestOutGameEnemyProfileMstRecord : object
{
    public int enemyProfileMstId { get; set; }
    public int enemyUniqueId { get; set; }
    public int enemyMstId { get; set; }
    public string name { get; set; }
    public string runesName { get; set; }
    public int seriesId { get; set; }
    public string description { get; set; }
    public int sortOrder { get; set; }
    public bool isCollectionDisp { get; set; }
    public int unlockType { get; set; }
    public int unlockId { get; set; }
    public string releaseTime { get; set; }
}

public class QuestOutGameQuestEnemyAppearanceMstRecord : object
{
    public int questEnemyAppearanceMstId { get; set; }
    public int questStageMstId { get; set; }
    public int wave { get; set; }
    public int enemyMstId { get; set; }
    public int enemySkillSetId { get; set; }
    public int enemyConditionSkillSetId { get; set; }
    public int passiveSkillMstId { get; set; }
    public int weakElement1 { get; set; }
    public int weakElement2 { get; set; }
    public int weakElement3 { get; set; }
    public int weakElement4 { get; set; }
    public int weakElement5 { get; set; }
    public int weakElement6 { get; set; }
    public bool isMainTargetEnemy { get; set; }
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int speed { get; set; }
    public int criticalRate { get; set; }
    public int criticalDamageRate { get; set; }
    public int healRate { get; set; }
    public int effectHitRate { get; set; }
    public int effectParryRate { get; set; }
    public int burnParryRate { get; set; }
    public int weaknessParryRate { get; set; }
    public int poisonParryRate { get; set; }
    public int stunParryRate { get; set; }
    public int curseParryRate { get; set; }
    public int bleedParryRate { get; set; }
    public int fireDamageRate { get; set; }
    public int aquaDamageRate { get; set; }
    public int forestDamageRate { get; set; }
    public int lightDamageRate { get; set; }
    public int darkDamageRate { get; set; }
    public int neutralDamageRate { get; set; }
    public int fireResistRate { get; set; }
    public int aquaResistRate { get; set; }
    public int forestResistRate { get; set; }
    public int lightResistRate { get; set; }
    public int darkResistRate { get; set; }
    public int neutralResistRate { get; set; }
    public int fireAimDamageRate { get; set; }
    public int aquaAimDamageRate { get; set; }
    public int forestAimDamageRate { get; set; }
    public int lightAimDamageRate { get; set; }
    public int darkAimDamageRate { get; set; }
    public int neutralAimDamageRate { get; set; }
    public int breakMstId { get; set; }
    public int conditionType { get; set; }
    public int conditionValue { get; set; }
    public int summonId { get; set; }
    public int hpGaugeCount { get; set; }
    public int startHpGaugeCount { get; set; }
    public string modeChangeEffectTxt { get; set; }
}

public class QuestOutGameQuestEnemySkillSetMstRecord : object
{
    public int questEnemySkillSetMstId { get; set; }
    public int enemySkillSetId { get; set; }
    public int skillMstId { get; set; }
    public int weightValue { get; set; }
    public int hpGaugeValue { get; set; }
    public bool isDescriptionHidden { get; set; }
}

public class QuestOutGameBreakMstRecord : object
{
    public int breakMstId { get; set; }
    public int breakPoint { get; set; }
    public int breakPointRecoveryPerTurn { get; set; }
    public int breakTurnGaugeSlowRatio { get; set; }
    public int initialBreakedDamageReceiveRate { get; set; }
    public int maxBreakedDamageReceiveRate { get; set; }
    public int breakedDamageReceiveRateIncreaseRate { get; set; }
}

public class SkillAbilityEffectTypeMstRecord : object
{
    public int abilityEffectTypeMstId { get; set; }
    public string name { get; set; }
    public string effectType { get; set; }
    public int category { get; set; }
    public string targetParams { get; set; }
    public int paramEffectType { get; set; }
    public string iconName { get; set; }
    public string stateFlipName { get; set; }
    public int displayType { get; set; }
}

public class SkillSkillDetailMstRecord : object
{
    public int skillDetailMstId { get; set; }
    public int skillMstId { get; set; }
    public string abilityEffectType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
    public int value3 { get; set; }
    public int value4 { get; set; }
    public int value5 { get; set; }
    public int element { get; set; }
    public int turn { get; set; }
    public int remainCount { get; set; }
    public int role { get; set; }
    public int range { get; set; }
    public int probability { get; set; }
    public string description { get; set; }
    public int descriptionType { get; set; }
    public string startConditionSetIdCsv { get; set; }
    public string activeConditionSetIdCsv { get; set; }
}

public class QuestOutGameQuestRewardMstRecord : object
{
    public int questRewardMstId { get; set; }
    public int rewardGroupId { get; set; }
    public int sortOrder { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class ExplorationFieldSeriesMstRecord : object
{
    public int fieldSeriesMstId { get; set; }
    public string name { get; set; }
    public int questMapMstId { get; set; }
    public int questGroupMstId { get; set; }
    public int styleMstId { get; set; }
    public string assetbundleName { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int sortOrder { get; set; }
}

public class ExplorationFieldStageMstRecord : object
{
    public int fieldStageMstId { get; set; }
    public int fieldSeriesMstId { get; set; }
    public string name { get; set; }
    public string subTitle { get; set; }
    public int difficulty { get; set; }
    public int prevFieldStageMstId { get; set; }
    public int prevFieldStageMstId2 { get; set; }
    public int firstClearRewardGroupId { get; set; }
    public string stageAssetbundleName { get; set; }
    public int backgroundCardMstId { get; set; }
}

public class ExplorationAdvMstRecord : object
{
    public int advMstId { get; set; }
    public int advType { get; set; }
    public bool has3dMovie { get; set; }
    public int advTitleMstId { get; set; }
    public string name { get; set; }
    public string subName { get; set; }
    public string advAssetbundleName { get; set; }
    public string advResourceName { get; set; }
    public int unlockType { get; set; }
    public int unlockId { get; set; }
    public bool gainGemFlg { get; set; }
    public int beforeAdvMstIdInGallery { get; set; }
    public string releaseTime { get; set; }
}

public class ExplorationAdvTitleMstRecord : object
{
    public int advTitleMstId { get; set; }
    public string title { get; set; }
    public bool isViewCollection { get; set; }
}

public class ObjectObjectReceiveTypeMstRecord : object
{
    public int objectReceiveType { get; set; }
    public int objectType { get; set; }
    public int expireDate { get; set; }
}

public class ObjectPayTypeMstRecord : object
{
    public int payType { get; set; }
    public int objectType { get; set; }
}

public class TalismanTalismanMstRecord : object
{
    public int talismanMstId { get; set; }
    public string name { get; set; }
    public int rarity { get; set; }
    public int talismanSlotId { get; set; }
    public int talismanSeriesMstId { get; set; }
    public string resourceName { get; set; }
}

public class TalismanTalismanParamMstRecord : object
{
    public int talismanParamMstId { get; set; }
    public int talismanParamEffectMstId { get; set; }
    public int level { get; set; }
    public int rarity { get; set; }
    public int talismanSlotId { get; set; }
    public int talismanParamType { get; set; }
    public int value { get; set; }
    public string description { get; set; }
}

public class TalismanTalismanParamEffectMstRecord : object
{
    public int talismanParamEffectMstId { get; set; }
    public string abilityEffectType { get; set; }
    public int element { get; set; }
    public int stance { get; set; }
    public string description { get; set; }
}

public class TalismanTalismanSeriesMstRecord : object
{
    public int talismanSeriesMstId { get; set; }
    public string talismanSeriesName { get; set; }
    public int slot2PassiveSkillMstId { get; set; }
    public int slot4PassiveSkillMstId { get; set; }
    public string resourceName { get; set; }
}

public class SkillPassiveSkillMstRecord : object
{
    public int passiveSkillMstId { get; set; }
    public int skillUniqueId { get; set; }
    public int level { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int conditionElement { get; set; }
    public int conditionRole { get; set; }
    public string skillButtonIcon { get; set; }
}

public class SkillPassiveSkillDetailMstRecord : object
{
    public int passiveSkillDetailMstId { get; set; }
    public int passiveSkillMstId { get; set; }
    public string abilityEffectType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
    public int value3 { get; set; }
    public int element { get; set; }
    public int turn { get; set; }
    public int remainCount { get; set; }
    public int role { get; set; }
    public int range { get; set; }
    public string description { get; set; }
    public int descriptionType { get; set; }
    public string startTimingIdCsv { get; set; }
    public string startConditionSetIdCsv { get; set; }
    public string activeConditionSetIdCsv { get; set; }
}

public class SkillLeaderSkillMstRecord : object
{
    public int leaderSkillMstId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
}

public class SkillLeaderSkillDetailMstRecord : object
{
    public int leaderSkillDetailMstId { get; set; }
    public int leaderSkillMstId { get; set; }
    public string abilityEffectType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
    public int value3 { get; set; }
    public int element { get; set; }
    public int stance { get; set; }
    public string description { get; set; }
}

public class PvpPvpRankingRewardMstRecord : object
{
    public int pvpRankingRewardMstId { get; set; }
    public int ranking { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class PvpPvpPointRewardMstRecord : object
{
    public int pvpPointRewardMstId { get; set; }
    public int point { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class UserTitleUserTitleMstRecord : object
{
    public int userTitleMstId { get; set; }
    public string title { get; set; }
    public int titleType { get; set; }
    public int value1 { get; set; }
}

public class GuildGuildTitleMstRecord : object
{
    public int guildTitleMstId { get; set; }
    public string title { get; set; }
    public bool hasDefault { get; set; }
    public string description { get; set; }
    public string resourceName { get; set; }
}

public class UserUserLevelUpMstRecord : object
{
    public int level { get; set; }
    public int levelUpExp { get; set; }
    public int backGroundPlayLimitSeconds { get; set; }
    public int subStyleSlotNum { get; set; }
    public int maxStamina { get; set; }
}

public class ShopShopSeriesMstRecord : object
{
    public int shopSeriesMstId { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int category { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int shopGroupId1 { get; set; }
    public int shopGroupId2 { get; set; }
    public int payType { get; set; }
    public int payId { get; set; }
    public string resourceName { get; set; }
}

public class ShopShopMstRecord : object
{
    public int shopMstId { get; set; }
    public int shopGroupId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public int sortOrder { get; set; }
    public int payType { get; set; }
    public int payId { get; set; }
    public int price { get; set; }
    public int purchaseLimitCount { get; set; }
    public int resetType { get; set; }
    public bool isSale { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
    public int detailGroupId { get; set; }
    public string resourceName { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
}

public class ShopShopDetailMstRecord : object
{
    public int shopDetailMstId { get; set; }
    public int detailGroupId { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class HomeBannerMstRecord : object
{
    public int bannerMstId { get; set; }
    public string name { get; set; }
    public string imageName { get; set; }
    public string destination { get; set; }
    public int bannerLabelMstId { get; set; }
}

public class HomeBannerLabelMstRecord : object
{
    public int bannerLabelMstId { get; set; }
    public string labelContent { get; set; }
    public string labelBgColor { get; set; }
}

public class HomeHomeBannerMstRecord : object
{
    public int homeBannerMstId { get; set; }
    public int bannerMstId { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int sortOrder { get; set; }
    public int osType { get; set; }
}

public class HomeHomeAppealMstRecord : object
{
    public int homeAppealMstId { get; set; }
    public int type { get; set; }
    public int bannerType { get; set; }
    public string resourceName { get; set; }
    public string bannerText1 { get; set; }
    public string bannerText2 { get; set; }
    public string bannerText3 { get; set; }
    public string bannerText4 { get; set; }
    public string textColor { get; set; }
    public string partsColor { get; set; }
    public int styleFigureMstId1 { get; set; }
    public int styleFigureMstId2 { get; set; }
    public int styleFigureMstId3 { get; set; }
    public string transitionSceneName { get; set; }
    public string transitionSceneParam { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int sortOrder { get; set; }
}

public class TipsTipsMstRecord : object
{
    public int tipsMstId { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string imageResourceName { get; set; }
    public int level { get; set; }
}

public class GveGveMstRecord : object
{
    public int gveMstId { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string battleStartTime { get; set; }
    public string battleEndTime { get; set; }
    public int gainEpUpRate { get; set; }
    public int specialAttackDamageUpRate { get; set; }
    public string resourceName { get; set; }
}

public class GveGveStageMstRecord : object
{
    public int gveStageMstId { get; set; }
    public int gveMstId { get; set; }
    public int laps { get; set; }
    public int step { get; set; }
    public int questStageMstId { get; set; }
    public int breakBonusTriggerCount { get; set; }
    public string characteristic { get; set; }
    public int victoryRound { get; set; }
}

public class GveGveStageRewardMstRecord : object
{
    public int gveStageRewardMstId { get; set; }
    public int gveStageMstId { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class MapGveMapGveMstRecord : object
{
    public int mapGveMstId { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string battleStartTime { get; set; }
    public string battleEndTime { get; set; }
    public int gainEpUpRate { get; set; }
    public int specialAttackDamageUpRate { get; set; }
    public string stageAssetbundleName { get; set; }
}

public class MapGveMapGveAreaMstRecord : object
{
    public int mapGveAreaMstId { get; set; }
    public int mapGveMstId { get; set; }
    public int areaNum { get; set; }
}

public class MapGveMapGvePointMstRecord : object
{
    public int mapGvePointMstId { get; set; }
    public int mapGveAreaMstId { get; set; }
    public int prevMapGvePointMstId { get; set; }
    public int pointType { get; set; }
    public int pointValue1 { get; set; }
    public int pointValue2 { get; set; }
    public int pointValue3 { get; set; }
    public bool isLock { get; set; }
    public int coordinateId { get; set; }
}

public class LoginBonusLoginBonusMstRecord : object
{
    public int loginBonusMstId { get; set; }
    public string title { get; set; }
    public int cycleType { get; set; }
    public int sortOrder { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
}

public class LoginBonusLoginBonusRewardMstRecord : object
{
    public int loginBonusRewardMstId { get; set; }
    public int loginBonusMstId { get; set; }
    public int dayCount { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class StyleStyleFigureMstRecord : object
{
    public int styleFigureMstId { get; set; }
    public int characterMstId { get; set; }
    public string modelName { get; set; }
    public string iconName { get; set; }
    public string voiceCueSheetName { get; set; }
}

public class StyleStyleFigureStoryMstRecord : object
{
    public int styleFigureStoryMstId { get; set; }
    public int styleFigureMstId { get; set; }
    public int advMstId { get; set; }
}

public class StyleStyleParamUpTreeMstRecord : object
{
    public int styleParamUpTreeMstId { get; set; }
    public int styleMstId { get; set; }
    public string treeName { get; set; }
    public int priority { get; set; }
    public int useItemMstId1 { get; set; }
    public int useItemNum1 { get; set; }
    public int useItemMstId2 { get; set; }
    public int useItemNum2 { get; set; }
    public int useItemMstId3 { get; set; }
    public int useItemNum3 { get; set; }
    public int conditionType { get; set; }
    public int conditionValue { get; set; }
}

public class StyleStyleParamUpMstRecord : object
{
    public int styleParamUpMstId { get; set; }
    public int groupId { get; set; }
    public int styleMstId { get; set; }
    public int styleParamUpTreeMstId { get; set; }
    public int priority { get; set; }
    public bool isStyleUniqueEffect { get; set; }
    public int styleParamUpEffectMstId { get; set; }
    public int styleParamUpCostMstId { get; set; }
    public int useMoney { get; set; }
    public int useItemMstId1 { get; set; }
    public int useItemNum1 { get; set; }
    public int useItemMstId2 { get; set; }
    public int useItemNum2 { get; set; }
    public int useItemMstId3 { get; set; }
    public int useItemNum3 { get; set; }
}

public class StyleStyleParamUpCostMstRecord : object
{
    public int styleParamUpCostMstId { get; set; }
    public int useMoney { get; set; }
    public int useItemMstId1 { get; set; }
    public int useItemNum1 { get; set; }
    public int useItemMstId2 { get; set; }
    public int useItemNum2 { get; set; }
    public int useItemMstId3 { get; set; }
    public int useItemNum3 { get; set; }
    public int useItemMstId4 { get; set; }
    public int useItemNum4 { get; set; }
    public int useItemMstId5 { get; set; }
    public int useItemNum5 { get; set; }
    public int useItemMstId6 { get; set; }
    public int useItemNum6 { get; set; }
}

public class StyleStyleParamUpEffectMstRecord : object
{
    public int styleParamUpEffectMstId { get; set; }
    public string name { get; set; }
    public int targetType { get; set; }
    public string abilityEffectType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
}

public class StyleStyleLimitBreakMstRecord : object
{
    public int styleLimitBreakMstId { get; set; }
    public int styleMstId { get; set; }
    public int limitBreakCount { get; set; }
    public int styleLimitBreakEffectMstId1 { get; set; }
    public int styleLimitBreakEffectMstId2 { get; set; }
}

public class StyleStyleLimitBreakEffectMstRecord : object
{
    public int styleLimitBreakEffectMstId { get; set; }
    public string name { get; set; }
    public int targetType { get; set; }
    public string abilityEffectType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
}

public class StyleStyleLevelUpMstRecord : object
{
    public long styleLevelUpMstId { get; set; }
    public int styleMstId { get; set; }
    public int level { get; set; }
    public int maxHp { get; set; }
    public int maxAtk { get; set; }
    public int maxDef { get; set; }
}

public class StyleStyleVoiceMstRecord : object
{
    public int styleVoiceMstId { get; set; }
    public int styleMstId { get; set; }
    public string name { get; set; }
    public int soundMstId { get; set; }
}

public class GvgGvgPointRewardMstRecord : object
{
    public int gvgPointRewardMstId { get; set; }
    public int point { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class GvgGvgRankingRewardMstRecord : object
{
    public int gvgRankingRewardMstId { get; set; }
    public int leagueId { get; set; }
    public int ranking { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class ChatChatStampMstRecord : object
{
    public int chatStampMstId { get; set; }
    public string description { get; set; }
}

public class QuestBattleBattleConditionMstRecord : object
{
    public int battleConditionMstId { get; set; }
    public string description { get; set; }
    public int compareTarget { get; set; }
    public int compareContent { get; set; }
    public int compareOperator { get; set; }
    public string compareValue { get; set; }
}

public class QuestBattleBattleConditionSetMstRecord : object
{
    public int battleConditionSetMstId { get; set; }
    public string description { get; set; }
    public string battleConditionMstIdCsv { get; set; }
}

public class QuestBattleEnemyConditionSetsAndActionMstRecord : object
{
    public int enemyConditionSetsAndActionMstId { get; set; }
    public int questEnemyAppearanceMstId { get; set; }
    public int enemyConditionSkillSetId { get; set; }
    public string conditionSetMstIdCsv { get; set; }
    public string skillMstIdCsv { get; set; }
    public bool isSkillBundle { get; set; }
    public bool isSkillReusable { get; set; }
    public int priority { get; set; }
}

public class CollectionDioramaBackgroundMstRecord : object
{
    public int dioramaBackgroundMstId { get; set; }
    public int seriesId { get; set; }
    public int fieldSeriesMstId { get; set; }
    public string stageThumbnailName { get; set; }
    public string backgroundResourceName { get; set; }
    public string stageName { get; set; }
    public int unlockType { get; set; }
    public int unlockId { get; set; }
    public string releaseTime { get; set; }
    public int sortOrder { get; set; }
    public int enemyType { get; set; }
}

public class CollectionLive2DParamMstRecord : object
{
    public int live2DParamMstId { get; set; }
    public string json { get; set; }
}

public class GvgGvgMstRecord : object
{
    public int gvgMstId { get; set; }
    public string eventStartTime { get; set; }
    public string eventEndTime { get; set; }
    public string battleStartTime { get; set; }
    public string battleEndTime { get; set; }
    public string resourceName { get; set; }
    public string stagePrefabName { get; set; }
    public string bgmCueSheetName { get; set; }
    public string bgmCueName { get; set; }
}

public class SoundSoundMstRecord : object
{
    public int soundMstId { get; set; }
    public int seriesId { get; set; }
    public int soundType { get; set; }
    public string name { get; set; }
    public string songWriter { get; set; }
    public string songComposer { get; set; }
    public string cueSheetName { get; set; }
    public string cueName { get; set; }
    public int unlockType { get; set; }
    public int unlockId { get; set; }
    public string releaseTime { get; set; }
}

public class CollectionCollectionIllustMstRecord : object
{
    public int collectionIllustMstId { get; set; }
    public string name { get; set; }
    public string illustrator { get; set; }
    public string source { get; set; }
    public int questMapMstId { get; set; }
    public int completeRewardCardMstId { get; set; }
    public int completeRewardStyleMstId { get; set; }
    public int completeRewardGemNum { get; set; }
    public int completeHomeAppealMstId { get; set; }
    public bool expandCelestialGlobe { get; set; }
    public string resourceName { get; set; }
    public bool isAutoUnlocked { get; set; }
    public int advMstId { get; set; }
}

public class CollectionCollectionIllustPieceMstRecord : object
{
    public int collectionIllustPieceMstId { get; set; }
    public int collectionIllustMstId { get; set; }
    public int collectionConditionGroupMstId { get; set; }
}

public class CollectionCollectionParamUpMstRecord : object
{
    public int collectionParamUpMstId { get; set; }
    public int category { get; set; }
}

public class CollectionCollectionParamUpLevelMstRecord : object
{
    public int collectionParamUpLevelMstId { get; set; }
    public int collectionParamUpMstId { get; set; }
    public int level { get; set; }
    public int conditionCount { get; set; }
    public string paramUpText { get; set; }
    public int effectGroupId { get; set; }
    public int rewardGroupId { get; set; }
}

public class CollectionCollectionParamUpEffectMstRecord : object
{
    public int collectionParamUpEffectMstId { get; set; }
    public int effectGroupId { get; set; }
    public int targetType { get; set; }
    public int element { get; set; }
    public int stance { get; set; }
    public string abilityEffectType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
}

public class CollectionCollectionConditionGroupMstRecord : object
{
    public int collectionConditionGroupMstId { get; set; }
    public int fieldSeriesMstId { get; set; }
    public int conditionGroupId1 { get; set; }
    public int conditionGroupId2 { get; set; }
    public int advMstId1 { get; set; }
    public int advMstId2 { get; set; }
}

public class CollectionCollectionConditionMstRecord : object
{
    public int collectionConditionMstId { get; set; }
    public int conditionGroupId { get; set; }
    public int fieldPointMstId { get; set; }
    public int objectType { get; set; }
    public int objectId { get; set; }
    public int fieldSeriesMstId { get; set; }
    public int fieldStratumMstId { get; set; }
    public int fieldStageMstId { get; set; }
    public int stratumNum { get; set; }
    public int chapterNum { get; set; }
    public int dungeonEventMstId { get; set; }
    public string presetEventMstId { get; set; }
    public int collectionGroup { get; set; }
    public int groupType { get; set; }
    public int collectionIllustMstId { get; set; }
}

public class CollectionCollectionRewardMstRecord : object
{
    public int collectionRewardMstId { get; set; }
    public int rewardGroupId { get; set; }
    public int sortOrder { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class StoryEventStoryEventMstRecord : object
{
    public int storyEventMstId { get; set; }
    public string name { get; set; }
    public int storyQuestGroupId { get; set; }
    public int scoreAttackMstId { get; set; }
    public int eventItemId { get; set; }
    public int shopSeriesMstId { get; set; }
    public string bonusStyleIds { get; set; }
    public bool isEndPlayable { get; set; }
    public string endDisplayTime { get; set; }
    public int sortOrder { get; set; }
    public int eventStartDirection { get; set; }
    public string topImageName { get; set; }
    public string bannerImageName { get; set; }
    public string bossCameraAssetName { get; set; }
    public string description { get; set; }
}

public class StoryEventStoryEventQuestStageMstRecord : object
{
    public int questStageMstId { get; set; }
    public int eventItemNum { get; set; }
}

public class TutorialMiniTutorialMstRecord : object
{
    public int miniTutorialMstId { get; set; }
    public int miniTutorialNumber { get; set; }
    public int sortOrder { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string resourceName { get; set; }
    public int advMstId { get; set; }
}

public class StoryEventStoryEventScenarioMstRecord : object
{
    public int storyEventScenarioMstId { get; set; }
    public int storyEventMstId { get; set; }
    public int advMstId { get; set; }
    public int conditionQuestStageMstId { get; set; }
    public int sortOrder { get; set; }
}

public class StoryEventStoryEventScenarioRewardMstRecord : object
{
    public int storyEventScenarioRewardMstId { get; set; }
    public int storyEventScenarioMstId { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class StoryEventStoryEventBonusRateMstRecord : object
{
    public int storyEventBonusRateMstId { get; set; }
    public int storyEventMstId { get; set; }
    public int bonusType { get; set; }
    public int bonusMstId { get; set; }
    public int limitBreakCount0Rate { get; set; }
    public int limitBreakCount1Rate { get; set; }
    public int limitBreakCount2Rate { get; set; }
    public int limitBreakCount3Rate { get; set; }
    public int limitBreakCount4Rate { get; set; }
    public int limitBreakCount5Rate { get; set; }
}

public class DungeonDungeonMstRecord : object
{
    public int dungeonMstId { get; set; }
    public int questGroupMstId { get; set; }
    public int dungeonTypeMstId { get; set; }
    public string dungeonName { get; set; }
    public string characterResourceName { get; set; }
    public string resourceName { get; set; }
    public string recommendationElementCsv { get; set; }
    public int recommendationPartyPower { get; set; }
    public int soundMstId { get; set; }
    public int recommendationElement { get; set; }
}

public class DungeonDungeonTypeMstRecord : object
{
    public int dungeonTypeMstId { get; set; }
    public int structureType { get; set; }
    public int room1LengthType { get; set; }
    public int room2LengthType { get; set; }
    public int room3LengthType { get; set; }
    public int room4LengthType { get; set; }
    public int room5LengthType { get; set; }
}

public class DungeonDungeonRoomMstRecord : object
{
    public long dungeonRoomMstId { get; set; }
    public int dungeonMstId { get; set; }
    public int roomIndex { get; set; }
    public int cameraType { get; set; }
    public int presetEvent1 { get; set; }
    public int presetEvent2 { get; set; }
    public int presetEvent3 { get; set; }
    public int presetEvent4 { get; set; }
    public int presetEvent5 { get; set; }
    public string levelResourceName { get; set; }
    public string backgroundResourceName { get; set; }
}

public class DungeonDungeonEventMstRecord : object
{
    public long dungeonEventMstId { get; set; }
    public long dungeonRoomMstId { get; set; }
    public int dungeonMstId { get; set; }
    public int dungeonPointId { get; set; }
    public int eventType { get; set; }
    public int value1 { get; set; }
    public int value2 { get; set; }
    public int value3 { get; set; }
    public int value4 { get; set; }
    public bool isHidden { get; set; }
    public int dungeonRoomId { get; set; }
    public int order { get; set; }
}

public class ExplorationFieldStratumMstRecord : object
{
    public int fieldStratumMstId { get; set; }
    public int fieldStageMstId { get; set; }
    public int stratumNum { get; set; }
    public bool isWholeFieldVisible { get; set; }
    public int soundMstId { get; set; }
}

public class ExplorationFieldPointMstRecord : object
{
    public int fieldPointMstId { get; set; }
    public int fieldStratumMstId { get; set; }
    public int prevFieldPointMstId { get; set; }
    public string name { get; set; }
    public int chapterNum { get; set; }
    public int pointType { get; set; }
    public int pointValue1 { get; set; }
    public int pointValue2 { get; set; }
    public int displayType { get; set; }
    public bool isHidden { get; set; }
    public int firstClearRewardGroupId { get; set; }
    public int firstClearOtherCollectionRewardGroupId { get; set; }
    public string needViewAdvMstIds { get; set; }
    public int coordinateId { get; set; }
    public string assetbundleName { get; set; }
    public string startTime { get; set; }
}

public class ExplorationBossDirectionMstRecord : object
{
    public int bossDirectionMstId { get; set; }
    public string resourceName { get; set; }
    public int nextSceneType { get; set; }
    public int objectId { get; set; }
    public int nextBossDirectionMstId { get; set; }
}

public class GatheringGatheringLevelMstRecord : object
{
    public int gatheringLevel { get; set; }
    public int userLevel { get; set; }
}

public class GatheringGatheringRewardMstRecord : object
{
    public int gatheringRewardMstId { get; set; }
    public int gatheringLevel { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
}

public class ScoreAttackScoreAttackMstRecord : object
{
    public int scoreAttackMstId { get; set; }
    public string name { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string comment { get; set; }
    public int reprintNum { get; set; }
    public int highScoreRewardGroupId { get; set; }
    public int totalScoreRewardGroupId { get; set; }
    public int dioramaBackgroundMstId { get; set; }
}

public class ScoreAttackScoreAttackStageMstRecord : object
{
    public int scoreAttackStageMstId { get; set; }
    public int scoreAttackMstId { get; set; }
    public int questStageMstId { get; set; }
    public int difficulty { get; set; }
}

public class ScoreAttackScoreAttackHighScoreRewardMstRecord : object
{
    public int scoreAttackHighScoreRewardMstId { get; set; }
    public int groupId { get; set; }
    public long score { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class ScoreAttackScoreAttackTotalScoreRewardMstRecord : object
{
    public int scoreAttackTotalScoreRewardMstId { get; set; }
    public int groupId { get; set; }
    public long score { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class CalcPointCalculationPointPolicyMstRecord : object
{
    public int calculationPointPolicyMstId { get; set; }
    public int policyType { get; set; }
    public string coefficientName { get; set; }
    public int conditionValue { get; set; }
    public int value { get; set; }
    public string startTime { get; set; }
}

public class GuildMissionGuildMissionMstRecord : object
{
    public int guildMissionMstId { get; set; }
    public int missionTitleMstId { get; set; }
    public int sortOrder { get; set; }
    public int guildMissionUniqueId { get; set; }
    public int guildMissionUniquePriority { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
    public int resetType { get; set; }
    public int resetCycle { get; set; }
    public int triggerType { get; set; }
    public int conditionType { get; set; }
    public int conditionObjectId { get; set; }
    public int conditionObjectId2 { get; set; }
    public int conditionCount { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
}

public class GuildMissionGuildMissionTransitionMstRecord : object
{
    public int guildMissionTransitionMstId { get; set; }
    public int guildMissionMstId { get; set; }
    public string transitionSceneName { get; set; }
    public int transitionSceneParam { get; set; }
}

public class MapGveMapGveUserDataRecord : object
{
    public long userId { get; set; }
    public int mapGveMstId { get; set; }
    public int mapGvePointMstId { get; set; }
    public string enableMovePointMstIdCsv { get; set; }
    public string clearPointMstIdCsv { get; set; }
    public string unlockPointMstIdCsv { get; set; }
    public int totalDamage { get; set; }
}

public class MapGveMapGveGuildDataRecord : object
{
    public long guildDataId { get; set; }
    public int mapGveMstId { get; set; }
    public string reachBossPointMstIdCsv { get; set; }
}

public class MapGveMapGveRankingRecord : object
{
    public string userName { get; set; }
    public int rank { get; set; }
    public int ranking { get; set; }
    public int totalDamage { get; set; }
    public int favoriteStyleMstId { get; set; }
}

public class CardCardDataRecord : object
{
    public long userId { get; set; }
    public long cardDataId { get; set; }
    public int cardMstId { get; set; }
    public int passiveSkillLevel { get; set; }
    public int limitBreakCount { get; set; }
    public bool isProtect { get; set; }
    public bool isAlreadyView { get; set; }
    public string createdTime { get; set; }
}

public class ItemItemDataRecord : object
{
    public long userId { get; set; }
    public int itemMstId { get; set; }
    public long lotNumber { get; set; }
    public int num { get; set; }
    public string endTime { get; set; }
}

public class CharacterCharacterDataRecord : object
{
    public long userId { get; set; }
    public int characterMstId { get; set; }
    public int awakeLevel { get; set; }
    public int level { get; set; }
    public int exp { get; set; }
    public int heartLevel { get; set; }
    public int heartExp { get; set; }
    public int intimacyPoint { get; set; }
    public int useCount { get; set; }
    public int levelResetCount { get; set; }
    public string createdTime { get; set; }
}

public class StyleSkillInfo : object
{
    public int skillMstId { get; set; }
    public int skillUniqueId { get; set; }
    public int level { get; set; }
}

public class StylePassiveSkillInfo : object
{
    public int passiveSkillMstId { get; set; }
    public int skillUniqueId { get; set; }
    public int level { get; set; }
}

public class StyleSpecialAttackSkillInfo : object
{
    public int skillMstId { get; set; }
    public int level { get; set; }
    public int maxLevel { get; set; }
}

public class StyleLeaderSkillInfo : object
{
    public int leaderSkillMstId { get; set; }
    public int level { get; set; }
}

public class StyleParamUpTreeInfo : object
{
    public int styleParamUpTreeMstId { get; set; }
    public bool isOpen { get; set; }
    public int lastParamUpPriority { get; set; }
}

public class StyleParamUpEffectInfo : object
{
    public string abilityEffectType { get; set; }
    public int totalValue1 { get; set; }
    public int totalValue2 { get; set; }
}

public class StyleStyleDataRecord : object
{
    public long userId { get; set; }
    public int styleMstId { get; set; }
    public int level { get; set; }
    public int exp { get; set; }
    public int limitBreakCount { get; set; }
    public int specialAttackLevel { get; set; }
    public int normalAttackLevel { get; set; }
    public int skill1Level { get; set; }
    public int passiveSkill1Level { get; set; }
    public int limitBreakPassiveSkill1Level { get; set; }
    public string createdTime { get; set; }
    public StyleSkillInfo normalAttackInfo { get; set; }
    public List<StyleSkillInfo> skillInfoList { get; set; }
    public List<StylePassiveSkillInfo> passiveSkillInfoList { get; set; }
    public List<StylePassiveSkillInfo> limitBreakPassiveSkillInfoList { get; set; }
    public StylePassiveSkillInfo subPassiveSkillInfo { get; set; }
    public StyleSpecialAttackSkillInfo specialAttackSkillInfo { get; set; }
    public StyleLeaderSkillInfo leaderSkillInfo { get; set; }
    public List<StyleParamUpTreeInfo> paramUpTreeInfoList { get; set; }
    public int lastParamUpPriority { get; set; }
    public List<StyleParamUpEffectInfo> paramUpEffectInfoList { get; set; }
    public List<StyleParamUpEffectInfo> limitBreakParamUpEffectInfoList { get; set; }
    public bool isAlreadyView { get; set; }
}

public class CollectionCollectionDataRecord : object
{
    public long userId { get; set; }
    public ObjectObjectType objectType { get; set; }
    public int objectId { get; set; }
    public bool isGet { get; set; }
    public bool isAlreadyView { get; set; }
    public string createdTime { get; set; }
}

public class ObjectObjectViewData : object
{
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class ObjectStyleGainViewData : object
{
    public int styleMstId { get; set; }
    public int num { get; set; }
    public bool isNew { get; set; }
    public ObjectObjectViewData convertedItem { get; set; }
    public List<ObjectObjectViewData> additionObjectList { get; set; }
}

public class ObjectCardGainViewData : object
{
    public int cardMstId { get; set; }
    public int num { get; set; }
    public bool isNew { get; set; }
    public ObjectObjectViewData convertedItem { get; set; }
}

public class ObjectGainViewData : object
{
    public List<ObjectStyleGainViewData> styleGainViewDataList { get; set; }
    public List<ObjectCardGainViewData> cardGainViewDataList { get; set; }
}

public class ObjectObjectDataRecord : object
{
    public List<CardCardDataRecord> cardDataList { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
    public List<CharacterCharacterDataRecord> characterDataList { get; set; }
    public List<StyleStyleDataRecord> styleDataList { get; set; }
    public List<CollectionCollectionDataRecord> collectionDataList { get; set; }
    public List<TalismanTalismanDataRecord> talismanDataList { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
    public ObjectGainViewData gainViewData { get; set; }
}

public class InAppSnsAccessToken : object
{
    public string accessToken { get; set; }
    public string accountId { get; set; }
}

public class HariboteChatMessageDataRecord : object
{
    public string userName { get; set; }
    public long userId { get; set; }
    public int styleMstId { get; set; }
    public string message { get; set; }
    public string createdTime { get; set; }
}

public class QuestBattleQuestRoomData : object
{
    public long questDataId { get; set; }
    public int questStageMstId { get; set; }
    public int gveStageMstId { get; set; }
    public int fieldStageMstId { get; set; }
    public bool backGroundPlay { get; set; }
    public int repeatNum { get; set; }
    public string createdTime { get; set; }
}

public class ExplorationFieldStageUserDataRecord : object
{
    public long userId { get; set; }
    public int fieldSeriesMstId { get; set; }
    public int fieldStageMstId { get; set; }
    public int fieldPointMstId { get; set; }
    public int dungeonPointId { get; set; }
    public string presetEventMstId { get; set; }
    public string enableMoveFieldPointMstIdCsv { get; set; }
    public string clearFieldPointMstIdCsv { get; set; }
    public string clearTempDungeonEventMstIdCsv { get; set; }
    public string clearTempPresetEventMstIdCsv { get; set; }
    public string clearDungeonEventMstIdCsv { get; set; }
    public string clearPresetEventMstIdCsv { get; set; }
    public string openFieldPointMstIdCsv { get; set; }
    public bool isClear { get; set; }
    public string firstBattleFieldStratumMstIdCsv { get; set; }
}

public class CharacterCharacterLevelUpInfo : object
{
    public int characterMstId { get; set; }
    public int styleMstId { get; set; }
    public int beforeLevel { get; set; }
    public int beforeExp { get; set; }
    public int afterLevel { get; set; }
    public int afterExp { get; set; }
}

public class StyleStyleLevelUpInfo : object
{
    public int styleMstId { get; set; }
    public int beforeLevel { get; set; }
    public int beforeExp { get; set; }
    public int afterLevel { get; set; }
    public int afterExp { get; set; }
}

public class CollectionCollectionDetailInfo : object
{
    public int groupType { get; set; }
    public int groupValue { get; set; }
    public bool isBossStratum { get; set; }
    public int group1ConditionCount { get; set; }
    public int group2ConditionCount { get; set; }
    public int group1AchievedCount { get; set; }
    public int group2AchievedCount { get; set; }
}

public class CollectionFieldStageCollectionInfo : object
{
    public int fieldStageMstId { get; set; }
    public bool enableEntry { get; set; }
    public bool isClear { get; set; }
    public int maxReleasedStratumNum { get; set; }
    public int collectionIllustMstId { get; set; }
    public int group1ConditionCount { get; set; }
    public int group2ConditionCount { get; set; }
    public int group1AchievedCount { get; set; }
    public int group2AchievedCount { get; set; }
    public int itemConditionCount { get; set; }
    public int itemAchievedCount { get; set; }
    public List<CollectionCollectionDetailInfo> collectionDetailInfoList { get; set; }
}

public class TutorialFeatureRelease : object
{
    public int level { get; set; }
    public List<string> featureReleaseStrList { get; set; }
}

public class TutorialMiniTutorialDataRecord : object
{
    public long userId { get; set; }
    public List<int> finishedMiniTutorialNumberList { get; set; }
}

public class ExplorationBattleStageInfo : object
{
    public long questDataId { get; set; }
    public int questStageMstId { get; set; }
    public int fieldStageMstId { get; set; }
    public string endTime { get; set; }
}

public class QuestBattleAttackInfo : object
{
    public int skillMstId { get; set; }
    public int level { get; set; }
}

public class QuestBattlePassiveSkillInfo : object
{
    public int passiveSkillMstId { get; set; }
    public int level { get; set; }
    public int abilitySourceType { get; set; }
}

public class QuestBattleLeaderSkillInfo : object
{
    public int leaderSkillMstId { get; set; }
    public int level { get; set; }
}

public class QuestBattleTalismanParamInfo : object
{
    public int talismanParamMstId { get; set; }
}

public class QuestBattleBattleUnit : object
{
    public int battleUnitDataId { get; set; }
    public int battleUnitType { get; set; }
    public int battleUnitMstId { get; set; }
    public int styleMstId { get; set; }
    public int levelReactionValue { get; set; }
    public int levelReactionBreakDamageValue { get; set; }
    public int levelReactionSlipDamageValue { get; set; }
    public int maxHp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int speed { get; set; }
    public int criticalRate { get; set; }
    public int criticalDamageRate { get; set; }
    public int breakDamageRate { get; set; }
    public int healRate { get; set; }
    public int recoveryEpRate { get; set; }
    public int effectHitRate { get; set; }
    public int effectParryRate { get; set; }
    public int fireDamageRate { get; set; }
    public int aquaDamageRate { get; set; }
    public int forestDamageRate { get; set; }
    public int lightDamageRate { get; set; }
    public int darkDamageRate { get; set; }
    public int neutralDamageRate { get; set; }
    public int fireResistRate { get; set; }
    public int aquaResistRate { get; set; }
    public int forestResistRate { get; set; }
    public int lightResistRate { get; set; }
    public int darkResistRate { get; set; }
    public int neutralResistRate { get; set; }
    public QuestBattleAttackInfo normalAttackInfo { get; set; }
    public List<QuestBattleAttackInfo> attackInfoList { get; set; }
    public QuestBattleAttackInfo specialAttackInfo { get; set; }
    public List<QuestBattlePassiveSkillInfo> passiveSkillInfoList { get; set; }
    public QuestBattleLeaderSkillInfo leaderSkillInfo { get; set; }
    public List<QuestBattleTalismanParamInfo> talismanParamInfoList { get; set; }
}

public class PartyCharacterBuildDetail : object
{
    public StyleStyleDataRecord styleData { get; set; }
    public CharacterCharacterDataRecord characterData { get; set; }
    public CardCardDataRecord cardData { get; set; }
    public List<CardCardDataRecord> cardDataList { get; set; }
    public List<TalismanTalismanDataRecord> talismanDataList { get; set; }
    public List<StyleStyleDataRecord> subStyleDataList { get; set; }
    public List<CardCardDataRecord> subCardDataList { get; set; }
}

public class LoginBonusLoginBonusConfig : object
{
    public int loginBonusRefreshHour { get; set; }
}

public class CharacterAwakeCostInfo : object
{
    public int awakeLevel { get; set; }
    public int onlyMaterialNum { get; set; }
    public int genericMaterialNum { get; set; }
}

public class CharacterRegionRecord : object
{
    public int regionId { get; set; }
    public string name { get; set; }
}

public class CharacterSeriesRecord : object
{
    public int seriesId { get; set; }
    public string name { get; set; }
}

public class CharacterLevelUpCost : object
{
    public int level { get; set; }
    public int exp { get; set; }
    public int goldPerExp { get; set; }
}

public class CharacterCharacterConfig : object
{
    public List<CharacterAwakeCostInfo> awakeCostInfo { get; set; }
    public List<CharacterRegionRecord> region { get; set; }
    public List<CharacterSeriesRecord> series { get; set; }
    public int genericAwakeItemMstId { get; set; }
    public int namaeCharacterMstId { get; set; }
    public int namaeObjectRewardGroupId { get; set; }
    public List<CharacterLevelUpCost> levelUpCost { get; set; }
}

public class CardCardGenericLimitBreakRecord : object
{
    public int rarity { get; set; }
    public int itemMstId { get; set; }
}

public class CardCardMaxLevelRecord : object
{
    public int rarity { get; set; }
    public int limitBreakCount { get; set; }
    public int maxLevel { get; set; }
}

public class CardCardSellRecord : object
{
    public int rarity { get; set; }
    public int itemMstId { get; set; }
    public int num { get; set; }
    public int gold { get; set; }
}

public class CardUnlockSubCardDataSlotRecord : object
{
    public int achievedLevel { get; set; }
    public int slot { get; set; }
}

public class CardSubCardReflectRateRecord : object
{
    public int equippedNum { get; set; }
    public int rate { get; set; }
}

public class CardCardLimitBreakRarityRecord : object
{
    public int rarity { get; set; }
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class CardCardConfig : object
{
    public List<CardCardGenericLimitBreakRecord> genericLimitBreakInfo { get; set; }
    public List<CardCardMaxLevelRecord> maxLevelInfo { get; set; }
    public List<CardCardSellRecord> sellCardInfo { get; set; }
    public List<CardUnlockSubCardDataSlotRecord> unlockSubCardDataSlot { get; set; }
    public List<CardSubCardReflectRateRecord> subCardReflectRate { get; set; }
    public List<CardCardLimitBreakRarityRecord> cardLimitBreakRarityInfo { get; set; }
}

public class CollectionCollectionConfig : object
{
    public int gainGemNum { get; set; }
    public List<int> hiddenGalleryCardMstIdList { get; set; }
}

public class StyleStyleLimitBreakRarityRecord : object
{
    public int rarity { get; set; }
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class StyleStyleLimitBreakCostRecord : object
{
    public int rarity { get; set; }
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class StyleLimitBreakBonusRecord : object
{
    public int limitBreakCount { get; set; }
    public int bonus { get; set; }
}

public class StyleLimitBreakCharacterMaxLevelRecord : object
{
    public int rarity { get; set; }
    public int limitBreakCount { get; set; }
    public int maxLevel { get; set; }
}

public class StyleUnlockSubStyleDataSlotRecord : object
{
    public int achievedLevel { get; set; }
    public int styleLevel { get; set; }
    public int fieldStageMstId { get; set; }
    public string conditionTxt { get; set; }
    public int slot { get; set; }
    public int miniTutorialNumber { get; set; }
}

public class StyleLimitBreakSpecialAttackMaxLevelRecord : object
{
    public int limitBreakCount { get; set; }
    public int maxLevel { get; set; }
}

public class StyleParamUpMaxPriorityInfo : object
{
    public int styleLevel { get; set; }
    public int maxPriority { get; set; }
}

public class StyleLevelUpCost : object
{
    public int level { get; set; }
    public int exp { get; set; }
    public int goldPerExp { get; set; }
}

public class StyleStyleConfig : object
{
    public List<StyleStyleLimitBreakRarityRecord> styleLimitBreakRarityInfo { get; set; }
    public List<StyleStyleLimitBreakCostRecord> limitBreakCostInfo { get; set; }
    public List<StyleLimitBreakBonusRecord> limitBreakBonus { get; set; }
    public List<StyleLimitBreakCharacterMaxLevelRecord> limitBreakCharacterMaxLevel { get; set; }
    public int limitBreakPassiveSkill1TargetCount { get; set; }
    public int limitBreakSpecialAttackEffectTargetCount { get; set; }
    public List<StyleUnlockSubStyleDataSlotRecord> unlockSubStyleDataSlot { get; set; }
    public int maxSkillLevel { get; set; }
    public int defaultSpecialAttackMaxLevel { get; set; }
    public List<StyleLimitBreakSpecialAttackMaxLevelRecord> limitBreakSpecialAttackMaxLevel { get; set; }
    public List<StyleParamUpMaxPriorityInfo> paramUpMaxPriorityInfo { get; set; }
    public List<StyleLevelUpCost> levelUpCost { get; set; }
    public int unlockSubStyleFieldStageMstId { get; set; }
}

public class PvpWinStreakBonusRate : object
{
    public int winStreakCount { get; set; }
    public int correctedBonusRate { get; set; }
}

public class PvpPvpConfig : object
{
    public int maxFreePlayCountPerDay { get; set; }
    public int maxPlayCountPerDay { get; set; }
    public int addPlayCountGemNum { get; set; }
    public int outOfRangeRanking { get; set; }
    public List<PvpWinStreakBonusRate> winStreakBonusRateList { get; set; }
    public int rewardItemMstId { get; set; }
    public int shopSeriesMstId { get; set; }
}

public class TalismanTalismanRarityRecord : object
{
    public int rarity { get; set; }
    public int gold { get; set; }
    public int levelUpCostGold { get; set; }
}

public class TalismanTalismanConfig : object
{
    public int talismanNumLimit { get; set; }
    public List<TalismanTalismanRarityRecord> rarityInfo { get; set; }
    public int maxSellNum { get; set; }
    public int useLevelUpTalismanNum { get; set; }
}

public class MissionMissionConfig : object
{
    public int beginnerMissionFirstMissionTitleMstId { get; set; }
    public int subscriptionMissionDoubleTermRewardScale { get; set; }
}

public class GuildMinMaxInfo : object
{
    public int min { get; set; }
    public int max { get; set; }
}

public class GuildValidatorInfo : object
{
    public GuildMinMaxInfo length { get; set; }
}

public class GuildGuildValidator : object
{
    public GuildValidatorInfo guildName { get; set; }
    public GuildValidatorInfo guildDescription { get; set; }
    public GuildValidatorInfo guildNameOrId { get; set; }
}

public class GuildGuildConfig : object
{
    public int maxGuildMemberNum { get; set; }
    public int guildRoleMstIdOfMember { get; set; }
    public int guildRoleMstIdOfGuildMaster { get; set; }
    public int guildRoleMstIdOfGuildSubMaster { get; set; }
    public int maxGuildSubMasterNum { get; set; }
    public int masterMigrateNotLoginDay { get; set; }
    public int maxJoinRequestNum { get; set; }
    public int maxReceiveJoinRequestNum { get; set; }
    public int maxScoutNum { get; set; }
    public int maxReceiveScoutNum { get; set; }
    public GuildGuildValidator validator { get; set; }
}

public class GveMedalData : object
{
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class GveGveConfig : object
{
    public int dayPlayCount { get; set; }
    public int chainInitialLevel { get; set; }
    public int chainMaxLevel { get; set; }
    public int damageApiInterval { get; set; }
    public GveMedalData participationMedal { get; set; }
}

public class PresentPresentBoxConfig : object
{
    public string defaultExpireTime { get; set; }
}

public class UserUserConfig : object
{
    public int staminaRecoverSec { get; set; }
    public int maxStamina { get; set; }
    public int staminaUpperLimit { get; set; }
    public int staminaRecoverMaxCountInDay { get; set; }
    public int staminaRecoverGemInfoGemNum { get; set; }
    public int staminaRecoverGemInfoRecoverAmount { get; set; }
    public int staminaRecoverGemInfoMaxCountInDay { get; set; }
    public int restrictSetNameDays { get; set; }
    public int maxUserNameLength { get; set; }
    public int playerIdDigitNum { get; set; }
    public int defaultUserTitleMstId { get; set; }
    public int storeReviewMinPendingDays { get; set; }
    public int userExpMax { get; set; }
    public int maxCommentLength { get; set; }
}

public class QuestOutGameQuestConfig : object
{
    public int backGroundPlayAddLapTimeSeconds { get; set; }
    public int characterHeartDailyBattleClearLimit { get; set; }
}

public class TutorialTutorialStepRecord : object
{
    public string name { get; set; }
    public int value { get; set; }
}

public class TutorialTutorialBattleFixedAllyInfo : object
{
    public int questStageMstId { get; set; }
    public int styleMstId { get; set; }
    public List<int> styleMstIds { get; set; }
}

public class TutorialUnlockConditionTxtInfo : object
{
    public int miniTutorialNumber { get; set; }
    public string unlockConditionTxt { get; set; }
}

public class TutorialReleaseStageTalkConfig : object
{
    public string releaseStageName { get; set; }
    public int releaseFlag { get; set; }
    public int releaseTalkFlag { get; set; }
    public int talkId { get; set; }
}

public class TutorialTutorialConfig : object
{
    public List<TutorialTutorialStepRecord> tutorialStepList { get; set; }
    public int finishTutorialStep { get; set; }
    public List<TutorialTutorialBattleFixedAllyInfo> tutorialBattleFixedAllyInfoList { get; set; }
    public List<TutorialUnlockConditionTxtInfo> unlockConditionTxtInfoList { get; set; }
    public List<TutorialReleaseStageTalkConfig> releaseStageTalkConfigList { get; set; }
    public List<string> dungeonMstList { get; set; }
    public List<string> battleMstList { get; set; }
}

public class TowerTowerConfig : object
{
    public int resetTowerSkipNum { get; set; }
    public int maxTowerSkipNumForItem { get; set; }
    public int maxSkipNumForItemRecoveryInADay { get; set; }
    public List<int> saveFloor { get; set; }
}

public class PartyFixParamsPowerRate : object
{
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int speed { get; set; }
}

public class PartyRoleCoefficientInfo : object
{
    public int role { get; set; }
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
}

public class PartyRateParamsPowerRate : object
{
    public int criticalRate { get; set; }
    public int criticalDamageRate { get; set; }
    public int breakDamageRate { get; set; }
    public int healRate { get; set; }
    public int recoveryEpRate { get; set; }
    public int effectHitRate { get; set; }
    public int effectParryRate { get; set; }
}

public class PartySkillCoefficientPerLevel : object
{
    public int skillLevel { get; set; }
    public int coefficient { get; set; }
}

public class PartySkillPowerRateInfo : object
{
    public double baseConst { get; set; }
    public double exponent { get; set; }
    public int addConst { get; set; }
    public List<PartySkillCoefficientPerLevel> coefficientPerLevel { get; set; }
}

public class PartyPowerRate : object
{
    public PartyFixParamsPowerRate fixParams { get; set; }
    public List<PartyRoleCoefficientInfo> roleCoefficientInfoList { get; set; }
    public int skillPowerBaseValue { get; set; }
    public int specialAttackCoefficient { get; set; }
    public int skillCoefficient { get; set; }
    public int passiveSkillCoefficient { get; set; }
    public int normalAttackCoefficient { get; set; }
    public PartyRateParamsPowerRate rateParams { get; set; }
    public PartySkillPowerRateInfo specialAttack { get; set; }
    public PartySkillPowerRateInfo skill { get; set; }
    public PartySkillPowerRateInfo passiveSkill { get; set; }
    public PartySkillPowerRateInfo normalAttack { get; set; }
}

public class PartySubStyleDataParamRate : object
{
    public int slot { get; set; }
    public int achievedLevel { get; set; }
    public int rate { get; set; }
}

public class PartyPartyConfig : object
{
    public int partyNumMax { get; set; }
    public int nameLengthMax { get; set; }
    public string defaultSoloPartyName { get; set; }
    public string defaultBattlePartyName { get; set; }
    public PartyPowerRate powerRate { get; set; }
    public int subStyleDataParamRate { get; set; }
    public List<PartySubStyleDataParamRate> subStyleDataParamRateInfo { get; set; }
}

public class ShopServiceInfo : object
{
    public string label { get; set; }
    public bool firstFree { get; set; }
    public int rewardDetailAnnounceMstId { get; set; }
    public string resourceName { get; set; }
    public string titleDescription { get; set; }
    public List<string> description { get; set; }
    public List<string> notesIos { get; set; }
    public List<string> notesAndroid { get; set; }
}

public class ShopSubscriptionConfig : object
{
    public List<string> subscriptionLabelList { get; set; }
    public List<ShopServiceInfo> serviceList { get; set; }
}

public class StoryEventStoryEventConfig : object
{
    public int keyItemMstId { get; set; }
    public int keyItemNum { get; set; }
    public int archiveEventItemId { get; set; }
    public int maxPlayCountPerDay { get; set; }
    public int maxPlayCountPerDayArchive { get; set; }
    public int playCountRecoverGemInfoGemNum { get; set; }
    public int playCountRecoverGemInfoRecoverAmount { get; set; }
    public int playCountRecoverGemInfoMaxCountInDay { get; set; }
    public int playCountRecoverGemInfoMaxCount { get; set; }
}

public class ChatChatConfig : object
{
    public int directChatRoomListLimit { get; set; }
    public int groupChatRoomListLimit { get; set; }
    public int groupChatRoomCreationLimit { get; set; }
    public int groupChatRoomMemberLimit { get; set; }
    public int chatBlockUserLimit { get; set; }
    public int chatsExpireDays { get; set; }
}

public class ConfigFirestoreConfig : object
{
    public string firestoreCollectionPath { get; set; }
}

public class TermsTermsConfig : object
{
    public int latestTermNumChat { get; set; }
    public List<TermsTermsInfo> termsUpdatedTextChat { get; set; }
}

public class GatheringGatheringShortcutAmountRecord : object
{
    public int times { get; set; }
    public int amount { get; set; }
}

public class GatheringGatheringShortcutCountConfig : object
{
    public List<GatheringGatheringShortcutAmountRecord> incAmount { get; set; }
}

public class GatheringGatheringConfig : object
{
    public int gatheringMaxHours { get; set; }
    public int gatheringShortcutHours { get; set; }
    public int perMinutes { get; set; }
    public GatheringGatheringShortcutCountConfig gatheringShortcutCount { get; set; }
}

public class GvgGvgConfig : object
{
    public List<int> preLeagueMatchDayList { get; set; }
}

public class ScoreAttackScoreAttackConfig : object
{
    public int topRankingViewNumber { get; set; }
    public int outOfRankingViewNumber { get; set; }
}

public class ConfigAppResourceConfig : object
{
    public List<string> allowedBgmList { get; set; }
    public List<string> allowedStreamingMovieList { get; set; }
    public List<string> replaceStreamingMovieList { get; set; }
    public List<string> forEnglishStreamingMovieList { get; set; }
}

public class TowerUserTowerDataRecord : object
{
    public long userId { get; set; }
    public int eventType { get; set; }
    public int maxQuestStageMstId { get; set; }
    public int skipNum { get; set; }
    public string skipNumUpdatedTime { get; set; }
    public int skipNumForItem { get; set; }
    public int skipNumForItemRecoverInADay { get; set; }
    public string skipNumForItemRecoverTime { get; set; }
    public int reprintNum { get; set; }
}

public class TowerSkipFloorDataRecord : object
{
    public int prevMaxQuestStageMstId { get; set; }
    public List<int> rewardMstIds { get; set; }
    public ObjectObjectDataRecord objectDataRecord { get; set; }
}

public class QuestOutGameUserQuestStageDataRecord : object
{
    public long userId { get; set; }
    public int questStageMstId { get; set; }
    public int reprintNum { get; set; }
    public int questGroupMstId { get; set; }
    public int lastElapsedSeconds { get; set; }
    public int clearCount { get; set; }
    public int dailyClearCount { get; set; }
    public string dailyClearCountUpdatedTime { get; set; }
}

public class StoryEventStoryEventDataRecord : object
{
    public long userId { get; set; }
    public int storyEventMstId { get; set; }
    public int todayPlayableCount { get; set; }
    public int gemRecoveryCount { get; set; }
    public string countResetTime { get; set; }
}

public class StoryEventStoryEventInfo : object
{
    public int storyEventMstId { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public bool isOpen { get; set; }
    public bool isUnlocked { get; set; }
    public bool isPlayable { get; set; }
}

public class QuestOutGameUserQuestGroupDataRecord : object
{
    public long userId { get; set; }
    public int questGroupMstId { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
}

public class ScoreAttackUserScoreAttackDataRecord : object
{
    public int scoreAttackMstId { get; set; }
    public long userId { get; set; }
    public long highScore { get; set; }
    public long totalScore { get; set; }
    public int questStageMstId { get; set; }
    public int scoreAttackHighScoreRewardMstId { get; set; }
    public int scoreAttackTotalScoreRewardMstId { get; set; }
    public int reprintNum { get; set; }
    public int clearedDifficulty { get; set; }
}

public class ShopShopCountDataRecord : object
{
    public long userId { get; set; }
    public int shopSeriesMstId { get; set; }
    public int shopMstId { get; set; }
    public int purchaseCount { get; set; }
    public string resetTime { get; set; }
}

public class ShopBuyViewData : object
{
    public bool isSuccess { get; set; }
}

public class ShopShopPaymentMstRecord : object
{
    public int shopPaymentMstId { get; set; }
    public int groupId { get; set; }
    public string productId { get; set; }
    public int type { get; set; }
    public int announceMstId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public bool isSale { get; set; }
    public string comment { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string resourceName { get; set; }
    public int dispType { get; set; }
}

public class ShopShopPaymentBonusRewardMstRecord : object
{
    public int shopPaymentBonusRewardMstId { get; set; }
    public int groupId { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class ScoreAttackRankingInfo : object
{
    public string userName { get; set; }
    public long userId { get; set; }
    public int rank { get; set; }
    public int ranking { get; set; }
    public long score { get; set; }
    public int favoriteStyleMstId { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int partyPower { get; set; }
}

public class ScoreAttackScoreAttackRoomData : object
{
    public long questDataId { get; set; }
    public int questStageMstId { get; set; }
    public int scoreAttackStageMstId { get; set; }
    public string endTime { get; set; }
    public string createdTime { get; set; }
}

public class ScoreAttackStageInfo : object
{
    public long questDataId { get; set; }
    public int questStageMstId { get; set; }
    public int scoreAttackStageMstId { get; set; }
    public string endTime { get; set; }
}

public class ScoreAttackScoreInfo : object
{
    public long score { get; set; }
    public long roundBonus { get; set; }
    public long difficultyBonus { get; set; }
    public long turnDamageBonus { get; set; }
    public long roundDamageBonus { get; set; }
    public long hpBonus { get; set; }
    public long aliveBonus { get; set; }
    public int roundCount { get; set; }
    public int difficulty { get; set; }
    public long maxTurnDamage { get; set; }
    public long maxRoundDamage { get; set; }
    public long battleEndHp { get; set; }
    public long maxHp { get; set; }
    public int aliveCount { get; set; }
}

public class PvpPvpTopInfo : object
{
    public int selfRanking { get; set; }
    public int selfPvpPoint { get; set; }
    public int winStreakCount { get; set; }
    public int remainTodayFreePlayCount { get; set; }
    public int remainTodayPlayCount { get; set; }
    public int seasonId { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public string nextSeasonStartTime { get; set; }
}

public class PvpRankingInfo : object
{
    public string userName { get; set; }
    public long userId { get; set; }
    public int rank { get; set; }
    public int ranking { get; set; }
    public int pvpPoint { get; set; }
    public int favoriteStyleMstId { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int partyPower { get; set; }
}

public class PvpCharacterBuildInfo : object
{
    public int styleMstId { get; set; }
    public int partyIndex { get; set; }
    public int totalPower { get; set; }
}

public class PvpPvpUserInfo : object
{
    public long userId { get; set; }
    public string userName { get; set; }
    public int rank { get; set; }
    public int ranking { get; set; }
    public int point { get; set; }
    public int partyPower { get; set; }
    public int iconStyleMstId { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int relativelyLevel { get; set; }
    public List<PvpCharacterBuildInfo> characterBuildInfoList { get; set; }
}

public class PvpPointInfo : object
{
    public int point { get; set; }
    public int basePoint { get; set; }
    public int relativelyBonus { get; set; }
    public int roundBonus { get; set; }
    public int hpBonus { get; set; }
    public int battleEndHp { get; set; }
    public int maxHp { get; set; }
    public double winStreakBonusCoefficient { get; set; }
}

public class PvpRewardInfo : object
{
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class PvpMatchHistory : object
{
    public int pvpDataId { get; set; }
    public int result { get; set; }
    public int addPoint { get; set; }
    public long offenseUserId { get; set; }
    public string offensePlayerName { get; set; }
    public int offensePlayerRank { get; set; }
    public int offensePartyPower { get; set; }
    public int offenseIconStyleMstId { get; set; }
    public string offenseSetUserTitleMstIds { get; set; }
    public int offenseBeforeRanking { get; set; }
    public long defenseUserId { get; set; }
    public string defensePlayerName { get; set; }
    public int defensePlayerRank { get; set; }
    public int defensePartyPower { get; set; }
    public int defenseIconStyleMstId { get; set; }
    public string defenseSetUserTitleMstIds { get; set; }
    public int defenseBeforeRanking { get; set; }
}

public class UserTitleUserTitleDataRecord : object
{
    public long userId { get; set; }
    public int userTitleMstId { get; set; }
    public int value1 { get; set; }
    public string createdTime { get; set; }
}

public class PartyCharacterBuildDataRecord : object
{
    public long userId { get; set; }
    public int styleMstId { get; set; }
    public int cardMstId { get; set; }
    public string subStyleMstIds { get; set; }
}

public class UserUserProfileDataRecord : object
{
    public long userId { get; set; }
    public string comment { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int favoriteCharacterMstId { get; set; }
    public int favoriteSpecialAttackMstId { get; set; }
    public int pvpHighestRank { get; set; }
    public long continueLoginDayNum { get; set; }
    public long maxContinueLoginDayNum { get; set; }
    public string recentLoginTime { get; set; }
}

public class CharacterUseCharacterRankingRecord : object
{
    public int ranking { get; set; }
    public int characterMstId { get; set; }
    public int useCount { get; set; }
}

public class GuildGuildDataRecord : object
{
    public long guildDataId { get; set; }
    public int guildInstantId { get; set; }
    public string guildName { get; set; }
    public long guildMasterUserId { get; set; }
    public int guildMasterLevel { get; set; }
    public string guildMasterRecentLoginTime { get; set; }
    public int joinMember { get; set; }
    public int guildTitleMstId { get; set; }
    public bool isAutoApproval { get; set; }
    public int guildAtmosphere { get; set; }
    public string guildDescription { get; set; }
    public int lastGvgLeagueId { get; set; }
    public int lastGvgLeagueRanking { get; set; }
    public int totalMaxPartyPower { get; set; }
}

public class GuildGuildRequestDataRecord : object
{
    public long userId { get; set; }
    public long guildDataId { get; set; }
    public int requestType { get; set; }
    public int status { get; set; }
    public string sendTime { get; set; }
}

public class CollectionCollectionParamUpAchieveDataRecord : object
{
    public long userId { get; set; }
    public int collectionParamUpMstId { get; set; }
    public int achievedLevel { get; set; }
    public int viewedLevel { get; set; }
}

public class UserUserDisplayInfo : object
{
    public long userId { get; set; }
    public string name { get; set; }
    public int level { get; set; }
    public int favoriteStyleMstId { get; set; }
    public string recentLoginTime { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int maxPartyPower { get; set; }
    public bool isDeletedAccount { get; set; }
}

public class UserUserSubscriptionDataRecord : object
{
    public long userId { get; set; }
    public string subscriptionLabel { get; set; }
    public bool isSubscription { get; set; }
    public string currentEndTime { get; set; }
    public int continueCount { get; set; }
}

public class PresentPresentDataRecord : object
{
    public long presentDataId { get; set; }
    public long userId { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
    public string comment { get; set; }
    public string receivedTime { get; set; }
    public string expireTime { get; set; }
    public string createdTime { get; set; }
}

public class MissionMissionDataRecord : object
{
    public long userId { get; set; }
    public int missionUniqueId { get; set; }
    public int missionMstId { get; set; }
    public string resetTime { get; set; }
    public int count { get; set; }
    public bool isClear { get; set; }
    public bool isClear2 { get; set; }
    public bool isDoubleBonus { get; set; }
    public bool isDoubleBonus2 { get; set; }
}

public class GuildMissionGuildMissionDataRecord : object
{
    public long guildDataId { get; set; }
    public int guildMissionUniqueId { get; set; }
    public int guildMissionMstId { get; set; }
    public string resetTime { get; set; }
    public int count { get; set; }
    public bool isClear { get; set; }
}

public class GuildGuildUserDataRecord : object
{
    public long userId { get; set; }
    public long guildDataId { get; set; }
    public int guildRoleMstId { get; set; }
    public string joinTime { get; set; }
}

public class MissionreceivedObjectData : object
{
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
    public bool isSendPresent { get; set; }
}

public class PvpPvpResultRecord : object
{
    public long userId { get; set; }
    public int lastRanking { get; set; }
    public int pvpPoint { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int seasonId { get; set; }
}

public class HomeHomeViewData : object
{
    public bool enablePresentBadge { get; set; }
    public bool enableMissionBadge { get; set; }
    public bool enableBeginnerMission { get; set; }
    public bool enableCollectionBadge { get; set; }
    public string storyEventEndTime { get; set; }
    public bool enableStoryEventBadge { get; set; }
    public int towerFloorNum { get; set; }
    public bool enableTowerBadge { get; set; }
    public bool enableMainQuestBadge { get; set; }
    public bool enableNewGachaBadge { get; set; }
    public bool enableGachaBadge { get; set; }
    public bool enableUnionBadge { get; set; }
    public bool enablePvpBadge { get; set; }
    public bool enableGvgBadge { get; set; }
    public int characterHeartQuestPlayCount { get; set; }
    public PvpPvpResultRecord pvpResultInfo { get; set; }
}

public class HomeLoginBonusRecord : object
{
    public long userId { get; set; }
    public int loginBonusMstId { get; set; }
    public int loginBonusRewardMstId { get; set; }
    public int dayCount { get; set; }
    public int dayTotalCount { get; set; }
    public string lastRewardDate { get; set; }
}

public class UserComebackUserDataRecord : object
{
    public long userId { get; set; }
    public int comebackCount { get; set; }
    public string comebackTime { get; set; }
    public string endTime { get; set; }
}

public class UserUserLevelUpInfo : object
{
    public int beforeLevel { get; set; }
    public int beforeExp { get; set; }
    public int beforeStamina { get; set; }
    public UserUserParamDataRecord userParamData { get; set; }
}

public class GatheringUserGatheringDataRecord : object
{
    public long userId { get; set; }
    public int gatheringLevel { get; set; }
    public string gatheringTime { get; set; }
    public int shortcutCount { get; set; }
    public string shortcutCountResetTime { get; set; }
}

public class GvgGvgGuildInfo : object
{
    public int ranking { get; set; }
    public int leagueId { get; set; }
    public int winNum { get; set; }
    public int dailyGuildPoint { get; set; }
    public int totalGuildPoint { get; set; }
    public int selfPoint { get; set; }
    public bool isAggregation { get; set; }
}

public class GvgGvgEnemyGuildInfo : object
{
    public int ranking { get; set; }
    public string guildName { get; set; }
    public long guildDataId { get; set; }
    public int guildTitleMstId { get; set; }
    public int dailyGuildPoint { get; set; }
}

public class GvgMatchTopInfo : object
{
    public int result { get; set; }
    public int addPoint { get; set; }
    public long userId { get; set; }
    public string playerName { get; set; }
}

public class GvgMatchHistory : object
{
    public string matchDateTime { get; set; }
    public int day { get; set; }
    public int result { get; set; }
    public int addPoint { get; set; }
    public long offenseUserId { get; set; }
    public string offensePlayerName { get; set; }
    public int offensePlayerRank { get; set; }
    public int offensePartyPower { get; set; }
    public int offenseIconStyleMstId { get; set; }
    public string offenseSetUserTitleMstIds { get; set; }
    public long defenseUserId { get; set; }
    public string defensePlayerName { get; set; }
    public int defensePlayerRank { get; set; }
    public int defensePartyPower { get; set; }
    public int defenseIconStyleMstId { get; set; }
    public string defenseSetUserTitleMstIds { get; set; }
    public long allyUserId { get; set; }
    public string allyPlayerName { get; set; }
    public int allyPlayerRank { get; set; }
    public int allyIconStyleMstId { get; set; }
    public long enemyUserId { get; set; }
    public string enemyPlayerName { get; set; }
    public int enemyPlayerRank { get; set; }
    public int enemyIconStyleMstId { get; set; }
}

public class GvgMatchInfo : object
{
    public long userId { get; set; }
    public string playerName { get; set; }
    public int playerRank { get; set; }
    public int iconStyleMstId { get; set; }
    public string setUserTitleMstIds { get; set; }
    public int partyPower { get; set; }
    public int relativelyLevel { get; set; }
    public int result { get; set; }
    public List<PvpCharacterBuildInfo> characterBuildInfoList { get; set; }
}

public class GvgRankingInfo : object
{
    public long guildDataId { get; set; }
    public string guildName { get; set; }
    public int ranking { get; set; }
    public int guildTitleMstId { get; set; }
    public int iconStyleMstId { get; set; }
    public int guildPoint { get; set; }
}

public class GvgLeagueMatchResultInfo : object
{
    public long guildDataId { get; set; }
    public int guild1Result { get; set; }
    public int guild2Result { get; set; }
    public int guild3Result { get; set; }
    public int guild4Result { get; set; }
}

public class GvgLeagueMatchGuildInfo : object
{
    public string guildName { get; set; }
    public long guildDataId { get; set; }
    public int guildTitleMstId { get; set; }
}

public class GvgStageInfo : object
{
    public string stagePrefabName { get; set; }
    public string bgmCueName { get; set; }
    public string bgmCueSheetName { get; set; }
}

public class GveGveGuildDataRecord : object
{
    public long guildDataId { get; set; }
    public int gveStageMstId { get; set; }
    public int chainId { get; set; }
    public int chainLevel { get; set; }
}

public class GveGveUserDataRecord : object
{
    public long userId { get; set; }
    public int todayPlayCount { get; set; }
    public string todayPlayCountResetTime { get; set; }
}

public class GveGveStageDataRecord : object
{
    public long guildDataId { get; set; }
    public int gveStageMstId { get; set; }
    public int hp { get; set; }
    public int breakCount { get; set; }
    public bool isBreakBonus { get; set; }
    public bool isStrategyBuff { get; set; }
    public int bossDebuffMag { get; set; }
}

public class GveGveUserStageDataRecord : object
{
    public long userId { get; set; }
    public int gveStageMstId { get; set; }
    public bool useFirstBattleBreakBonus { get; set; }
}

public class GveGveGuildChainDataRecord : object
{
    public int chainId { get; set; }
    public int chainLevel { get; set; }
    public string lastAttackTime { get; set; }
}

public class GveRankingInfo : object
{
    public long userId { get; set; }
    public int ranking { get; set; }
    public int damage { get; set; }
}

public class GveGveHistoryInfo : object
{
    public long userId { get; set; }
    public string attackTime { get; set; }
    public int damage { get; set; }
}

public class GveGuildMemberCharacter : object
{
    public long userId { get; set; }
    public int styleMstId { get; set; }
}

public class QuestBattleStageInfo : object
{
    public long questDataId { get; set; }
    public int questStageMstId { get; set; }
    public string endTime { get; set; }
}

public class GveGveUserChainDataRecord : object
{
    public long userId { get; set; }
    public int chainId { get; set; }
    public int chainLevel { get; set; }
}

public class GuildGuildTitleDataRecord : object
{
    public long guildDataId { get; set; }
    public int guildTitleMstId { get; set; }
}

public class GuildGuildActivityDataRecord : object
{
    public string actionTime { get; set; }
    public string viewText { get; set; }
    public long userId { get; set; }
}

public class GachaGachaRecord : object
{
    public int gachaMstId { get; set; }
    public int gachaSeriesMstId { get; set; }
    public string gachaName { get; set; }
    public int payType { get; set; }
    public int payItemId { get; set; }
    public int price { get; set; }
    public int repeatCount { get; set; }
    public int countLimit { get; set; }
    public int dailyCountLimit { get; set; }
    public int minRarity { get; set; }
    public int minRarityCount { get; set; }
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int sortNum { get; set; }
}

public class GachaGachaStepUpRecord : object
{
    public int gachaSeriesMstId { get; set; }
    public int step { get; set; }
    public int gachaPickUpId { get; set; }
    public int payType { get; set; }
    public int price { get; set; }
    public int repeatCount { get; set; }
    public int minRarity { get; set; }
    public int minRarityCount { get; set; }
    public int sortNum { get; set; }
}

public class GachaGachaSeriesRecord : object
{
    public int gachaSeriesMstId { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string headLine { get; set; }
    public int badgeType { get; set; }
    public GachaGachaType gachaType { get; set; }
    public GachaGachaDrawType gachaDrawType { get; set; }
    public int gachaRateId { get; set; }
    public int gachaPickUpId { get; set; }
    public int seriesCountLimit { get; set; }
    public int seriesDailyCountLimit { get; set; }
    public int lapLimit { get; set; }
    public int priority { get; set; }
    public int shopSeriesMstId { get; set; }
    public int bannerMstId { get; set; }
    public string resourceName { get; set; }
}

public class GachaGachaAppealRecord : object
{
    public int gachaSeriesMstId { get; set; }
    public string movieResourceName1 { get; set; }
    public string movieResourceName2 { get; set; }
    public string movieResourceName3 { get; set; }
    public string imageResourceName1 { get; set; }
    public string imageResourceName2 { get; set; }
    public string imageResourceName3 { get; set; }
    public string imageResourceName4 { get; set; }
    public string imageResourceName { get; set; }
    public int styleMstId1 { get; set; }
    public int styleMstId2 { get; set; }
    public int styleMstId3 { get; set; }
}

public class GachaGachaBonusRecord : object
{
    public int gachaBonusMstId { get; set; }
    public int gachaMstId { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class GachaGachaSeriesBonusRecord : object
{
    public int gachaSeriesBonusMstId { get; set; }
    public int gachaSeriesMstId { get; set; }
    public int gachaCount { get; set; }
    public int lap { get; set; }
    public int step { get; set; }
    public int objectReceiveType { get; set; }
    public int objectId { get; set; }
    public int num { get; set; }
}

public class GachaGachaCountDataRecord : object
{
    public long userId { get; set; }
    public int gachaMstId { get; set; }
    public int dailyCount { get; set; }
    public int totalCount { get; set; }
    public string resetTime { get; set; }
}

public class ItemConversionItemViewByBeforeItem : object
{
    public int bannerMstId { get; set; }
    public int beforeItemMstId { get; set; }
    public int beforeNum { get; set; }
    public int conversionNum { get; set; }
}

public class ItemConversionItemViewByAfterItem : object
{
    public int conversionItemMstId { get; set; }
}

public class GachaGachaTopViewData : object
{
    public List<GachaGachaRecord> gachaList { get; set; }
    public List<GachaGachaStepUpRecord> gachaStepUpList { get; set; }
    public List<GachaGachaSeriesRecord> gachaSeriesList { get; set; }
    public List<GachaGachaAppealRecord> gachaAppealList { get; set; }
    public List<GachaGachaBonusRecord> gachaBonusList { get; set; }
    public List<GachaGachaSeriesBonusRecord> gachaSeriesBonusList { get; set; }
    public List<GachaGachaCountDataRecord> gachaCountDataList { get; set; }
    public List<int> newBadgeGachaSeriesMstIdList { get; set; }
    public List<ItemConversionItemViewByBeforeItem> conversionItemViewByBeforeItemList { get; set; }
    public ItemConversionItemViewByAfterItem conversionItemViewByAfterItem { get; set; }
    public List<ItemItemDataRecord> itemDataList { get; set; }
}

public class GachaPickUpInfo : object
{
    public int objectReceiveType { get; set; }
    public int objectType { get; set; }
    public int objectId { get; set; }
}

public class QuestOutGameUserQuestTrainingDataRecord : object
{
    public long userId { get; set; }
    public int questGroupMstId { get; set; }
    public int clearedQuestStageMstId { get; set; }
    public int rankUpEffectedQuestStageMstId { get; set; }
}

public class QuestOutGameUserQuestCharacterHeartDataRecord : object
{
    public long userId { get; set; }
    public int dailyClearCount { get; set; }
    public string dailyClearCountUpdatedTime { get; set; }
}

public class QuestOutGameUserQuestCharacterHeartPartySaveDataRecord : object
{
    public long userId { get; set; }
    public int questStageMstId { get; set; }
    public int member1 { get; set; }
    public int cardMstId1 { get; set; }
    public string subStyleMstIds1 { get; set; }
    public int member2 { get; set; }
    public int cardMstId2 { get; set; }
    public string subStyleMstIds2 { get; set; }
    public int member3 { get; set; }
    public int cardMstId3 { get; set; }
    public string subStyleMstIds3 { get; set; }
    public int member4 { get; set; }
    public int cardMstId4 { get; set; }
    public string subStyleMstIds4 { get; set; }
    public int member5 { get; set; }
    public int cardMstId5 { get; set; }
    public string subStyleMstIds5 { get; set; }
}

public class CollectionCollectionIllustAchieveDataRecord : object
{
    public long userId { get; set; }
    public int collectionIllustMstId { get; set; }
    public string achievedConditionGroupIdCsv1 { get; set; }
    public string achievedConditionGroupIdCsv2 { get; set; }
    public string completeProgressConditionGroupIdCsv { get; set; }
}

public class CollectionMagiaRecordCharacterMstRecord : object
{
    public int magiaRecordCharacterMstId { get; set; }
    public string name { get; set; }
    public string resourceName { get; set; }
}

public class CollectionMagiaRecordMemoriaMstRecord : object
{
    public int magiaRecordMemoriaMstId { get; set; }
    public string name { get; set; }
    public string resourceName { get; set; }
}

public class ChatChatRoomInfo : object
{
    public int roomType { get; set; }
    public string roomDocumentId { get; set; }
    public string roomName { get; set; }
}

public class CharacterCharacterHeartLevelUpInfo : object
{
    public int characterMstId { get; set; }
    public int beforeHeartLevel { get; set; }
    public int beforeHeartExp { get; set; }
    public int afterHeartLevel { get; set; }
    public int afterHeartExp { get; set; }
}

public class ExplorationQuestMapEffectedInfo : object
{
    public int questMapMstId { get; set; }
    public int difficulty { get; set; }
}

