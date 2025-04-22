namespace MagiaClient.Models;

using System;
using System.Collections.Generic;


public class WebPlayApiLoginLogRequest : RequestBase<WebPlayApiLoginLogResponse>
{
    public sealed override string Url => "/api/web_play/login_log";
    public string sessionToken { get; set; }
}

public class WebPlayApiGetUserMigrationInfoRequest : RequestBase<WebPlayApiGetUserMigrationInfoResponse>
{
    public sealed override string Url => "/api/web_play/get_user_migration_info";
    public string sessionToken { get; set; }
}

public class WebPayApiPurchaseRequest : RequestBase<WebPayApiPurchaseResponse>
{
    public sealed override string Url => "/api/web_pay/purchase";
    public string productId { get; set; }
}

public class WebPayApiGetPurchaseResultRequest : RequestBase<WebPayApiGetPurchaseResultResponse>
{
    public sealed override string Url => "/api/web_pay/get_purchase_result";
    public string purchaseId { get; set; }
}

public class WebPayApiRestoreRequest : RequestBase<WebPayApiRestoreResponse>
{
    public sealed override string Url => "/api/web_pay/restore";
    // No fields
}

public class WebPayApiCancelLatestRequest : RequestBase<WebPayApiCancelLatestResponse>
{
    public sealed override string Url => "/api/web_pay/cancel_latest";
    // No fields
}

public class TitleApiGetTitleTopDataRequest : RequestBase<TitleApiGetTitleTopDataResponse>
{
    public sealed override string Url => "/api/title/get_title_top_data";
    public int osType { get; set; }
    public int storeType { get; set; }
    public string appVersion { get; set; }
}

public class TermsApiGetUpdatedTermsRequest : RequestBase<TermsApiGetUpdatedTermsResponse>
{
    public sealed override string Url => "/api/terms/get_updated_terms";
    public int storeType { get; set; }
}

public class TermsApiAgreeLatestTermsRequest : RequestBase<TermsApiAgreeLatestTermsResponse>
{
    public sealed override string Url => "/api/terms/agree_latest_terms";
    public int storeType { get; set; }
    public int agreeTermId { get; set; }
}

public class TermsApiAgreeChatTermsRequest : RequestBase<TermsApiAgreeChatTermsResponse>
{
    public sealed override string Url => "/api/terms/agree_chat_terms";
    // No fields
}

public class TalismanApiGetTalismanListRequest : RequestBase<TalismanApiGetTalismanListResponse>
{
    public sealed override string Url => "/api/talisman/get_talisman_list";
    // No fields
}

public class TalismanApiTalismanLevelUpRequest : RequestBase<TalismanApiTalismanLevelUpResponse>
{
    public sealed override string Url => "/api/talisman/talisman_level_up";
    public long talismanDataId { get; set; }
    public List<long> consumeTalismanDataIds { get; set; }
}

public class TalismanApiTalismanSellRequest : RequestBase<TalismanApiTalismanSellResponse>
{
    public sealed override string Url => "/api/talisman/talisman_sell";
    public List<long> talismanDataIds { get; set; }
}

public class TalismanApiSetTalismanProtectRequest : RequestBase<TalismanApiSetTalismanProtectResponse>
{
    public sealed override string Url => "/api/talisman/set_talisman_protect";
    public long talismanDataId { get; set; }
    public bool isProtect { get; set; }
}

public class ServerApiGetTimeZoneInfoRequest : RequestBase<ServerApiGetTimeZoneInfoResponse>
{
    public sealed override string Url => "/api/server/get_time_zone_info";
    // No fields
}

public class ServerApiCertHashListRequest : RequestBase<ServerApiCertHashListResponse>
{
    public sealed override string Url => "/api/server/cert_hash_list";
    // No fields
}

public class SerialCampaignApiInputSerialCodeRequest : RequestBase<SerialCampaignApiInputSerialCodeResponse>
{
    public sealed override string Url => "/api/serial_campaign/input_serial_code";
    public string serialCode { get; set; }
}

public class SerialCampaignApiPreAppLinkRequest : RequestBase<SerialCampaignApiPreAppLinkResponse>
{
    public sealed override string Url => "/api/serial_campaign/pre_app_link";
    public string serialCode { get; set; }
}

public class SampleApiHttpConnectRequest : RequestBase<SampleApiHttpConnectResponse>
{
    public sealed override string Url => "/api/sample/http_connect";
    // No fields
}

public class NotificationApiRegisterRequest : RequestBase<NotificationApiRegisterResponse>
{
    public sealed override string Url => "/api/notification/register";
    public string deviceToken { get; set; }
}

public class NotificationApiSetOsRequest : RequestBase<NotificationApiSetOsResponse>
{
    public sealed override string Url => "/api/notification/set_os";
    public string os { get; set; }
}

public class NotificationApiSetLanguageRequest : RequestBase<NotificationApiSetLanguageResponse>
{
    public sealed override string Url => "/api/notification/set_language";
    public string language { get; set; }
}

public class NotificationApiSetRegionRequest : RequestBase<NotificationApiSetRegionResponse>
{
    public sealed override string Url => "/api/notification/set_region";
    public string region { get; set; }
}

public class NotificationApiSetTimezoneRequest : RequestBase<NotificationApiSetTimezoneResponse>
{
    public sealed override string Url => "/api/notification/set_timezone";
    public string timezone { get; set; }
}

public class NotificationApiUnsetOsRequest : RequestBase<NotificationApiUnsetOsResponse>
{
    public sealed override string Url => "/api/notification/unset_os";
    // No fields
}

public class NotificationApiUnsetRegionRequest : RequestBase<NotificationApiUnsetRegionResponse>
{
    public sealed override string Url => "/api/notification/unset_region";
    // No fields
}

public class NotificationApiUnsetLanguageRequest : RequestBase<NotificationApiUnsetLanguageResponse>
{
    public sealed override string Url => "/api/notification/unset_language";
    // No fields
}

public class NotificationApiUnsetTimezoneRequest : RequestBase<NotificationApiUnsetTimezoneResponse>
{
    public sealed override string Url => "/api/notification/unset_timezone";
    // No fields
}

public class NotificationApiSetTagRequest : RequestBase<NotificationApiSetTagResponse>
{
    public sealed override string Url => "/api/notification/set_tag";
    public string tag { get; set; }
}

public class NotificationApiUnsetTagRequest : RequestBase<NotificationApiUnsetTagResponse>
{
    public sealed override string Url => "/api/notification/unset_tag";
    public string tag { get; set; }
}

public class MstApiGetItemMstListRequest : RequestBase<MstApiGetItemMstListResponse>
{
    public sealed override string Url => "/api/mst/get_item_mst_list";
    // No fields
}

public class MstApiGetCardMstListRequest : RequestBase<MstApiGetCardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_card_mst_list";
    // No fields
}

public class MstApiGetCardLimitBreakMstListRequest : RequestBase<MstApiGetCardLimitBreakMstListResponse>
{
    public sealed override string Url => "/api/mst/get_card_limit_break_mst_list";
    // No fields
}

public class MstApiGetSkillMstListRequest : RequestBase<MstApiGetSkillMstListResponse>
{
    public sealed override string Url => "/api/mst/get_skill_mst_list";
    // No fields
}

public class MstApiGetSkillLevelUpConditionMstListRequest : RequestBase<MstApiGetSkillLevelUpConditionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_skill_level_up_condition_mst_list";
    // No fields
}

public class MstApiGetCharacterAwakeMstListRequest : RequestBase<MstApiGetCharacterAwakeMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_awake_mst_list";
    // No fields
}

public class MstApiGetCharacterMstListRequest : RequestBase<MstApiGetCharacterMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_mst_list";
    // No fields
}

public class MstApiGetCharacterProfileMstListRequest : RequestBase<MstApiGetCharacterProfileMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_profile_mst_list";
    // No fields
}

public class MstApiGetCharacterHeartMstListRequest : RequestBase<MstApiGetCharacterHeartMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_heart_mst_list";
    // No fields
}

public class MstApiGetCharacterHeartParamUpGroupMstListRequest : RequestBase<MstApiGetCharacterHeartParamUpGroupMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_heart_param_up_group_mst_list";
    // No fields
}

public class MstApiGetCharacterHeartObjectRewardMstListRequest : RequestBase<MstApiGetCharacterHeartObjectRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_heart_object_reward_mst_list";
    // No fields
}

public class MstApiGetCharacterHeartLevelUpMstListRequest : RequestBase<MstApiGetCharacterHeartLevelUpMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_heart_level_up_mst_list";
    // No fields
}

public class MstApiGetCharacterTeamMstListRequest : RequestBase<MstApiGetCharacterTeamMstListResponse>
{
    public sealed override string Url => "/api/mst/get_character_team_mst_list";
    // No fields
}

public class MstApiGetStyleMstListRequest : RequestBase<MstApiGetStyleMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_mst_list";
    // No fields
}

public class MstApiGetTowerMstListRequest : RequestBase<MstApiGetTowerMstListResponse>
{
    public sealed override string Url => "/api/mst/get_tower_mst_list";
    // No fields
}

public class MstApiGetQuestCategoryMstListRequest : RequestBase<MstApiGetQuestCategoryMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_category_mst_list";
    // No fields
}

public class MstApiGetQuestMapMstListRequest : RequestBase<MstApiGetQuestMapMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_map_mst_list";
    // No fields
}

public class MstApiGetQuestGroupMstListRequest : RequestBase<MstApiGetQuestGroupMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_group_mst_list";
    // No fields
}

public class MstApiGetQuestStageMstListRequest : RequestBase<MstApiGetQuestStageMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_stage_mst_list";
    // No fields
}

public class MstApiGetQuestConditionMstListRequest : RequestBase<MstApiGetQuestConditionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_condition_mst_list";
    // No fields
}

public class MstApiGetMissionTitleMstListRequest : RequestBase<MstApiGetMissionTitleMstListResponse>
{
    public sealed override string Url => "/api/mst/get_mission_title_mst_list";
    // No fields
}

public class MstApiGetMissionTransitionMstListRequest : RequestBase<MstApiGetMissionTransitionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_mission_transition_mst_list";
    // No fields
}

public class MstApiGetSubscriptionMissionRewardMstListRequest : RequestBase<MstApiGetSubscriptionMissionRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_subscription_mission_reward_mst_list";
    // No fields
}

public class MstApiGetMissionMstListRequest : RequestBase<MstApiGetMissionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_mission_mst_list";
    // No fields
}

