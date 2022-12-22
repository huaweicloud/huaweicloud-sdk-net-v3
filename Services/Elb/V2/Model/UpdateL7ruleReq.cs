using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// L7转发策略请求实体
    /// </summary>
    public class UpdateL7ruleReq 
    {

        /// <summary>
        /// 转发匹配方式： type为HOST_NAME时，取值范围：EQUAL_TO：精确匹配；t ype为PATH时，取值范围：REGEX：正则匹配；STARTS_WITH：前缀匹配；EQUAL_TO：精确匹配。
        /// </summary>
        [JsonProperty("compare_type", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareType { get; set; }

        /// <summary>
        /// 转发规则的管理状态；取值范围： true/false。该字段为预留字段，暂未启用。默认为true。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 是否反向匹配；取值范围：true/false。默认值：false；该字段为预留字段，暂未启用。
        /// </summary>
        [JsonProperty("invert", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invert { get; set; }

        /// <summary>
        /// 匹配内容的键值。默认为null。该字段为预留字段，暂未启用。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 匹配内容的值。不能包含空格。 当type为HOST_NAME时，取值范围：String (100)，字符串只能包含英文字母、数字、“-”或“.”，且必须以字母或数字开头。 当type为PATH时，取值范围：String (128)。当转发规则的compare_type为STARTS_WITH、EQUAL_TO时，字符串只能包含英文字母、数字、_~&#39;;@^-%#&amp;$.*+?,&#x3D;!:| /()[]{}，且必须以\&quot;/\&quot;开头。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateL7ruleReq {\n");
            sb.Append("  compareType: ").Append(CompareType).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  invert: ").Append(Invert).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateL7ruleReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateL7ruleReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompareType == input.CompareType ||
                    (this.CompareType != null &&
                    this.CompareType.Equals(input.CompareType))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Invert == input.Invert ||
                    (this.Invert != null &&
                    this.Invert.Equals(input.Invert))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.CompareType != null)
                    hashCode = hashCode * 59 + this.CompareType.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Invert != null)
                    hashCode = hashCode * 59 + this.Invert.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
