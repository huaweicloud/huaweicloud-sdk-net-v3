using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业运行及故障恢复记录。
    /// </summary>
    public class RunningRecord 
    {

        /// <summary>
        /// 本次运行开始时间的unix时间戳，单位为秒(s)。
        /// </summary>
        [JsonProperty("start_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartAt { get; set; }

        /// <summary>
        /// 本次运行结束时间的unix时间戳，单位为秒(s)。
        /// </summary>
        [JsonProperty("end_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndAt { get; set; }

        /// <summary>
        /// **参数解释**：本次运行加速卡启动时间的unix时间戳，单位为秒(s)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("xpu_start_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? XpuStartAt { get; set; }

        /// <summary>
        /// 本地运行的启动方式： - init_or_rescheduled：代表本次启动为被调度后的首次运行，包括初次启动及调度恢复后的运行。 - restarted：代表本次启动非被调度后的首次运行，为进程重启后的运行。
        /// </summary>
        [JsonProperty("start_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StartType { get; set; }

        /// <summary>
        /// 本次运行结束原因。
        /// </summary>
        [JsonProperty("end_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string EndReason { get; set; }

        /// <summary>
        /// 引发本次运行结束的task worker ID(如worker-0)。
        /// </summary>
        [JsonProperty("end_related_task", NullValueHandling = NullValueHandling.Ignore)]
        public string EndRelatedTask { get; set; }

        /// <summary>
        /// 本次运行结束后所采取的故障容忍策略，枚举值如下： - npu_proc_restart: NPU原地热恢复 - gpu_proc_restart: GPU原地热恢复 - proc_restart: 进程原地重启 - pod_reschedule: Pod级重调度 - job_reschedule: Job级重调度 - job_reschedule_with_taint: 隔离式Job重调度
        /// </summary>
        [JsonProperty("end_recover", NullValueHandling = NullValueHandling.Ignore)]
        public string EndRecover { get; set; }

        /// <summary>
        /// 本次运行结束后在故障容忍策略降级前所采取的容忍策略，取值范围同end_recover。
        /// </summary>
        [JsonProperty("end_recover_before_downgrade", NullValueHandling = NullValueHandling.Ignore)]
        public string EndRecoverBeforeDowngrade { get; set; }

        /// <summary>
        /// **参数解释**：本次运行异常结束时采取的所有故障容忍策略详情。
        /// </summary>
        [JsonProperty("recover_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecoverRecord> RecoverRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunningRecord {\n");
            sb.Append("  startAt: ").Append(StartAt).Append("\n");
            sb.Append("  endAt: ").Append(EndAt).Append("\n");
            sb.Append("  xpuStartAt: ").Append(XpuStartAt).Append("\n");
            sb.Append("  startType: ").Append(StartType).Append("\n");
            sb.Append("  endReason: ").Append(EndReason).Append("\n");
            sb.Append("  endRelatedTask: ").Append(EndRelatedTask).Append("\n");
            sb.Append("  endRecover: ").Append(EndRecover).Append("\n");
            sb.Append("  endRecoverBeforeDowngrade: ").Append(EndRecoverBeforeDowngrade).Append("\n");
            sb.Append("  recoverRecords: ").Append(RecoverRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunningRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunningRecord input)
        {
            if (input == null) return false;
            if (this.StartAt != input.StartAt || (this.StartAt != null && !this.StartAt.Equals(input.StartAt))) return false;
            if (this.EndAt != input.EndAt || (this.EndAt != null && !this.EndAt.Equals(input.EndAt))) return false;
            if (this.XpuStartAt != input.XpuStartAt || (this.XpuStartAt != null && !this.XpuStartAt.Equals(input.XpuStartAt))) return false;
            if (this.StartType != input.StartType || (this.StartType != null && !this.StartType.Equals(input.StartType))) return false;
            if (this.EndReason != input.EndReason || (this.EndReason != null && !this.EndReason.Equals(input.EndReason))) return false;
            if (this.EndRelatedTask != input.EndRelatedTask || (this.EndRelatedTask != null && !this.EndRelatedTask.Equals(input.EndRelatedTask))) return false;
            if (this.EndRecover != input.EndRecover || (this.EndRecover != null && !this.EndRecover.Equals(input.EndRecover))) return false;
            if (this.EndRecoverBeforeDowngrade != input.EndRecoverBeforeDowngrade || (this.EndRecoverBeforeDowngrade != null && !this.EndRecoverBeforeDowngrade.Equals(input.EndRecoverBeforeDowngrade))) return false;
            if (this.RecoverRecords != input.RecoverRecords || (this.RecoverRecords != null && input.RecoverRecords != null && !this.RecoverRecords.SequenceEqual(input.RecoverRecords))) return false;

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
                if (this.StartAt != null) hashCode = hashCode * 59 + this.StartAt.GetHashCode();
                if (this.EndAt != null) hashCode = hashCode * 59 + this.EndAt.GetHashCode();
                if (this.XpuStartAt != null) hashCode = hashCode * 59 + this.XpuStartAt.GetHashCode();
                if (this.StartType != null) hashCode = hashCode * 59 + this.StartType.GetHashCode();
                if (this.EndReason != null) hashCode = hashCode * 59 + this.EndReason.GetHashCode();
                if (this.EndRelatedTask != null) hashCode = hashCode * 59 + this.EndRelatedTask.GetHashCode();
                if (this.EndRecover != null) hashCode = hashCode * 59 + this.EndRecover.GetHashCode();
                if (this.EndRecoverBeforeDowngrade != null) hashCode = hashCode * 59 + this.EndRecoverBeforeDowngrade.GetHashCode();
                if (this.RecoverRecords != null) hashCode = hashCode * 59 + this.RecoverRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
