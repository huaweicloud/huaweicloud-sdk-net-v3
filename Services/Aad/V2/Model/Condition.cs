using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// cc规则防护规则限速条件
    /// </summary>
    public class Condition 
    {

        /// <summary>
        /// 字段类型 url：路径 ip：IPv4 ipv6：IPv6 params：Params cookie：Cookie header：Header response_code：Response Code
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 条件列表逻辑匹配内容。 当匹配逻辑为exist或not_exist时，contents必须为空，其他情况下contents必填且长度不超过2048 当category为response_code时，contents状态码为200~599，正则为 ^(?:[2-5]\\d{2})$ 当匹配逻辑包含\&quot;len\&quot;时，contents必须为0~65535的整数；当匹配逻辑包含\&quot;num\&quot;时，contents必须为0~512的整数
        /// </summary>
        [JsonProperty("contents", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Contents { get; set; }

        /// <summary>
        /// 子字段 当字段类型为ip或ipv6时，index必填且必须为：client-ip：客户端IP、x-forwarded-for：X-Forwarded-For、TCP连接IP: $remote_addr 当字段类型（category）选择“params”、“cookie”、“header”时，请根据实际需求配置子字段且该参数必填。 当匹配逻辑为num_greater、num_less、num_equal、num_not_equal时，子字段必须为空 当子字段不为空时，最大长度不超过2048
        /// </summary>
        [JsonProperty("index", NullValueHandling = NullValueHandling.Ignore)]
        public string Index { get; set; }

        /// <summary>
        /// 条件列表匹配逻辑。 如果字段类型category是url，匹配逻辑可以为：contain、 not_contain、 equal、 not_equal、 prefix、 not_prefix、 suffix、 not_suffix、 len_greater、 len_less、len_equal或者len_not_equal 如果字段类型category是ip、ipv6或response_code，匹配逻辑可以为： equal、not_equal 如果字段类型category是params、cookie或者header, 匹配逻辑可以为：contain、 not_contain、 equal、 not_equal、 prefix、 not_prefix、 suffix、 not_suffix、 len_greater、 len_less、len_equal、len_not_equal、num_greater、num_less、num_equal、num_not_equal、exist或者not_exist
        /// </summary>
        [JsonProperty("logic_operation", NullValueHandling = NullValueHandling.Ignore)]
        public string LogicOperation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  contents: ").Append(Contents).Append("\n");
            sb.Append("  index: ").Append(Index).Append("\n");
            sb.Append("  logicOperation: ").Append(LogicOperation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Condition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Condition input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Contents != input.Contents || (this.Contents != null && input.Contents != null && !this.Contents.SequenceEqual(input.Contents))) return false;
            if (this.Index != input.Index || (this.Index != null && !this.Index.Equals(input.Index))) return false;
            if (this.LogicOperation != input.LogicOperation || (this.LogicOperation != null && !this.LogicOperation.Equals(input.LogicOperation))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Contents != null) hashCode = hashCode * 59 + this.Contents.GetHashCode();
                if (this.Index != null) hashCode = hashCode * 59 + this.Index.GetHashCode();
                if (this.LogicOperation != null) hashCode = hashCode * 59 + this.LogicOperation.GetHashCode();
                return hashCode;
            }
        }
    }
}
