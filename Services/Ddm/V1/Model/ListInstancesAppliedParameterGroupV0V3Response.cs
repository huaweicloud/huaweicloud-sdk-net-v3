using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstancesAppliedParameterGroupV0V3Response : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  查询可应用的实例列表返回相关信息的集合。  **参数范围**：  不涉及。
        /// </summary>
        [JsonProperty("entities", NullValueHandling = NullValueHandling.Ignore)]
        public List<ApplicableInstance> Entities { get; set; }

        /// <summary>
        /// **参数解释**：  分页参数: 每页记录数。  **约束限制**：  不涉及。  **取值范围**：  大于0且小于等于128。  **默认取值**：  默认值是10。
        /// </summary>
        [JsonProperty("instance_count_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceCountLimit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstancesAppliedParameterGroupV0V3Response {\n");
            sb.Append("  entities: ").Append(Entities).Append("\n");
            sb.Append("  instanceCountLimit: ").Append(InstanceCountLimit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstancesAppliedParameterGroupV0V3Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstancesAppliedParameterGroupV0V3Response input)
        {
            if (input == null) return false;
            if (this.Entities != input.Entities || (this.Entities != null && input.Entities != null && !this.Entities.SequenceEqual(input.Entities))) return false;
            if (this.InstanceCountLimit != input.InstanceCountLimit || (this.InstanceCountLimit != null && !this.InstanceCountLimit.Equals(input.InstanceCountLimit))) return false;

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
                if (this.Entities != null) hashCode = hashCode * 59 + this.Entities.GetHashCode();
                if (this.InstanceCountLimit != null) hashCode = hashCode * 59 + this.InstanceCountLimit.GetHashCode();
                return hashCode;
            }
        }
    }
}
