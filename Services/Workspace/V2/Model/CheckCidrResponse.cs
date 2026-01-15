using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckCidrResponse : SdkResponse
    {

        /// <summary>
        /// 规划的冲突网段
        /// </summary>
        [JsonProperty("manage_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ManageCidrs { get; set; }

        /// <summary>
        /// 租户网段与冲突网段的重叠部分
        /// </summary>
        [JsonProperty("conflict_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConflictCidrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckCidrResponse {\n");
            sb.Append("  manageCidrs: ").Append(ManageCidrs).Append("\n");
            sb.Append("  conflictCidrs: ").Append(ConflictCidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckCidrResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckCidrResponse input)
        {
            if (input == null) return false;
            if (this.ManageCidrs != input.ManageCidrs || (this.ManageCidrs != null && input.ManageCidrs != null && !this.ManageCidrs.SequenceEqual(input.ManageCidrs))) return false;
            if (this.ConflictCidrs != input.ConflictCidrs || (this.ConflictCidrs != null && input.ConflictCidrs != null && !this.ConflictCidrs.SequenceEqual(input.ConflictCidrs))) return false;

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
                if (this.ManageCidrs != null) hashCode = hashCode * 59 + this.ManageCidrs.GetHashCode();
                if (this.ConflictCidrs != null) hashCode = hashCode * 59 + this.ConflictCidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
