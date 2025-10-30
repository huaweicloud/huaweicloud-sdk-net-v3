using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudPond.V2.Model
{
    /// <summary>
    /// 销售周期信息
    /// </summary>
    public class SaleCycleOption 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pay_mode", NullValueHandling = NullValueHandling.Ignore)]
        public PayMode? PayMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodType? PeriodType { get; set; }

        /// <summary>
        /// 销售周期取值
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> PeriodNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaleCycleOption {\n");
            sb.Append("  payMode: ").Append(PayMode).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaleCycleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SaleCycleOption input)
        {
            if (input == null) return false;
            if (this.PayMode != input.PayMode || (this.PayMode != null && !this.PayMode.Equals(input.PayMode))) return false;
            if (this.PeriodType != input.PeriodType || (this.PeriodType != null && !this.PeriodType.Equals(input.PeriodType))) return false;
            if (this.PeriodNum != input.PeriodNum || (this.PeriodNum != null && input.PeriodNum != null && !this.PeriodNum.SequenceEqual(input.PeriodNum))) return false;

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
                if (this.PayMode != null) hashCode = hashCode * 59 + this.PayMode.GetHashCode();
                if (this.PeriodType != null) hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null) hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
