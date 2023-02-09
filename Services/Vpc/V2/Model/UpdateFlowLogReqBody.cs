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
    public class UpdateFlowLogReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flow_log", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateFlowLogReq FlowLog { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFlowLogReqBody {\n");
            sb.Append("  flowLog: ").Append(FlowLog).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFlowLogReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFlowLogReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FlowLog == input.FlowLog ||
                    (this.FlowLog != null &&
                    this.FlowLog.Equals(input.FlowLog))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FlowLog != null)
                    hashCode = hashCode * 59 + this.FlowLog.GetHashCode();
                return hashCode;
            }
        }
    }
}
