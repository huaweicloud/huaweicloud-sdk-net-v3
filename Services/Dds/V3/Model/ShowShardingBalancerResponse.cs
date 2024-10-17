using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowShardingBalancerResponse : SdkResponse
    {

        /// <summary>
        /// 集群均衡是否打开。
        /// </summary>
        [JsonProperty("is_open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("active_window", NullValueHandling = NullValueHandling.Ignore)]
        public BalancerActiveWindow ActiveWindow { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowShardingBalancerResponse {\n");
            sb.Append("  isOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  activeWindow: ").Append(ActiveWindow).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowShardingBalancerResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowShardingBalancerResponse input)
        {
            if (input == null) return false;
            if (this.IsOpen != input.IsOpen || (this.IsOpen != null && !this.IsOpen.Equals(input.IsOpen))) return false;
            if (this.ActiveWindow != input.ActiveWindow || (this.ActiveWindow != null && !this.ActiveWindow.Equals(input.ActiveWindow))) return false;

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
                if (this.IsOpen != null) hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
                if (this.ActiveWindow != null) hashCode = hashCode * 59 + this.ActiveWindow.GetHashCode();
                return hashCode;
            }
        }
    }
}
