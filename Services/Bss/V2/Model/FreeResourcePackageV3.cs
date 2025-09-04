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
    public class FreeResourcePackageV3 
    {

        /// <summary>
        /// 订购资源包产品后，系统生成的ID，是这个资源包列表的标识字段。
        /// </summary>
        [JsonProperty("order_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderInstanceId { get; set; }

        /// <summary>
        /// 订单ID，如果source_type为“1：软开云赠送”，该字段为空。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 产品ID，即资源包ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品名称，即资源包名称。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目应用范围： 0：应用所有1：应用到具体企业项目
        /// </summary>
        [JsonProperty("enterprise_project_scope", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnterpriseProjectScope { get; set; }

        /// <summary>
        /// 生效时间，购买资源包的时间，格式UTC。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 失效时间，资源包到期时间，格式UTC。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 状态： 0：未生效1：生效中2：已用完3：已失效4：已退订
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“cn-north-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 资源包的来源类型： 0：订单1：软开云赠送
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceType { get; set; }

        /// <summary>
        /// 套餐绑定类型： ATOMIC_PKG：原子套餐BUNDLE_PKG：组合套餐
        /// </summary>
        [JsonProperty("bundle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BundleType { get; set; }

        /// <summary>
        /// 使用模式。 1：可重置表示购买的资源包能够按照一定的周期恢复使用量。例如购买一个1年的按需资源包，使用量是40G，可重置，重置周期为1个月，表示1年内每个月会给予40G的使用量。 2：不可重置表示购买的资源包的使用量不会恢复。例如购买一个1年的按需资源包，使用量是40G，不可重置，表示1年内一共给予40G的使用量。
        /// </summary>
        [JsonProperty("quota_reuse_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotaReuseMode { get; set; }

        /// <summary>
        /// 资源套餐内的资源项信息（资源项ID级的详情），具体参见表3。
        /// </summary>
        [JsonProperty("free_resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<FreeResourceV3> FreeResources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeResourcePackageV3 {\n");
            sb.Append("  orderInstanceId: ").Append(OrderInstanceId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectScope: ").Append(EnterpriseProjectScope).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  bundleType: ").Append(BundleType).Append("\n");
            sb.Append("  quotaReuseMode: ").Append(QuotaReuseMode).Append("\n");
            sb.Append("  freeResources: ").Append(FreeResources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FreeResourcePackageV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FreeResourcePackageV3 input)
        {
            if (input == null) return false;
            if (this.OrderInstanceId != input.OrderInstanceId || (this.OrderInstanceId != null && !this.OrderInstanceId.Equals(input.OrderInstanceId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectScope != input.EnterpriseProjectScope || (this.EnterpriseProjectScope != null && !this.EnterpriseProjectScope.Equals(input.EnterpriseProjectScope))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.SourceType != input.SourceType || (this.SourceType != null && !this.SourceType.Equals(input.SourceType))) return false;
            if (this.BundleType != input.BundleType || (this.BundleType != null && !this.BundleType.Equals(input.BundleType))) return false;
            if (this.QuotaReuseMode != input.QuotaReuseMode || (this.QuotaReuseMode != null && !this.QuotaReuseMode.Equals(input.QuotaReuseMode))) return false;
            if (this.FreeResources != input.FreeResources || (this.FreeResources != null && input.FreeResources != null && !this.FreeResources.SequenceEqual(input.FreeResources))) return false;

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
                if (this.OrderInstanceId != null) hashCode = hashCode * 59 + this.OrderInstanceId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectScope != null) hashCode = hashCode * 59 + this.EnterpriseProjectScope.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.SourceType != null) hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.BundleType != null) hashCode = hashCode * 59 + this.BundleType.GetHashCode();
                if (this.QuotaReuseMode != null) hashCode = hashCode * 59 + this.QuotaReuseMode.GetHashCode();
                if (this.FreeResources != null) hashCode = hashCode * 59 + this.FreeResources.GetHashCode();
                return hashCode;
            }
        }
    }
}
