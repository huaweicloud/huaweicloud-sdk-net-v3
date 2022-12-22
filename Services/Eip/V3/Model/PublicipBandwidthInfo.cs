using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 公网IP绑定的带宽信息
    /// </summary>
    public class PublicipBandwidthInfo 
    {

        /// <summary>
        /// 带宽ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能描述：带宽大小 取值范围：默认5Mbit/s~2000Mbit/s
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 功能说明：带宽类型,标识是否是共享带宽 取值范围：PER，WHOLE。   PER：独享带宽   WHOLE：共享带宽 约束：其中IPv6暂不支持WHOLE类型带宽。
        /// </summary>
        [JsonProperty("share_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareType { get; set; }

        /// <summary>
        /// 功能说明：按流量计费还是按带宽计费 取值范围： bandwidth：按带宽计费 traffic：按流量计费 95peak_plus：按增强型95计费
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 功能说明：带宽名称 取值范围：1-64个字符,支持数字、字母、中文、_(下划线)、-(中划线)、.(点)
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：账单信息。如果billinginfo不为空，说明是包周期的带宽
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicipBandwidthInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  shareType: ").Append(ShareType).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicipBandwidthInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicipBandwidthInfo input)
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
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ShareType == input.ShareType ||
                    (this.ShareType != null &&
                    this.ShareType.Equals(input.ShareType))
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ShareType != null)
                    hashCode = hashCode * 59 + this.ShareType.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
