using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAvalibleRdsResponse : SdkResponse
    {

        /// <summary>
        /// 可用目标DN。
        /// </summary>
        [JsonProperty("target_data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetDn4Restore> TargetDataNodes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAvalibleRdsResponse {\n");
            sb.Append("  targetDataNodes: ").Append(TargetDataNodes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAvalibleRdsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAvalibleRdsResponse input)
        {
            if (input == null) return false;
            if (this.TargetDataNodes != input.TargetDataNodes || (this.TargetDataNodes != null && input.TargetDataNodes != null && !this.TargetDataNodes.SequenceEqual(input.TargetDataNodes))) return false;

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
                if (this.TargetDataNodes != null) hashCode = hashCode * 59 + this.TargetDataNodes.GetHashCode();
                return hashCode;
            }
        }
    }
}
