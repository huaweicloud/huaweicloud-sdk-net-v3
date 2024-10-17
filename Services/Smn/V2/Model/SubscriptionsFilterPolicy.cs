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
    /// 过滤策略。
    /// </summary>
    public class SubscriptionsFilterPolicy 
    {

        /// <summary>
        /// 过滤策略名称。 包含小写英文字母([a-z])、数字([0-9])、下划线(_)，下划线不得开始、结尾或连续出现），长度限制{1,32}，不能是smn_开头。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 字符串精确匹配数组。数组长度[1, 10]，数组内容不能重复，值不能为null或者空字符串“ ”，长度限制[1,32]，中英文、数字、下划线
        /// </summary>
        [JsonProperty("string_equals", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StringEquals { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionsFilterPolicy {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  stringEquals: ").Append(StringEquals).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionsFilterPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscriptionsFilterPolicy input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.StringEquals != input.StringEquals || (this.StringEquals != null && input.StringEquals != null && !this.StringEquals.SequenceEqual(input.StringEquals))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StringEquals != null) hashCode = hashCode * 59 + this.StringEquals.GetHashCode();
                return hashCode;
            }
        }
    }
}
