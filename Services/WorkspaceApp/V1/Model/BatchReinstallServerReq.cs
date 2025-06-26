using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 批量重建服务器的请求体。
    /// </summary>
    public class BatchReinstallServerReq 
    {

        /// <summary>
        /// 应用服务器id集合。
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// 是否自动升级hda版本。
        /// </summary>
        [JsonProperty("update_access_agent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateAccessAgent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchReinstallServerReq {\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("  updateAccessAgent: ").Append(UpdateAccessAgent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchReinstallServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchReinstallServerReq input)
        {
            if (input == null) return false;
            if (this.ServerIds != input.ServerIds || (this.ServerIds != null && input.ServerIds != null && !this.ServerIds.SequenceEqual(input.ServerIds))) return false;
            if (this.UpdateAccessAgent != input.UpdateAccessAgent || (this.UpdateAccessAgent != null && !this.UpdateAccessAgent.Equals(input.UpdateAccessAgent))) return false;

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
                if (this.UpdateAccessAgent != null) hashCode = hashCode * 59 + this.UpdateAccessAgent.GetHashCode();
                return hashCode;
            }
        }
    }
}
