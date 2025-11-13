using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteServerGroupMemberReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteServerGroupMemberReq {\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteServerGroupMemberReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteServerGroupMemberReq input)
        {
            if (input == null) return false;
            if (this.ServerIds != input.ServerIds || (this.ServerIds != null && input.ServerIds != null && !this.ServerIds.SequenceEqual(input.ServerIds))) return false;

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
                if (this.ServerIds != null) hashCode = hashCode * 59 + this.ServerIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
