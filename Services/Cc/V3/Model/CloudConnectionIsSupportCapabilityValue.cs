using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 是否支持云连接能力。
    /// </summary>
    public class CloudConnectionIsSupportCapabilityValue 
    {

        /// <summary>
        /// 是否支持云连接能力。
        /// </summary>
        [JsonProperty("is_support", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupport { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudConnectionIsSupportCapabilityValue {\n");
            sb.Append("  isSupport: ").Append(IsSupport).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudConnectionIsSupportCapabilityValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudConnectionIsSupportCapabilityValue input)
        {
            if (input == null) return false;
            if (this.IsSupport != input.IsSupport || (this.IsSupport != null && !this.IsSupport.Equals(input.IsSupport))) return false;

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
                if (this.IsSupport != null) hashCode = hashCode * 59 + this.IsSupport.GetHashCode();
                return hashCode;
            }
        }
    }
}