public class MstApiGetEnemyMstListRequest : RequestBase<MstApiGetEnemyMstListResponse>
{
    public sealed override string Url => "/api/mst/get_enemy_mst_list";
    // No fields
}

public class MstApiGetEnemyProfileMstListRequest : RequestBase<MstApiGetEnemyProfileMstListResponse>
{
    public sealed override string Url => "/api/mst/get_enemy_profile_mst_list";
    // No fields
}

public class MstApiGetQuestEnemyAppearanceMstListRequest : RequestBase<MstApiGetQuestEnemyAppearanceMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_enemy_appearance_mst_list";
    // No fields
}

public class MstApiGetQuestEnemySkillSetMstListRequest : RequestBase<MstApiGetQuestEnemySkillSetMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_enemy_skill_set_mst_list";
    // No fields
}

public class MstApiGetBreakMstListRequest : RequestBase<MstApiGetBreakMstListResponse>
{
    public sealed override string Url => "/api/mst/get_break_mst_list";
    // No fields
}

public class MstApiGetAbilityEffectTypeMstListRequest : RequestBase<MstApiGetAbilityEffectTypeMstListResponse>
{
    public sealed override string Url => "/api/mst/get_ability_effect_type_mst_list";
    // No fields
}

public class MstApiGetSkillDetailMstListRequest : RequestBase<MstApiGetSkillDetailMstListResponse>
{
    public sealed override string Url => "/api/mst/get_skill_detail_mst_list";
    // No fields
}

public class MstApiGetQuestRewardMstListRequest : RequestBase<MstApiGetQuestRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_quest_reward_mst_list";
    // No fields
}

public class MstApiGetFieldSeriesMstListRequest : RequestBase<MstApiGetFieldSeriesMstListResponse>
{
    public sealed override string Url => "/api/mst/get_field_series_mst_list";
    // No fields
}

public class MstApiGetFieldStageMstListRequest : RequestBase<MstApiGetFieldStageMstListResponse>
{
    public sealed override string Url => "/api/mst/get_field_stage_mst_list";
    // No fields
}

public class MstApiGetAdvMstListRequest : RequestBase<MstApiGetAdvMstListResponse>
{
    public sealed override string Url => "/api/mst/get_adv_mst_list";
    // No fields
}

public class MstApiGetAdvTitleMstListRequest : RequestBase<MstApiGetAdvTitleMstListResponse>
{
    public sealed override string Url => "/api/mst/get_adv_title_mst_list";
    // No fields
}

public class MstApiGetObjectReceiveTypeMstListRequest : RequestBase<MstApiGetObjectReceiveTypeMstListResponse>
{
    public sealed override string Url => "/api/mst/get_object_receive_type_mst_list";
    // No fields
}

public class MstApiGetPayTypeMstListRequest : RequestBase<MstApiGetPayTypeMstListResponse>
{
    public sealed override string Url => "/api/mst/get_pay_type_mst_list";
    // No fields
}

public class MstApiGetTalismanMstListRequest : RequestBase<MstApiGetTalismanMstListResponse>
{
    public sealed override string Url => "/api/mst/get_talisman_mst_list";
    // No fields
}

public class MstApiGetTalismanParamMstListRequest : RequestBase<MstApiGetTalismanParamMstListResponse>
{
    public sealed override string Url => "/api/mst/get_talisman_param_mst_list";
    // No fields
}

public class MstApiGetTalismanParamEffectMstListRequest : RequestBase<MstApiGetTalismanParamEffectMstListResponse>
{
    public sealed override string Url => "/api/mst/get_talisman_param_effect_mst_list";
    // No fields
}

public class MstApiGetTalismanSeriesMstListRequest : RequestBase<MstApiGetTalismanSeriesMstListResponse>
{
    public sealed override string Url => "/api/mst/get_talisman_series_mst_list";
    // No fields
}

public class MstApiGetPassiveSkillMstListRequest : RequestBase<MstApiGetPassiveSkillMstListResponse>
{
    public sealed override string Url => "/api/mst/get_passive_skill_mst_list";
    // No fields
}

public class MstApiGetPassiveSkillDetailMstListRequest : RequestBase<MstApiGetPassiveSkillDetailMstListResponse>
{
    public sealed override string Url => "/api/mst/get_passive_skill_detail_mst_list";
    // No fields
}

public class MstApiGetLeaderSkillMstListRequest : RequestBase<MstApiGetLeaderSkillMstListResponse>
{
    public sealed override string Url => "/api/mst/get_leader_skill_mst_list";
    // No fields
}

public class MstApiGetLeaderSkillDetailMstListRequest : RequestBase<MstApiGetLeaderSkillDetailMstListResponse>
{
    public sealed override string Url => "/api/mst/get_leader_skill_detail_mst_list";
    // No fields
}

public class MstApiGetPvpRankingRewardMstListRequest : RequestBase<MstApiGetPvpRankingRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_pvp_ranking_reward_mst_list";
    // No fields
}

public class MstApiGetPvpPointRewardMstListRequest : RequestBase<MstApiGetPvpPointRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_pvp_point_reward_mst_list";
    // No fields
}

public class MstApiGetUserTitleMstListRequest : RequestBase<MstApiGetUserTitleMstListResponse>
{
    public sealed override string Url => "/api/mst/get_user_title_mst_list";
    // No fields
}

public class MstApiGetGuildTitleMstListRequest : RequestBase<MstApiGetGuildTitleMstListResponse>
{
    public sealed override string Url => "/api/mst/get_guild_title_mst_list";
    // No fields
}

public class MstApiGetUserLevelUpMstListRequest : RequestBase<MstApiGetUserLevelUpMstListResponse>
{
    public sealed override string Url => "/api/mst/get_user_level_up_mst_list";
    // No fields
}

public class MstApiGetShopSeriesMstListRequest : RequestBase<MstApiGetShopSeriesMstListResponse>
{
    public sealed override string Url => "/api/mst/get_shop_series_mst_list";
    // No fields
}

public class MstApiGetShopMstListRequest : RequestBase<MstApiGetShopMstListResponse>
{
    public sealed override string Url => "/api/mst/get_shop_mst_list";
    // No fields
}

public class MstApiGetShopDetailMstListRequest : RequestBase<MstApiGetShopDetailMstListResponse>
{
    public sealed override string Url => "/api/mst/get_shop_detail_mst_list";
    // No fields
}

public class MstApiGetBannerMstListRequest : RequestBase<MstApiGetBannerMstListResponse>
{
    public sealed override string Url => "/api/mst/get_banner_mst_list";
    // No fields
}

public class MstApiGetBannerLabelMstListRequest : RequestBase<MstApiGetBannerLabelMstListResponse>
{
    public sealed override string Url => "/api/mst/get_banner_label_mst_list";
    // No fields
}

public class MstApiGetHomeBannerMstListRequest : RequestBase<MstApiGetHomeBannerMstListResponse>
{
    public sealed override string Url => "/api/mst/get_home_banner_mst_list";
    // No fields
}

public class MstApiGetHomeAppealMstListRequest : RequestBase<MstApiGetHomeAppealMstListResponse>
{
    public sealed override string Url => "/api/mst/get_home_appeal_mst_list";
    // No fields
}

public class MstApiGetTipsMstListRequest : RequestBase<MstApiGetTipsMstListResponse>
{
    public sealed override string Url => "/api/mst/get_tips_mst_list";
    // No fields
}

public class MstApiGetGveMstListRequest : RequestBase<MstApiGetGveMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gve_mst_list";
    // No fields
}

public class MstApiGetGveStageMstListRequest : RequestBase<MstApiGetGveStageMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gve_stage_mst_list";
    // No fields
}

public class MstApiGetGveStageRewardMstListRequest : RequestBase<MstApiGetGveStageRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gve_stage_reward_mst_list";
    // No fields
}

public class MstApiGetMapGveMstListRequest : RequestBase<MstApiGetMapGveMstListResponse>
{
    public sealed override string Url => "/api/mst/get_map_gve_mst_list";
    // No fields
}

public class MstApiGetMapGveAreaMstListRequest : RequestBase<MstApiGetMapGveAreaMstListResponse>
{
    public sealed override string Url => "/api/mst/get_map_gve_area_mst_list";
    // No fields
}

public class MstApiGetMapGvePointMstListRequest : RequestBase<MstApiGetMapGvePointMstListResponse>
{
    public sealed override string Url => "/api/mst/get_map_gve_point_mst_list";
    // No fields
}

public class MstApiGetLoginBonusMstListRequest : RequestBase<MstApiGetLoginBonusMstListResponse>
{
    public sealed override string Url => "/api/mst/get_login_bonus_mst_list";
    // No fields
}

public class MstApiGetLoginBonusRewardMstListRequest : RequestBase<MstApiGetLoginBonusRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_login_bonus_reward_mst_list";
    // No fields
}

public class MstApiGetStyleFigureMstListRequest : RequestBase<MstApiGetStyleFigureMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_figure_mst_list";
    // No fields
}

public class MstApiGetStyleFigureStoryMstListRequest : RequestBase<MstApiGetStyleFigureStoryMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_figure_story_mst_list";
    // No fields
}

public class MstApiGetStyleParamUpTreeMstListRequest : RequestBase<MstApiGetStyleParamUpTreeMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_param_up_tree_mst_list";
    // No fields
}

public class MstApiGetStyleParamUpMstListRequest : RequestBase<MstApiGetStyleParamUpMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_param_up_mst_list";
    // No fields
}

public class MstApiGetStyleParamUpCostMstListRequest : RequestBase<MstApiGetStyleParamUpCostMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_param_up_cost_mst_list";
    // No fields
}

public class MstApiGetStyleParamUpEffectMstListRequest : RequestBase<MstApiGetStyleParamUpEffectMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_param_up_effect_mst_list";
    // No fields
}

public class MstApiGetStyleLimitBreakMstListRequest : RequestBase<MstApiGetStyleLimitBreakMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_limit_break_mst_list";
    // No fields
}

public class MstApiGetStyleLimitBreakEffectMstListRequest : RequestBase<MstApiGetStyleLimitBreakEffectMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_limit_break_effect_mst_list";
    // No fields
}

public class MstApiGetStyleLevelUpMstListRequest : RequestBase<MstApiGetStyleLevelUpMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_level_up_mst_list";
    // No fields
}

public class MstApiGetStyleVoiceMstListRequest : RequestBase<MstApiGetStyleVoiceMstListResponse>
{
    public sealed override string Url => "/api/mst/get_style_voice_mst_list";
    // No fields
}

