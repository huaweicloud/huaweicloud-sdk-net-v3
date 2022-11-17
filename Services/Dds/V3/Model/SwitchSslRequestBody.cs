using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SwitchSslRequestBody 
    {

        /// <summary>
        /// SSL开关选项。取值：取“0”，表示DDS实例默认不启用SSL连接。取“1”，表示DDS实例默认启用SSL连接。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public string SslOption { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchSslRequestBody {\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchSslRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchSslRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SslOption == input.SslOption ||
                    (this.SslOption != null &&
                    this.SslOption.Equals(input.SslOption))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SslOption != null)
                    hashCode = hashCode * 59 + this.SslOption.GetHashCode();
                return hashCode;
            }
        }
    }
}
