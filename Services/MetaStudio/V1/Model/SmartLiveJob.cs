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
    /// 数字人直播任务信息。
    /// </summary>
    public class SmartLiveJob 
    {
        /// <summary>
        /// 数字人直播任务的状态。 * WAITING: 等待 * PROCESSING: 处理中 * SUCCEED: 成功 * FAILED: 失败 * BLOCKED: 封禁
        /// </summary>
        /// <value>数字人直播任务的状态。 * WAITING: 等待 * PROCESSING: 处理中 * SUCCEED: 成功 * FAILED: 失败 * BLOCKED: 封禁</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StateEnum WAITING = new StateEnum("WAITING");

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StateEnum PROCESSING = new StateEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly StateEnum SUCCEED = new StateEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            /// <summary>
            /// Enum BLOCKED for value: BLOCKED
            /// </summary>
            public static readonly StateEnum BLOCKED = new StateEnum("BLOCKED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
                { "BLOCKED", BLOCKED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 使用的资源类型。 * PERIOD：包周期资源 * ONDEMAND：按需资源 * ONE_TIME：一次性资源 * UNKNOW：未知资源类型。
        /// </summary>
        /// <value>使用的资源类型。 * PERIOD：包周期资源 * ONDEMAND：按需资源 * ONE_TIME：一次性资源 * UNKNOW：未知资源类型。</value>
        [JsonConverter(typeof(EnumClassConverter<UsedResourceTypeEnum>))]
        public class UsedResourceTypeEnum
        {
            /// <summary>
            /// Enum PERIOD for value: PERIOD
            /// </summary>
            public static readonly UsedResourceTypeEnum PERIOD = new UsedResourceTypeEnum("PERIOD");

            /// <summary>
            /// Enum ONDEMAND for value: ONDEMAND
            /// </summary>
            public static readonly UsedResourceTypeEnum ONDEMAND = new UsedResourceTypeEnum("ONDEMAND");

            /// <summary>
            /// Enum ONE_TIME for value: ONE_TIME
            /// </summary>
            public static readonly UsedResourceTypeEnum ONE_TIME = new UsedResourceTypeEnum("ONE_TIME");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly UsedResourceTypeEnum UNKNOW = new UsedResourceTypeEnum("UNKNOW");

            private static readonly Dictionary<string, UsedResourceTypeEnum> StaticFields =
            new Dictionary<string, UsedResourceTypeEnum>()
            {
                { "PERIOD", PERIOD },
                { "ONDEMAND", ONDEMAND },
                { "ONE_TIME", ONE_TIME },
                { "UNKNOW", UNKNOW },
            };

            private string _value;

            public UsedResourceTypeEnum()
            {

            }

            public UsedResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static UsedResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as UsedResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UsedResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UsedResourceTypeEnum a, UsedResourceTypeEnum b)
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

            public static bool operator !=(UsedResourceTypeEnum a, UsedResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数字人直播任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 直播间ID
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 直播间名称
        /// </summary>
        [JsonProperty("room_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomName { get; set; }

        /// <summary>
        /// 数字人直播任务的状态。 * WAITING: 等待 * PROCESSING: 处理中 * SUCCEED: 成功 * FAILED: 失败 * BLOCKED: 封禁
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// **参数解释**： 数字人直播时长，单位秒。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 数字人直播任务开始时间。格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 数字人直播任务结束时间。格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }

        /// <summary>
        /// 数字人直播任务创建时间。格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 数字人直播任务最后更新时间。格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("lastupdate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastupdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_room_info", NullValueHandling = NullValueHandling.Ignore)]
        public RTCRoomInfoList RtcRoomInfo { get; set; }

        /// <summary>
        /// 直播事件上报地址。用户将自行获取的直播间事件上报到此地址，用于触发智能互动，自动回复话术。
        /// </summary>
        [JsonProperty("live_event_report_url", NullValueHandling = NullValueHandling.Ignore)]
        public string LiveEventReportUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_event_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public LiveEventCallBackConfig LiveEventCallbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rtc_callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public RTCLiveEventCallBackConfig RtcCallbackConfig { get; set; }

        /// <summary>
        /// **参数解释**： 数字人直播推流时长，单位秒。
        /// </summary>
        [JsonProperty("stream_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? StreamDuration { get; set; }

        /// <summary>
        /// 封禁信息
        /// </summary>
        [JsonProperty("block_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockReason { get; set; }

        /// <summary>
        /// 直播间封面图URL
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("co_streamer_config", NullValueHandling = NullValueHandling.Ignore)]
        public CoStreamerConfig CoStreamerConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("live_job_log", NullValueHandling = NullValueHandling.Ignore)]
        public LiveJobLog LiveJobLog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("relation_live_platform_info", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformLiveDetailInfo RelationLivePlatformInfo { get; set; }

        /// <summary>
        /// 使用的资源类型。 * PERIOD：包周期资源 * ONDEMAND：按需资源 * ONE_TIME：一次性资源 * UNKNOW：未知资源类型。
        /// </summary>
        [JsonProperty("used_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public UsedResourceTypeEnum UsedResourceType { get; set; }
        /// <summary>
        /// AI标识开关
        /// </summary>
        [JsonProperty("is_ai_mark_on", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAiMarkOn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartLiveJob {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  roomName: ").Append(RoomName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastupdateTime: ").Append(LastupdateTime).Append("\n");
            sb.Append("  rtcRoomInfo: ").Append(RtcRoomInfo).Append("\n");
            sb.Append("  liveEventReportUrl: ").Append(LiveEventReportUrl).Append("\n");
            sb.Append("  liveEventCallbackConfig: ").Append(LiveEventCallbackConfig).Append("\n");
            sb.Append("  rtcCallbackConfig: ").Append(RtcCallbackConfig).Append("\n");
            sb.Append("  streamDuration: ").Append(StreamDuration).Append("\n");
            sb.Append("  blockReason: ").Append(BlockReason).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  coStreamerConfig: ").Append(CoStreamerConfig).Append("\n");
            sb.Append("  liveJobLog: ").Append(LiveJobLog).Append("\n");
            sb.Append("  relationLivePlatformInfo: ").Append(RelationLivePlatformInfo).Append("\n");
            sb.Append("  usedResourceType: ").Append(UsedResourceType).Append("\n");
            sb.Append("  isAiMarkOn: ").Append(IsAiMarkOn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartLiveJob);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartLiveJob input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.RoomName != input.RoomName || (this.RoomName != null && !this.RoomName.Equals(input.RoomName))) return false;
            if (this.State != input.State) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastupdateTime != input.LastupdateTime || (this.LastupdateTime != null && !this.LastupdateTime.Equals(input.LastupdateTime))) return false;
            if (this.RtcRoomInfo != input.RtcRoomInfo || (this.RtcRoomInfo != null && !this.RtcRoomInfo.Equals(input.RtcRoomInfo))) return false;
            if (this.LiveEventReportUrl != input.LiveEventReportUrl || (this.LiveEventReportUrl != null && !this.LiveEventReportUrl.Equals(input.LiveEventReportUrl))) return false;
            if (this.LiveEventCallbackConfig != input.LiveEventCallbackConfig || (this.LiveEventCallbackConfig != null && !this.LiveEventCallbackConfig.Equals(input.LiveEventCallbackConfig))) return false;
            if (this.RtcCallbackConfig != input.RtcCallbackConfig || (this.RtcCallbackConfig != null && !this.RtcCallbackConfig.Equals(input.RtcCallbackConfig))) return false;
            if (this.StreamDuration != input.StreamDuration || (this.StreamDuration != null && !this.StreamDuration.Equals(input.StreamDuration))) return false;
            if (this.BlockReason != input.BlockReason || (this.BlockReason != null && !this.BlockReason.Equals(input.BlockReason))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.CoStreamerConfig != input.CoStreamerConfig || (this.CoStreamerConfig != null && !this.CoStreamerConfig.Equals(input.CoStreamerConfig))) return false;
            if (this.LiveJobLog != input.LiveJobLog || (this.LiveJobLog != null && !this.LiveJobLog.Equals(input.LiveJobLog))) return false;
            if (this.RelationLivePlatformInfo != input.RelationLivePlatformInfo || (this.RelationLivePlatformInfo != null && !this.RelationLivePlatformInfo.Equals(input.RelationLivePlatformInfo))) return false;
            if (this.UsedResourceType != input.UsedResourceType) return false;
            if (this.IsAiMarkOn != input.IsAiMarkOn || (this.IsAiMarkOn != null && !this.IsAiMarkOn.Equals(input.IsAiMarkOn))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.RoomName != null) hashCode = hashCode * 59 + this.RoomName.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastupdateTime != null) hashCode = hashCode * 59 + this.LastupdateTime.GetHashCode();
                if (this.RtcRoomInfo != null) hashCode = hashCode * 59 + this.RtcRoomInfo.GetHashCode();
                if (this.LiveEventReportUrl != null) hashCode = hashCode * 59 + this.LiveEventReportUrl.GetHashCode();
                if (this.LiveEventCallbackConfig != null) hashCode = hashCode * 59 + this.LiveEventCallbackConfig.GetHashCode();
                if (this.RtcCallbackConfig != null) hashCode = hashCode * 59 + this.RtcCallbackConfig.GetHashCode();
                if (this.StreamDuration != null) hashCode = hashCode * 59 + this.StreamDuration.GetHashCode();
                if (this.BlockReason != null) hashCode = hashCode * 59 + this.BlockReason.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.CoStreamerConfig != null) hashCode = hashCode * 59 + this.CoStreamerConfig.GetHashCode();
                if (this.LiveJobLog != null) hashCode = hashCode * 59 + this.LiveJobLog.GetHashCode();
                if (this.RelationLivePlatformInfo != null) hashCode = hashCode * 59 + this.RelationLivePlatformInfo.GetHashCode();
                hashCode = hashCode * 59 + this.UsedResourceType.GetHashCode();
                if (this.IsAiMarkOn != null) hashCode = hashCode * 59 + this.IsAiMarkOn.GetHashCode();
                return hashCode;
            }
        }
    }
}
