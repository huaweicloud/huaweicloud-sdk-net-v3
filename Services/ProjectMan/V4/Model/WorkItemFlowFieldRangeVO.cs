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
    /// 工作项字段范围
    /// </summary>
    public class WorkItemFlowFieldRangeVO 
    {

        /// <summary>
        /// 可选值对象列表
        /// </summary>
        [JsonProperty("setting_val_object", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, Object>> SettingValObject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowFieldRangeVO {\n");
            sb.Append("  settingValObject: ").Append(SettingValObject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowFieldRangeVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowFieldRangeVO input)
        {
            if (input == null) return false;
            if (this.SettingValObject != input.SettingValObject || (this.SettingValObject != null && input.SettingValObject != null && !this.SettingValObject.SequenceEqual(input.SettingValObject))) return false;

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
                if (this.SettingValObject != null) hashCode = hashCode * 59 + this.SettingValObject.GetHashCode();
                return hashCode;
            }
        }
    }
}
