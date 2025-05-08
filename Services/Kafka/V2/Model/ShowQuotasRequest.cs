using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowQuotasRequest 
    {

        /// <summary>
        /// 是否包含标签配额。
        /// </summary>
        [SDKProperty("includeTagsQuota", IsQuery = true)]
        [JsonProperty("includeTagsQuota", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeTagsQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowQuotasRequest {\n");
            sb.Append("  includeTagsQuota: ").Append(IncludeTagsQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowQuotasRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowQuotasRequest input)
        {
            if (input == null) return false;
            if (this.IncludeTagsQuota != input.IncludeTagsQuota || (this.IncludeTagsQuota != null && !this.IncludeTagsQuota.Equals(input.IncludeTagsQuota))) return false;

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
                if (this.IncludeTagsQuota != null) hashCode = hashCode * 59 + this.IncludeTagsQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
