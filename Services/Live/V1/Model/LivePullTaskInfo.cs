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
    /// 直播拉流转推任务信息
    /// </summary>
    public class LivePullTaskInfo 
    {
        /// <summary>
        /// 修改任务时文件切换方式 immediate_new_source：立即播放新的拉流源内容 continue_from_file_start：从上次断流url文件重新开始推流 continue_from_break_point：从上次断流url文件断流位置开始推流（续上）
        /// </summary>
        /// <value>修改任务时文件切换方式 immediate_new_source：立即播放新的拉流源内容 continue_from_file_start：从上次断流url文件重新开始推流 continue_from_break_point：从上次断流url文件断流位置开始推流（续上）</value>
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
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 任务执行区域
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 拉流源类型 PullLivePushLive：拉转推（拉直播推直播） PullVodPushLive：轮播（拉点播推直播）
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceType { get; set; }

        /// <summary>
        /// 拉流源URL 当 source_type 为 PullLivePushLive 时，只能填写一个URL 当 source_type 为 PullVodPushLive 时，可以指定多个轮播源文件URL
        /// </summary>
        [JsonProperty("source_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SourceUrls { get; set; }

        /// <summary>
        /// 推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 推流app
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 推流流名
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }

        /// <summary>
        /// 推流参数
        /// </summary>
        [JsonProperty("push_args", NullValueHandling = NullValueHandling.Ignore)]
        public string PushArgs { get; set; }

        /// <summary>
        /// 完整的目标URL。 如果指定此参数，domain、app_name和stream_name需要传入空字符串或不传。
        /// </summary>
        [JsonProperty("destination_url", NullValueHandling = NullValueHandling.Ignore)]
        public string DestinationUrl { get; set; }

        /// <summary>
        /// 任务启动时间，时间格式： \&quot;2006-01-02T15:04:05Z\&quot;
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务结束时间，时间格式： \&quot;2006-01-02T15:04:05Z\&quot;  1. 结束时间必须大于开始时间； 2. 结束时间必须大于当前时间； 3. 结束时间 和 开始时间 间隔必须小于七天。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 要回调的事件列表（不填则回调全部） - TaskStart：任务启动回调 - TaskExit：任务停止回调 - VodSourceFileStart：仅PullVodPushLive可用，文件启动切换 - VodSourceFileFinish：仅PullVodPushLive可用，文件播放完毕 - ResetTaskConfig：仅PullVodPushLive可用，任务更新 - TaskAlarm：用于告警事件通知
        /// </summary>
        [JsonProperty("callback_events", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CallbackEvents { get; set; }

        /// <summary>
        /// 回调接收地址
        /// </summary>
        [JsonProperty("callback_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 备源的类型 - PullLivePushLive：直播 注意事项： 1. 仅当source_type为PullVodPushLive生效。 2. 主直播源拉流中断时，自动使用备源进行拉流。
        /// </summary>
        [JsonProperty("backup_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupSourceType { get; set; }

        /// <summary>
        /// 备源URL，仅当source_type为PullVodPushLive生效。
        /// </summary>
        [JsonProperty("backup_source_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BackupSourceUrls { get; set; }

        /// <summary>
        /// 缺省值”-1” -1：无限轮播，以结束时间为准；N：按文件列表播放N轮，以播放完成和结束时间先到为准。 不传、为空（\&quot;\&quot;）时按缺省值生效
        /// </summary>
        [JsonProperty("vod_loop_time", NullValueHandling = NullValueHandling.Ignore)]
        public string VodLoopTime { get; set; }

        /// <summary>
        /// 指定播放文件的下标，从0开始表示第一个文件，最大值 len(source_urls)-1
        /// </summary>
        [JsonProperty("vod_start_video_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? VodStartVideoIndex { get; set; }

        /// <summary>
        /// 指定从上述指定文件的第几秒开始播放
        /// </summary>
        [JsonProperty("vod_start_video_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? VodStartVideoTime { get; set; }

        /// <summary>
        /// 修改任务时文件切换方式 immediate_new_source：立即播放新的拉流源内容 continue_from_file_start：从上次断流url文件重新开始推流 continue_from_break_point：从上次断流url文件断流位置开始推流（续上）
        /// </summary>
        [JsonProperty("vod_refresh_type", NullValueHandling = NullValueHandling.Ignore)]
        public VodRefreshTypeEnum VodRefreshType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LivePullTaskInfo {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  sourceUrls: ").Append(SourceUrls).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("  pushArgs: ").Append(PushArgs).Append("\n");
            sb.Append("  destinationUrl: ").Append(DestinationUrl).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  callbackEvents: ").Append(CallbackEvents).Append("\n");
            sb.Append("  callbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  backupSourceType: ").Append(BackupSourceType).Append("\n");
            sb.Append("  backupSourceUrls: ").Append(BackupSourceUrls).Append("\n");
            sb.Append("  vodLoopTime: ").Append(VodLoopTime).Append("\n");
            sb.Append("  vodStartVideoIndex: ").Append(VodStartVideoIndex).Append("\n");
            sb.Append("  vodStartVideoTime: ").Append(VodStartVideoTime).Append("\n");
            sb.Append("  vodRefreshType: ").Append(VodRefreshType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LivePullTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LivePullTaskInfo input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;
            if (this.SourceUrls != input.SourceUrls || (this.SourceUrls != null && input.SourceUrls != null && !this.SourceUrls.SequenceEqual(input.SourceUrls))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.StreamName != input.StreamName || (this.StreamName != null && !this.StreamName.Equals(input.StreamName))) return false;
            if (this.PushArgs != input.PushArgs || (this.PushArgs != null && !this.PushArgs.Equals(input.PushArgs))) return false;
            if (this.DestinationUrl != input.DestinationUrl || (this.DestinationUrl != null && !this.DestinationUrl.Equals(input.DestinationUrl))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.CallbackEvents != input.CallbackEvents || (this.CallbackEvents != null && input.CallbackEvents != null && !this.CallbackEvents.SequenceEqual(input.CallbackEvents))) return false;
            if (this.CallbackUrl != input.CallbackUrl || (this.CallbackUrl != null && !this.CallbackUrl.Equals(input.CallbackUrl))) return false;
            if (this.BackupSourceType != input.BackupSourceType || (this.BackupSourceType != null && !this.BackupSourceType.Equals(input.BackupSourceType))) return false;
            if (this.BackupSourceUrls != input.BackupSourceUrls || (this.BackupSourceUrls != null && input.BackupSourceUrls != null && !this.BackupSourceUrls.SequenceEqual(input.BackupSourceUrls))) return false;
            if (this.VodLoopTime != input.VodLoopTime || (this.VodLoopTime != null && !this.VodLoopTime.Equals(input.VodLoopTime))) return false;
            if (this.VodStartVideoIndex != input.VodStartVideoIndex || (this.VodStartVideoIndex != null && !this.VodStartVideoIndex.Equals(input.VodStartVideoIndex))) return false;
            if (this.VodStartVideoTime != input.VodStartVideoTime || (this.VodStartVideoTime != null && !this.VodStartVideoTime.Equals(input.VodStartVideoTime))) return false;
            if (this.VodRefreshType != input.VodRefreshType) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.SourceUrls != null) hashCode = hashCode * 59 + this.SourceUrls.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.StreamName != null) hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                if (this.PushArgs != null) hashCode = hashCode * 59 + this.PushArgs.GetHashCode();
                if (this.DestinationUrl != null) hashCode = hashCode * 59 + this.DestinationUrl.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CallbackEvents != null) hashCode = hashCode * 59 + this.CallbackEvents.GetHashCode();
                if (this.CallbackUrl != null) hashCode = hashCode * 59 + this.CallbackUrl.GetHashCode();
                if (this.BackupSourceType != null) hashCode = hashCode * 59 + this.BackupSourceType.GetHashCode();
                if (this.BackupSourceUrls != null) hashCode = hashCode * 59 + this.BackupSourceUrls.GetHashCode();
                if (this.VodLoopTime != null) hashCode = hashCode * 59 + this.VodLoopTime.GetHashCode();
                if (this.VodStartVideoIndex != null) hashCode = hashCode * 59 + this.VodStartVideoIndex.GetHashCode();
                if (this.VodStartVideoTime != null) hashCode = hashCode * 59 + this.VodStartVideoTime.GetHashCode();
                hashCode = hashCode * 59 + this.VodRefreshType.GetHashCode();
                return hashCode;
            }
        }
    }
}
