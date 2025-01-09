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
    /// Response Object
    /// </summary>
    public class ListAccessAddressBackupConfigResponse : SdkResponse
    {

        /// <summary>
        /// 接入配置列表信息。
        /// </summary>
        [JsonProperty("access_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessConfigInfo> AccessConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessAddressBackupConfigResponse {\n");
            sb.Append("  accessConfig: ").Append(AccessConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessAddressBackupConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessAddressBackupConfigResponse input)
        {
            if (input == null) return false;
            if (this.AccessConfig != input.AccessConfig || (this.AccessConfig != null && input.AccessConfig != null && !this.AccessConfig.SequenceEqual(input.AccessConfig))) return false;

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
                if (this.AccessConfig != null) hashCode = hashCode * 59 + this.AccessConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
