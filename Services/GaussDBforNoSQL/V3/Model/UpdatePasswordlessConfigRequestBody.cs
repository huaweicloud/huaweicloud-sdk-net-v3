using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePasswordlessConfigRequestBody 
    {

        /// <summary>
        /// 要设置的免密配置,ip与网段的列表,空列表表示清空免密配置。
        /// </summary>
        [JsonProperty("config_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConfigIps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePasswordlessConfigRequestBody {\n");
            sb.Append("  configIps: ").Append(ConfigIps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePasswordlessConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePasswordlessConfigRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigIps == input.ConfigIps ||
                    this.ConfigIps != null &&
                    input.ConfigIps != null &&
                    this.ConfigIps.SequenceEqual(input.ConfigIps)
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
                if (this.ConfigIps != null)
                    hashCode = hashCode * 59 + this.ConfigIps.GetHashCode();
                return hashCode;
            }
        }
    }
}
