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
    /// 节点池扩容时覆盖节点的默认计费模式配置
    /// </summary>
    public class ScaleUpBillingConfigOverride 
    {

        /// <summary>
        /// 节点计费类型，0(按需)，1(包周期)
        /// </summary>
        [JsonProperty("billingMode", NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleUpExtendParam ExtendParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleUpBillingConfigOverride {\n");
            sb.Append("  billingMode: ").Append(BillingMode).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleUpBillingConfigOverride);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleUpBillingConfigOverride input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingMode == input.BillingMode ||
                    (this.BillingMode != null &&
                    this.BillingMode.Equals(input.BillingMode))
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
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
                if (this.BillingMode != null)
                    hashCode = hashCode * 59 + this.BillingMode.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
