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
    public class SwitchSslOpenRequest 
    {

        /// <summary>
        /// true:  打开 false: 关闭
        /// </summary>
        [JsonProperty("ssl_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchSslOpenRequest {\n");
            sb.Append("  sslEnabled: ").Append(SslEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchSslOpenRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchSslOpenRequest input)
        {
            if (input == null) return false;
            if (this.SslEnabled != input.SslEnabled || (this.SslEnabled != null && !this.SslEnabled.Equals(input.SslEnabled))) return false;

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
                if (this.SslEnabled != null) hashCode = hashCode * 59 + this.SslEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
