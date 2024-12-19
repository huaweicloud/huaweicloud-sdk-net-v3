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
    /// 合规规则修正记录查询条件详情。
    /// </summary>
    public class RemediationResourceKey 
    {

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 云服务名称，为兼容部分合规结果中云服务名称为空的场景，可为空字符串。
        /// </summary>
        [JsonProperty("resource_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceProvider { get; set; }

        /// <summary>
        /// 资源类型，为兼容部分合规结果中资源类型为空的场景，可为空字符串。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationResourceKey {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceProvider: ").Append(ResourceProvider).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationResourceKey);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationResourceKey input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceProvider != input.ResourceProvider || (this.ResourceProvider != null && !this.ResourceProvider.Equals(input.ResourceProvider))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceProvider != null) hashCode = hashCode * 59 + this.ResourceProvider.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
