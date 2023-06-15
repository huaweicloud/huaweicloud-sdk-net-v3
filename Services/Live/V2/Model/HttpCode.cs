using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpCode 
    {

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        /// <summary>
        /// 状态码出现次数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 状态码在对应时间点中的占比，保留4位小数。 
        /// </summary>
        [JsonProperty("proportion", NullValueHandling = NullValueHandling.Ignore)]
        public double? Proportion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpCode {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  proportion: ").Append(Proportion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpCode);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Proportion == input.Proportion ||
                    (this.Proportion != null &&
                    this.Proportion.Equals(input.Proportion))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Proportion != null)
                    hashCode = hashCode * 59 + this.Proportion.GetHashCode();
                return hashCode;
            }
        }
    }
}
