using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerOnDemandResource 
    {

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 所属可用区的编码。
        /// </summary>
        [JsonProperty("availability_zone_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneCode { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 资源类型名称。例如ECS的资源类型名称为“云主机”。
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源实例名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 生效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如“2019-05-06T08:05:01Z”。 其中，HH范围是0～23，mm和ss范围是0～59。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 资源状态： 1：正常（已开通）2：宽限期3：冻结中4：变更中5：正在关闭6：已关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 云服务产品的资源规格。如果是VM的资源规格，则需要在规格后面添加“.win”或“.linux”，例如“s2.small.1.linux”。
        /// </summary>
        [JsonProperty("resource_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 按需资源的容量大小。 格式如：\&quot;resourceInfo\&quot;: \&quot;{\\\&quot;specSize\\\&quot;:40.0}\&quot;
        /// </summary>
        [JsonProperty("resource_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceInfo { get; set; }

        /// <summary>
        /// 产品规格描述。例如： 虚拟机：“通用计算增强型|c6.2xlarge.4|8vCPUs|32GB|linux”硬盘：“云硬盘_SATA_LXH01|40.0GB”
        /// </summary>
        [JsonProperty("product_spec_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductSpecDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerOnDemandResource {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  availabilityZoneCode: ").Append(AvailabilityZoneCode).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  resourceInfo: ").Append(ResourceInfo).Append("\n");
            sb.Append("  productSpecDesc: ").Append(ProductSpecDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomerOnDemandResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomerOnDemandResource input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.AvailabilityZoneCode != input.AvailabilityZoneCode || (this.AvailabilityZoneCode != null && !this.AvailabilityZoneCode.Equals(input.AvailabilityZoneCode))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ResourceSpecCode != input.ResourceSpecCode || (this.ResourceSpecCode != null && !this.ResourceSpecCode.Equals(input.ResourceSpecCode))) return false;
            if (this.ResourceInfo != input.ResourceInfo || (this.ResourceInfo != null && !this.ResourceInfo.Equals(input.ResourceInfo))) return false;
            if (this.ProductSpecDesc != input.ProductSpecDesc || (this.ProductSpecDesc != null && !this.ProductSpecDesc.Equals(input.ProductSpecDesc))) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.AvailabilityZoneCode != null) hashCode = hashCode * 59 + this.AvailabilityZoneCode.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ResourceSpecCode != null) hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ResourceInfo != null) hashCode = hashCode * 59 + this.ResourceInfo.GetHashCode();
                if (this.ProductSpecDesc != null) hashCode = hashCode * 59 + this.ProductSpecDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
