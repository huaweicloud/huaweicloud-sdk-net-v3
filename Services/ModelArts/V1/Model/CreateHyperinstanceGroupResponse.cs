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
    public class CreateHyperinstanceGroupResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：hyperinstance-group ID。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：hyperinstance-group名称。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：npu数量限制。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("npu_count_limit", NullValueHandling = NullValueHandling.Ignore)]
        public string NpuCountLimit { get; set; }

        /// <summary>
        /// **参数解释**：npu数量。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("npu_count", NullValueHandling = NullValueHandling.Ignore)]
        public string NpuCount { get; set; }

        /// <summary>
        /// **参数解释**：超节点集群ID。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceClusterId { get; set; }

        /// <summary>
        /// **参数解释**：创建时间。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// **参数解释**：更新时间。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHyperinstanceGroupResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  npuCountLimit: ").Append(NpuCountLimit).Append("\n");
            sb.Append("  npuCount: ").Append(NpuCount).Append("\n");
            sb.Append("  hyperinstanceClusterId: ").Append(HyperinstanceClusterId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateHyperinstanceGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateHyperinstanceGroupResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NpuCountLimit != input.NpuCountLimit || (this.NpuCountLimit != null && !this.NpuCountLimit.Equals(input.NpuCountLimit))) return false;
            if (this.NpuCount != input.NpuCount || (this.NpuCount != null && !this.NpuCount.Equals(input.NpuCount))) return false;
            if (this.HyperinstanceClusterId != input.HyperinstanceClusterId || (this.HyperinstanceClusterId != null && !this.HyperinstanceClusterId.Equals(input.HyperinstanceClusterId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NpuCountLimit != null) hashCode = hashCode * 59 + this.NpuCountLimit.GetHashCode();
                if (this.NpuCount != null) hashCode = hashCode * 59 + this.NpuCount.GetHashCode();
                if (this.HyperinstanceClusterId != null) hashCode = hashCode * 59 + this.HyperinstanceClusterId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
