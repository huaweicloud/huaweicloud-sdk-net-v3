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
    public class SecurityOptions 
    {

        /// <summary>
        /// 是否支持安全启动 true:支持安全启动 false:不支持安全启动 默认值：false
        /// </summary>
        [JsonProperty("secure_boot_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecureBootEnabled { get; set; }

        /// <summary>
        /// 是否支持vtpm启动 true:支持vtpm启动 false:不支持vtpm启动 默认值：false
        /// </summary>
        [JsonProperty("tpm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TpmEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityOptions {\n");
            sb.Append("  secureBootEnabled: ").Append(SecureBootEnabled).Append("\n");
            sb.Append("  tpmEnabled: ").Append(TpmEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SecurityOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SecurityOptions input)
        {
            if (input == null) return false;
            if (this.SecureBootEnabled != input.SecureBootEnabled || (this.SecureBootEnabled != null && !this.SecureBootEnabled.Equals(input.SecureBootEnabled))) return false;
            if (this.TpmEnabled != input.TpmEnabled || (this.TpmEnabled != null && !this.TpmEnabled.Equals(input.TpmEnabled))) return false;

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
                if (this.SecureBootEnabled != null) hashCode = hashCode * 59 + this.SecureBootEnabled.GetHashCode();
                if (this.TpmEnabled != null) hashCode = hashCode * 59 + this.TpmEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
