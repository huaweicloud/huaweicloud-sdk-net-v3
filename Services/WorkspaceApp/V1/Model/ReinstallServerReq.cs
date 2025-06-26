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
    /// 重建服务器的请求体。
    /// </summary>
    public class ReinstallServerReq 
    {

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
            sb.Append("class ReinstallServerReq {\n");
            sb.Append("  updateAccessAgent: ").Append(UpdateAccessAgent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallServerReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallServerReq input)
        {
            if (input == null) return false;
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
                if (this.UpdateAccessAgent != null) hashCode = hashCode * 59 + this.UpdateAccessAgent.GetHashCode();
                return hashCode;
            }
        }
    }
}
