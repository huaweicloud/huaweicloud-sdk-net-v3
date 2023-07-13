using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FirewallInstanceResource 
    {

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 服务类型，用于CBC使用，特指：hws.service.type.cfw
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型，包括: 1、云防火墙:hws.resource.type.cfw 2、EIP:hws.resource.type.cfw.exp.eip 3、带宽:hws.resource.type.cfw.exp.bandwidth 4、VPC:hws.resource.type.cfw.exp.vpc 5、日志存储:hws.resource.type.cfw.exp.logaudit
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 库存单位码
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 资源数量
        /// </summary>
        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// 资源单位
        /// </summary>
        [JsonProperty("resource_size_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSizeMeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallInstanceResource {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  resourceSizeMeasureId: ").Append(ResourceSizeMeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallInstanceResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallInstanceResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.CloudServiceType == input.CloudServiceType ||
                    (this.CloudServiceType != null &&
                    this.CloudServiceType.Equals(input.CloudServiceType))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.ResourceSpecCode == input.ResourceSpecCode ||
                    (this.ResourceSpecCode != null &&
                    this.ResourceSpecCode.Equals(input.ResourceSpecCode))
                ) && 
                (
                    this.ResourceSize == input.ResourceSize ||
                    (this.ResourceSize != null &&
                    this.ResourceSize.Equals(input.ResourceSize))
                ) && 
                (
                    this.ResourceSizeMeasureId == input.ResourceSizeMeasureId ||
                    (this.ResourceSizeMeasureId != null &&
                    this.ResourceSizeMeasureId.Equals(input.ResourceSizeMeasureId))
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
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.CloudServiceType != null)
                    hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ResourceSize != null)
                    hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.ResourceSizeMeasureId != null)
                    hashCode = hashCode * 59 + this.ResourceSizeMeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
