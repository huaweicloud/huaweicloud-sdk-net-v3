using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 修改激活码请求。
    /// </summary>
    public class UpdateActiveCodeReq 
    {

        /// <summary>
        /// 有效天数（0表示长期有效）。
        /// </summary>
        [JsonProperty("valid_period", NullValueHandling = NullValueHandling.Ignore)]
        public int? ValidPeriod { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateActiveCodeReq {\n");
            sb.Append("  validPeriod: ").Append(ValidPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateActiveCodeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateActiveCodeReq input)
        {
            if (input == null) return false;
            if (this.ValidPeriod != input.ValidPeriod || (this.ValidPeriod != null && !this.ValidPeriod.Equals(input.ValidPeriod))) return false;

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
                if (this.ValidPeriod != null) hashCode = hashCode * 59 + this.ValidPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}
