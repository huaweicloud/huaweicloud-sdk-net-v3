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
    /// 参数属性。
    /// </summary>
    public class ParametersConstraint 
    {

        /// <summary>
        /// 参数种类。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 是否可编辑。
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Editable { get; set; }

        /// <summary>
        /// 是否必须。
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// 是否敏感。该功能暂未实现。
        /// </summary>
        [JsonProperty("sensitive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sensitive { get; set; }

        /// <summary>
        /// 有效种类。
        /// </summary>
        [JsonProperty("valid_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidType { get; set; }

        /// <summary>
        /// 有效范围。
        /// </summary>
        [JsonProperty("valid_range", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ValidRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParametersConstraint {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  editable: ").Append(Editable).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  sensitive: ").Append(Sensitive).Append("\n");
            sb.Append("  validType: ").Append(ValidType).Append("\n");
            sb.Append("  validRange: ").Append(ValidRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParametersConstraint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParametersConstraint input)
        {
            if (input == null) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Editable != input.Editable || (this.Editable != null && !this.Editable.Equals(input.Editable))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.Sensitive != input.Sensitive || (this.Sensitive != null && !this.Sensitive.Equals(input.Sensitive))) return false;
            if (this.ValidType != input.ValidType || (this.ValidType != null && !this.ValidType.Equals(input.ValidType))) return false;
            if (this.ValidRange != input.ValidRange || (this.ValidRange != null && input.ValidRange != null && !this.ValidRange.SequenceEqual(input.ValidRange))) return false;

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
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Editable != null) hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Sensitive != null) hashCode = hashCode * 59 + this.Sensitive.GetHashCode();
                if (this.ValidType != null) hashCode = hashCode * 59 + this.ValidType.GetHashCode();
                if (this.ValidRange != null) hashCode = hashCode * 59 + this.ValidRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
