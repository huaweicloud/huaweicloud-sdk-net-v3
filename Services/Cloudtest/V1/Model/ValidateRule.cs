using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ValidateRule 
    {

        /// <summary>
        /// 依赖信息列表
        /// </summary>
        [JsonProperty("dependent_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<ConditionInstance> DependentInfo { get; set; }

        /// <summary>
        /// 是否启用的标识符
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 配置依赖的标识符
        /// </summary>
        [JsonProperty("is_configDep", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConfigDep { get; set; }

        /// <summary>
        /// 是否依赖的标识符
        /// </summary>
        [JsonProperty("is_dependent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDependent { get; set; }

        /// <summary>
        /// 消息
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 特殊字符
        /// </summary>
        [JsonProperty("special_char", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialChar { get; set; }

        /// <summary>
        /// 特殊字符的有效性
        /// </summary>
        [JsonProperty("special_char_valid", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialCharValid { get; set; }

        /// <summary>
        /// 示例
        /// </summary>
        [JsonProperty("x_example", NullValueHandling = NullValueHandling.Ignore)]
        public string XExample { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateRule {\n");
            sb.Append("  dependentInfo: ").Append(DependentInfo).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  isConfigDep: ").Append(IsConfigDep).Append("\n");
            sb.Append("  isDependent: ").Append(IsDependent).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  specialChar: ").Append(SpecialChar).Append("\n");
            sb.Append("  specialCharValid: ").Append(SpecialCharValid).Append("\n");
            sb.Append("  xExample: ").Append(XExample).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateRule input)
        {
            if (input == null) return false;
            if (this.DependentInfo != input.DependentInfo || (this.DependentInfo != null && input.DependentInfo != null && !this.DependentInfo.SequenceEqual(input.DependentInfo))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.IsConfigDep != input.IsConfigDep || (this.IsConfigDep != null && !this.IsConfigDep.Equals(input.IsConfigDep))) return false;
            if (this.IsDependent != input.IsDependent || (this.IsDependent != null && !this.IsDependent.Equals(input.IsDependent))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.SpecialChar != input.SpecialChar || (this.SpecialChar != null && !this.SpecialChar.Equals(input.SpecialChar))) return false;
            if (this.SpecialCharValid != input.SpecialCharValid || (this.SpecialCharValid != null && !this.SpecialCharValid.Equals(input.SpecialCharValid))) return false;
            if (this.XExample != input.XExample || (this.XExample != null && !this.XExample.Equals(input.XExample))) return false;

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
                if (this.DependentInfo != null) hashCode = hashCode * 59 + this.DependentInfo.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.IsConfigDep != null) hashCode = hashCode * 59 + this.IsConfigDep.GetHashCode();
                if (this.IsDependent != null) hashCode = hashCode * 59 + this.IsDependent.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.SpecialChar != null) hashCode = hashCode * 59 + this.SpecialChar.GetHashCode();
                if (this.SpecialCharValid != null) hashCode = hashCode * 59 + this.SpecialCharValid.GetHashCode();
                if (this.XExample != null) hashCode = hashCode * 59 + this.XExample.GetHashCode();
                return hashCode;
            }
        }
    }
}
