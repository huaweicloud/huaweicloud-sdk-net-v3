using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIpWhitelistResponse : SdkResponse
    {

        /// <summary>
        /// 是否启用白名单（true/false）。
        /// </summary>
        [JsonProperty("enable_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableWhitelist { get; set; }

        /// <summary>
        /// IP白名单分组列表。
        /// </summary>
        [JsonProperty("whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<Whitelist> Whitelist { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpWhitelistResponse {\n");
            sb.Append("  enableWhitelist: ").Append(EnableWhitelist).Append("\n");
            sb.Append("  whitelist: ").Append(Whitelist).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpWhitelistResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpWhitelistResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableWhitelist == input.EnableWhitelist ||
                    (this.EnableWhitelist != null &&
                    this.EnableWhitelist.Equals(input.EnableWhitelist))
                ) && 
                (
                    this.Whitelist == input.Whitelist ||
                    this.Whitelist != null &&
                    input.Whitelist != null &&
                    this.Whitelist.SequenceEqual(input.Whitelist)
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
                if (this.EnableWhitelist != null)
                    hashCode = hashCode * 59 + this.EnableWhitelist.GetHashCode();
                if (this.Whitelist != null)
                    hashCode = hashCode * 59 + this.Whitelist.GetHashCode();
                return hashCode;
            }
        }
    }
}
