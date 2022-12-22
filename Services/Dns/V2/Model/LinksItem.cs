using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 指向当前资源或者其他资源的链接。当查询需要分页时，需要包含一个next链接指向下一页。
    /// </summary>
    public class LinksItem 
    {

        /// <summary>
        /// 对应快捷链接。
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }

        /// <summary>
        /// 快捷链接标记名称。
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LinksItem {\n");
            sb.Append("  href: ").Append(Href).Append("\n");
            sb.Append("  rel: ").Append(Rel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LinksItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LinksItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.Rel != null)
                    hashCode = hashCode * 59 + this.Rel.GetHashCode();
                return hashCode;
            }
        }
    }
}
