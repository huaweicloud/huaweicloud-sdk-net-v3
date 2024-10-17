using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IsFavoriteItem 
    {

        /// <summary>
        /// 监控看板是否标记收藏, true: 收藏, false: 未收藏
        /// </summary>
        [JsonProperty("is_favorite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFavorite { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IsFavoriteItem {\n");
            sb.Append("  isFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IsFavoriteItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IsFavoriteItem input)
        {
            if (input == null) return false;
            if (this.IsFavorite != input.IsFavorite || (this.IsFavorite != null && !this.IsFavorite.Equals(input.IsFavorite))) return false;

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
                if (this.IsFavorite != null) hashCode = hashCode * 59 + this.IsFavorite.GetHashCode();
                return hashCode;
            }
        }
    }
}
