using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SslOptionRequest 
    {

        /// <summary>
        /// - true, 打开ssl开关。 - false, 关闭ssl开关。
        /// </summary>
        [JsonProperty("ssl_option", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SslOption { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SslOptionRequest {\n");
            sb.Append("  sslOption: ").Append(SslOption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SslOptionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SslOptionRequest input)
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
