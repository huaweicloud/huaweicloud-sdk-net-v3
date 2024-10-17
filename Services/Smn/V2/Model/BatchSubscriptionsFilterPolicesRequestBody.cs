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
    /// filter_polices字段，必填，一个筛选策略最多可具有 5 个属性策略。  name-属性名称：满足正则 ^(?!smn_)(?!.*?_$)(?!^_)(?!.*?__)[a-z0-9_]{1,32}$ （英文字母([a-z])、数字([0-9])、下划线(_)，下划线不得开始、结尾或连续出现），长度限制{1,32}，key不能是smn_开头 字符串匹配策略： string_equals：精准匹配字符串；类型：字符串数组，数组长度[1,10]，字符串长度限制[1,32]，不能重复，不能空值“ ”
    /// </summary>
    public class BatchSubscriptionsFilterPolicesRequestBody 
    {

        /// <summary>
        /// 批量处理订阅者策略列表。
        /// </summary>
        [JsonProperty("polices", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchSubscriptionsFilterPolicesRequestBodyPolices> Polices { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSubscriptionsFilterPolicesRequestBody {\n");
            sb.Append("  polices: ").Append(Polices).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSubscriptionsFilterPolicesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSubscriptionsFilterPolicesRequestBody input)
        {
            if (input == null) return false;
            if (this.Polices != input.Polices || (this.Polices != null && input.Polices != null && !this.Polices.SequenceEqual(input.Polices))) return false;

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
                if (this.Polices != null) hashCode = hashCode * 59 + this.Polices.GetHashCode();
                return hashCode;
            }
        }
    }
}
