using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWhitelistsResponse : SdkResponse
    {

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 白名单列表
        /// </summary>
        [JsonProperty("whitelists", NullValueHandling = NullValueHandling.Ignore)]
        public List<WhitelistBean> Whitelists { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWhitelistsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
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
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Whitelists != input.Whitelists || (this.Whitelists != null && input.Whitelists != null && !this.Whitelists.SequenceEqual(input.Whitelists))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Whitelists != null) hashCode = hashCode * 59 + this.Whitelists.GetHashCode();
                return hashCode;
            }
        }
    }
}
