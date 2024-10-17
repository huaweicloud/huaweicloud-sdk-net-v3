using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 任务参数配置信息
    /// </summary>
    public class ParameterInfo 
    {

        /// <summary>
        /// 参数名称，如：“applier_thread_num”，“read_task_num”等
        /// </summary>
        [JsonProperty("parameter_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterName { get; set; }

        /// <summary>
        /// 参数名称对应的参数值，如：“20”，“false”
        /// </summary>
        [JsonProperty("parameter_value", NullValueHandling = NullValueHandling.Ignore)]
        public string ParameterValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParameterInfo {\n");
            sb.Append("  parameterName: ").Append(ParameterName).Append("\n");
            sb.Append("  parameterValue: ").Append(ParameterValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ParameterInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ParameterInfo input)
        {
            if (input == null) return false;
            if (this.ParameterName != input.ParameterName || (this.ParameterName != null && !this.ParameterName.Equals(input.ParameterName))) return false;
            if (this.ParameterValue != input.ParameterValue || (this.ParameterValue != null && !this.ParameterValue.Equals(input.ParameterValue))) return false;

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
                if (this.ParameterName != null) hashCode = hashCode * 59 + this.ParameterName.GetHashCode();
                if (this.ParameterValue != null) hashCode = hashCode * 59 + this.ParameterValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
