using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 被添加到标签策略强制执行的资源类型。
    /// </summary>
    public class TagPolicyServiceDto 
    {

        /// <summary>
        /// 服务名称。
        /// </summary>
        [JsonProperty("service_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 资源类型。
        /// </summary>
        [JsonProperty("resource_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// resource_type是否支持全量选择，即*
        /// </summary>
        [JsonProperty("support_all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportAll { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagPolicyServiceDto {\n");
            sb.Append("  serviceName: ").Append(ServiceName).Append("\n");
            sb.Append("  resourceTypes: ").Append(ResourceTypes).Append("\n");
            sb.Append("  supportAll: ").Append(SupportAll).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagPolicyServiceDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagPolicyServiceDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ResourceTypes == input.ResourceTypes ||
                    this.ResourceTypes != null &&
                    input.ResourceTypes != null &&
                    this.ResourceTypes.SequenceEqual(input.ResourceTypes)
                ) && 
                (
                    this.SupportAll == input.SupportAll ||
                    (this.SupportAll != null &&
                    this.SupportAll.Equals(input.SupportAll))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.ResourceTypes != null)
                    hashCode = hashCode * 59 + this.ResourceTypes.GetHashCode();
                if (this.SupportAll != null)
                    hashCode = hashCode * 59 + this.SupportAll.GetHashCode();
                return hashCode;
            }
        }
    }
}
