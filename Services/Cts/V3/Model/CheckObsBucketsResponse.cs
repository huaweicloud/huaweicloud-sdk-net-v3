using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckObsBucketsResponse : SdkResponse
    {

        /// <summary>
        /// 检查OBS桶状态响应体。
        /// </summary>
        [JsonProperty("buckets", NullValueHandling = NullValueHandling.Ignore)]
        public List<Bucket> Buckets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckObsBucketsResponse {\n");
            sb.Append("  buckets: ").Append(Buckets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckObsBucketsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckObsBucketsResponse input)
        {
            if (input == null) return false;
            if (this.Buckets != input.Buckets || (this.Buckets != null && input.Buckets != null && !this.Buckets.SequenceEqual(input.Buckets))) return false;

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
                if (this.Buckets != null) hashCode = hashCode * 59 + this.Buckets.GetHashCode();
                return hashCode;
            }
        }
    }
}
