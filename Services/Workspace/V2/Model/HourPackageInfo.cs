using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面小时包详情。
    /// </summary>
    public class HourPackageInfo 
    {

        /// <summary>
        /// 小时包根订单ID。
        /// </summary>
        [JsonProperty("root_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootOrderId { get; set; }

        /// <summary>
        /// 小时包资源ID。
        /// </summary>
        [JsonProperty("package_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageResourceId { get; set; }

        /// <summary>
        /// 小时包实例ID。
        /// </summary>
        [JsonProperty("package_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageInstanceId { get; set; }

        /// <summary>
        /// 小时包specCode。
        /// </summary>
        [JsonProperty("package_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageSpecCode { get; set; }

        /// <summary>
        /// 组合商品resourceTypeCode。
        /// </summary>
        [JsonProperty("combined_product_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CombinedProductTypeCode { get; set; }

        /// <summary>
        /// 小时包用完策略：SHUTDOWN_OR_HIBERNATE：自动关机/休眠；PAY_PER_USE：自动按需计费。
        /// </summary>
        [JsonProperty("use_up_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string UseUpPolicy { get; set; }

        /// <summary>
        /// 小时包总时长。
        /// </summary>
        [JsonProperty("package_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? PackageDuration { get; set; }

        /// <summary>
        /// 小时包已用时长。
        /// </summary>
        [JsonProperty("use_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? UseDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HourPackageInfo {\n");
            sb.Append("  rootOrderId: ").Append(RootOrderId).Append("\n");
            sb.Append("  packageResourceId: ").Append(PackageResourceId).Append("\n");
            sb.Append("  packageInstanceId: ").Append(PackageInstanceId).Append("\n");
            sb.Append("  packageSpecCode: ").Append(PackageSpecCode).Append("\n");
            sb.Append("  combinedProductTypeCode: ").Append(CombinedProductTypeCode).Append("\n");
            sb.Append("  useUpPolicy: ").Append(UseUpPolicy).Append("\n");
            sb.Append("  packageDuration: ").Append(PackageDuration).Append("\n");
            sb.Append("  useDuration: ").Append(UseDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HourPackageInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HourPackageInfo input)
        {
            if (input == null) return false;
            if (this.RootOrderId != input.RootOrderId || (this.RootOrderId != null && !this.RootOrderId.Equals(input.RootOrderId))) return false;
            if (this.PackageResourceId != input.PackageResourceId || (this.PackageResourceId != null && !this.PackageResourceId.Equals(input.PackageResourceId))) return false;
            if (this.PackageInstanceId != input.PackageInstanceId || (this.PackageInstanceId != null && !this.PackageInstanceId.Equals(input.PackageInstanceId))) return false;
            if (this.PackageSpecCode != input.PackageSpecCode || (this.PackageSpecCode != null && !this.PackageSpecCode.Equals(input.PackageSpecCode))) return false;
            if (this.CombinedProductTypeCode != input.CombinedProductTypeCode || (this.CombinedProductTypeCode != null && !this.CombinedProductTypeCode.Equals(input.CombinedProductTypeCode))) return false;
            if (this.UseUpPolicy != input.UseUpPolicy || (this.UseUpPolicy != null && !this.UseUpPolicy.Equals(input.UseUpPolicy))) return false;
            if (this.PackageDuration != input.PackageDuration || (this.PackageDuration != null && !this.PackageDuration.Equals(input.PackageDuration))) return false;
            if (this.UseDuration != input.UseDuration || (this.UseDuration != null && !this.UseDuration.Equals(input.UseDuration))) return false;

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
                if (this.RootOrderId != null) hashCode = hashCode * 59 + this.RootOrderId.GetHashCode();
                if (this.PackageResourceId != null) hashCode = hashCode * 59 + this.PackageResourceId.GetHashCode();
                if (this.PackageInstanceId != null) hashCode = hashCode * 59 + this.PackageInstanceId.GetHashCode();
                if (this.PackageSpecCode != null) hashCode = hashCode * 59 + this.PackageSpecCode.GetHashCode();
                if (this.CombinedProductTypeCode != null) hashCode = hashCode * 59 + this.CombinedProductTypeCode.GetHashCode();
                if (this.UseUpPolicy != null) hashCode = hashCode * 59 + this.UseUpPolicy.GetHashCode();
                if (this.PackageDuration != null) hashCode = hashCode * 59 + this.PackageDuration.GetHashCode();
                if (this.UseDuration != null) hashCode = hashCode * 59 + this.UseDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
