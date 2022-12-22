using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWhitelistsResponse : SdkResponse
    {

        /// <summary>
        /// 白名单对象的列表
        /// </summary>
        [JsonProperty("whitelists", NullValueHandling = NullValueHandling.Ignore)]
        public List<WhitelistResp> Whitelists { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWhitelistsResponse {\n");
            sb.Append("  whitelists: ").Append(Whitelists).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWhitelistsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWhitelistsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Whitelists == input.Whitelists ||
                    this.Whitelists != null &&
                    input.Whitelists != null &&
                    this.Whitelists.SequenceEqual(input.Whitelists)
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
                if (this.Whitelists != null)
                    hashCode = hashCode * 59 + this.Whitelists.GetHashCode();
                return hashCode;
            }
        }
    }
}
