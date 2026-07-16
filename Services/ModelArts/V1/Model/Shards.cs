using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Shards 
    {

        /// <summary>
        /// **参数解释**：日志分片的obs下载链接集。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("object_urls", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ObjectUrls { get; set; }

        /// <summary>
        /// **参数解释**：本次请求返回的日志分片数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：本次请求命中的日志分片总数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Shards {\n");
            sb.Append("  objectUrls: ").Append(ObjectUrls).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Shards);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Shards input)
        {
            if (input == null) return false;
            if (this.ObjectUrls != input.ObjectUrls || (this.ObjectUrls != null && input.ObjectUrls != null && !this.ObjectUrls.SequenceEqual(input.ObjectUrls))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.ObjectUrls != null) hashCode = hashCode * 59 + this.ObjectUrls.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
