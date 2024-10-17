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
    public class ShowUpgradeDurationResponse : SdkResponse
    {

        /// <summary>
        /// 升级策略列表
        /// </summary>
        [JsonProperty("strategies", NullValueHandling = NullValueHandling.Ignore)]
        public List<DurationStrategies> Strategies { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUpgradeDurationResponse {\n");
            sb.Append("  strategies: ").Append(Strategies).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUpgradeDurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUpgradeDurationResponse input)
        {
            if (input == null) return false;
            if (this.Strategies != input.Strategies || (this.Strategies != null && input.Strategies != null && !this.Strategies.SequenceEqual(input.Strategies))) return false;

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
                if (this.Strategies != null) hashCode = hashCode * 59 + this.Strategies.GetHashCode();
                return hashCode;
            }
        }
    }
}
