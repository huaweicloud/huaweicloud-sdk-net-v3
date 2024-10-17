using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowHighRiskCommandsResponse : SdkResponse
    {

        /// <summary>
        /// 高危命令与对应重命名命令。
        /// </summary>
        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public List<CommandInfo> Commands { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowHighRiskCommandsResponse {\n");
            sb.Append("  commands: ").Append(Commands).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowHighRiskCommandsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowHighRiskCommandsResponse input)
        {
            if (input == null) return false;
            if (this.Commands != input.Commands || (this.Commands != null && input.Commands != null && !this.Commands.SequenceEqual(input.Commands))) return false;

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
                if (this.Commands != null) hashCode = hashCode * 59 + this.Commands.GetHashCode();
                return hashCode;
            }
        }
    }
}
