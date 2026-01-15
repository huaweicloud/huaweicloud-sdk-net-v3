using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 获取指定任务迁移进度响应体
    /// </summary>
    public class QueryProgressResp 
    {
        /// <summary>
        /// 迁移模式。 - FULL_TRANS: 全量 - INCR_TRANS: 增量 - FULL_INCR_TRANS: 全量+增量
        /// </summary>
        /// <value>迁移模式。 - FULL_TRANS: 全量 - INCR_TRANS: 增量 - FULL_INCR_TRANS: 全量+增量</value>
        [JsonConverter(typeof(EnumClassConverter<TaskModeEnum>))]
        public class TaskModeEnum
        {
            /// <summary>
            /// Enum FULL_TRANS for value: FULL_TRANS
            /// </summary>
            public static readonly TaskModeEnum FULL_TRANS = new TaskModeEnum("FULL_TRANS");

            /// <summary>
            /// Enum FULL_INCR_TRANS for value: FULL_INCR_TRANS
            /// </summary>
            public static readonly TaskModeEnum FULL_INCR_TRANS = new TaskModeEnum("FULL_INCR_TRANS");

            /// <summary>
            /// Enum INCR_TRANS for value: INCR_TRANS
            /// </summary>
            public static readonly TaskModeEnum INCR_TRANS = new TaskModeEnum("INCR_TRANS");

            private static readonly Dictionary<string, TaskModeEnum> StaticFields =
            new Dictionary<string, TaskModeEnum>()
            {
                { "FULL_TRANS", FULL_TRANS },
                { "FULL_INCR_TRANS", FULL_INCR_TRANS },
                { "INCR_TRANS", INCR_TRANS },
            };

            private string _value;

            public TaskModeEnum()
            {

            }

            public TaskModeEnum(string value)
            {
                _value = value;
            }

            public static TaskModeEnum FromValue(string value)
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

                if (this.Equals(obj as TaskModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TaskModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TaskModeEnum a, TaskModeEnum b)
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

            public static bool operator !=(TaskModeEnum a, TaskModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 迁移百分比
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 增量迁移时延。单位：s
        /// </summary>
        [JsonProperty("incre_trans_delay", NullValueHandling = NullValueHandling.Ignore)]
        public string IncreTransDelay { get; set; }

        /// <summary>
        /// 增量迁移时延。单位：ms
        /// </summary>
        [JsonProperty("incre_trans_delay_millis", NullValueHandling = NullValueHandling.Ignore)]
        public string IncreTransDelayMillis { get; set; }

        /// <summary>
        /// 迁移模式。 - FULL_TRANS: 全量 - INCR_TRANS: 增量 - FULL_INCR_TRANS: 全量+增量
        /// </summary>
        [JsonProperty("task_mode", NullValueHandling = NullValueHandling.Ignore)]
        public TaskModeEnum TaskMode { get; set; }
        /// <summary>
        /// 任务状态 CREATING：创建中，CREATE_FAILED：创建失败，CONFIGURATION：配置中，WAITING_FOR_START：等待启动中，RELEASE_RESOURCE_COMPLETE：已结束，DELETED：已删除，INCRE_TRANSFER_STARTED：增量迁移中，INCRE_TRANSFER_FAILED：增量迁移失败，FULL_TRANSFER_STARTED：全量迁移中，FULL_TRANSFER_COMPLETE：全量迁移完成，PAUSING：暂停中，FULL_TRANSFER_FAILED：全量迁移失败
        /// </summary>
        [JsonProperty("transfer_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferStatus { get; set; }

        /// <summary>
        /// 迁移时间，时间戳
        /// </summary>
        [JsonProperty("process_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 预计剩余时间
        /// </summary>
        [JsonProperty("remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingTime { get; set; }

        /// <summary>
        /// 数据，结构，索引迁移进度信息体
        /// </summary>
        [JsonProperty("progress_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ProgressInfo> ProgressMap { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryProgressResp {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  increTransDelay: ").Append(IncreTransDelay).Append("\n");
            sb.Append("  increTransDelayMillis: ").Append(IncreTransDelayMillis).Append("\n");
            sb.Append("  taskMode: ").Append(TaskMode).Append("\n");
            sb.Append("  transferStatus: ").Append(TransferStatus).Append("\n");
            sb.Append("  processTime: ").Append(ProcessTime).Append("\n");
            sb.Append("  remainingTime: ").Append(RemainingTime).Append("\n");
            sb.Append("  progressMap: ").Append(ProgressMap).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  errorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryProgressResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryProgressResp input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.IncreTransDelay != input.IncreTransDelay || (this.IncreTransDelay != null && !this.IncreTransDelay.Equals(input.IncreTransDelay))) return false;
            if (this.IncreTransDelayMillis != input.IncreTransDelayMillis || (this.IncreTransDelayMillis != null && !this.IncreTransDelayMillis.Equals(input.IncreTransDelayMillis))) return false;
            if (this.TaskMode != input.TaskMode) return false;
            if (this.TransferStatus != input.TransferStatus || (this.TransferStatus != null && !this.TransferStatus.Equals(input.TransferStatus))) return false;
            if (this.ProcessTime != input.ProcessTime || (this.ProcessTime != null && !this.ProcessTime.Equals(input.ProcessTime))) return false;
            if (this.RemainingTime != input.RemainingTime || (this.RemainingTime != null && !this.RemainingTime.Equals(input.RemainingTime))) return false;
            if (this.ProgressMap != input.ProgressMap || (this.ProgressMap != null && input.ProgressMap != null && !this.ProgressMap.SequenceEqual(input.ProgressMap))) return false;
            if (this.ErrorCode != input.ErrorCode || (this.ErrorCode != null && !this.ErrorCode.Equals(input.ErrorCode))) return false;
            if (this.ErrorMsg != input.ErrorMsg || (this.ErrorMsg != null && !this.ErrorMsg.Equals(input.ErrorMsg))) return false;

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
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.IncreTransDelay != null) hashCode = hashCode * 59 + this.IncreTransDelay.GetHashCode();
                if (this.IncreTransDelayMillis != null) hashCode = hashCode * 59 + this.IncreTransDelayMillis.GetHashCode();
                hashCode = hashCode * 59 + this.TaskMode.GetHashCode();
                if (this.TransferStatus != null) hashCode = hashCode * 59 + this.TransferStatus.GetHashCode();
                if (this.ProcessTime != null) hashCode = hashCode * 59 + this.ProcessTime.GetHashCode();
                if (this.RemainingTime != null) hashCode = hashCode * 59 + this.RemainingTime.GetHashCode();
                if (this.ProgressMap != null) hashCode = hashCode * 59 + this.ProgressMap.GetHashCode();
                if (this.ErrorCode != null) hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                if (this.ErrorMsg != null) hashCode = hashCode * 59 + this.ErrorMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
