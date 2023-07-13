using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VersionLinks 
    {

        /// <summary>
        /// 链接类型。self：自助链接包含了版本链接的资源。bookmark：书签链接提供了一个永久资源的永久链接。alternate：备用链接包含了资源的替换表示形式。
        /// </summary>
        [JsonProperty("rel", NullValueHandling = NullValueHandling.Ignore)]
        public string Rel { get; set; }

        /// <summary>
        /// 资源链接地址。
        /// </summary>
        [JsonProperty("href", NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionLinks {\n");
            sb.Append("  rel: ").Append(Rel).Append("\n");
            sb.Append("  href: ").Append(Href).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionLinks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionLinks input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Rel == input.Rel ||
                    (this.Rel != null &&
                    this.Rel.Equals(input.Rel))
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
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
                if (this.Rel != null)
                    hashCode = hashCode * 59 + this.Rel.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                return hashCode;
            }
        }
    }
}
