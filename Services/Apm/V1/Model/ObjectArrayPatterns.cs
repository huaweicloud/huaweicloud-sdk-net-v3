using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 对象数组
    /// </summary>
    public class ObjectArrayPatterns 
    {

        /// <summary>
        /// 键
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 最大长度
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        [JsonProperty("max_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? MaxValue { get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        [JsonProperty("min_value", NullValueHandling = NullValueHandling.Ignore)]
        public double? MinValue { get; set; }

        /// <summary>
        /// 是否可以为空值
        /// </summary>
        [JsonProperty("nullable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        [JsonProperty("hint", NullValueHandling = NullValueHandling.Ignore)]
        public string Hint { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectArrayPatterns {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  maxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  minValue: ").Append(MinValue).Append("\n");
            sb.Append("  nullable: ").Append(Nullable).Append("\n");
            sb.Append("  hint: ").Append(Hint).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectArrayPatterns);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectArrayPatterns input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.MaxLength != input.MaxLength || (this.MaxLength != null && !this.MaxLength.Equals(input.MaxLength))) return false;
            if (this.MaxValue != input.MaxValue || (this.MaxValue != null && !this.MaxValue.Equals(input.MaxValue))) return false;
            if (this.MinValue != input.MinValue || (this.MinValue != null && !this.MinValue.Equals(input.MinValue))) return false;
            if (this.Nullable != input.Nullable || (this.Nullable != null && !this.Nullable.Equals(input.Nullable))) return false;
            if (this.Hint != input.Hint || (this.Hint != null && !this.Hint.Equals(input.Hint))) return false;

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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.MaxLength != null) hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.MaxValue != null) hashCode = hashCode * 59 + this.MaxValue.GetHashCode();
                if (this.MinValue != null) hashCode = hashCode * 59 + this.MinValue.GetHashCode();
                if (this.Nullable != null) hashCode = hashCode * 59 + this.Nullable.GetHashCode();
                if (this.Hint != null) hashCode = hashCode * 59 + this.Hint.GetHashCode();
                return hashCode;
            }
        }
    }
}
