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
    /// 
    /// </summary>
    public class SmartLiveRoomBaseInfo 
    {
        /// <summary>
        /// 直播间类型。 * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。
        /// </summary>
        /// <value>直播间类型。 * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。</value>
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
        /// 直播间配置状态。 - ENABLE: 直播间正常可用。 - DISABLE： 直播间不可用。不可用原因在error_info中说明。 - BLOCKED：直播间被冻结。冻结原因在error_info中说明。
        /// </summary>
        /// <value>直播间配置状态。 - ENABLE: 直播间正常可用。 - DISABLE： 直播间不可用。不可用原因在error_info中说明。 - BLOCKED：直播间被冻结。冻结原因在error_info中说明。</value>
        [JsonConverter(typeof(EnumClassConverter<RoomStateEnum>))]
        public class RoomStateEnum
        {
            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly RoomStateEnum ENABLE = new RoomStateEnum("ENABLE");

            /// <summary>
            /// Enum DISABLE for value: DISABLE
            /// </summary>
            public static readonly RoomStateEnum DISABLE = new RoomStateEnum("DISABLE");

            /// <summary>
            /// Enum BLOCKED for value: BLOCKED
            /// </summary>
            public static readonly RoomStateEnum BLOCKED = new RoomStateEnum("BLOCKED");

            private static readonly Dictionary<string, RoomStateEnum> StaticFields =
            new Dictionary<string, RoomStateEnum>()
            {
                { "ENABLE", ENABLE },
                { "DISABLE", DISABLE },
                { "BLOCKED", BLOCKED },
            };

            private string _value;

            public RoomStateEnum()
            {

            }

            public RoomStateEnum(string value)
            {
                _value = value;
            }

            public static RoomStateEnum FromValue(string value)
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

                if (this.Equals(obj as RoomStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoomStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoomStateEnum a, RoomStateEnum b)
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

            public static bool operator !=(RoomStateEnum a, RoomStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 横竖屏类型。默认值为：VERTICAL。 * LANDSCAPE：横屏。 * VERTICAL： 竖屏。
        /// </summary>
        /// <value>横竖屏类型。默认值为：VERTICAL。 * LANDSCAPE：横屏。 * VERTICAL： 竖屏。</value>
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
        /// 当前直播状态 - WAITING：任务等待执行 - PROCESSING：任务执行中 - SUCCEED：任务处理成功 - FAILED：任务处理时变 - CANCELED：任务取消 - BLOCKED：任务被冻结
        /// </summary>
        /// <value>当前直播状态 - WAITING：任务等待执行 - PROCESSING：任务执行中 - SUCCEED：任务处理成功 - FAILED：任务处理时变 - CANCELED：任务取消 - BLOCKED：任务被冻结</value>
        [JsonConverter(typeof(EnumClassConverter<LastJobStatusEnum>))]
        public class LastJobStatusEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly LastJobStatusEnum WAITING = new LastJobStatusEnum("WAITING");

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly LastJobStatusEnum PROCESSING = new LastJobStatusEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly LastJobStatusEnum SUCCEED = new LastJobStatusEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly LastJobStatusEnum FAILED = new LastJobStatusEnum("FAILED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly LastJobStatusEnum CANCELED = new LastJobStatusEnum("CANCELED");

            /// <summary>
            /// Enum BLOCKED for value: BLOCKED
            /// </summary>
            public static readonly LastJobStatusEnum BLOCKED = new LastJobStatusEnum("BLOCKED");

            private static readonly Dictionary<string, LastJobStatusEnum> StaticFields =
            new Dictionary<string, LastJobStatusEnum>()
            {
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
                { "CANCELED", CANCELED },
                { "BLOCKED", BLOCKED },
            };

            private string _value;

            public LastJobStatusEnum()
            {

            }

            public LastJobStatusEnum(string value)
            {
                _value = value;
            }

            public static LastJobStatusEnum FromValue(string value)
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

                if (this.Equals(obj as LastJobStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LastJobStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LastJobStatusEnum a, LastJobStatusEnum b)
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

            public static bool operator !=(LastJobStatusEnum a, LastJobStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 直播间确认状态。此状态仅用于特定用户需要人工确认场景。 - UNCONFIRM: 未确认 - CONFIRMED：已确认 - REJECT： 拒绝
        /// </summary>
        /// <value>直播间确认状态。此状态仅用于特定用户需要人工确认场景。 - UNCONFIRM: 未确认 - CONFIRMED：已确认 - REJECT： 拒绝</value>
        [JsonConverter(typeof(EnumClassConverter<ConfirmStateEnum>))]
        public class ConfirmStateEnum
        {
            /// <summary>
            /// Enum UNCONFIRM for value: UNCONFIRM
            /// </summary>
            public static readonly ConfirmStateEnum UNCONFIRM = new ConfirmStateEnum("UNCONFIRM");

            /// <summary>
            /// Enum CONFIRMED for value: CONFIRMED
            /// </summary>
            public static readonly ConfirmStateEnum CONFIRMED = new ConfirmStateEnum("CONFIRMED");

            /// <summary>
            /// Enum REJECT for value: REJECT
            /// </summary>
            public static readonly ConfirmStateEnum REJECT = new ConfirmStateEnum("REJECT");

            private static readonly Dictionary<string, ConfirmStateEnum> StaticFields =
            new Dictionary<string, ConfirmStateEnum>()
            {
                { "UNCONFIRM", UNCONFIRM },
                { "CONFIRMED", CONFIRMED },
                { "REJECT", REJECT },
            };

            private string _value;

            public ConfirmStateEnum()
            {

            }

            public ConfirmStateEnum(string value)
            {
                _value = value;
            }

            public static ConfirmStateEnum FromValue(string value)
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

                if (this.Equals(obj as ConfirmStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfirmStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfirmStateEnum a, ConfirmStateEnum b)
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

            public static bool operator !=(ConfirmStateEnum a, ConfirmStateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 直播间ID
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 直播间名称
        /// </summary>
        [JsonProperty("room_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomName { get; set; }

        /// <summary>
        /// 直播间类型。 * NORMAL：普通直播间，直播间一直存在，可以反复开播 * TEMP：临时直播间，直播任务结束后自动清理直播间。 * TEMPLATE：直播间模板。
        /// </summary>
        [JsonProperty("room_type", NullValueHandling = NullValueHandling.Ignore)]
        public RoomTypeEnum RoomType { get; set; }
        /// <summary>
        /// 直播间配置状态。 - ENABLE: 直播间正常可用。 - DISABLE： 直播间不可用。不可用原因在error_info中说明。 - BLOCKED：直播间被冻结。冻结原因在error_info中说明。
        /// </summary>
        [JsonProperty("room_state", NullValueHandling = NullValueHandling.Ignore)]
        public RoomStateEnum RoomState { get; set; }
        /// <summary>
        /// 横竖屏类型。默认值为：VERTICAL。 * LANDSCAPE：横屏。 * VERTICAL： 竖屏。
        /// </summary>
        [JsonProperty("view_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ViewModeEnum ViewMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("shared_config", NullValueHandling = NullValueHandling.Ignore)]
        public SharedConfig SharedConfig { get; set; }

        /// <summary>
        /// 直播间描述。
        /// </summary>
        [JsonProperty("room_description", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomDescription { get; set; }

        /// <summary>
        /// 直播间封面图URL
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 直播间封面图URL
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// 数字人模型信息
        /// </summary>
        [JsonProperty("model_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModelInfo> ModelInfos { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 开始直播时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("last_job_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastJobStartTime { get; set; }

        /// <summary>
        /// 结束直播时间，格式遵循：RFC 3339 如“2021-01-10T08:43:17Z”。
        /// </summary>
        [JsonProperty("last_job_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastJobEndTime { get; set; }

        /// <summary>
        /// 当前直播状态 - WAITING：任务等待执行 - PROCESSING：任务执行中 - SUCCEED：任务处理成功 - FAILED：任务处理时变 - CANCELED：任务取消 - BLOCKED：任务被冻结
        /// </summary>
        [JsonProperty("last_job_status", NullValueHandling = NullValueHandling.Ignore)]
        public LastJobStatusEnum LastJobStatus { get; set; }
        /// <summary>
        /// 私有数据，用户填写，原样带回。
        /// </summary>
        [JsonProperty("priv_data", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivData { get; set; }

        /// <summary>
        /// 直播间确认状态。此状态仅用于特定用户需要人工确认场景。 - UNCONFIRM: 未确认 - CONFIRMED：已确认 - REJECT： 拒绝
        /// </summary>
        [JsonProperty("confirm_state", NullValueHandling = NullValueHandling.Ignore)]
        public ConfirmStateEnum ConfirmState { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmartLiveRoomBaseInfo {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  roomName: ").Append(RoomName).Append("\n");
            sb.Append("  roomType: ").Append(RoomType).Append("\n");
            sb.Append("  roomState: ").Append(RoomState).Append("\n");
            sb.Append("  viewMode: ").Append(ViewMode).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  sharedConfig: ").Append(SharedConfig).Append("\n");
            sb.Append("  roomDescription: ").Append(RoomDescription).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  modelInfos: ").Append(ModelInfos).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  lastJobStartTime: ").Append(LastJobStartTime).Append("\n");
            sb.Append("  lastJobEndTime: ").Append(LastJobEndTime).Append("\n");
            sb.Append("  lastJobStatus: ").Append(LastJobStatus).Append("\n");
            sb.Append("  privData: ").Append(PrivData).Append("\n");
            sb.Append("  confirmState: ").Append(ConfirmState).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmartLiveRoomBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmartLiveRoomBaseInfo input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.RoomName != input.RoomName || (this.RoomName != null && !this.RoomName.Equals(input.RoomName))) return false;
            if (this.RoomType != input.RoomType) return false;
            if (this.RoomState != input.RoomState) return false;
            if (this.ViewMode != input.ViewMode) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.SharedConfig != input.SharedConfig || (this.SharedConfig != null && !this.SharedConfig.Equals(input.SharedConfig))) return false;
            if (this.RoomDescription != input.RoomDescription || (this.RoomDescription != null && !this.RoomDescription.Equals(input.RoomDescription))) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.Thumbnail != input.Thumbnail || (this.Thumbnail != null && !this.Thumbnail.Equals(input.Thumbnail))) return false;
            if (this.ModelInfos != input.ModelInfos || (this.ModelInfos != null && input.ModelInfos != null && !this.ModelInfos.SequenceEqual(input.ModelInfos))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.LastJobStartTime != input.LastJobStartTime || (this.LastJobStartTime != null && !this.LastJobStartTime.Equals(input.LastJobStartTime))) return false;
            if (this.LastJobEndTime != input.LastJobEndTime || (this.LastJobEndTime != null && !this.LastJobEndTime.Equals(input.LastJobEndTime))) return false;
            if (this.LastJobStatus != input.LastJobStatus) return false;
            if (this.PrivData != input.PrivData || (this.PrivData != null && !this.PrivData.Equals(input.PrivData))) return false;
            if (this.ConfirmState != input.ConfirmState) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.RoomName != null) hashCode = hashCode * 59 + this.RoomName.GetHashCode();
                hashCode = hashCode * 59 + this.RoomType.GetHashCode();
                hashCode = hashCode * 59 + this.RoomState.GetHashCode();
                hashCode = hashCode * 59 + this.ViewMode.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.SharedConfig != null) hashCode = hashCode * 59 + this.SharedConfig.GetHashCode();
                if (this.RoomDescription != null) hashCode = hashCode * 59 + this.RoomDescription.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.Thumbnail != null) hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.ModelInfos != null) hashCode = hashCode * 59 + this.ModelInfos.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.LastJobStartTime != null) hashCode = hashCode * 59 + this.LastJobStartTime.GetHashCode();
                if (this.LastJobEndTime != null) hashCode = hashCode * 59 + this.LastJobEndTime.GetHashCode();
                hashCode = hashCode * 59 + this.LastJobStatus.GetHashCode();
                if (this.PrivData != null) hashCode = hashCode * 59 + this.PrivData.GetHashCode();
                hashCode = hashCode * 59 + this.ConfirmState.GetHashCode();
                return hashCode;
            }
        }
    }
}
