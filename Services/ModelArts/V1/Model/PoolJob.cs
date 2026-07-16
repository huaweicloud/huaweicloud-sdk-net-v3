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
    /// 资源管理作业。
    /// </summary>
    public class PoolJob 
    {

        /// <summary>
        /// **参数解释**： job开始处理时间，单位毫秒。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("startTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// **参数解释**： Job结束时间，单位毫秒。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("endTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTimestamp { get; set; }

        /// <summary>
        /// **参数解释**： 任务ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**： 任务名称。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("jobName", NullValueHandling = NullValueHandling.Ignore)]
        public string JobName { get; set; }

        /// <summary>
        /// **参数解释**： Job关联的资源，比如资源池描述。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("involvedObjects", NullValueHandling = NullValueHandling.Ignore)]
        public string InvolvedObjects { get; set; }

        /// <summary>
        /// **参数解释**： Job输入参数。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("inputs", NullValueHandling = NullValueHandling.Ignore)]
        public string Inputs { get; set; }

        /// <summary>
        /// **参数解释**： Job状态。 **取值范围**： 可选值如下： - Running：任务正在运行中。 - Success：任务执行成功。 - Failed：任务执行失败。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// **参数解释**： Job是否被挂起。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("suspend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Suspend { get; set; }

        /// <summary>
        /// **参数解释**： Job类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**： Job的执行过程信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public string Conditions { get; set; }

        /// <summary>
        /// **参数解释**： Job执行失败时返回执行信息。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolJob {\n");
            sb.Append("  startTimestamp: ").Append(StartTimestamp).Append("\n");
            sb.Append("  endTimestamp: ").Append(EndTimestamp).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  jobName: ").Append(JobName).Append("\n");
            sb.Append("  involvedObjects: ").Append(InvolvedObjects).Append("\n");
            sb.Append("  inputs: ").Append(Inputs).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  suspend: ").Append(Suspend).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolJob);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolJob input)
        {
            if (input == null) return false;
            if (this.StartTimestamp != input.StartTimestamp || (this.StartTimestamp != null && !this.StartTimestamp.Equals(input.StartTimestamp))) return false;
            if (this.EndTimestamp != input.EndTimestamp || (this.EndTimestamp != null && !this.EndTimestamp.Equals(input.EndTimestamp))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.JobName != input.JobName || (this.JobName != null && !this.JobName.Equals(input.JobName))) return false;
            if (this.InvolvedObjects != input.InvolvedObjects || (this.InvolvedObjects != null && !this.InvolvedObjects.Equals(input.InvolvedObjects))) return false;
            if (this.Inputs != input.Inputs || (this.Inputs != null && !this.Inputs.Equals(input.Inputs))) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.Suspend != input.Suspend || (this.Suspend != null && !this.Suspend.Equals(input.Suspend))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && !this.Conditions.Equals(input.Conditions))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;

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
                if (this.StartTimestamp != null) hashCode = hashCode * 59 + this.StartTimestamp.GetHashCode();
                if (this.EndTimestamp != null) hashCode = hashCode * 59 + this.EndTimestamp.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.JobName != null) hashCode = hashCode * 59 + this.JobName.GetHashCode();
                if (this.InvolvedObjects != null) hashCode = hashCode * 59 + this.InvolvedObjects.GetHashCode();
                if (this.Inputs != null) hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Suspend != null) hashCode = hashCode * 59 + this.Suspend.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }
    }
}
