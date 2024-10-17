using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// RDS实例按需转包周期请求
    /// </summary>
    public class ToPeriodReq 
    {

        /// <summary>
        /// 周期类型。MONTH：月；YEAR：年
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 周期数。
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 是否自动支付。YES：自动扣费；NO：手动支付（默认）
        /// </summary>
        [JsonProperty("auto_pay_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoPayPolicy { get; set; }

        /// <summary>
        /// 是否到期自动续期。YES：自动续费；NO：不自动续费（默认）
        /// </summary>
        [JsonProperty("auto_renew_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoRenewPolicy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ToPeriodReq {\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  autoPayPolicy: ").Append(AutoPayPolicy).Append("\n");
            sb.Append("  autoRenewPolicy: ").Append(AutoRenewPolicy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ToPeriodReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ToPeriodReq input)
        {
            if (input == null) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && !this.PeriodNum.Equals(input.PeriodNum))) return false;
            if (this.AutoPayPolicy != input.AutoPayPolicy || (this.AutoPayPolicy != null && !this.AutoPayPolicy.Equals(input.AutoPayPolicy))) return false;
            if (this.AutoRenewPolicy != input.AutoRenewPolicy || (this.AutoRenewPolicy != null && !this.AutoRenewPolicy.Equals(input.AutoRenewPolicy))) return false;

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
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.AutoPayPolicy != null) hashCode = hashCode * 59 + this.AutoPayPolicy.GetHashCode();
                if (this.AutoRenewPolicy != null) hashCode = hashCode * 59 + this.AutoRenewPolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
