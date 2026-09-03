using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 多值标签筛选条件。
    /// </summary>
    public class MutiValueTag 
    {

        /// <summary>
        /// **参数解释**：标签key。 **取值范围**：1-128字符，支持字母、数字、中文及特殊字符（_.:&#x3D;+-@），不能以_sys_开头。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：该key下的value列表，多个value之间为OR关系。 **约束限制**：同一key下values不能重复，最多10个。 **取值范围**：0-255字符，支持字母、数字、中文及特殊字符（_.:/&#x3D;+-@）。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MutiValueTag {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MutiValueTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MutiValueTag input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
