using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class DownloadHttpSignCertResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("content-type", IsHeader = true)]
        [JsonProperty("content-type", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadHttpSignCertResponse {\n");
            sb.Append("  contentType: ").Append(ContentType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DownloadHttpSignCertResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DownloadHttpSignCertResponse input)
        {
            if (input == null) return false;
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
                if (this.ContentType != null) hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                return hashCode;
            }
        }
    }
}
