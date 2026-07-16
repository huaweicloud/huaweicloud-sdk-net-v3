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
    /// 
    /// </summary>
    public class RecoverRecord 
    {

        /// <summary>
        /// **参数描述**：本次故障容忍策略开始执行时间的unix时间戳，单位为秒(s)，同时也是故障发生时间。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("recover_start_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecoverStartAt { get; set; }

        /// <summary>
        /// **参数描述**：本次故障容忍策略结束时间的unix时间戳，单位为秒(s)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("recover_end_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? RecoverEndAt { get; set; }

        /// <summary>
        /// **参数描述**：本次故障容忍策略。 **取值范围**：枚举值如下： - npu_step_retry: Step重计算 - npu_proc_restart: NPU原地热恢复 - proc_restart: 进程原地重启 - pod_reschedule: Pod级重调度 - job_reschedule: Job级重调度 - job_reschedule_with_taint: 隔离式Job重调度
        /// </summary>
        [JsonProperty("recover", NullValueHandling = NullValueHandling.Ignore)]
        public string Recover { get; set; }

        /// <summary>
        /// **参数描述**：本次故障场景。 **取值范围**：枚举值如下： - chip_fault: 芯片故障 - node_fault: 节点故障 - job_failed: 作业失败退出 - job_hanged: 作业卡死 - job_subhealth: 作业亚健康 - error_in_log: 日志异常
        /// </summary>
        [JsonProperty("fault_scenario", NullValueHandling = NullValueHandling.Ignore)]
        public string FaultScenario { get; set; }

        /// <summary>
        /// **参数描述**：本次故障原因。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// **参数描述**：引发本次运行结束的task worker ID(如worker-0)。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("related_task", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedTask { get; set; }

        /// <summary>
        /// **参数描述**：本次故障执行结果。 **取值范围**：枚举值如下： - recovering: 执行中 - success: 成功 - failed: 失败 - downgrade: 策略降级 - terminated: 策略被终止 - quotaExceeded: 策略执行次数超限制
        /// </summary>
        [JsonProperty("recover_result", NullValueHandling = NullValueHandling.Ignore)]
        public string RecoverResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecoverRecord {\n");
            sb.Append("  recoverStartAt: ").Append(RecoverStartAt).Append("\n");
            sb.Append("  recoverEndAt: ").Append(RecoverEndAt).Append("\n");
            sb.Append("  recover: ").Append(Recover).Append("\n");
            sb.Append("  faultScenario: ").Append(FaultScenario).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  relatedTask: ").Append(RelatedTask).Append("\n");
            sb.Append("  recoverResult: ").Append(RecoverResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecoverRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecoverRecord input)
        {
            if (input == null) return false;
            if (this.RecoverStartAt != input.RecoverStartAt || (this.RecoverStartAt != null && !this.RecoverStartAt.Equals(input.RecoverStartAt))) return false;
            if (this.RecoverEndAt != input.RecoverEndAt || (this.RecoverEndAt != null && !this.RecoverEndAt.Equals(input.RecoverEndAt))) return false;
            if (this.Recover != input.Recover || (this.Recover != null && !this.Recover.Equals(input.Recover))) return false;
            if (this.FaultScenario != input.FaultScenario || (this.FaultScenario != null && !this.FaultScenario.Equals(input.FaultScenario))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.RelatedTask != input.RelatedTask || (this.RelatedTask != null && !this.RelatedTask.Equals(input.RelatedTask))) return false;
            if (this.RecoverResult != input.RecoverResult || (this.RecoverResult != null && !this.RecoverResult.Equals(input.RecoverResult))) return false;

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
                if (this.RecoverStartAt != null) hashCode = hashCode * 59 + this.RecoverStartAt.GetHashCode();
                if (this.RecoverEndAt != null) hashCode = hashCode * 59 + this.RecoverEndAt.GetHashCode();
                if (this.Recover != null) hashCode = hashCode * 59 + this.Recover.GetHashCode();
                if (this.FaultScenario != null) hashCode = hashCode * 59 + this.FaultScenario.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.RelatedTask != null) hashCode = hashCode * 59 + this.RelatedTask.GetHashCode();
                if (this.RecoverResult != null) hashCode = hashCode * 59 + this.RecoverResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
