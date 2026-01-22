using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListRepoAccessoriesResponse : SdkResponse
    {

        /// <summary>
        /// 附件总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public long? Total { get; set; }

        /// <summary>
        /// 附件列表
        /// </summary>
        [JsonProperty("accessories", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessoryListAccessories> Accessories { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepoAccessoriesResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  accessories: ").Append(Accessories).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepoAccessoriesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepoAccessoriesResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Accessories != input.Accessories || (this.Accessories != null && input.Accessories != null && !this.Accessories.SequenceEqual(input.Accessories))) return false;

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
                if (this.Accessories != null) hashCode = hashCode * 59 + this.Accessories.GetHashCode();
                return hashCode;
            }
        }
    }
}
