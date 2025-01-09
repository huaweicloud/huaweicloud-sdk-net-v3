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
    /// 修改云办公服务接入地址备份配置请求体。
    /// </summary>
    public class UpdateAccessAddressBackupConfigReq 
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
            sb.Append("class UpdateAccessAddressBackupConfigReq {\n");
            sb.Append("  accessConfig: ").Append(AccessConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAccessAddressBackupConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAccessAddressBackupConfigReq input)
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
