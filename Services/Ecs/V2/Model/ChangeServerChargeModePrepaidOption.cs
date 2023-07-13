using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ChangeServerChargeModePrepaidOption 
    {

        /// <summary>
        /// 是否连同支持的按需数据盘一起转为包周期。 当参数为true，包括按需非共享的数据盘，不包括共享云硬盘，DSS和DESS硬盘 默认值为false
        /// </summary>
        [JsonProperty("include_data_disks", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// 是否连同弹性公网IP一起转为包周期 只有“独享”、“按带宽计费”的弹性公网IP才可以转换为包周期计费模式 默认值为false
        /// </summary>
        [JsonProperty("include_publicips", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludePublicips { get; set; }

        /// <summary>
        /// 订购周期类型，取值范围： month-月 year-年
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 订购周期的周期数。 取值范围： period_type&#x3D;month时，取值范围为[1,9]。 period_type&#x3D;year时，取值范围为[1,3]。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodNum { get; set; }

        /// <summary>
        /// 是否自动支付。 true：自动支付，需要确保账户余额充足，如果余额不足则会生成异常订单，只能作废此订单 false：只生成订单不扣费 默认值为false
        /// </summary>
        [JsonProperty("auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// 是否自动续费。默认值：false
        /// </summary>
        [JsonProperty("auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRenew { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeServerChargeModePrepaidOption {\n");
            sb.Append("  includeDataDisks: ").Append(IncludeDataDisks).Append("\n");
            sb.Append("  includePublicips: ").Append(IncludePublicips).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  autoPay: ").Append(AutoPay).Append("\n");
            sb.Append("  autoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeServerChargeModePrepaidOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeServerChargeModePrepaidOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeDataDisks == input.IncludeDataDisks ||
                    (this.IncludeDataDisks != null &&
                    this.IncludeDataDisks.Equals(input.IncludeDataDisks))
                ) && 
                (
                    this.IncludePublicips == input.IncludePublicips ||
                    (this.IncludePublicips != null &&
                    this.IncludePublicips.Equals(input.IncludePublicips))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.AutoPay == input.AutoPay ||
                    (this.AutoPay != null &&
                    this.AutoPay.Equals(input.AutoPay))
                ) && 
                (
                    this.AutoRenew == input.AutoRenew ||
                    (this.AutoRenew != null &&
                    this.AutoRenew.Equals(input.AutoRenew))
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
                if (this.IncludeDataDisks != null)
                    hashCode = hashCode * 59 + this.IncludeDataDisks.GetHashCode();
                if (this.IncludePublicips != null)
                    hashCode = hashCode * 59 + this.IncludePublicips.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.AutoPay != null)
                    hashCode = hashCode * 59 + this.AutoPay.GetHashCode();
                if (this.AutoRenew != null)
                    hashCode = hashCode * 59 + this.AutoRenew.GetHashCode();
                return hashCode;
            }
        }
    }
}