public class MstApiGetGvgPointRewardMstListRequest : RequestBase<MstApiGetGvgPointRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gvg_point_reward_mst_list";
    // No fields
}

public class MstApiGetGvgRankingRewardMstListRequest : RequestBase<MstApiGetGvgRankingRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gvg_ranking_reward_mst_list";
    // No fields
}

public class MstApiGetChatStampMstListRequest : RequestBase<MstApiGetChatStampMstListResponse>
{
    public sealed override string Url => "/api/mst/get_chat_stamp_mst_list";
    // No fields
}

public class MstApiGetBattleConditionMstListRequest : RequestBase<MstApiGetBattleConditionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_battle_condition_mst_list";
    // No fields
}

public class MstApiGetBattleConditionSetMstListRequest : RequestBase<MstApiGetBattleConditionSetMstListResponse>
{
    public sealed override string Url => "/api/mst/get_battle_condition_set_mst_list";
    // No fields
}

public class MstApiGetEnemyConditionSetsAndActionMstListRequest : RequestBase<MstApiGetEnemyConditionSetsAndActionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_enemy_condition_sets_and_action_mst_list";
    // No fields
}

public class MstApiGetDioramaBackgroundMstListRequest : RequestBase<MstApiGetDioramaBackgroundMstListResponse>
{
    public sealed override string Url => "/api/mst/get_diorama_background_mst_list";
    // No fields
}

public class MstApiGetLive2DParamMstListRequest : RequestBase<MstApiGetLive2DParamMstListResponse>
{
    public sealed override string Url => "/api/mst/get_live2_d_param_mst_list";
    // No fields
}

public class MstApiGetGvgMstListRequest : RequestBase<MstApiGetGvgMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gvg_mst_list";
    // No fields
}

public class MstApiGetSoundMstListRequest : RequestBase<MstApiGetSoundMstListResponse>
{
    public sealed override string Url => "/api/mst/get_sound_mst_list";
    // No fields
}

public class MstApiGetCollectionIllustMstListRequest : RequestBase<MstApiGetCollectionIllustMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_illust_mst_list";
    // No fields
}

public class MstApiGetCollectionIllustPieceMstListRequest : RequestBase<MstApiGetCollectionIllustPieceMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_illust_piece_mst_list";
    // No fields
}

public class MstApiGetCollectionParamUpMstListRequest : RequestBase<MstApiGetCollectionParamUpMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_param_up_mst_list";
    // No fields
}

public class MstApiGetCollectionParamUpLevelMstListRequest : RequestBase<MstApiGetCollectionParamUpLevelMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_param_up_level_mst_list";
    // No fields
}

public class MstApiGetCollectionParamUpEffectMstListRequest : RequestBase<MstApiGetCollectionParamUpEffectMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_param_up_effect_mst_list";
    // No fields
}

public class MstApiGetCollectionConditionGroupMstListRequest : RequestBase<MstApiGetCollectionConditionGroupMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_condition_group_mst_list";
    // No fields
}

public class MstApiGetCollectionConditionMstListRequest : RequestBase<MstApiGetCollectionConditionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_condition_mst_list";
    // No fields
}

public class MstApiGetCollectionRewardMstListRequest : RequestBase<MstApiGetCollectionRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_collection_reward_mst_list";
    // No fields
}

public class MstApiGetStoryEventMstListRequest : RequestBase<MstApiGetStoryEventMstListResponse>
{
    public sealed override string Url => "/api/mst/get_story_event_mst_list";
    // No fields
}

public class MstApiGetStoryEventQuestStageMstListRequest : RequestBase<MstApiGetStoryEventQuestStageMstListResponse>
{
    public sealed override string Url => "/api/mst/get_story_event_quest_stage_mst_list";
    // No fields
}

public class MstApiGetMiniTutorialMstListRequest : RequestBase<MstApiGetMiniTutorialMstListResponse>
{
    public sealed override string Url => "/api/mst/get_mini_tutorial_mst_list";
    // No fields
}

public class MstApiGetStoryEventScenarioMstListRequest : RequestBase<MstApiGetStoryEventScenarioMstListResponse>
{
    public sealed override string Url => "/api/mst/get_story_event_scenario_mst_list";
    // No fields
}

public class MstApiGetStoryEventScenarioRewardMstListRequest : RequestBase<MstApiGetStoryEventScenarioRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_story_event_scenario_reward_mst_list";
    // No fields
}

public class MstApiGetStoryEventBonusRateMstListRequest : RequestBase<MstApiGetStoryEventBonusRateMstListResponse>
{
    public sealed override string Url => "/api/mst/get_story_event_bonus_rate_mst_list";
    // No fields
}

public class MstApiGetDungeonMstListRequest : RequestBase<MstApiGetDungeonMstListResponse>
{
    public sealed override string Url => "/api/mst/get_dungeon_mst_list";
    // No fields
}

public class MstApiGetDungeonTypeMstListRequest : RequestBase<MstApiGetDungeonTypeMstListResponse>
{
    public sealed override string Url => "/api/mst/get_dungeon_type_mst_list";
    // No fields
}

public class MstApiGetDungeonRoomMstListRequest : RequestBase<MstApiGetDungeonRoomMstListResponse>
{
    public sealed override string Url => "/api/mst/get_dungeon_room_mst_list";
    // No fields
}

public class MstApiGetDungeonEventMstListRequest : RequestBase<MstApiGetDungeonEventMstListResponse>
{
    public sealed override string Url => "/api/mst/get_dungeon_event_mst_list";
    // No fields
}

public class MstApiGetFieldStratumMstListRequest : RequestBase<MstApiGetFieldStratumMstListResponse>
{
    public sealed override string Url => "/api/mst/get_field_stratum_mst_list";
    // No fields
}

public class MstApiGetFieldPointMstListRequest : RequestBase<MstApiGetFieldPointMstListResponse>
{
    public sealed override string Url => "/api/mst/get_field_point_mst_list";
    // No fields
}

public class MstApiGetBossDirectionMstListRequest : RequestBase<MstApiGetBossDirectionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_boss_direction_mst_list";
    // No fields
}

public class MstApiGetGatheringLevelMstListRequest : RequestBase<MstApiGetGatheringLevelMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gathering_level_mst_list";
    // No fields
}

public class MstApiGetGatheringRewardMstListRequest : RequestBase<MstApiGetGatheringRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_gathering_reward_mst_list";
    // No fields
}

public class MstApiGetScoreAttackMstListRequest : RequestBase<MstApiGetScoreAttackMstListResponse>
{
    public sealed override string Url => "/api/mst/get_score_attack_mst_list";
    // No fields
}

public class MstApiGetScoreAttackStageMstListRequest : RequestBase<MstApiGetScoreAttackStageMstListResponse>
{
    public sealed override string Url => "/api/mst/get_score_attack_stage_mst_list";
    // No fields
}

public class MstApiGetScoreAttackHighScoreRewardMstListRequest : RequestBase<MstApiGetScoreAttackHighScoreRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_score_attack_high_score_reward_mst_list";
    // No fields
}

public class MstApiGetScoreAttackTotalScoreRewardMstListRequest : RequestBase<MstApiGetScoreAttackTotalScoreRewardMstListResponse>
{
    public sealed override string Url => "/api/mst/get_score_attack_total_score_reward_mst_list";
    // No fields
}

public class MstApiGetCalculationPointPolicyMstListRequest : RequestBase<MstApiGetCalculationPointPolicyMstListResponse>
{
    public sealed override string Url => "/api/mst/get_calculation_point_policy_mst_list";
    // No fields
}

public class MstApiGetGuildMissionMstListRequest : RequestBase<MstApiGetGuildMissionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_guild_mission_mst_list";
    // No fields
}

public class MstApiGetGuildMissionTransitionMstListRequest : RequestBase<MstApiGetGuildMissionTransitionMstListResponse>
{
    public sealed override string Url => "/api/mst/get_guild_mission_transition_mst_list";
    // No fields
}

public class MapGveApiGetTopInfoRequest : RequestBase<MapGveApiGetTopInfoResponse>
{
    public sealed override string Url => "/api/map_gve/get_top_info";
    // No fields
}

public class MapGveApiReachPointRequest : RequestBase<MapGveApiReachPointResponse>
{
    public sealed override string Url => "/api/map_gve/reach_point";
    public int mapGvePointMstId { get; set; }
}

public class LoginApiLoginRequest : RequestBase<LoginApiLoginResponse>
{
    public sealed override string Url => "/api/login";
    public string appVersion { get; set; }
    public string urlParam { get; set; }
    public string deviceModel { get; set; }
    public int osType { get; set; }
    public string osVersion { get; set; }
    public int storeType { get; set; }
    public int graphicsDeviceId { get; set; }
    public int graphicsDeviceVendorId { get; set; }
    public int processorCount { get; set; }
    public string processorType { get; set; }
    public int supportedRenderTargetCount { get; set; }
    public bool supports3DTextures { get; set; }
    public bool supportsAccelerometer { get; set; }
    public bool supportsComputeShaders { get; set; }
    public bool supportsGyroscope { get; set; }
    public bool supportsImageEffects { get; set; }
    public bool supportsInstancing { get; set; }
    public bool supportsLocationService { get; set; }
    public bool supportsRenderTextures { get; set; }
    public bool supportsRenderToCubemap { get; set; }
    public bool supportsShadows { get; set; }
    public bool supportsSparseTextures { get; set; }
    public int supportsStencil { get; set; }
    public bool supportsVibration { get; set; }
    public string uuid { get; set; }
    public int xuid { get; set; }
}

public class InAppSnsApiCreateLoginUrlRequest : RequestBase<InAppSnsApiCreateLoginUrlResponse>
{
    public sealed override string Url => "/api/in_app_sns/create_login_url";
    public int platform { get; set; }
}

public class InAppSnsApiGetAccessTokenRequest : RequestBase<InAppSnsApiGetAccessTokenResponse>
{
    public sealed override string Url => "/api/in_app_sns/get_access_token";
    public string state { get; set; }
}

public class HariboteChatApiGetMessageDataListRequest : RequestBase<HariboteChatApiGetMessageDataListResponse>
{
    public sealed override string Url => "/api/debug/haribote_chat/get_message_data_list";
    // No fields
}

public class HariboteChatApiSendMessageRequest : RequestBase<HariboteChatApiSendMessageResponse>
{
    public sealed override string Url => "/api/debug/haribote_chat/send_message";
    public string message { get; set; }
}

