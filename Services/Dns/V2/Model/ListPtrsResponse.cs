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
    /// Response Object
    /// </summary>
    public class ListPtrsResponse : SdkResponse
    {

        /// <summary>
        /// 反向解析列表。
        /// </summary>
        [JsonProperty("floatingips", NullValueHandling = NullValueHandling.Ignore)]
        public List<FloatingIpsPtr> Floatingips { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public PageLink Links { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPtrsResponse {\n");
            sb.Append("  floatingips: ").Append(Floatingips).Append("\n");
            sb.Append("  links: ").Append(Links).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPtrsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPtrsResponse input)
        {
            if (input == null) return false;
            if (this.Floatingips != input.Floatingips || (this.Floatingips != null && input.Floatingips != null && !this.Floatingips.SequenceEqual(input.Floatingips))) return false;
            if (this.Links != input.Links || (this.Links != null && !this.Links.Equals(input.Links))) return false;
            if (this.Metadata != input.Metadata || (this.Metadata != null && !this.Metadata.Equals(input.Metadata))) return false;

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
                if (this.Floatingips != null) hashCode = hashCode * 59 + this.Floatingips.GetHashCode();
                if (this.Links != null) hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Metadata != null) hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                return hashCode;
            }
        }
    }
}
