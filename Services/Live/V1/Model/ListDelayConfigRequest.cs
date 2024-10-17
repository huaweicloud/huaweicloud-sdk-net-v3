using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDelayConfigRequest 
    {

        /// <summary>
        /// 播放域名
        /// </summary>
        [SDKProperty("play_domain", IsQuery = true)]
        [JsonProperty("play_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDelayConfigRequest {\n");
            sb.Append("  playDomain: ").Append(PlayDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDelayConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDelayConfigRequest input)
        {
            if (input == null) return false;
            if (this.PlayDomain != input.PlayDomain || (this.PlayDomain != null && !this.PlayDomain.Equals(input.PlayDomain))) return false;

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
                if (this.PlayDomain != null) hashCode = hashCode * 59 + this.PlayDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
