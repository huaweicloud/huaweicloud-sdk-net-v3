using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchChangeInstanceSpecificationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  批量规格变更的任务ID列表，仅变更按需实例时会返回该参数。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("job_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// **参数解释**：  批量规格变更订单ID列表，仅变更包年/包月实例时会返回该参数。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("order_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OrderIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchChangeInstanceSpecificationResponse {\n");
            sb.Append("  jobIds: ").Append(JobIds).Append("\n");
            sb.Append("  orderIds: ").Append(OrderIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchChangeInstanceSpecificationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchChangeInstanceSpecificationResponse input)
        {
            if (input == null) return false;
            if (this.JobIds != input.JobIds || (this.JobIds != null && input.JobIds != null && !this.JobIds.SequenceEqual(input.JobIds))) return false;
            if (this.OrderIds != input.OrderIds || (this.OrderIds != null && input.OrderIds != null && !this.OrderIds.SequenceEqual(input.OrderIds))) return false;

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
                if (this.JobIds != null) hashCode = hashCode * 59 + this.JobIds.GetHashCode();
                if (this.OrderIds != null) hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
