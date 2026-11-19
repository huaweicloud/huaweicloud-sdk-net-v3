using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowKillProcessTaskResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**  Kill会话任务列表。
        /// </summary>
        [JsonProperty("processes", NullValueHandling = NullValueHandling.Ignore)]
        public List<KillProcessItem> Processes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKillProcessTaskResponse {\n");
            sb.Append("  processes: ").Append(Processes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKillProcessTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKillProcessTaskResponse input)
        {
            if (input == null) return false;
            if (this.Processes != input.Processes || (this.Processes != null && input.Processes != null && !this.Processes.SequenceEqual(input.Processes))) return false;

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
                if (this.Processes != null) hashCode = hashCode * 59 + this.Processes.GetHashCode();
                return hashCode;
            }
        }
    }
}
