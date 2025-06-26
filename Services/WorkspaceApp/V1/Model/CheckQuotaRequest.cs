using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class CheckQuotaRequest 
    {

        /// <summary>
        /// 产品id。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 规格id。
        /// </summary>
        [SDKProperty("flavor_id", IsQuery = true)]
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 订单需要创建总实例数、订购数量。
        /// </summary>
        [SDKProperty("subscription_num", IsQuery = true)]
        [JsonProperty("subscription_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionNum { get; set; }

        /// <summary>
        /// 单台实例所需的磁盘大小（最大系统盘1块*1024、数据盘10块*32768）。
        /// </summary>
        [SDKProperty("disk_size", IsQuery = true)]
        [JsonProperty("disk_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskSize { get; set; }

        /// <summary>
        /// 单台实例所需的磁盘数量（最大系统盘1块、数据盘10块）。
        /// </summary>
        [SDKProperty("disk_num", IsQuery = true)]
        [JsonProperty("disk_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DiskNum { get; set; }

        /// <summary>
        /// 是否包周期。
        /// </summary>
        [SDKProperty("is_period", IsQuery = true)]
        [JsonProperty("is_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPeriod { get; set; }

        /// <summary>
        /// 主机id。
        /// </summary>
        [SDKProperty("deh_id", IsQuery = true)]
        [JsonProperty("deh_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DehId { get; set; }

        /// <summary>
        /// 云专属分布式存储池id。
        /// </summary>
        [SDKProperty("cluster_id", IsQuery = true)]
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckQuotaRequest {\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  subscriptionNum: ").Append(SubscriptionNum).Append("\n");
            sb.Append("  diskSize: ").Append(DiskSize).Append("\n");
            sb.Append("  diskNum: ").Append(DiskNum).Append("\n");
            sb.Append("  isPeriod: ").Append(IsPeriod).Append("\n");
            sb.Append("  dehId: ").Append(DehId).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckQuotaRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckQuotaRequest input)
        {
            if (input == null) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.SubscriptionNum != input.SubscriptionNum || (this.SubscriptionNum != null && !this.SubscriptionNum.Equals(input.SubscriptionNum))) return false;
            if (this.DiskSize != input.DiskSize || (this.DiskSize != null && !this.DiskSize.Equals(input.DiskSize))) return false;
            if (this.DiskNum != input.DiskNum || (this.DiskNum != null && !this.DiskNum.Equals(input.DiskNum))) return false;
            if (this.IsPeriod != input.IsPeriod || (this.IsPeriod != null && !this.IsPeriod.Equals(input.IsPeriod))) return false;
            if (this.DehId != input.DehId || (this.DehId != null && !this.DehId.Equals(input.DehId))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.SubscriptionNum != null) hashCode = hashCode * 59 + this.SubscriptionNum.GetHashCode();
                if (this.DiskSize != null) hashCode = hashCode * 59 + this.DiskSize.GetHashCode();
                if (this.DiskNum != null) hashCode = hashCode * 59 + this.DiskNum.GetHashCode();
                if (this.IsPeriod != null) hashCode = hashCode * 59 + this.IsPeriod.GetHashCode();
                if (this.DehId != null) hashCode = hashCode * 59 + this.DehId.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
