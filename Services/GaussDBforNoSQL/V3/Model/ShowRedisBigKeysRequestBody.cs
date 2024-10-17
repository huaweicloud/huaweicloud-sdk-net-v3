using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowRedisBigKeysRequestBody 
    {

        /// <summary>
        /// 索引位置偏移量，表示从查询到的大key列表偏移offset条数据后查询对应的大key信息。 取值大于或等于0。不传该参数时，查询偏移量默认为0，表示从第一条大key开始查询。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询个数上限值。 取值范围：1~100。不传该参数时，默认查询前100条大key。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 大key的类型,一个字符串列表,支持\&quot;string\&quot;,\&quot;hash\&quot;,\&quot;zset\&quot;,\&quot;set\&quot;,\&quot;list\&quot;,\&quot;stream\&quot;六种类型。
        /// </summary>
        [JsonProperty("key_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> KeyTypes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRedisBigKeysRequestBody {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  keyTypes: ").Append(KeyTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRedisBigKeysRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRedisBigKeysRequestBody input)
        {
            if (input == null) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.KeyTypes != input.KeyTypes || (this.KeyTypes != null && input.KeyTypes != null && !this.KeyTypes.SequenceEqual(input.KeyTypes))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.KeyTypes != null) hashCode = hashCode * 59 + this.KeyTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
