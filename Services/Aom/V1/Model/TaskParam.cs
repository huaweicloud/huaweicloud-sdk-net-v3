using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// 任务参数对象。
    /// </summary>
    public class TaskParam 
    {

        /// <summary>
        /// 参数名称。
        /// </summary>
        [JsonProperty("param_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamName { get; set; }

        /// <summary>
        /// 参数类型。
        /// </summary>
        [JsonProperty("param_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamType { get; set; }

        /// <summary>
        /// 参数分组。
        /// </summary>
        [JsonProperty("param_group", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamGroup { get; set; }

        /// <summary>
        /// 参数初始值。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskParam {\n");
            sb.Append("  paramName: ").Append(ParamName).Append("\n");
            sb.Append("  paramType: ").Append(ParamType).Append("\n");
            sb.Append("  paramGroup: ").Append(ParamGroup).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskParam input)
        {
            if (input == null) return false;
            if (this.ParamName != input.ParamName || (this.ParamName != null && !this.ParamName.Equals(input.ParamName))) return false;
            if (this.ParamType != input.ParamType || (this.ParamType != null && !this.ParamType.Equals(input.ParamType))) return false;
            if (this.ParamGroup != input.ParamGroup || (this.ParamGroup != null && !this.ParamGroup.Equals(input.ParamGroup))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;

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
                if (this.ParamName != null) hashCode = hashCode * 59 + this.ParamName.GetHashCode();
                if (this.ParamType != null) hashCode = hashCode * 59 + this.ParamType.GetHashCode();
                if (this.ParamGroup != null) hashCode = hashCode * 59 + this.ParamGroup.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
