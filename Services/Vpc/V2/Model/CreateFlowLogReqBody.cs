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
    /// 
    /// </summary>
    public class CreateFlowLogReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flow_log", NullValueHandling = NullValueHandling.Ignore)]
        public CreateFlowLogReq FlowLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFlowLogReqBody {\n");
            sb.Append("  flowLog: ").Append(FlowLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFlowLogReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFlowLogReqBody input)
        {
            if (input == null) return false;
            if (this.FlowLog != input.FlowLog || (this.FlowLog != null && !this.FlowLog.Equals(input.FlowLog))) return false;

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
                if (this.FlowLog != null) hashCode = hashCode * 59 + this.FlowLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
