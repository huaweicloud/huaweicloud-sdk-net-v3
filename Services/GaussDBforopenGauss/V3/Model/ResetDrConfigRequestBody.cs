using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 重置容灾配置request信息。
    /// </summary>
    public class ResetDrConfigRequestBody 
    {

        /// <summary>
        /// 对端子网IP网段或者IP，多个以英文逗号分割。
        /// </summary>
        [JsonProperty("opposite_data_cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string OppositeDataCidr { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetDrConfigRequestBody {\n");
            sb.Append("  oppositeDataCidr: ").Append(OppositeDataCidr).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetDrConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetDrConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.OppositeDataCidr != input.OppositeDataCidr || (this.OppositeDataCidr != null && !this.OppositeDataCidr.Equals(input.OppositeDataCidr))) return false;

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
                if (this.OppositeDataCidr != null) hashCode = hashCode * 59 + this.OppositeDataCidr.GetHashCode();
                return hashCode;
            }
        }
    }
}
