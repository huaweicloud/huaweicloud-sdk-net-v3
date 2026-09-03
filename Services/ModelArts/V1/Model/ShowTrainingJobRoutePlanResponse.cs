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
    /// Response Object
    /// </summary>
    public class ShowTrainingJobRoutePlanResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：训练作业ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：路由规划状态。 **取值范围**： - success：路由规划成功 - failed：路由规划未执行或不满足条件，返回默认rank映射
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：rank映射结果，格式为\&quot;newRankId-workerId\&quot;，多个映射项之间以英文逗号分隔。 **约束限制**：当status为failed时，返回基于作业规格计算的默认顺序映射。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("rank_mapping", NullValueHandling = NullValueHandling.Ignore)]
        public string RankMapping { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrainingJobRoutePlanResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  rankMapping: ").Append(RankMapping).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrainingJobRoutePlanResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrainingJobRoutePlanResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RankMapping != input.RankMapping || (this.RankMapping != null && !this.RankMapping.Equals(input.RankMapping))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RankMapping != null) hashCode = hashCode * 59 + this.RankMapping.GetHashCode();
                return hashCode;
            }
        }
    }
}
