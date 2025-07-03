using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DeleteAgentResponse : SdkResponse
    {

        /// <summary>
        /// 删除状态。
        /// </summary>
        [JsonProperty("delete_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeleteStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAgentResponse {\n");
            sb.Append("  deleteStatus: ").Append(DeleteStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAgentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAgentResponse input)
        {
            if (input == null) return false;
            if (this.DeleteStatus != input.DeleteStatus || (this.DeleteStatus != null && !this.DeleteStatus.Equals(input.DeleteStatus))) return false;

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
                if (this.DeleteStatus != null) hashCode = hashCode * 59 + this.DeleteStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
