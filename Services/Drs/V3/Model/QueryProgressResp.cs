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
        /// **参数解释**：  任务迁移模式，指定数据复制任务的执行方式。  **约束限制**：  单主灾备场景仅支持选择FULL_INCR_TRANS（全量+增量）。  **取值范围**：  - FULL_TRANS：全量迁移，仅迁移历史数据，迁移完成后任务结束 - INCR_TRANS：增量迁移，仅同步新增数据变更，适用于持续同步场景 - FULL_INCR_TRANS：全量+增量迁移，先迁移历史数据再持续同步增量，适用于平滑切换场景  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  任务迁移模式，指定数据复制任务的执行方式。  **约束限制**：  单主灾备场景仅支持选择FULL_INCR_TRANS（全量+增量）。  **取值范围**：  - FULL_TRANS：全量迁移，仅迁移历史数据，迁移完成后任务结束 - INCR_TRANS：增量迁移，仅同步新增数据变更，适用于持续同步场景 - FULL_INCR_TRANS：全量+增量迁移，先迁移历史数据再持续同步增量，适用于平滑切换场景  **默认取值**：  不涉及</value>
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
        /// **参数解释**：  迁移任务ID，用于唯一标识一个数据复制任务，在查询、修改、删除等操作中作为任务的识别凭证。  **约束限制**：  不涉及。  **取值范围**：  UUID格式字符串。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：  迁移百分比，表示当前任务的数据迁移完成进度。  **约束限制**：  不涉及。  **取值范围**：  0-100。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// **参数解释**：  增量迁移时延。当任务处于增量阶段时，该值表示源库与目标库之间的数据同步延迟。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("incre_trans_delay", NullValueHandling = NullValueHandling.Ignore)]
        public string IncreTransDelay { get; set; }

        /// <summary>
        /// **参数解释**：  增量迁移时延，与incre_trans_delay含义相同，但以毫秒为单位提供更精确的时延信息。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("incre_trans_delay_millis", NullValueHandling = NullValueHandling.Ignore)]
        public string IncreTransDelayMillis { get; set; }

        /// <summary>
        /// **参数解释**：  任务迁移模式，指定数据复制任务的执行方式。  **约束限制**：  单主灾备场景仅支持选择FULL_INCR_TRANS（全量+增量）。  **取值范围**：  - FULL_TRANS：全量迁移，仅迁移历史数据，迁移完成后任务结束 - INCR_TRANS：增量迁移，仅同步新增数据变更，适用于持续同步场景 - FULL_INCR_TRANS：全量+增量迁移，先迁移历史数据再持续同步增量，适用于平滑切换场景  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("task_mode", NullValueHandling = NullValueHandling.Ignore)]
        public TaskModeEnum TaskMode { get; set; }
        /// <summary>
        /// **参数解释**：  任务当前传输状态，表示数据迁移任务所处的运行阶段，可用于判断任务是否正常推进。  **约束限制**：  不涉及。  **取值范围**：  - CREATING：创建中 - CREATE_FAILED：创建失败 - CONFIGURATION：配置中 - WAITING_FOR_START：等待启动中 - RELEASE_RESOURCE_COMPLETE：已结束 - DELETED：已删除 - INCRE_TRANSFER_STARTED：增量迁移中 - INCRE_TRANSFER_FAILED：增量迁移失败 - FULL_TRANSFER_STARTED：全量迁移中 - FULL_TRANSFER_COMPLETE：全量迁移完成 - PAUSING：暂停中 - FULL_TRANSFER_FAILED：全量迁移失败  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("transfer_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferStatus { get; set; }

        /// <summary>
        /// **参数解释**：  迁移时间，格式为毫秒级Unix时间戳，表示任务最近一次进度更新时间。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("process_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessTime { get; set; }

        /// <summary>
        /// **参数解释**：  预计剩余完成时间，单位为秒。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingTime { get; set; }

        /// <summary>
        /// **参数解释**：  数据、结构、索引迁移进度信息体，详情请参见ProgressInfo定义。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("progress_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ProgressInfo> ProgressMap { get; set; }

        /// <summary>
        /// **参数解释**：  错误码，当任务报错时返回的错误代码。  **约束限制**：  不涉及。  **取值范围**：  格式为DRS.XXXXXX。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// **参数解释**：  错误详细信息，当任务执行失败时返回的具体错误描述。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("error_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// **参数解释**：  增量迁移RPS。  **约束限制**：  值为-1时代表任务尚未进入到增量状态。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("apply_rows_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ApplyRowsRate { get; set; }

        /// <summary>
        /// **参数解释**：  增量迁移网络流量。  **约束限制**：  值为-1时代表任务尚未进入到增量状态。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("apply_bytes_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? ApplyBytesRate { get; set; }



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
            sb.Append("  applyRowsRate: ").Append(ApplyRowsRate).Append("\n");
            sb.Append("  applyBytesRate: ").Append(ApplyBytesRate).Append("\n");
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
            if (this.ApplyRowsRate != input.ApplyRowsRate || (this.ApplyRowsRate != null && !this.ApplyRowsRate.Equals(input.ApplyRowsRate))) return false;
            if (this.ApplyBytesRate != input.ApplyBytesRate || (this.ApplyBytesRate != null && !this.ApplyBytesRate.Equals(input.ApplyBytesRate))) return false;

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
                if (this.ApplyRowsRate != null) hashCode = hashCode * 59 + this.ApplyRowsRate.GetHashCode();
                if (this.ApplyBytesRate != null) hashCode = hashCode * 59 + this.ApplyBytesRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
