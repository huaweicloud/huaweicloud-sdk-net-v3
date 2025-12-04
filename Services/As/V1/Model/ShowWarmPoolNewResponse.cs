using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowWarmPoolNewResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("warm_pool", NullValueHandling = NullValueHandling.Ignore)]
        public WarmPoolInfo WarmPool { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowWarmPoolNewResponse {\n");
            sb.Append("  warmPool: ").Append(WarmPool).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowWarmPoolNewResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowWarmPoolNewResponse input)
        {
            if (input == null) return false;
            if (this.WarmPool != input.WarmPool || (this.WarmPool != null && !this.WarmPool.Equals(input.WarmPool))) return false;

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
                if (this.WarmPool != null) hashCode = hashCode * 59 + this.WarmPool.GetHashCode();
                return hashCode;
            }
        }
    }
}
