using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 商品文本信息
    /// </summary>
    public class ProductTextInfo 
    {

        /// <summary>
        /// 文本标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductTextInfo {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductTextInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProductTextInfo input)
        {
            if (input == null) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;

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
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }
    }
}
