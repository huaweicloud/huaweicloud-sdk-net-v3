using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ExportIpBlacklistResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public string Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Content-Disposition", IsHeader = true)]
        [JsonProperty("Content-Disposition", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Content-Length", IsHeader = true)]
        [JsonProperty("Content-Length", NullValueHandling = NullValueHandling.Ignore)]
        public int? ContentLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("Content-Type", IsHeader = true)]
        [JsonProperty("Content-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportIpBlacklistResponse {\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("  contentDisposition: ").Append(ContentDisposition).Append("\n");
            sb.Append("  contentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExportIpBlacklistResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExportIpBlacklistResponse input)
        {
            if (input == null) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;
            if (this.ContentDisposition != input.ContentDisposition || (this.ContentDisposition != null && !this.ContentDisposition.Equals(input.ContentDisposition))) return false;
            if (this.ContentLength != input.ContentLength || (this.ContentLength != null && !this.ContentLength.Equals(input.ContentLength))) return false;
            if (this.ContentType != input.ContentType || (this.ContentType != null && !this.ContentType.Equals(input.ContentType))) return false;

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
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.ContentDisposition != null) hashCode = hashCode * 59 + this.ContentDisposition.GetHashCode();
                if (this.ContentLength != null) hashCode = hashCode * 59 + this.ContentLength.GetHashCode();
                if (this.ContentType != null) hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                return hashCode;
            }
        }
    }
}
