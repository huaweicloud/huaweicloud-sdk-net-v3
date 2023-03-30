using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 设备属性过滤信息，自定义结构。
    /// </summary>
    public class PropertyFilter 
    {

        /// <summary>
        /// **参数说明**：设备属性的路径信息，格式：service_id/DataProperty，例如门磁状态为“DoorWindow/status”。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数说明**：数据比较的操作符。 **取值范围**：当前支持的操作符有：&gt;，&lt;，&gt;&#x3D;，&lt;&#x3D;，&#x3D;,in:表示在指定值中匹配和between:表示数值区间。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public string Operator { get; set; }

        /// <summary>
        /// **参数说明**：数据比较表达式的右值。与数据比较操作符between联用时，右值表示最小值和最大值，用逗号隔开，如“20,30”表示大于等于20小于30。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数说明**：当operator为in时该字段必填，使用该字段传递比较表达式右值，上限为20个。
        /// </summary>
        [JsonProperty("in_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InValues { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public Strategy Strategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyFilter {\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  inValues: ").Append(InValues).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PropertyFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PropertyFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.InValues == input.InValues ||
                    this.InValues != null &&
                    input.InValues != null &&
                    this.InValues.SequenceEqual(input.InValues)
                ) && 
                (
                    this.Strategy == input.Strategy ||
                    (this.Strategy != null &&
                    this.Strategy.Equals(input.Strategy))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.InValues != null)
                    hashCode = hashCode * 59 + this.InValues.GetHashCode();
                if (this.Strategy != null)
                    hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
