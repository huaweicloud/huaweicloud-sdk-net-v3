using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSlowlogResponse : SdkResponse
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 慢日志列表
        /// </summary>
        [JsonProperty("slowlogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<SlowlogItem> Slowlogs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSlowlogResponse {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  slowlogs: ").Append(Slowlogs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSlowlogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSlowlogResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Slowlogs == input.Slowlogs ||
                    this.Slowlogs != null &&
                    input.Slowlogs != null &&
                    this.Slowlogs.SequenceEqual(input.Slowlogs)
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
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Slowlogs != null)
                    hashCode = hashCode * 59 + this.Slowlogs.GetHashCode();
                return hashCode;
            }
        }
    }
}
