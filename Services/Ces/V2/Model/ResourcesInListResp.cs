using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResourcesInListResp 
    {

        /// <summary>
        /// **参数解释**： 资源分组ID，监控范围为资源分组时存在该值。 **取值范围**： 以rg开头，后跟22个字母或数字。 
        /// </summary>
        [JsonProperty("resource_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// **参数解释**： 资源分组名称，监控范围为资源分组时存在该值。 **取值范围**： 长度为[1,128]个字符。 
        /// </summary>
        [JsonProperty("resource_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// **参数解释**： 维度信息。 
        /// </summary>
        [JsonProperty("dimensions", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricDimensionResp> Dimensions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourcesInListResp {\n");
            sb.Append("  resourceGroupId: ").Append(ResourceGroupId).Append("\n");
            sb.Append("  resourceGroupName: ").Append(ResourceGroupName).Append("\n");
            sb.Append("  dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourcesInListResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourcesInListResp input)
        {
            if (input == null) return false;
            if (this.ResourceGroupId != input.ResourceGroupId || (this.ResourceGroupId != null && !this.ResourceGroupId.Equals(input.ResourceGroupId))) return false;
            if (this.ResourceGroupName != input.ResourceGroupName || (this.ResourceGroupName != null && !this.ResourceGroupName.Equals(input.ResourceGroupName))) return false;
            if (this.Dimensions != input.Dimensions || (this.Dimensions != null && input.Dimensions != null && !this.Dimensions.SequenceEqual(input.Dimensions))) return false;

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
                if (this.ResourceGroupId != null) hashCode = hashCode * 59 + this.ResourceGroupId.GetHashCode();
                if (this.ResourceGroupName != null) hashCode = hashCode * 59 + this.ResourceGroupName.GetHashCode();
                if (this.Dimensions != null) hashCode = hashCode * 59 + this.Dimensions.GetHashCode();
                return hashCode;
            }
        }
    }
}
