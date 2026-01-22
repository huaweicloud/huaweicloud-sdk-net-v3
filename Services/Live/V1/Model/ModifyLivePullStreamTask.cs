using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyLivePullStreamTask 
    {
        /// <summary>
        /// pause停用/enable启用
        /// </summary>
        /// <value>pause停用/enable启用</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum PAUSE for value: pause
            /// </summary>
            public static readonly StatusEnum PAUSE = new StatusEnum("pause");

            /// <summary>
            /// Enum ENABLE for value: enable
            /// </summary>
            public static readonly StatusEnum ENABLE = new StatusEnum("enable");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "pause", PAUSE },
                { "enable", ENABLE },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 缺省值 immediate_new_source，可选 immediate_new_source、continue_from_file_start、continue_from_break_point
        /// </summary>
        /// <value>缺省值 immediate_new_source，可选 immediate_new_source、continue_from_file_start、continue_from_break_point</value>
        [JsonConverter(typeof(EnumClassConverter<VodRefreshTypeEnum>))]
        public class VodRefreshTypeEnum
        {
            /// <summary>
            /// Enum IMMEDIATE_NEW_SOURCE for value: immediate_new_source
            /// </summary>
            public static readonly VodRefreshTypeEnum IMMEDIATE_NEW_SOURCE = new VodRefreshTypeEnum("immediate_new_source");

            /// <summary>
            /// Enum CONTINUE_FROM_FILE_START for value: continue_from_file_start
            /// </summary>
            public static readonly VodRefreshTypeEnum CONTINUE_FROM_FILE_START = new VodRefreshTypeEnum("continue_from_file_start");

            /// <summary>
            /// Enum CONTINUE_FROM_BREAK_POINT for value: continue_from_break_point
            /// </summary>
            public static readonly VodRefreshTypeEnum CONTINUE_FROM_BREAK_POINT = new VodRefreshTypeEnum("continue_from_break_point");

            private static readonly Dictionary<string, VodRefreshTypeEnum> StaticFields =
            new Dictionary<string, VodRefreshTypeEnum>()
            {
                { "immediate_new_source", IMMEDIATE_NEW_SOURCE },
                { "continue_from_file_start", CONTINUE_FROM_FILE_START },
                { "continue_from_break_point", CONTINUE_FROM_BREAK_POINT },
            };

            private string _value;

            public VodRefreshTypeEnum()
            {

            }

            public VodRefreshTypeEnum(string value)
            {
                _value = value;
            }

            public static VodRefreshTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VodRefreshTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VodRefreshTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VodRefreshTypeEnum a, VodRefreshTypeEnum b)
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

            public static bool operator !=(VodRefreshTypeEnum a, VodRefreshTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines callbackEvents
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<CallbackEventsEnum>))]
        public class CallbackEventsEnum
        {
            /// <summary>
            /// Enum TASKSTART for value: TaskStart
            /// </summary>
            public static readonly CallbackEventsEnum TASKSTART = new CallbackEventsEnum("TaskStart");

            /// <summary>
            /// Enum VODSOURCEFILESTART for value: VodSourceFileStart
            /// </summary>
            public static readonly CallbackEventsEnum VODSOURCEFILESTART = new CallbackEventsEnum("VodSourceFileStart");

            /// <summary>
            /// Enum VODSOURCEFILEFINISH for value: VodSourceFileFinish
            /// </summary>
            public static readonly CallbackEventsEnum VODSOURCEFILEFINISH = new CallbackEventsEnum("VodSourceFileFinish");

            /// <summary>
            /// Enum RESETTASKCONFIG for value: ResetTaskConfig
            /// </summary>
            public static readonly CallbackEventsEnum RESETTASKCONFIG = new CallbackEventsEnum("ResetTaskConfig");

            /// <summary>
            /// Enum TASKEXIT for value: TaskExit
            /// </summary>
            public static readonly CallbackEventsEnum TASKEXIT = new CallbackEventsEnum("TaskExit");

            /// <summary>
            /// Enum TASKALARM for value: TaskAlarm
            /// </summary>
            public static readonly CallbackEventsEnum TASKALARM = new CallbackEventsEnum("TaskAlarm");

            private static readonly Dictionary<string, CallbackEventsEnum> StaticFields =
            new Dictionary<string, CallbackEventsEnum>()
            {
                { "TaskStart", TASKSTART },
                { "VodSourceFileStart", VODSOURCEFILESTART },
                { "VodSourceFileFinish", VODSOURCEFILEFINISH },
                { "ResetTaskConfig", RESETTASKCONFIG },
                { "TaskExit", TASKEXIT },
                { "TaskAlarm", TASKALARM },
            };

            private string _value;

            public CallbackEventsEnum()
            {

            }

            public CallbackEventsEnum(string value)
            {
                _value = value;
            }

            public static CallbackEventsEnum FromValue(string value)
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

                if (this.Equals(obj as CallbackEventsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CallbackEventsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CallbackEventsEnum a, CallbackEventsEnum b)
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

            public static bool operator !=(CallbackEventsEnum a, CallbackEventsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// pause停用/enable启用
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 拉流源URL
        /// </summary>
        [JsonProperty("source_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceUrls { get; set; }

        /// <summary>
        /// 缺省值”-1”。-1：无限轮播，以结束时间为准；N：按文件列表播放N轮，以播放完成和结束时间先到的为准。不传、为空（\&quot;\&quot;）时按缺省值生效
        /// </summary>
        [JsonProperty("vod_loop_time", NullValueHandling = NullValueHandling.Ignore)]
        public string VodLoopTime { get; set; }

        /// <summary>
        /// 缺省值 immediate_new_source，可选 immediate_new_source、continue_from_file_start、continue_from_break_point
        /// </summary>
        [JsonProperty("vod_refresh_type", NullValueHandling = NullValueHandling.Ignore)]
        public VodRefreshTypeEnum VodRefreshType { get; set; }
        /// <summary>
        /// 缺省值 0，指定播放文件的下标，从0开始表示第一个文件，最大值 len(source_urls)-1
        /// </summary>
        [JsonProperty("vod_start_video_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? VodStartVideoIndex { get; set; }

        /// <summary>
        /// 任务启动时间，时间格式： \&quot;2006-01-02T15:04:05Z\&quot; 必须小于结束时间，缺省为当前时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// 任务结束时间，时间格式： \&quot;2006-01-02T15:04:05Z\&quot; 必须大于开始时间，至多为开始时间+7天
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// 缺省值 0，指定从上述指定文件的第几秒开始播放
        /// </summary>
        [JsonProperty("vod_start_video_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? VodStartVideoTime { get; set; }

        /// <summary>
        /// 要回调的事件列表（不填则回调全部） - TaskStart：任务启动回调 - TaskExit：任务停止回调 - VodSourceFileStart 仅PullVodPushLive可用，文件启动切换 - VodSourceFileFinish 仅PullVodPushLive可用，文件播放完毕 - ResetTaskConfig 仅PullVodPushLive可用，任务更新 - TaskAlarm: 用于告警事件通知
        /// </summary>
        [JsonProperty("callback_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<CallbackEventsEnum> CallbackEvents { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyLivePullStreamTask {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sourceUrls: ").Append(SourceUrls).Append("\n");
            sb.Append("  vodLoopTime: ").Append(VodLoopTime).Append("\n");
            sb.Append("  vodRefreshType: ").Append(VodRefreshType).Append("\n");
            sb.Append("  vodStartVideoIndex: ").Append(VodStartVideoIndex).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  vodStartVideoTime: ").Append(VodStartVideoTime).Append("\n");
            sb.Append("  callbackEvents: ").Append(CallbackEvents).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyLivePullStreamTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyLivePullStreamTask input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Status != input.Status) return false;
            if (this.SourceUrls != input.SourceUrls || (this.SourceUrls != null && input.SourceUrls != null && !this.SourceUrls.SequenceEqual(input.SourceUrls))) return false;
            if (this.VodLoopTime != input.VodLoopTime || (this.VodLoopTime != null && !this.VodLoopTime.Equals(input.VodLoopTime))) return false;
            if (this.VodRefreshType != input.VodRefreshType) return false;
            if (this.VodStartVideoIndex != input.VodStartVideoIndex || (this.VodStartVideoIndex != null && !this.VodStartVideoIndex.Equals(input.VodStartVideoIndex))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.VodStartVideoTime != input.VodStartVideoTime || (this.VodStartVideoTime != null && !this.VodStartVideoTime.Equals(input.VodStartVideoTime))) return false;
            if (this.CallbackEvents != input.CallbackEvents || (this.CallbackEvents != null && input.CallbackEvents != null && !this.CallbackEvents.SequenceEqual(input.CallbackEvents))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SourceUrls != null) hashCode = hashCode * 59 + this.SourceUrls.GetHashCode();
                if (this.VodLoopTime != null) hashCode = hashCode * 59 + this.VodLoopTime.GetHashCode();
                hashCode = hashCode * 59 + this.VodRefreshType.GetHashCode();
                if (this.VodStartVideoIndex != null) hashCode = hashCode * 59 + this.VodStartVideoIndex.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.VodStartVideoTime != null) hashCode = hashCode * 59 + this.VodStartVideoTime.GetHashCode();
                hashCode = hashCode * 59 + this.CallbackEvents.GetHashCode();
                return hashCode;
            }
        }
    }
}
