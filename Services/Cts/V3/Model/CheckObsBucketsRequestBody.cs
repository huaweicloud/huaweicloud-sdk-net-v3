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
    /// 
    /// </summary>
    public class CheckObsBucketsRequestBody 
    {

        /// <summary>
        /// 请求检查的OBS桶列表。
        /// </summary>
        [JsonProperty("buckets", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckBucketRequest> Buckets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckObsBucketsRequestBody {\n");
            sb.Append("  buckets: ").Append(Buckets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckObsBucketsRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckObsBucketsRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buckets == input.Buckets ||
                    this.Buckets != null &&
                    input.Buckets != null &&
                    this.Buckets.SequenceEqual(input.Buckets)
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
                if (this.Buckets != null)
                    hashCode = hashCode * 59 + this.Buckets.GetHashCode();
                return hashCode;
            }
        }
    }
}
