using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowFlowLogRequest 
    {

        /// <summary>
        /// 流日志资源唯一标识
        /// </summary>
        [SDKProperty("flowlog_id", IsPath = true)]
        [JsonProperty("flowlog_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlowlogId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFlowLogRequest {\n");
            sb.Append("  flowlogId: ").Append(FlowlogId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFlowLogRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFlowLogRequest input)
        {
            if (input == null) return false;
            if (this.FlowlogId != input.FlowlogId || (this.FlowlogId != null && !this.FlowlogId.Equals(input.FlowlogId))) return false;

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
                if (this.FlowlogId != null) hashCode = hashCode * 59 + this.FlowlogId.GetHashCode();
                return hashCode;
            }
        }
    }
}
