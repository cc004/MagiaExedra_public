using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Crypto
{
    internal static class Program
    {
        private static readonly string[] mstModelNames = 
        {
            "item",
            "card",
            "card_limit_break",
            "skill",
            "skill_level_up_condition",
            "character_awake",
            "character",
            "character_profile",
            "character_heart",
            "character_heart_param_up_group",
            "character_heart_object_reward",
            "character_heart_level_up",
            "character_team",
            "style",
            "tower",
            "quest_category",
            "quest_map",
            "quest_group",
            "quest_stage",
            "quest_condition",
            "mission_title",
            "mission_transition",
            "subscription_mission_reward",
            "mission",
            "enemy",
            "enemy_profile",
            "quest_enemy_appearance",
            "quest_enemy_skill_set",
            "break",
            "ability_effect_type",
            "skill_detail",
            "quest_reward",
            "field_series",
            "field_stage",
            "adv",
            "adv_title",
            "object_receive_type",
            "pay_type",
            "talisman",
            "talisman_param",
            "talisman_param_effect",
            "talisman_series",
            "passive_skill",
            "passive_skill_detail",
            "leader_skill",
            "leader_skill_detail",
            "pvp_ranking_reward",
            "pvp_point_reward",
            "user_title",
            "guild_title",
            "user_level_up",
            "shop_series",
            "shop",
            "shop_detail",
            "banner",
            "banner_label",
            "home_banner",
            "home_appeal",
            "tips",
            "gve",
            "gve_stage",
            "gve_stage_reward",
            "map_gve",
            "map_gve_area",
            "map_gve_point",
            "login_bonus",
            "login_bonus_reward",
            "style_figure",
            "style_figure_story",
            "style_param_up_tree",
            "style_param_up",
            "style_param_up_cost",
            "style_param_up_effect",
            "style_limit_break",
            "style_limit_break_effect",
            "style_level_up",
            "style_voice",
            "gvg_point_reward",
            "gvg_ranking_reward",
            "chat_stamp",
            "battle_condition",
            "battle_condition_set",
            "enemy_condition_sets_and_action",
            "diorama_background",
            "live2_d_param",
            "gvg",
            "sound",
            "collection_illust",
            "collection_illust_piece",
            "collection_param_up",
            "collection_param_up_level",
            "collection_param_up_effect",
            "collection_condition_group",
            "collection_condition",
            "collection_reward",
            "story_event",
            "story_event_quest_stage",
            "mini_tutorial",
            "story_event_scenario",
            "story_event_scenario_reward",
            "story_event_bonus_rate",
            "dungeon",
            "dungeon_type",
            "dungeon_room",
            "dungeon_event",
            "field_stratum",
            "field_point",
            "boss_direction",
            "gathering_level",
            "gathering_reward",
            "score_attack",
            "score_attack_stage",
            "score_attack_high_score_reward",
            "score_attack_total_score_reward",
            "calculation_point_policy",
            "guild_mission",
            "guild_mission_transition"
    };

        static async Task Main(string[] args)
        {
            var resp = File.ReadAllText("dump.txt");
            var dec = new decimal(10, 0, 0, false, 1);

            var encrypted = resp.Split('\n').SelectMany(line =>
            {
                var res = new List<byte>();
                if (string.IsNullOrWhiteSpace(line)) return res;
                var split = line.Split(' ');
                for (int i = 2; i < 2 + 16; ++i)
                    res.Add(byte.Parse(split[i], NumberStyles.HexNumber));
                return res;
            }).ToArray();

            Console.WriteLine(PackHelper.Unpack(encrypted).ToString(Formatting.Indented));
        }
    }
}
