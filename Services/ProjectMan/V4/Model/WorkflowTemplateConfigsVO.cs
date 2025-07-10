using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 状态流流转线流转配置信息
    /// </summary>
    public class WorkflowTemplateConfigsVO 
    {

        /// <summary>
        /// 操作项配置
        /// </summary>
        [JsonProperty("configValue", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> ConfigValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowTemplateConfigsVO {\n");
            sb.Append("  configValue: ").Append(ConfigValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkflowTemplateConfigsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkflowTemplateConfigsVO input)
        {
            if (input == null) return false;
            if (this.ConfigValue != input.ConfigValue || (this.ConfigValue != null && input.ConfigValue != null && !this.ConfigValue.SequenceEqual(input.ConfigValue))) return false;

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
                if (this.ConfigValue != null) hashCode = hashCode * 59 + this.ConfigValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
