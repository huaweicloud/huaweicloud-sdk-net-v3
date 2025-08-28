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
    /// 
    /// </summary>
    public class KillProcessesOpenRequest 
    {

        /// <summary>
        /// 会话id集合
        /// </summary>
        [JsonProperty("process_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProcessIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KillProcessesOpenRequest {\n");
            sb.Append("  processIds: ").Append(ProcessIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KillProcessesOpenRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KillProcessesOpenRequest input)
        {
            if (input == null) return false;
            if (this.ProcessIds != input.ProcessIds || (this.ProcessIds != null && input.ProcessIds != null && !this.ProcessIds.SequenceEqual(input.ProcessIds))) return false;

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
                if (this.ProcessIds != null) hashCode = hashCode * 59 + this.ProcessIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
