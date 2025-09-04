using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DemandProductInfo 
    {

        /// <summary>
        /// ID标识，同一次询价中不能重复，用于标识返回询价结果和请求的映射关系。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("cloud_service_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceType { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。 ResourceType是CloudServiceType中的一种资源，CloudServiceType由多种ResourceType组合提供。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务类型的资源规格，部分云服务类型和资源规格举例如下： 弹性云服务器：根据操作系统类型在云服务器规格的ID后添加“.win”或“.linux”，例如“s2.small.1.linux”。云服务器规格的ID字段，您可以调用查询规格详情和规格扩展信息列表接口获取。 带宽：12_bgp：动态BGP按流量计费带宽12_sbgp：静态BGP按流量计费带宽19_bgp：动态BGP按带宽计费带宽19_sbgp：静态BGP按带宽计费带宽19_share：按带宽计费共享带宽 IP：5_bgp：动态BGP公网IP5_sbgp：静态BGP公网IP 云硬盘：SATA：普通IO云硬盘SAS：高IO云硬盘GPSSD：通用型SSD云硬盘SSD：超高IO云硬盘
        /// </summary>
        [JsonProperty("resource_spec", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpec { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“ap-southeast-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 可用区标识。
        /// </summary>
        [JsonProperty("available_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableZone { get; set; }

        /// <summary>
        /// 资源容量大小，例如购买的卷大小或带宽大小。 线性产品时该参数不能为空。线性产品为包括硬盘，带宽等在订购时需要指定大小的产品。例如硬盘在订购时需选择10G、20G等不同大小。
        /// </summary>
        [JsonProperty("resource_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceSize { get; set; }

        /// <summary>
        /// 资源容量度量标识，枚举值如下： 15：Mbps（购买带宽时使用）17：GB（购买云硬盘时使用）14：个（次） 线性产品时该参数不能为空。线性产品为包括硬盘，带宽等在订购时需要指定大小的产品。例如硬盘在订购时需选择10G、20G等不同大小。
        /// </summary>
        [JsonProperty("size_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SizeMeasureId { get; set; }

        /// <summary>
        /// 使用量因子编码，取值和话单中的使用量因子一致，云服务和使用量因子对应关系举例如下： 云服务器：Duration云硬盘：Duration弹性IP：Duration带宽：Duration或upflow市场镜像：Duration 您可以调用查询使用量类型列表接口获取响应参数表3中参数code的取值，即每种云服务对应的计费因子。
        /// </summary>
        [JsonProperty("usage_factor", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageFactor { get; set; }

        /// <summary>
        /// 使用量值。 例如按小时询价，使用量值为1，使用量单位为小时。
        /// </summary>
        [JsonProperty("usage_value", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? UsageValue { get; set; }

        /// <summary>
        /// 使用量度量单位，您可以调用查询度量单位列表接口获取。 例如按小时询价，使用量值为1，使用量单位为小时。
        /// </summary>
        [JsonProperty("usage_measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsageMeasureId { get; set; }

        /// <summary>
        /// 订购数量。
        /// </summary>
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemandProductInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  cloudServiceType: ").Append(CloudServiceType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceSpec: ").Append(ResourceSpec).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  availableZone: ").Append(AvailableZone).Append("\n");
            sb.Append("  resourceSize: ").Append(ResourceSize).Append("\n");
            sb.Append("  sizeMeasureId: ").Append(SizeMeasureId).Append("\n");
            sb.Append("  usageFactor: ").Append(UsageFactor).Append("\n");
            sb.Append("  usageValue: ").Append(UsageValue).Append("\n");
            sb.Append("  usageMeasureId: ").Append(UsageMeasureId).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DemandProductInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DemandProductInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CloudServiceType != input.CloudServiceType || (this.CloudServiceType != null && !this.CloudServiceType.Equals(input.CloudServiceType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceSpec != input.ResourceSpec || (this.ResourceSpec != null && !this.ResourceSpec.Equals(input.ResourceSpec))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.AvailableZone != input.AvailableZone || (this.AvailableZone != null && !this.AvailableZone.Equals(input.AvailableZone))) return false;
            if (this.ResourceSize != input.ResourceSize || (this.ResourceSize != null && !this.ResourceSize.Equals(input.ResourceSize))) return false;
            if (this.SizeMeasureId != input.SizeMeasureId || (this.SizeMeasureId != null && !this.SizeMeasureId.Equals(input.SizeMeasureId))) return false;
            if (this.UsageFactor != input.UsageFactor || (this.UsageFactor != null && !this.UsageFactor.Equals(input.UsageFactor))) return false;
            if (this.UsageValue != input.UsageValue || (this.UsageValue != null && !this.UsageValue.Equals(input.UsageValue))) return false;
            if (this.UsageMeasureId != input.UsageMeasureId || (this.UsageMeasureId != null && !this.UsageMeasureId.Equals(input.UsageMeasureId))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;

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
                if (this.CloudServiceType != null) hashCode = hashCode * 59 + this.CloudServiceType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceSpec != null) hashCode = hashCode * 59 + this.ResourceSpec.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.AvailableZone != null) hashCode = hashCode * 59 + this.AvailableZone.GetHashCode();
                if (this.ResourceSize != null) hashCode = hashCode * 59 + this.ResourceSize.GetHashCode();
                if (this.SizeMeasureId != null) hashCode = hashCode * 59 + this.SizeMeasureId.GetHashCode();
                if (this.UsageFactor != null) hashCode = hashCode * 59 + this.UsageFactor.GetHashCode();
                if (this.UsageValue != null) hashCode = hashCode * 59 + this.UsageValue.GetHashCode();
                if (this.UsageMeasureId != null) hashCode = hashCode * 59 + this.UsageMeasureId.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
