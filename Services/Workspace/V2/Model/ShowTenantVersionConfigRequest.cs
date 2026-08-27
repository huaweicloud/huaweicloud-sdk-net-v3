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
    public class ShowTenantVersionConfigRequest 
    {

        /// <summary>
        /// 版本配置ID
        /// </summary>
        [SDKProperty("version_config_id", IsPath = true)]
        [JsonProperty("version_config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionConfigId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTenantVersionConfigRequest {\n");
            sb.Append("  versionConfigId: ").Append(VersionConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTenantVersionConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTenantVersionConfigRequest input)
        {
            if (input == null) return false;
            if (this.VersionConfigId != input.VersionConfigId || (this.VersionConfigId != null && !this.VersionConfigId.Equals(input.VersionConfigId))) return false;

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
                if (this.VersionConfigId != null) hashCode = hashCode * 59 + this.VersionConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
