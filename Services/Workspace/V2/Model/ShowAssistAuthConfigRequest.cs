using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAssistAuthConfigRequest 
    {

        /// <summary>
        /// 主认证配置id
        /// </summary>
        [SDKProperty("main_auth_config_id", IsQuery = true)]
        [JsonProperty("main_auth_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MainAuthConfigId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAssistAuthConfigRequest {\n");
            sb.Append("  mainAuthConfigId: ").Append(MainAuthConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssistAuthConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssistAuthConfigRequest input)
        {
            if (input == null) return false;
            if (this.MainAuthConfigId != input.MainAuthConfigId || (this.MainAuthConfigId != null && !this.MainAuthConfigId.Equals(input.MainAuthConfigId))) return false;

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
                if (this.MainAuthConfigId != null) hashCode = hashCode * 59 + this.MainAuthConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
