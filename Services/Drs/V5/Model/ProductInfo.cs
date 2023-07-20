using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 产品信息。
    /// </summary>
    public class ProductInfo 
    {

        /// <summary>
        /// ID标识，同一次询价中不能重复，用于标识返回询价结果和请求的映射关系。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户购买云服务产品的云服务类型，例如EC2，云服务类型为hws.service.type.ec2。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 用户购买云服务产品的资源类型，例如EC2中的VM，资源类型为hws.resource.type.vm。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 用户购买云服务产品的资源规格，例如VM的小型规格，资源规格为m1.tiny。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 资源容量度量标识。
        /// </summary>
        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// 使用量因子，按需计费必填，取值和话单中的使用量因子一致，云服务和使用量因子对应关系如下： - Duration：云服务器 - flow：流量
        /// </summary>
        [JsonProperty("usage_factor", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageFactor { get; set; }

        /// <summary>
        /// 使用量值，按需询价必填，例如按小时询价，使用量值为1，使用量单位为小时。
        /// </summary>
        [JsonProperty("usage_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? UsageValue { get; set; }

        /// <summary>
        /// 使用量单位标识，按需询价必填，例如按小时询价，使用量值为1，使用量单位为小时。 - 4：小时 - 10：GB - 11：MB - 13：Byte - 17：FLOW_GB
        /// </summary>
        [JsonProperty("usage_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageMeasureId { get; set; }

        /// <summary>
        /// 资源容量大小，例如购买的卷大小或带宽大小。
        /// </summary>
        [JsonProperty("resource_size_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSizeMeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  usageFactor: ").Append(UsageFactor).Append("\n");
            sb.Append("  usageValue: ").Append(UsageValue).Append("\n");
            sb.Append("  usageMeasureId: ").Append(UsageMeasureId).Append("\n");
            sb.Append("  resourceSizeMeasureId: ").Append(ResourceSizeMeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.UsageFactor == input.UsageFactor ||
                    (this.UsageFactor != null &&
                    this.UsageFactor.Equals(input.UsageFactor))
                ) && 
                (
                    this.UsageValue == input.UsageValue ||
                    (this.UsageValue != null &&
                    this.UsageValue.Equals(input.UsageValue))
                ) && 
                (
                    this.UsageMeasureId == input.UsageMeasureId ||
                    (this.UsageMeasureId != null &&
                    this.UsageMeasureId.Equals(input.UsageMeasureId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CloudServiceType != null)
                    hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ResourceSize != null)
                    hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.UsageFactor != null)
                    hashCode = hashCode * 59 + this.UsageFactor.GetHashCode();
                if (this.UsageValue != null)
                    hashCode = hashCode * 59 + this.UsageValue.GetHashCode();
                if (this.UsageMeasureId != null)
                    hashCode = hashCode * 59 + this.UsageMeasureId.GetHashCode();
                if (this.ResourceSizeMeasureId != null)
                    hashCode = hashCode * 59 + this.ResourceSizeMeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
