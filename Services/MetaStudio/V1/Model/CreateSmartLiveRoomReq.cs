using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 创建直播间配置。
    /// </summary>
    public class CreateSmartLiveRoomReq 
    {
        /// <summary>
        /// **参数解释**： 直播间类型。 **约束限制**： 不涉及。 **取值范围**： * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。
        /// </summary>
        /// <value>**参数解释**： 直播间类型。 **约束限制**： 不涉及。 **取值范围**： * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。</value>
        [JsonConverter(typeof(EnumClassConverter<RoomTypeEnum>))]
        public class RoomTypeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly RoomTypeEnum NORMAL = new RoomTypeEnum("NORMAL");

            /// <summary>
            /// Enum TEMP for value: TEMP
            /// </summary>
            public static readonly RoomTypeEnum TEMP = new RoomTypeEnum("TEMP");

            /// <summary>
            /// Enum TEMPLATE for value: TEMPLATE
            /// </summary>
            public static readonly RoomTypeEnum TEMPLATE = new RoomTypeEnum("TEMPLATE");

            private static readonly Dictionary<string, RoomTypeEnum> StaticFields =
            new Dictionary<string, RoomTypeEnum>()
            {
                { "NORMAL", NORMAL },
                { "TEMP", TEMP },
                { "TEMPLATE", TEMPLATE },
            };

            private string _value;

            public RoomTypeEnum()
            {

            }

            public RoomTypeEnum(string value)
            {
                _value = value;
            }

            public static RoomTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as RoomTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoomTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoomTypeEnum a, RoomTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(RoomTypeEnum a, RoomTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 横竖屏类型。 **约束限制**： 用户无需填写，通过video_config中分辨率判断 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL： 竖屏。
        /// </summary>
        /// <value>**参数解释**： 横竖屏类型。 **约束限制**： 用户无需填写，通过video_config中分辨率判断 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL： 竖屏。</value>
        [JsonConverter(typeof(EnumClassConverter<ViewModeEnum>))]
        public class ViewModeEnum
        {
            /// <summary>
            /// Enum LANDSCAPE for value: LANDSCAPE
            /// </summary>
            public static readonly ViewModeEnum LANDSCAPE = new ViewModeEnum("LANDSCAPE");

            /// <summary>
            /// Enum VERTICAL for value: VERTICAL
            /// </summary>
            public static readonly ViewModeEnum VERTICAL = new ViewModeEnum("VERTICAL");

            private static readonly Dictionary<string, ViewModeEnum> StaticFields =
            new Dictionary<string, ViewModeEnum>()
            {
                { "LANDSCAPE", LANDSCAPE },
                { "VERTICAL", VERTICAL },
            };

            private string _value;

            public ViewModeEnum()
            {

            }

            public ViewModeEnum(string value)
            {
                _value = value;
            }

            public static ViewModeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ViewModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ViewModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ViewModeEnum a, ViewModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ViewModeEnum a, ViewModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 直播间名称。 **约束限制**： 不涉及。 **取值范围**： 字符长度1-256位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("room_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomName { get; set; }

        /// <summary>
        /// **参数解释**： 直播间描述。 **约束限制**： 不涉及。 **取值范围**： 字符长度0-1024位。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("room_description", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomDescription { get; set; }

        /// <summary>
        /// **参数解释**： 直播间类型。 **约束限制**： 不涉及。 **取值范围**： * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。
        /// </summary>
        [JsonProperty("room_type", NullValueHandling = NullValueHandling.Ignore)]
        public RoomTypeEnum RoomType { get; set; }
        /// <summary>
        /// 默认直播剧本列表。
        /// </summary>
        [JsonProperty("scene_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiveVideoScriptInfo> SceneScripts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("interaction_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveRoomInteractionConfig InteractionConfig { get; set; }

        /// <summary>
        /// 互动规则列表
        /// </summary>
        [JsonProperty("interaction_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<LiveRoomInteractionRuleInfo> InteractionRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("play_policy", NullValueHandling = NullValueHandling.Ignore)]
        public PlayPolicy PlayPolicy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoConfig VideoConfig { get; set; }

        /// <summary>
        /// **参数解释**： RTMP视频推流第三方直播平台地址。 &gt; 直播过程中刷新地址，需要调用COMMAND命令REFRESH_OUTPUT_URL。  **约束限制**： 不涉及 **取值范围**： 当前仅支持一条RTMP出流地址。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("output_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OutputUrls { get; set; }

        /// <summary>
        /// **参数解释**： RTMP视频推流第三方直播平台流密钥，与推流地址对应。 &gt; 直播过程中刷新地址，需要调用COMMAND命令REFRESH_OUTPUT_URL。  **约束限制**： 不涉及 **取值范围**： 当前仅支持一条RTMP出流地址。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("stream_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StreamKeys { get; set; }

        /// <summary>
        /// **参数解释**： 主播轮换时备选主播数字人资产ID（仅形象资产，不包含声音）。  **约束限制**： 不涉及 **取值范围**： 当前最大支持5个备选主播。 数字人资产ID，字符长度0-64位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("backup_model_asset_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BackupModelAssetIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_event_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveRoomEventCallBackConfig LiveEventCallbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public RTCLiveEventCallBackConfig RtcCallbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shared_config", NullValueHandling = NullValueHandling.Ignore)]
        public SharedConfig SharedConfig { get; set; }

        /// <summary>
        /// **参数解释**： 横竖屏类型。 **约束限制**： 用户无需填写，通过video_config中分辨率判断 **取值范围**： * LANDSCAPE：横屏。 * VERTICAL： 竖屏。
        /// </summary>
        [JsonProperty("view_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ViewModeEnum ViewMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("co_streamer_config", NullValueHandling = NullValueHandling.Ignore)]
        public CoStreamerConfig CoStreamerConfig { get; set; }

        /// <summary>
        /// **参数解释**： 匹配值私有数据，用户填写，原样带回。 **约束限制**： 不涉及 **取值范围**： 字符长度0-8192 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("priv_data", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relation_live_platform_info", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformLiveInfo RelationLivePlatformInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSmartLiveRoomReq {\n");
            sb.Append("  roomName: ").Append(RoomName).Append("\n");
            sb.Append("  roomDescription: ").Append(RoomDescription).Append("\n");
            sb.Append("  roomType: ").Append(RoomType).Append("\n");
            sb.Append("  sceneScripts: ").Append(SceneScripts).Append("\n");
            sb.Append("  interactionConfig: ").Append(InteractionConfig).Append("\n");
            sb.Append("  interactionRules: ").Append(InteractionRules).Append("\n");
            sb.Append("  playPolicy: ").Append(PlayPolicy).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  outputUrls: ").Append(OutputUrls).Append("\n");
            sb.Append("  streamKeys: ").Append(StreamKeys).Append("\n");
            sb.Append("  backupModelAssetIds: ").Append(BackupModelAssetIds).Append("\n");
            sb.Append("  liveEventCallbackConfig: ").Append(LiveEventCallbackConfig).Append("\n");
            sb.Append("  rtcCallbackConfig: ").Append(RtcCallbackConfig).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  sharedConfig: ").Append(SharedConfig).Append("\n");
            sb.Append("  viewMode: ").Append(ViewMode).Append("\n");
            sb.Append("  coStreamerConfig: ").Append(CoStreamerConfig).Append("\n");
            sb.Append("  privData: ").Append(PrivData).Append("\n");
            sb.Append("  relationLivePlatformInfo: ").Append(RelationLivePlatformInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSmartLiveRoomReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSmartLiveRoomReq input)
        {
            if (input == null) return false;
            if (this.RoomName != input.RoomName || (this.RoomName != null && !this.RoomName.Equals(input.RoomName))) return false;
            if (this.RoomDescription != input.RoomDescription || (this.RoomDescription != null && !this.RoomDescription.Equals(input.RoomDescription))) return false;
            if (this.RoomType != input.RoomType) return false;
            if (this.SceneScripts != input.SceneScripts || (this.SceneScripts != null && input.SceneScripts != null && !this.SceneScripts.SequenceEqual(input.SceneScripts))) return false;
            if (this.InteractionConfig != input.InteractionConfig || (this.InteractionConfig != null && !this.InteractionConfig.Equals(input.InteractionConfig))) return false;
            if (this.InteractionRules != input.InteractionRules || (this.InteractionRules != null && input.InteractionRules != null && !this.InteractionRules.SequenceEqual(input.InteractionRules))) return false;
            if (this.PlayPolicy != input.PlayPolicy || (this.PlayPolicy != null && !this.PlayPolicy.Equals(input.PlayPolicy))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.OutputUrls != input.OutputUrls || (this.OutputUrls != null && input.OutputUrls != null && !this.OutputUrls.SequenceEqual(input.OutputUrls))) return false;
            if (this.StreamKeys != input.StreamKeys || (this.StreamKeys != null && input.StreamKeys != null && !this.StreamKeys.SequenceEqual(input.StreamKeys))) return false;
            if (this.BackupModelAssetIds != input.BackupModelAssetIds || (this.BackupModelAssetIds != null && input.BackupModelAssetIds != null && !this.BackupModelAssetIds.SequenceEqual(input.BackupModelAssetIds))) return false;
            if (this.LiveEventCallbackConfig != input.LiveEventCallbackConfig || (this.LiveEventCallbackConfig != null && !this.LiveEventCallbackConfig.Equals(input.LiveEventCallbackConfig))) return false;
            if (this.RtcCallbackConfig != input.RtcCallbackConfig || (this.RtcCallbackConfig != null && !this.RtcCallbackConfig.Equals(input.RtcCallbackConfig))) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.SharedConfig != input.SharedConfig || (this.SharedConfig != null && !this.SharedConfig.Equals(input.SharedConfig))) return false;
            if (this.ViewMode != input.ViewMode) return false;
            if (this.CoStreamerConfig != input.CoStreamerConfig || (this.CoStreamerConfig != null && !this.CoStreamerConfig.Equals(input.CoStreamerConfig))) return false;
            if (this.PrivData != input.PrivData || (this.PrivData != null && !this.PrivData.Equals(input.PrivData))) return false;
            if (this.RelationLivePlatformInfo != input.RelationLivePlatformInfo || (this.RelationLivePlatformInfo != null && !this.RelationLivePlatformInfo.Equals(input.RelationLivePlatformInfo))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.RoomName != null) hashCode = hashCode * 59 + this.RoomName.GetHashCode();
                if (this.RoomDescription != null) hashCode = hashCode * 59 + this.RoomDescription.GetHashCode();
                hashCode = hashCode * 59 + this.RoomType.GetHashCode();
                if (this.SceneScripts != null) hashCode = hashCode * 59 + this.SceneScripts.GetHashCode();
                if (this.InteractionConfig != null) hashCode = hashCode * 59 + this.InteractionConfig.GetHashCode();
                if (this.InteractionRules != null) hashCode = hashCode * 59 + this.InteractionRules.GetHashCode();
                if (this.PlayPolicy != null) hashCode = hashCode * 59 + this.PlayPolicy.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.OutputUrls != null) hashCode = hashCode * 59 + this.OutputUrls.GetHashCode();
                if (this.StreamKeys != null) hashCode = hashCode * 59 + this.StreamKeys.GetHashCode();
                if (this.BackupModelAssetIds != null) hashCode = hashCode * 59 + this.BackupModelAssetIds.GetHashCode();
                if (this.LiveEventCallbackConfig != null) hashCode = hashCode * 59 + this.LiveEventCallbackConfig.GetHashCode();
                if (this.RtcCallbackConfig != null) hashCode = hashCode * 59 + this.RtcCallbackConfig.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                if (this.SharedConfig != null) hashCode = hashCode * 59 + this.SharedConfig.GetHashCode();
                hashCode = hashCode * 59 + this.ViewMode.GetHashCode();
                if (this.CoStreamerConfig != null) hashCode = hashCode * 59 + this.CoStreamerConfig.GetHashCode();
                if (this.PrivData != null) hashCode = hashCode * 59 + this.PrivData.GetHashCode();
                if (this.RelationLivePlatformInfo != null) hashCode = hashCode * 59 + this.RelationLivePlatformInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
