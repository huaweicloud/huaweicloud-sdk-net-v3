using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SwitchSSLRequest 
    {

        /// <summary>
        /// SSL数据加密开关设置。  - true: 开启SSL数据加密。 - false: 关闭SSL数据加密。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslOption { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchSSLRequest {\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchSSLRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchSSLRequest input)
        {
            if (input == null) return false;
            if (this.SslOption != input.SslOption || (this.SslOption != null && !this.SslOption.Equals(input.SslOption))) return false;

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
                if (this.SslOption != null) hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                return hashCode;
            }
        }
    }
}
