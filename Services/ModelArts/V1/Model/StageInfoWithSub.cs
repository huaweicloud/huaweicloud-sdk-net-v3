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
    /// 作业流程阶段信息列表的主阶段元信息，包含子阶段。
    /// </summary>
    public class StageInfoWithSub 
    {

        /// <summary>
        /// **参数解释**：作业ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：主阶段名称。  **取值范围**： - scheduling：作业调度 - preparing：环境准备 - running：作业运行 - end：作业结束
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：主阶段英文描述信息。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("en_message", NullValueHandling = NullValueHandling.Ignore)]
        public string EnMessage { get; set; }

        /// <summary>
        /// **参数解释**：主阶段中文描述信息。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("zh_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhMessage { get; set; }

        /// <summary>
        /// **参数解释**：主阶段开始时间。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// **参数解释**：主阶段结束时间。  **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**：主阶段序号。 **取值范围**：[1,4]。
        /// </summary>
        [JsonProperty("stage_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? StageOrder { get; set; }

        /// <summary>
        /// **参数解释**：子阶段信息列表。
        /// </summary>
        [JsonProperty("sub_stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubStage> SubStages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StageInfoWithSub {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  enMessage: ").Append(EnMessage).Append("\n");
            sb.Append("  zhMessage: ").Append(ZhMessage).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  stageOrder: ").Append(StageOrder).Append("\n");
            sb.Append("  subStages: ").Append(SubStages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StageInfoWithSub);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StageInfoWithSub input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.EnMessage != input.EnMessage || (this.EnMessage != null && !this.EnMessage.Equals(input.EnMessage))) return false;
            if (this.ZhMessage != input.ZhMessage || (this.ZhMessage != null && !this.ZhMessage.Equals(input.ZhMessage))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.StageOrder != input.StageOrder || (this.StageOrder != null && !this.StageOrder.Equals(input.StageOrder))) return false;
            if (this.SubStages != input.SubStages || (this.SubStages != null && input.SubStages != null && !this.SubStages.SequenceEqual(input.SubStages))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.EnMessage != null) hashCode = hashCode * 59 + this.EnMessage.GetHashCode();
                if (this.ZhMessage != null) hashCode = hashCode * 59 + this.ZhMessage.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StageOrder != null) hashCode = hashCode * 59 + this.StageOrder.GetHashCode();
                if (this.SubStages != null) hashCode = hashCode * 59 + this.SubStages.GetHashCode();
                return hashCode;
            }
        }
    }
}
