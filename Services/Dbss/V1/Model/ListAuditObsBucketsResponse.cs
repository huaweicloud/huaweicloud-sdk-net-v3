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
    public class ListAuditObsBucketsResponse : SdkResponse
    {

        /// <summary>
        /// OBS桶列表
        /// </summary>
        [JsonProperty("obs_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ObsBucketObject> ObsList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAuditObsBucketsResponse {\n");
            sb.Append("  obsList: ").Append(ObsList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAuditObsBucketsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAuditObsBucketsResponse input)
        {
            if (input == null) return false;
            if (this.ObsList != input.ObsList || (this.ObsList != null && input.ObsList != null && !this.ObsList.SequenceEqual(input.ObsList))) return false;

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
                if (this.ObsList != null) hashCode = hashCode * 59 + this.ObsList.GetHashCode();
                return hashCode;
            }
        }
    }
}
