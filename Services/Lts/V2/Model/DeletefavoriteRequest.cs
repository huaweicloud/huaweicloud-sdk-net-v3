using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeletefavoriteRequest 
    {

        /// <summary>
        /// 收藏资源id
        /// </summary>
        [SDKProperty("fav_res_id", IsPath = true)]
        [JsonProperty("fav_res_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FavResId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletefavoriteRequest {\n");
            sb.Append("  favResId: ").Append(FavResId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeletefavoriteRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeletefavoriteRequest input)
        {
            if (input == null) return false;
            if (this.FavResId != input.FavResId || (this.FavResId != null && !this.FavResId.Equals(input.FavResId))) return false;

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
                if (this.FavResId != null) hashCode = hashCode * 59 + this.FavResId.GetHashCode();
                return hashCode;
            }
        }
    }
}
