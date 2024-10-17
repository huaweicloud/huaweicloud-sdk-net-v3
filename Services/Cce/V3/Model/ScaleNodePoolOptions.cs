using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 节点池伸缩选项配置
    /// </summary>
    public class ScaleNodePoolOptions 
    {

        /// <summary>
        /// 扩容状态检查策略: instant(同步检查), async(异步检查)。默认同步检查instant 
        /// </summary>
        [JsonProperty("scalableChecking", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalableChecking { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("billingConfigOverride", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleUpBillingConfigOverride BillingConfigOverride { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleNodePoolOptions {\n");
            sb.Append("  scalableChecking: ").Append(ScalableChecking).Append("\n");
            sb.Append("  billingConfigOverride: ").Append(BillingConfigOverride).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleNodePoolOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleNodePoolOptions input)
        {
            if (input == null) return false;
            if (this.ScalableChecking != input.ScalableChecking || (this.ScalableChecking != null && !this.ScalableChecking.Equals(input.ScalableChecking))) return false;
            if (this.BillingConfigOverride != input.BillingConfigOverride || (this.BillingConfigOverride != null && !this.BillingConfigOverride.Equals(input.BillingConfigOverride))) return false;

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
                if (this.ScalableChecking != null) hashCode = hashCode * 59 + this.ScalableChecking.GetHashCode();
                if (this.BillingConfigOverride != null) hashCode = hashCode * 59 + this.BillingConfigOverride.GetHashCode();
                return hashCode;
            }
        }
    }
}
