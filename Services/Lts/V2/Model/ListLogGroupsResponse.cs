using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListLogGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 日志组信息。
        /// </summary>
        [JsonProperty("log_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogGroup> LogGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogGroupsResponse {\n");
            sb.Append("  logGroups: ").Append(LogGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogGroupsResponse input)
        {
            if (input == null) return false;
            if (this.LogGroups != input.LogGroups || (this.LogGroups != null && input.LogGroups != null && !this.LogGroups.SequenceEqual(input.LogGroups))) return false;

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
                if (this.LogGroups != null) hashCode = hashCode * 59 + this.LogGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