public class FirestoreApiCreateTokenRequest : RequestBase<FirestoreApiCreateTokenResponse>
{
    public sealed override string Url => "/api/firestore/create_token";
    // No fields
}

public class ExplorationBattleApiInitializeStageV4Request : RequestBase<ExplorationBattleApiInitializeStageV4Response>
{
    public sealed override string Url => "/api/exploration_battle/initialize_stage_v4";
    public int fieldStageMstId { get; set; }
    public int fieldPointMstId { get; set; }
    public long dungeonEventMstId { get; set; }
    public long dungeonRoomMstId { get; set; }
    public int bossDirectionMstId { get; set; }
    public int presetEventIndex { get; set; }
    public long partyDataId { get; set; }
}

public class ExplorationBattleApiFinalizeStageForUserV4Request : RequestBase<ExplorationBattleApiFinalizeStageForUserV4Response>
{
    public sealed override string Url => "/api/exploration_battle/finalize_stage_for_user_v4";
    public int result { get; set; }
    public string battleLog { get; set; }
    public int autoMode { get; set; }
}

public class ExplorationBattleApiGetExplorationInfoRequest : RequestBase<ExplorationBattleApiGetExplorationInfoResponse>
{
    public sealed override string Url => "/api/exploration_battle/get_exploration_info";
    public long questDataId { get; set; }
}

public class ExplorationBattleApiRetireRequest : RequestBase<ExplorationBattleApiRetireResponse>
{
    public sealed override string Url => "/api/exploration_battle/retire";
    public string battleLog { get; set; }
    public bool isSystemRetire { get; set; }
}

public class DebugUserApiRecoverStaminaRequest : RequestBase<DebugUserApiRecoverStaminaResponse>
{
    public sealed override string Url => "/api/debug/debug_user/recover_stamina";
    // No fields
}

public class DebugSubscriptionApiIsValidSubscriptionRequest : RequestBase<DebugSubscriptionApiIsValidSubscriptionResponse>
{
    public sealed override string Url => "/api/debug/debug_subscription/is_valid_subscription";
    // No fields
}

public class DebugSubscriptionApiDoSubscribeForceRequest : RequestBase<DebugSubscriptionApiDoSubscribeForceResponse>
{
    public sealed override string Url => "/api/debug/debug_subscription/do_subscribe_force";
    // No fields
}

public class ConfigApiGetConfigRequest : RequestBase<ConfigApiGetConfigResponse>
{
    public sealed override string Url => "/api/config/get_config";
    // No fields
}

public class AppVersionApiGetReviewVersionDataRequest : RequestBase<AppVersionApiGetReviewVersionDataResponse>
{
    public sealed override string Url => "/api/app_version/get_review_version_data";
    public int storeType { get; set; }
    public string appVersion { get; set; }
}

public class AkamaiApiCreateTokenRequest : RequestBase<AkamaiApiCreateTokenResponse>
{
    public sealed override string Url => "/api/akamai/create_token";
    // No fields
}

public class TowerApiGetTowerTopRequest : RequestBase<TowerApiGetTowerTopResponse>
{
    public sealed override string Url => "/api/tower/get_tower_top";
    // No fields
}

