using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 规则过滤器
    /// </summary>
    public class PolicyFilterDefinition 
    {

        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 云服务名称
        /// </summary>
        [JsonProperty("resource_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 标签键
        /// </summary>
        [JsonProperty("tag_key", NullValueHandling = NullValueHandling.Ignore)]
        public string TagKey { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [JsonProperty("tag_value", NullValueHandling = NullValueHandling.Ignore)]
        public string TagValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyFilterDefinition {\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  resourceProvider: ").Append(ResourceProvider).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  tagKey: ").Append(TagKey).Append("\n");
            sb.Append("  tagValue: ").Append(TagValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyFilterDefinition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyFilterDefinition input)
        {
            if (input == null) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.ResourceProvider != input.ResourceProvider || (this.ResourceProvider != null && !this.ResourceProvider.Equals(input.ResourceProvider))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.TagKey != input.TagKey || (this.TagKey != null && !this.TagKey.Equals(input.TagKey))) return false;
            if (this.TagValue != input.TagValue || (this.TagValue != null && !this.TagValue.Equals(input.TagValue))) return false;

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
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.ResourceProvider != null) hashCode = hashCode * 59 + this.ResourceProvider.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.TagKey != null) hashCode = hashCode * 59 + this.TagKey.GetHashCode();
                if (this.TagValue != null) hashCode = hashCode * 59 + this.TagValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
