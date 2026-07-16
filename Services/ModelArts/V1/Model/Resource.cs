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
    /// 训练作业资源规格信息。flavor_id和pool_id+[flavor_id]方式二选一。
    /// </summary>
    public class Resource 
    {

        /// <summary>
        /// **参数解释**：训练作业资源规格模式。 **取值范围**： - regular：标准模式
        /// </summary>
        [JsonProperty("policy", NullValueHandling = NullValueHandling.Ignore)]
        public string Policy { get; set; }

        /// <summary>
        /// **参数解释**：训练作业资源规格id。 **取值范围**：CPU规格专属资源池不支持指定flavor_id。GPU/Ascend规格专属资源池可选取值如下： - modelarts.pool.visual.xlarge（1卡） - modelarts.pool.visual.2xlarge（2卡） - modelarts.pool.visual.4xlarge（4卡） - modelarts.pool.visual.8xlarge（8卡）
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// **参数解释**：使用flavor_id时，由ModelArts返回的只读规格名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("flavor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorName { get; set; }

        /// <summary>
        /// **参数解释**：训练作业选择的资源副本数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("node_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeCount { get; set; }

        /// <summary>
        /// **参数解释**：训练作业选择的资源池ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释**：训练作业选择的资源池联邦ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("pool_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor_detail", NullValueHandling = NullValueHandling.Ignore)]
        public FlavorDetail FlavorDetail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("main_container_allocated_resources", NullValueHandling = NullValueHandling.Ignore)]
        public MainContainerAllocatedResources MainContainerAllocatedResources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("main_container_customized_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public MainContainerCustomizedFlavor MainContainerCustomizedFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Resource {\n");
            sb.Append("  policy: ").Append(Policy).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  flavorName: ").Append(FlavorName).Append("\n");
            sb.Append("  nodeCount: ").Append(NodeCount).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  poolGroupId: ").Append(PoolGroupId).Append("\n");
            sb.Append("  flavorDetail: ").Append(FlavorDetail).Append("\n");
            sb.Append("  mainContainerAllocatedResources: ").Append(MainContainerAllocatedResources).Append("\n");
            sb.Append("  mainContainerCustomizedFlavor: ").Append(MainContainerCustomizedFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Resource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Resource input)
        {
            if (input == null) return false;
            if (this.Policy != input.Policy || (this.Policy != null && !this.Policy.Equals(input.Policy))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.FlavorName != input.FlavorName || (this.FlavorName != null && !this.FlavorName.Equals(input.FlavorName))) return false;
            if (this.NodeCount != input.NodeCount || (this.NodeCount != null && !this.NodeCount.Equals(input.NodeCount))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.PoolGroupId != input.PoolGroupId || (this.PoolGroupId != null && !this.PoolGroupId.Equals(input.PoolGroupId))) return false;
            if (this.FlavorDetail != input.FlavorDetail || (this.FlavorDetail != null && !this.FlavorDetail.Equals(input.FlavorDetail))) return false;
            if (this.MainContainerAllocatedResources != input.MainContainerAllocatedResources || (this.MainContainerAllocatedResources != null && !this.MainContainerAllocatedResources.Equals(input.MainContainerAllocatedResources))) return false;
            if (this.MainContainerCustomizedFlavor != input.MainContainerCustomizedFlavor || (this.MainContainerCustomizedFlavor != null && !this.MainContainerCustomizedFlavor.Equals(input.MainContainerCustomizedFlavor))) return false;

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
                if (this.Policy != null) hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.FlavorName != null) hashCode = hashCode * 59 + this.FlavorName.GetHashCode();
                if (this.NodeCount != null) hashCode = hashCode * 59 + this.NodeCount.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.PoolGroupId != null) hashCode = hashCode * 59 + this.PoolGroupId.GetHashCode();
                if (this.FlavorDetail != null) hashCode = hashCode * 59 + this.FlavorDetail.GetHashCode();
                if (this.MainContainerAllocatedResources != null) hashCode = hashCode * 59 + this.MainContainerAllocatedResources.GetHashCode();
                if (this.MainContainerCustomizedFlavor != null) hashCode = hashCode * 59 + this.MainContainerCustomizedFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