public class TowerApiRecoverySkipNumRequest : RequestBase<TowerApiRecoverySkipNumResponse>
{
    public sealed override string Url => "/api/tower/recovery_skip_num";
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class TowerApiSkipQuestBattleRequest : RequestBase<TowerApiSkipQuestBattleResponse>
{
    public sealed override string Url => "/api/tower/skip_quest_battle";
    public int questStageMstId { get; set; }
    public int repeatNum { get; set; }
    public long partyDataId { get; set; }
}

public class StyleApiGetStyleDataListRequest : RequestBase<StyleApiGetStyleDataListResponse>
{
    public sealed override string Url => "/api/style/get_style_data_list";
    // No fields
}

public class StyleApiStyleLevelUpRequest : RequestBase<StyleApiStyleLevelUpResponse>
{
    public sealed override string Url => "/api/style/style_level_up";
    public int styleMstId { get; set; }
    public List<int> itemMstIdList { get; set; }
    public List<int> itemNumList { get; set; }
}

public class StyleApiStyleLevelUpVer2Request : RequestBase<StyleApiStyleLevelUpVer2Response>
{
    public sealed override string Url => "/api/style/style_level_up_ver2";
    public int styleMstId { get; set; }
    public int level { get; set; }
}

public class StyleApiStyleSkillLevelUpRequest : RequestBase<StyleApiStyleSkillLevelUpResponse>
{
    public sealed override string Url => "/api/style/style_skill_level_up";
    public int styleMstId { get; set; }
    public int skillLevelUpType { get; set; }
    public int skillNo { get; set; }
    public int level { get; set; }
}

public class StyleApiStyleSpecialAttackSkillLevelUpRequest : RequestBase<StyleApiStyleSpecialAttackSkillLevelUpResponse>
{
    public sealed override string Url => "/api/style/style_special_attack_skill_level_up";
    public int styleMstId { get; set; }
    public int level { get; set; }
}

public class StyleApiStyleLimitBreakRequest : RequestBase<StyleApiStyleLimitBreakResponse>
{
    public sealed override string Url => "/api/style/style_limit_break";
    public int styleMstId { get; set; }
    public int itemNum { get; set; }
}

public class StyleApiOpenStyleParamUpTreeRequest : RequestBase<StyleApiOpenStyleParamUpTreeResponse>
{
    public sealed override string Url => "/api/style/open_style_param_up_tree";
    public int styleMstId { get; set; }
    public int styleParamUpTreeMstId { get; set; }
}

public class StyleApiStyleParamUpRequest : RequestBase<StyleApiStyleParamUpResponse>
{
    public sealed override string Url => "/api/style/style_param_up";
    public int styleMstId { get; set; }
    public int styleParamUpTreeMstId { get; set; }
    public int paramUpType { get; set; }
}

public class StyleApiUpdateAlreadyViewRequest : RequestBase<StyleApiUpdateAlreadyViewResponse>
{
    public sealed override string Url => "/api/style/update_already_view";
    public List<int> styleMstIds { get; set; }
}

public class StoryEventApiGetTopRequest : RequestBase<StoryEventApiGetTopResponse>
{
    public sealed override string Url => "/api/story_event/get_top";
    // No fields
}

public class StoryEventApiGetArchiveEventListRequest : RequestBase<StoryEventApiGetArchiveEventListResponse>
{
    public sealed override string Url => "/api/story_event/get_archive_event_list";
    // No fields
}

public class StoryEventApiOpenStoryRequest : RequestBase<StoryEventApiOpenStoryResponse>
{
    public sealed override string Url => "/api/story_event/open_story";
    public int storyEventMstId { get; set; }
}

public class StoryEventApiScenarioReadRequest : RequestBase<StoryEventApiScenarioReadResponse>
{
    public sealed override string Url => "/api/story_event/scenario_read";
    public int storyEventScenarioMstId { get; set; }
}

public class StoryEventApiRecoverPlayableCountRequest : RequestBase<StoryEventApiRecoverPlayableCountResponse>
{
    public sealed override string Url => "/api/story_event/recover_playable_count";
    public int storyEventMstId { get; set; }
    public int recoverCount { get; set; }
}

public class ShopApiGetShopListRequest : RequestBase<ShopApiGetShopListResponse>
{
    public sealed override string Url => "/api/shop/get_shop_list";
    // No fields
}

public class ShopApiBuyRequest : RequestBase<ShopApiBuyResponse>
{
    public sealed override string Url => "/api/shop/buy";
    public int shopMstId { get; set; }
    public int shopSeriesMstId { get; set; }
    public int num { get; set; }
}

public class ShopApiGetShopPaymentMstListRequest : RequestBase<ShopApiGetShopPaymentMstListResponse>
{
    public sealed override string Url => "/api/shop/get_shop_payment_mst_list";
    // No fields
}

public class ScoreAttackApiGetScoreAttackTopRequest : RequestBase<ScoreAttackApiGetScoreAttackTopResponse>
{
    public sealed override string Url => "/api/score_attack/get_score_attack_top";
    public int scoreAttackMstId { get; set; }
}

public class ScoreAttackApiGetRankingInfoRequest : RequestBase<ScoreAttackApiGetRankingInfoResponse>
{
    public sealed override string Url => "/api/score_attack/get_ranking_info";
    public int scoreAttackMstId { get; set; }
}

public class ScoreAttackApiInitializeStageRequest : RequestBase<ScoreAttackApiInitializeStageResponse>
{
    public sealed override string Url => "/api/score_attack/initialize_stage";
    public int scoreAttackStageMstId { get; set; }
    public long partyDataId { get; set; }
}

public class ScoreAttackApiGetScoreAttackInfoRequest : RequestBase<ScoreAttackApiGetScoreAttackInfoResponse>
{
    public sealed override string Url => "/api/score_attack/get_score_attack_info";
    public long questDataId { get; set; }
}

public class ScoreAttackApiFinalizeStageForUserRequest : RequestBase<ScoreAttackApiFinalizeStageForUserResponse>
{
    public sealed override string Url => "/api/score_attack/finalize_stage_for_user";
    public int result { get; set; }
    public string battleLog { get; set; }
    public int autoMode { get; set; }
}

public class ScoreAttackApiRetireRequest : RequestBase<ScoreAttackApiRetireResponse>
{
    public sealed override string Url => "/api/score_attack/retire";
    public string battleLog { get; set; }
    public bool isSystemRetire { get; set; }
}

public class PvpApiGetPvpTopRequest : RequestBase<PvpApiGetPvpTopResponse>
{
    public sealed override string Url => "/api/pvp/get_pvp_top";
    // No fields
}

public class PvpApiGetRankingInfoRequest : RequestBase<PvpApiGetRankingInfoResponse>
{
    public sealed override string Url => "/api/pvp/get_ranking_info";
    public int mode { get; set; }
}

public class PvpApiGetCandidateEnemyUserListRequest : RequestBase<PvpApiGetCandidateEnemyUserListResponse>
{
    public sealed override string Url => "/api/pvp/get_candidate_enemy_user_list";
    // No fields
}

public class PvpApiGetEnemyUserInfoRequest : RequestBase<PvpApiGetEnemyUserInfoResponse>
{
    public sealed override string Url => "/api/pvp/get_enemy_user_info";
    public long chooseEnemyUserId { get; set; }
    public long partyDataId { get; set; }
}

public class PvpApiInitializeStageRequest : RequestBase<PvpApiInitializeStageResponse>
{
    public sealed override string Url => "/api/pvp/initialize_stage";
    public long chooseEnemyUserId { get; set; }
    public long partyDataId { get; set; }
    public bool isConsumeGem { get; set; }
}

public class PvpApiRetireRequest : RequestBase<PvpApiRetireResponse>
{
    public sealed override string Url => "/api/pvp/retire";
    public string battleLog { get; set; }
    public bool isSystemRetire { get; set; }
}

public class PvpApiGetPvpInfoRequest : RequestBase<PvpApiGetPvpInfoResponse>
{
    public sealed override string Url => "/api/pvp/get_pvp_info";
    public string roomId { get; set; }
}

public class PvpApiFinalizeStageRequest : RequestBase<PvpApiFinalizeStageResponse>
{
    public sealed override string Url => "/api/pvp/finalize_stage";
    public string roomId { get; set; }
    public long winUserId { get; set; }
    public int result { get; set; }
    public string battleLog { get; set; }
}

public class PvpApiFinalizeStageForUserRequest : RequestBase<PvpApiFinalizeStageForUserResponse>
{
    public sealed override string Url => "/api/pvp/finalize_stage_for_user";
    public string roomId { get; set; }
    public int result { get; set; }
    public string battleLog { get; set; }
    public int autoMode { get; set; }
}

public class PvpApiGetMatchHistoryRequest : RequestBase<PvpApiGetMatchHistoryResponse>
{
    public sealed override string Url => "/api/pvp/get_match_history";
    // No fields
}

public class PvpApiGetMatchDetailHistoryRequest : RequestBase<PvpApiGetMatchDetailHistoryResponse>
{
    public sealed override string Url => "/api/pvp/get_match_detail_history";
    public int pvpDataId { get; set; }
}

public class PvpApiGetMatchCharacterBuildDetailRequest : RequestBase<PvpApiGetMatchCharacterBuildDetailResponse>
{
    public sealed override string Url => "/api/pvp/get_match_character_build_detail";
    public int pvpDataId { get; set; }
    public long targetUserId { get; set; }
}

public class PvpApiGetRankingUserCharacterBuildDetailRequest : RequestBase<PvpApiGetRankingUserCharacterBuildDetailResponse>
{
    public sealed override string Url => "/api/pvp/get_ranking_user_character_build_detail";
    public long targetUserId { get; set; }
}

public class UserTitleApiGetUserTitleDataListRequest : RequestBase<UserTitleApiGetUserTitleDataListResponse>
{
    public sealed override string Url => "/api/user_title/get_user_title_data_list";
    // No fields
}

public class UserApiGetUserDataRequest : RequestBase<UserApiGetUserDataResponse>
{
    public sealed override string Url => "/api/user/get_user_data";
    // No fields
}

public class UserApiGetUserParamDataRequest : RequestBase<UserApiGetUserParamDataResponse>
{
    public sealed override string Url => "/api/user/get_user_param_data";
    // No fields
}

public class UserApiGetInitDataListRequest : RequestBase<UserApiGetInitDataListResponse>
{
    public sealed override string Url => "/api/user/get_init_data_list";
    // No fields
}

public class UserApiGetUserProfileDataRequest : RequestBase<UserApiGetUserProfileDataResponse>
{
    public sealed override string Url => "/api/user/get_user_profile_data";
    public long targetUserId { get; set; }
}

public class UserApiGetOtherUserProfileDataRequest : RequestBase<UserApiGetOtherUserProfileDataResponse>
{
    public sealed override string Url => "/api/user/get_other_user_profile_data";
    public long targetUserId { get; set; }
}

public class UserApiSetNameRequest : RequestBase<UserApiSetNameResponse>
{
    public sealed override string Url => "/api/user/set_name";
    public string name { get; set; }
}

public class UserApiSetCommentRequest : RequestBase<UserApiSetCommentResponse>
{
    public sealed override string Url => "/api/user/set_comment";
    public string comment { get; set; }
}

public class UserApiSetFavoriteInfoRequest : RequestBase<UserApiSetFavoriteInfoResponse>
{
    public sealed override string Url => "/api/user/set_favorite_info";
    public int characterMstId { get; set; }
    public int styleMstId { get; set; }
    public int skillMstId { get; set; }
}

public class UserApiSetDisplayUserTitleRequest : RequestBase<UserApiSetDisplayUserTitleResponse>
{
    public sealed override string Url => "/api/user/set_display_user_title";
    public List<int> userTitleMstIds { get; set; }
    public List<int> value1List { get; set; }
}

public class UserApiSetStaminaRecoverRequest : RequestBase<UserApiSetStaminaRecoverResponse>
{
    public sealed override string Url => "/api/user/set_stamina_recover";
    public int recoverType { get; set; }
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class UserApiSaveOptionRequest : RequestBase<UserApiSaveOptionResponse>
{
    public sealed override string Url => "/api/user/save_option";
    public bool paymentAlert { get; set; }
    public bool battleDirectionSkip { get; set; }
    public bool battleActionTimeView { get; set; }
}

public class UserApiLoadOptionRequest : RequestBase<UserApiLoadOptionResponse>
{
    public sealed override string Url => "/api/user/load_option";
    // No fields
}

public class UserApiUserSearchRequest : RequestBase<UserApiUserSearchResponse>
{
    public sealed override string Url => "/api/user/user_search";
    public string searchString { get; set; }
}

public class UserApiGetUserSubscriptionDataRequest : RequestBase<UserApiGetUserSubscriptionDataResponse>
{
    public sealed override string Url => "/api/user/get_user_subscription_data";
    // No fields
}

public class UserApiGetUserDisplayInfoListRequest : RequestBase<UserApiGetUserDisplayInfoListResponse>
{
    public sealed override string Url => "/api/user/get_user_display_info_list";
    public List<long> userIdList { get; set; }
}

public class UserApiInitConfigRequest : RequestBase<UserApiInitConfigResponse>
{
    public sealed override string Url => "/api/user/init_config";
    // No fields
}

public partial class UserApiAccountDeleteRequest : RequestBase<UserApiAccountDeleteResponse>
{
    public sealed override string Url => "/api/user/account_delete";
    // No fields
}

public class UserApiStoreReviewRequest : RequestBase<UserApiStoreReviewResponse>
{
    public sealed override string Url => "/api/user/store_review";
    // No fields
}

public class UserApiGetPlayerIdRequest : RequestBase<UserApiGetPlayerIdResponse>
{
    public sealed override string Url => "/api/user/get_player_id";
    public long targetUserId { get; set; }
}

public class PresentApiGetPresentDataListRequest : RequestBase<PresentApiGetPresentDataListResponse>
{
    public sealed override string Url => "/api/present/get_present_data_list";
    public bool isOrderNewest { get; set; }
    public int expireTimeType { get; set; }
}

public class PresentApiGetReceivedHistoryRequest : RequestBase<PresentApiGetReceivedHistoryResponse>
{
    public sealed override string Url => "/api/present/get_received_history";
    // No fields
}

public class PresentApiGetNoReceivedPresentNumRequest : RequestBase<PresentApiGetNoReceivedPresentNumResponse>
{
    public sealed override string Url => "/api/present/get_no_received_present_num";
    // No fields
}

public class PresentApiReceiveRequest : RequestBase<PresentApiReceiveResponse>
{
    public sealed override string Url => "/api/present/receive";
    public List<long> presentDataIds { get; set; }
}

public class MissionApiGetMissionDataListRequest : RequestBase<MissionApiGetMissionDataListResponse>
{
    public sealed override string Url => "/api/mission/get_mission_data_list";
    public int missionType { get; set; }
}

public class MissionApiReceiveRequest : RequestBase<MissionApiReceiveResponse>
{
    public sealed override string Url => "/api/mission/receive";
    public List<int> missionMstIds { get; set; }
}

public class TutorialApiUpdateTutorialStepRequest : RequestBase<TutorialApiUpdateTutorialStepResponse>
{
    public sealed override string Url => "/api/tutorial/update_tutorial_step";
    public int tutorialStep { get; set; }
}

public class TutorialApiGetMiniTutorialDataRequest : RequestBase<TutorialApiGetMiniTutorialDataResponse>
{
    public sealed override string Url => "/api/tutorial/get_mini_tutorial_data";
    // No fields
}

public class TutorialApiExecMiniTutorialRequest : RequestBase<TutorialApiExecMiniTutorialResponse>
{
    public sealed override string Url => "/api/tutorial/exec_mini_tutorial";
    public int miniTutorialNumber { get; set; }
}

public class TutorialApiGetPrologueBattleInfoRequest : RequestBase<TutorialApiGetPrologueBattleInfoResponse>
{
    public sealed override string Url => "/api/tutorial/get_prologue_battle_info";
    // No fields
}

public class TutorialApiSkipTutorialToGachaRequest : RequestBase<TutorialApiSkipTutorialToGachaResponse>
{
    public sealed override string Url => "/api/tutorial/skip_tutorial_to_gacha";
    // No fields
}

public class ItemApiGetItemDataListRequest : RequestBase<ItemApiGetItemDataListResponse>
{
    public sealed override string Url => "/api/item/get_item_data_list";
    // No fields
}

public class ItemApiGetItemDataListByItemMstIdListRequest : RequestBase<ItemApiGetItemDataListByItemMstIdListResponse>
{
    public sealed override string Url => "/api/item/get_item_data_list_by_item_mst_id_list";
    public List<int> itemMstIds { get; set; }
}

public class ItemApiUseItemRequest : RequestBase<ItemApiUseItemResponse>
{
    public sealed override string Url => "/api/item/use_item";
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class ItemApiSellItemRequest : RequestBase<ItemApiSellItemResponse>
{
    public sealed override string Url => "/api/item/sell_item";
    public int itemMstId { get; set; }
    public int num { get; set; }
}

public class HomeApiGetHomeInfoRequest : RequestBase<HomeApiGetHomeInfoResponse>
{
    public sealed override string Url => "/api/home/get_home_info";
    public bool skipLoginBonus { get; set; }
}

public class GvgApiGetTopRequest : RequestBase<GvgApiGetTopResponse>
{
    public sealed override string Url => "/api/gvg/get_top";
    // No fields
}

public class GvgApiGetMatchHistoryRequest : RequestBase<GvgApiGetMatchHistoryResponse>
{
    public sealed override string Url => "/api/gvg/get_match_history";
    public int viewType { get; set; }
    public int day { get; set; }
}

public class GvgApiGetMatchDetailHistoryRequest : RequestBase<GvgApiGetMatchDetailHistoryResponse>
{
    public sealed override string Url => "/api/gvg/get_match_detail_history";
    public long offenseUserId { get; set; }
    public int day { get; set; }
    public long allyUserId { get; set; }
}

public class GvgApiGetMatchCharacterBuildDetailRequest : RequestBase<GvgApiGetMatchCharacterBuildDetailResponse>
{
    public sealed override string Url => "/api/gvg/get_match_character_build_detail";
    public int day { get; set; }
    public long offenseUserId { get; set; }
    public long targetUserId { get; set; }
}

public class GvgApiGetCandidateEnemyUserListRequest : RequestBase<GvgApiGetCandidateEnemyUserListResponse>
{
    public sealed override string Url => "/api/gvg/get_candidate_enemy_user_list";
    // No fields
}

public class GvgApiGetRankingInfoRequest : RequestBase<GvgApiGetRankingInfoResponse>
{
    public sealed override string Url => "/api/gvg/get_ranking_info";
    // No fields
}

public class GvgApiGetLeagueMatchResultsRequest : RequestBase<GvgApiGetLeagueMatchResultsResponse>
{
    public sealed override string Url => "/api/gvg/get_league_match_results";
    // No fields
}

public class GvgApiGetEnemyUserInfoRequest : RequestBase<GvgApiGetEnemyUserInfoResponse>
{
    public sealed override string Url => "/api/gvg/get_enemy_user_info";
    public long enemyUserId { get; set; }
    public long partyDataId { get; set; }
}

public class GvgApiGetTrialEnemyUserInfoRequest : RequestBase<GvgApiGetTrialEnemyUserInfoResponse>
{
    public sealed override string Url => "/api/gvg/get_trial_enemy_user_info";
    public long enemyUserId { get; set; }
    public long partyDataId { get; set; }
}

public class GvgApiInitializeStageRequest : RequestBase<GvgApiInitializeStageResponse>
{
    public sealed override string Url => "/api/gvg/initialize_stage";
    public long enemyUserId { get; set; }
    public long partyDataId { get; set; }
}

public class GvgApiGetGvgInfoRequest : RequestBase<GvgApiGetGvgInfoResponse>
{
    public sealed override string Url => "/api/gvg/get_gvg_info";
    public string roomId { get; set; }
}

public class GvgApiRetireRequest : RequestBase<GvgApiRetireResponse>
{
    public sealed override string Url => "/api/gvg/retire";
    public string battleLog { get; set; }
    public bool isSystemRetire { get; set; }
}

public class GvgApiGetTrialGvgInfoRequest : RequestBase<GvgApiGetTrialGvgInfoResponse>
{
    public sealed override string Url => "/api/gvg/get_trial_gvg_info";
    public long partyDataId { get; set; }
    public long enemyUserId { get; set; }
}

public class GvgApiGetTrialCandidateEnemyUserListRequest : RequestBase<GvgApiGetTrialCandidateEnemyUserListResponse>
{
    public sealed override string Url => "/api/gvg/get_trial_candidate_enemy_user_list";
    // No fields
}

public class GvgApiFinalizeStageForUserRequest : RequestBase<GvgApiFinalizeStageForUserResponse>
{
    public sealed override string Url => "/api/gvg/finalize_stage_for_user";
    public string roomId { get; set; }
    public int result { get; set; }
    public string battleLog { get; set; }
    public int autoMode { get; set; }
}

public class GveApiGetTopRequest : RequestBase<GveApiGetTopResponse>
{
    public sealed override string Url => "/api/gve/get_top";
    // No fields
}

public class GveApiGetGuildInfoRequest : RequestBase<GveApiGetGuildInfoResponse>
{
    public sealed override string Url => "/api/gve/get_guild_info";
    // No fields
}

public class GveApiGetRankingInfoRequest : RequestBase<GveApiGetRankingInfoResponse>
{
    public sealed override string Url => "/api/gve/get_ranking_info";
    // No fields
}

public class GveApiGetGveHistoryRequest : RequestBase<GveApiGetGveHistoryResponse>
{
    public sealed override string Url => "/api/gve/get_gve_history";
    // No fields
}

public class GveApiInitializeStageRequest : RequestBase<GveApiInitializeStageResponse>
{
    public sealed override string Url => "/api/gve/initialize_stage";
    public int gveStageMstId { get; set; }
    public long partyDataId { get; set; }
    public bool enableStrategyBuff { get; set; }
}

public class GveApiGetGveInfoRequest : RequestBase<GveApiGetGveInfoResponse>
{
    public sealed override string Url => "/api/gve/get_gve_info";
    public long questDataId { get; set; }
}

public class GveApiAddDamageRequest : RequestBase<GveApiAddDamageResponse>
{
    public sealed override string Url => "/api/gve/add_damage";
    public long questDataId { get; set; }
    public int breakCount { get; set; }
    public List<int> damageList { get; set; }
}

public class GveApiFinalizeStageForUserRequest : RequestBase<GveApiFinalizeStageForUserResponse>
{
    public sealed override string Url => "/api/gve/finalize_stage_for_user";
    public long questDataId { get; set; }
    public int totalDamage { get; set; }
    public string battleLog { get; set; }
    public int autoMode { get; set; }
}

public class GveApiRetireRequest : RequestBase<GveApiRetireResponse>
{
    public sealed override string Url => "/api/gve/retire";
    public string battleLog { get; set; }
    public bool isSystemRetire { get; set; }
}

public class GuildApiAppointGuildSubMasterRequest : RequestBase<GuildApiAppointGuildSubMasterResponse>
{
    public sealed override string Url => "/api/guild/appoint_guild_sub_master";
    public long userId { get; set; }
}

public class GuildApiApproveJoinRequestRequest : RequestBase<GuildApiApproveJoinRequestResponse>
{
    public sealed override string Url => "/api/guild/approve_join_request";
    public long userId { get; set; }
}

public class GuildApiApproveScoutRequest : RequestBase<GuildApiApproveScoutResponse>
{
    public sealed override string Url => "/api/guild/approve_scout";
    public long guildDataId { get; set; }
}

public class GuildApiCancelJoinRequestRequest : RequestBase<GuildApiCancelJoinRequestResponse>
{
    public sealed override string Url => "/api/guild/cancel_join_request";
    public long guildDataId { get; set; }
}

public class GuildApiCancelScoutRequest : RequestBase<GuildApiCancelScoutResponse>
{
    public sealed override string Url => "/api/guild/cancel_scout";
    public long userId { get; set; }
}

public class GuildApiGuildNameSearchRequest : RequestBase<GuildApiGuildNameSearchResponse>
{
    public sealed override string Url => "/api/guild/guild_name_search";
    public string guildName { get; set; }
}

public class GuildApiConditionalGuildSearchRequest : RequestBase<GuildApiConditionalGuildSearchResponse>
{
    public sealed override string Url => "/api/guild/conditional_guild_search";
    public int guildAtmosphere { get; set; }
    public bool isAutoApproval { get; set; }
}

public class GuildApiRecommendedGuildSearchRequest : RequestBase<GuildApiRecommendedGuildSearchResponse>
{
    public sealed override string Url => "/api/guild/recommended_guild_search";
    // No fields
}

public class GuildApiCreateGuildRequest : RequestBase<GuildApiCreateGuildResponse>
{
    public sealed override string Url => "/api/guild/create_guild";
    public string guildName { get; set; }
    public string guildDescription { get; set; }
    public bool isAutoApproval { get; set; }
    public int guildAtmosphere { get; set; }
}

public class GuildApiDenyJoinRequestRequest : RequestBase<GuildApiDenyJoinRequestResponse>
{
    public sealed override string Url => "/api/guild/deny_join_request";
    public long userId { get; set; }
}

public class GuildApiDenyScoutRequest : RequestBase<GuildApiDenyScoutResponse>
{
    public sealed override string Url => "/api/guild/deny_scout";
    public long guildDataId { get; set; }
}

public class GuildApiExpelGuildMemberRequest : RequestBase<GuildApiExpelGuildMemberResponse>
{
    public sealed override string Url => "/api/guild/expel_guild_member";
    public long userId { get; set; }
}

public class GuildApiGetApplyingJoinRequestListByGuildRequest : RequestBase<GuildApiGetApplyingJoinRequestListByGuildResponse>
{
    public sealed override string Url => "/api/guild/get_applying_join_request_list_by_guild";
    // No fields
}

public class GuildApiGetApplyingJoinRequestListByUserRequest : RequestBase<GuildApiGetApplyingJoinRequestListByUserResponse>
{
    public sealed override string Url => "/api/guild/get_applying_join_request_list_by_user";
    // No fields
}

public class GuildApiGetApplyingScoutListByGuildRequest : RequestBase<GuildApiGetApplyingScoutListByGuildResponse>
{
    public sealed override string Url => "/api/guild/get_applying_scout_list_by_guild";
    // No fields
}

public class GuildApiGetApplyingScoutListByUserRequest : RequestBase<GuildApiGetApplyingScoutListByUserResponse>
{
    public sealed override string Url => "/api/guild/get_applying_scout_list_by_user";
    // No fields
}

public class GuildApiGetGuildDataRequest : RequestBase<GuildApiGetGuildDataResponse>
{
    public sealed override string Url => "/api/guild/get_guild_data";
    public long guildDataId { get; set; }
    public bool isContainMemberList { get; set; }
}

public class GuildApiGetGuildTopInfoRequest : RequestBase<GuildApiGetGuildTopInfoResponse>
{
    public sealed override string Url => "/api/guild/get_guild_top_info";
    // No fields
}

public class GuildApiGetGuildMemberListRequest : RequestBase<GuildApiGetGuildMemberListResponse>
{
    public sealed override string Url => "/api/guild/get_guild_member_list";
    public long guildDataId { get; set; }
}

public class GuildApiJoinRequestRequest : RequestBase<GuildApiJoinRequestResponse>
{
    public sealed override string Url => "/api/guild/join_request";
    public long guildDataId { get; set; }
}

public class GuildApiLeaveGuildRequest : RequestBase<GuildApiLeaveGuildResponse>
{
    public sealed override string Url => "/api/guild/leave_guild";
    // No fields
}

public class GuildApiMigrateGuildMasterRequest : RequestBase<GuildApiMigrateGuildMasterResponse>
{
    public sealed override string Url => "/api/guild/migrate_guild_master";
    public long userId { get; set; }
}

public class GuildApiMigrateGuildSubMasterRequest : RequestBase<GuildApiMigrateGuildSubMasterResponse>
{
    public sealed override string Url => "/api/guild/migrate_guild_sub_master";
    public long targetUserId { get; set; }
}

public class GuildApiRemoveGuildRequest : RequestBase<GuildApiRemoveGuildResponse>
{
    public sealed override string Url => "/api/guild/remove_guild";
    // No fields
}

public class GuildApiRemoveGuildSubMasterRequest : RequestBase<GuildApiRemoveGuildSubMasterResponse>
{
    public sealed override string Url => "/api/guild/remove_guild_sub_master";
    public long userId { get; set; }
}

public class GuildApiGetCandidateScoutUserListRequest : RequestBase<GuildApiGetCandidateScoutUserListResponse>
{
    public sealed override string Url => "/api/guild/get_candidate_scout_user_list";
    // No fields
}

public class GuildApiScoutRequest : RequestBase<GuildApiScoutResponse>
{
    public sealed override string Url => "/api/guild/scout";
    public long userId { get; set; }
}

public class GuildApiSetGuildBasicSettingsRequest : RequestBase<GuildApiSetGuildBasicSettingsResponse>
{
    public sealed override string Url => "/api/guild/set_guild_basic_settings";
    public string guildName { get; set; }
    public string guildDescription { get; set; }
    public int guildTitleMstId { get; set; }
    public bool isAutoApproval { get; set; }
    public int guildAtmosphere { get; set; }
}

public class GuildApiInstantJoinRequestRequest : RequestBase<GuildApiInstantJoinRequestResponse>
{
    public sealed override string Url => "/api/guild/instant_join_request";
    // No fields
}

public class GuildApiGetGuildTitleDataListRequest : RequestBase<GuildApiGetGuildTitleDataListResponse>
{
    public sealed override string Url => "/api/guild/get_guild_title_data_list";
    public long guildDataId { get; set; }
}

public class GatheringApiGetGatheringTopRequest : RequestBase<GatheringApiGetGatheringTopResponse>
{
    public sealed override string Url => "/api/gathering/get_gathering_top";
    // No fields
}

public class GatheringApiReceiveRewardRequest : RequestBase<GatheringApiReceiveRewardResponse>
{
    public sealed override string Url => "/api/gathering/receive_reward";
    // No fields
}

public class GatheringApiShortcutGatheringRequest : RequestBase<GatheringApiShortcutGatheringResponse>
{
    public sealed override string Url => "/api/gathering/shortcut_gathering";
    // No fields
}

public class GachaApiGetGachaTopRequest : RequestBase<GachaApiGetGachaTopResponse>
{
    public sealed override string Url => "/api/gacha/get_gacha_top";
    // No fields
}

public class GachaApiGachaExecRequest : RequestBase<GachaApiGachaExecResponse>
{
    public sealed override string Url => "/api/gacha/gacha_exec";
    public int gachaMstId { get; set; }
}

public class GachaApiUpdateAlreadyViewRequest : RequestBase<GachaApiUpdateAlreadyViewResponse>
{
    public sealed override string Url => "/api/gacha/update_already_view";
    public List<int> gachaSeriesMstIdList { get; set; }
}

public class QuestOutGameApiGetUserQuestStageListRequest : RequestBase<QuestOutGameApiGetUserQuestStageListResponse>
{
    public sealed override string Url => "/api/quest_out_game/get_user_quest_stage_list";
    public int questCategoryMstId { get; set; }
}

public class QuestOutGameApiOpenQuestGroupRequest : RequestBase<QuestOutGameApiOpenQuestGroupResponse>
{
    public sealed override string Url => "/api/quest_out_game/open_quest_group";
    public int questGroupMstId { get; set; }
}

public class QuestOutGameApiGetUserTrainingQuestDataListRequest : RequestBase<QuestOutGameApiGetUserTrainingQuestDataListResponse>
{
    public sealed override string Url => "/api/quest_out_game/get_user_training_quest_data_list";
    // No fields
}

public class QuestOutGameApiSetUserTrainingQuestRankUpEffectRequest : RequestBase<QuestOutGameApiSetUserTrainingQuestRankUpEffectResponse>
{
    public sealed override string Url => "/api/quest_out_game/set_user_training_quest_rank_up_effect";
    public List<int> questStageMstIdList { get; set; }
}

public class QuestOutGameApiGetUserQuestCharacterHeartListRequest : RequestBase<QuestOutGameApiGetUserQuestCharacterHeartListResponse>
{
    public sealed override string Url => "/api/quest_out_game/get_user_quest_character_heart_list";
    // No fields
}

public class CollectionApiGetCollectionDataListRequest : RequestBase<CollectionApiGetCollectionDataListResponse>
{
    public sealed override string Url => "/api/collection/get_collection_data_list";
    public ObjectObjectType objectType { get; set; }
}

public class CollectionApiGetCollectionParamUpAchieveDataListRequest : RequestBase<CollectionApiGetCollectionParamUpAchieveDataListResponse>
{
    public sealed override string Url => "/api/collection/get_collection_param_up_achieve_data_list";
    // No fields
}

public class CollectionApiUpdateAlreadyViewRequest : RequestBase<CollectionApiUpdateAlreadyViewResponse>
{
    public sealed override string Url => "/api/collection/update_already_view";
    public ObjectObjectType objectType { get; set; }
    public List<int> objectIds { get; set; }
}

public class CollectionApiEndCompleteProgressRequest : RequestBase<CollectionApiEndCompleteProgressResponse>
{
    public sealed override string Url => "/api/collection/end_complete_progress";
    // No fields
}

public class CollectionApiGetMagiaRecordCollectionInfoRequest : RequestBase<CollectionApiGetMagiaRecordCollectionInfoResponse>
{
    public sealed override string Url => "/api/collection/get_magia_record_collection_info";
    // No fields
}

public class CollectionApiAdvReadRequest : RequestBase<CollectionApiAdvReadResponse>
{
    public sealed override string Url => "/api/collection/adv_read";
    public List<int> advMstIdList { get; set; }
    public List<int> skipTypeList { get; set; }
}

public class CollectionApiGetCollectionIllustAchieveDataRequest : RequestBase<CollectionApiGetCollectionIllustAchieveDataResponse>
{
    public sealed override string Url => "/api/collection/get_collection_illust_achieve_data";
    public int collectionIllustMstId { get; set; }
}

public class CollectionApiViewNewCollectionIllustEffectRequest : RequestBase<CollectionApiViewNewCollectionIllustEffectResponse>
{
    public sealed override string Url => "/api/collection/view_new_collection_illust_effect";
    public int collectionIllustMstId { get; set; }
}

public class ChatApiCreateGroupChatRoomRequest : RequestBase<ChatApiCreateGroupChatRoomResponse>
{
    public sealed override string Url => "/api/chat/create_group_chat_room";
    public string roomName { get; set; }
    public List<long> targetUserIdList { get; set; }
}

public class ChatApiAddUserToGroupChatRoomRequest : RequestBase<ChatApiAddUserToGroupChatRoomResponse>
{
    public sealed override string Url => "/api/chat/add_user_to_group_chat_room";
    public string roomDocumentId { get; set; }
    public List<long> targetUserIdList { get; set; }
}

public class ChatApiDeleteUserByGroupChatRoomRequest : RequestBase<ChatApiDeleteUserByGroupChatRoomResponse>
{
    public sealed override string Url => "/api/chat/delete_user_by_group_chat_room";
    public string roomDocumentId { get; set; }
    public long targetUserId { get; set; }
}

public class ChatApiLeaveGroupChatRoomRequest : RequestBase<ChatApiLeaveGroupChatRoomResponse>
{
    public sealed override string Url => "/api/chat/leave_group_chat_room";
    public string roomDocumentId { get; set; }
}

public class ChatApiCreateDirectChatRoomRequest : RequestBase<ChatApiCreateDirectChatRoomResponse>
{
    public sealed override string Url => "/api/chat/create_direct_chat_room";
    public long targetUserId { get; set; }
}

public class ChatApiLeaveDirectChatRoomRequest : RequestBase<ChatApiLeaveDirectChatRoomResponse>
{
    public sealed override string Url => "/api/chat/leave_direct_chat_room";
    public long targetUserId { get; set; }
    public string roomDocumentId { get; set; }
}

public class ChatApiApproveEnterChatRoomRequest : RequestBase<ChatApiApproveEnterChatRoomResponse>
{
    public sealed override string Url => "/api/chat/approve_enter_chat_room";
    public string roomDocumentId { get; set; }
}

public class ChatApiGetChatBlockUserListRequest : RequestBase<ChatApiGetChatBlockUserListResponse>
{
    public sealed override string Url => "/api/chat/get_chat_block_user_list";
    // No fields
}

public class ChatApiBlockChatUserRequest : RequestBase<ChatApiBlockChatUserResponse>
{
    public sealed override string Url => "/api/chat/block_chat_user";
    public long targetUserId { get; set; }
}

public class ChatApiUnblockChatUserRequest : RequestBase<ChatApiUnblockChatUserResponse>
{
    public sealed override string Url => "/api/chat/unblock_chat_user";
    public long targetUserId { get; set; }
}

public class ChatApiSearchChatUserRequest : RequestBase<ChatApiSearchChatUserResponse>
{
    public sealed override string Url => "/api/chat/search_chat_user";
    public string searchString { get; set; }
}

public class PartyApiGetPartyDataListRequest : RequestBase<PartyApiGetPartyDataListResponse>
{
    public sealed override string Url => "/api/party/get_party_data_list";
    // No fields
}

public class PartyApiGetCharacterBuildDataListRequest : RequestBase<PartyApiGetCharacterBuildDataListResponse>
{
    public sealed override string Url => "/api/party/get_character_build_data_list";
    // No fields
}

public class PartyApiSavePartyRequest : RequestBase<PartyApiSavePartyResponse>
{
    public sealed override string Url => "/api/party/save_party";
    public long partyDataId { get; set; }
    public string name { get; set; }
    public int partyType { get; set; }
    public int styleMstId1 { get; set; }
    public int styleMstId2 { get; set; }
    public int styleMstId3 { get; set; }
    public int styleMstId4 { get; set; }
    public int styleMstId5 { get; set; }
    public int partyIndex { get; set; }
}

public class PartyApiSavePartyLeaderRequest : RequestBase<PartyApiSavePartyLeaderResponse>
{
    public sealed override string Url => "/api/party/save_party_leader";
    public long partyDataId { get; set; }
    public int styleMstId { get; set; }
}

public class PartyApiSavePartyNameRequest : RequestBase<PartyApiSavePartyNameResponse>
{
    public sealed override string Url => "/api/party/save_party_name";
    public long partyDataId { get; set; }
    public string name { get; set; }
}

public class PartyApiSavePartyRoleRequest : RequestBase<PartyApiSavePartyRoleResponse>
{
    public sealed override string Url => "/api/party/save_party_role";
    public long partyDataId { get; set; }
    public int role { get; set; }
}

public class PartyApiSavePartyForRecommendRequest : RequestBase<PartyApiSavePartyForRecommendResponse>
{
    public sealed override string Url => "/api/party/save_party_for_recommend";
    public int partyType { get; set; }
    public long partyDataId { get; set; }
    public int partyIndex { get; set; }
    public int styleMstId1 { get; set; }
    public int cardMstId1 { get; set; }
    public List<int> subStyleMstIds1 { get; set; }
    public int styleMstId2 { get; set; }
    public int cardMstId2 { get; set; }
    public List<int> subStyleMstIds2 { get; set; }
    public int styleMstId3 { get; set; }
    public int cardMstId3 { get; set; }
    public List<int> subStyleMstIds3 { get; set; }
    public int styleMstId4 { get; set; }
    public int cardMstId4 { get; set; }
    public List<int> subStyleMstIds4 { get; set; }
    public int styleMstId5 { get; set; }
    public int cardMstId5 { get; set; }
    public List<int> subStyleMstIds5 { get; set; }
}

public class PartyApiGetRecommendPartyDataRequest : RequestBase<PartyApiGetRecommendPartyDataResponse>
{
    public sealed override string Url => "/api/party/get_recommend_party_data";
    public int selectedStyleElement { get; set; }
    public int selectedParameter { get; set; }
    public bool isSettingCard { get; set; }
    public bool isSettingSubStyle { get; set; }
    public bool sameCharacterInParty { get; set; }
}

public class PartyApiGetRecommendSubStyleRequest : RequestBase<PartyApiGetRecommendSubStyleResponse>
{
    public sealed override string Url => "/api/party/get_recommend_sub_style";
    public int characterBuildDataId { get; set; }
}

public class PartyApiGetRecommendCardRequest : RequestBase<PartyApiGetRecommendCardResponse>
{
    public sealed override string Url => "/api/party/get_recommend_card";
    public int characterBuildDataId { get; set; }
}

public class PartyApiRemovePartyRequest : RequestBase<PartyApiRemovePartyResponse>
{
    public sealed override string Url => "/api/party/remove_party";
    public long partyDataId { get; set; }
}

public class PartyApiSavePartyCardRequest : RequestBase<PartyApiSavePartyCardResponse>
{
    public sealed override string Url => "/api/party/save_party_card";
    public long partyDataId { get; set; }
    public int cardMstId1 { get; set; }
    public int cardMstId2 { get; set; }
    public int cardMstId3 { get; set; }
    public int cardMstId4 { get; set; }
    public int cardMstId5 { get; set; }
}

public class PartyApiSavePartySubStyleRequest : RequestBase<PartyApiSavePartySubStyleResponse>
{
    public sealed override string Url => "/api/party/save_party_sub_style";
    public long partyDataId { get; set; }
    public int memberIndex { get; set; }
    public List<int> subStyleMstIds { get; set; }
}

public class CharacterApiGetCharacterListRequest : RequestBase<CharacterApiGetCharacterListResponse>
{
    public sealed override string Url => "/api/character/get_character_list";
    // No fields
}

public class CharacterApiCharacterAwakeRequest : RequestBase<CharacterApiCharacterAwakeResponse>
{
    public sealed override string Url => "/api/character/character_awake";
    public int characterMstId { get; set; }
    public int onlyItemNum { get; set; }
    public int genericItemNum { get; set; }
}

public class CharacterApiCharacterLevelUpRequest : RequestBase<CharacterApiCharacterLevelUpResponse>
{
    public sealed override string Url => "/api/character/character_level_up";
    public int characterMstId { get; set; }
    public List<int> itemMstIdList { get; set; }
    public List<int> itemNumList { get; set; }
}

public class CharacterApiCharacterHeartLevelUpRequest : RequestBase<CharacterApiCharacterHeartLevelUpResponse>
{
    public sealed override string Url => "/api/character/character_heart_level_up";
    public int characterMstId { get; set; }
    public List<int> itemMstIdList { get; set; }
    public List<int> itemNumList { get; set; }
}

public class CardApiGetCardListRequest : RequestBase<CardApiGetCardListResponse>
{
    public sealed override string Url => "/api/card/get_card_list";
    // No fields
}

public class CardApiCardLimitBreakRequest : RequestBase<CardApiCardLimitBreakResponse>
{
    public sealed override string Url => "/api/card/card_limit_break";
    public long cardDataId { get; set; }
    public List<long> consumeCardDataIds { get; set; }
    public int genericItemNum { get; set; }
}

public class CardApiCardSellRequest : RequestBase<CardApiCardSellResponse>
{
    public sealed override string Url => "/api/card/card_sell";
    public List<long> cardDataIds { get; set; }
}

public class CardApiSetCardProtectRequest : RequestBase<CardApiSetCardProtectResponse>
{
    public sealed override string Url => "/api/card/set_card_protect";
    public long cardDataId { get; set; }
    public bool isProtect { get; set; }
}

public class CardApiUpdateAlreadyViewRequest : RequestBase<CardApiUpdateAlreadyViewResponse>
{
    public sealed override string Url => "/api/card/update_already_view";
    public List<int> cardMstIds { get; set; }
}

public class CardApiCardPassiveSkillLevelUpRequest : RequestBase<CardApiCardPassiveSkillLevelUpResponse>
{
    public sealed override string Url => "/api/card/card_passive_skill_level_up";
    public int cardMstId { get; set; }
    public int passiveSkillLevel { get; set; }
}

public class QuestBattleApiInitializeStageRequest : RequestBase<QuestBattleApiInitializeStageResponse>
{
    public sealed override string Url => "/api/quest_battle/initialize_stage";
    public int questStageMstId { get; set; }
    public long partyDataId { get; set; }
    public int repeatNum { get; set; }
    public bool backGroundPlay { get; set; }
    public bool isArchiveEvent { get; set; }
}

public class QuestBattleApiGetQuestInfoRequest : RequestBase<QuestBattleApiGetQuestInfoResponse>
{
    public sealed override string Url => "/api/quest_battle/get_quest_info";
    public long questDataId { get; set; }
}

public class QuestBattleApiFinalizeStageForUserRequest : RequestBase<QuestBattleApiFinalizeStageForUserResponse>
{
    public sealed override string Url => "/api/quest_battle/finalize_stage_for_user";
    public int result { get; set; }
    public string battleLog { get; set; }
    public int autoMode { get; set; }
}

public class QuestBattleApiRetireRequest : RequestBase<QuestBattleApiRetireResponse>
{
    public sealed override string Url => "/api/quest_battle/retire";
    public string battleLog { get; set; }
    public bool isSystemRetire { get; set; }
}

public class QuestBattleApiSkipQuestBattleRequest : RequestBase<QuestBattleApiSkipQuestBattleResponse>
{
    public sealed override string Url => "/api/quest_battle/skip_quest_battle";
    public int questStageMstId { get; set; }
    public long partyDataId { get; set; }
    public int repeatNum { get; set; }
    public bool isArchiveEvent { get; set; }
}

public class QuestBattleApiGetBackGroundInfoRequest : RequestBase<QuestBattleApiGetBackGroundInfoResponse>
{
    public sealed override string Url => "/api/quest_battle/get_back_ground_info";
    // No fields
}

public class ExplorationApiGetTopInfoV4Request : RequestBase<ExplorationApiGetTopInfoV4Response>
{
    public sealed override string Url => "/api/exploration/get_top_info_v4";
    public int fieldStageMstId { get; set; }
}

public class ExplorationApiReachFieldPointRequest : RequestBase<ExplorationApiReachFieldPointResponse>
{
    public sealed override string Url => "/api/exploration/reach_field_point";
    public int fieldPointMstId { get; set; }
}

public class ExplorationApiOccurDungeonEventRequest : RequestBase<ExplorationApiOccurDungeonEventResponse>
{
    public sealed override string Url => "/api/exploration/occur_dungeon_event";
    public int fieldStageMstId { get; set; }
    public long dungeonEventMstId { get; set; }
    public long dungeonRoomMstId { get; set; }
    public int presetEventIndex { get; set; }
}

public class ExplorationApiDungeonStartRequest : RequestBase<ExplorationApiDungeonStartResponse>
{
    public sealed override string Url => "/api/exploration/dungeon_start";
    public int fieldStageMstId { get; set; }
    public int dungeonMstId { get; set; }
}

public class ExplorationApiDungeonGoalRequest : RequestBase<ExplorationApiDungeonGoalResponse>
{
    public sealed override string Url => "/api/exploration/dungeon_goal";
    public int fieldStageMstId { get; set; }
    public int dungeonMstId { get; set; }
}

public class ExplorationApiResetDungeonProgressRequest : RequestBase<ExplorationApiResetDungeonProgressResponse>
{
    public sealed override string Url => "/api/exploration/reset_dungeon_progress";
    public int fieldStageMstId { get; set; }
}

public class ExplorationApiGetEnableStageListRequest : RequestBase<ExplorationApiGetEnableStageListResponse>
{
    public sealed override string Url => "/api/exploration/get_enable_stage_list";
    // No fields
}

public class ExplorationApiGetStageMstListRequest : RequestBase<ExplorationApiGetStageMstListResponse>
{
    public sealed override string Url => "/api/exploration/get_stage_mst_list";
    public int fieldStageMstId { get; set; }
}

public class ExplorationApiGetDungeonMstListRequest : RequestBase<ExplorationApiGetDungeonMstListResponse>
{
    public sealed override string Url => "/api/exploration/get_dungeon_mst_list";
    public int dungeonMstId { get; set; }
}

public class ExplorationApiGetFieldStageCollectionInfoListRequest : RequestBase<ExplorationApiGetFieldStageCollectionInfoListResponse>
{
    public sealed override string Url => "/api/exploration/get_field_stage_collection_info_list";
    // No fields
}

public class ExplorationApiUpdateUserQuestMapEffectedDataRequest : RequestBase<ExplorationApiUpdateUserQuestMapEffectedDataResponse>
{
    public sealed override string Url => "/api/exploration/update_user_quest_map_effected_data";
    public int questMapMstId { get; set; }
    public int difficulty { get; set; }
}

