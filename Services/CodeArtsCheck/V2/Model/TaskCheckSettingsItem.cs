using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskCheckSettingsItem 
    {

        /// <summary>
        /// 检查参数对应的key值
        /// </summary>
        [JsonProperty("cfg_key", NullValueHandling = NullValueHandling.Ignore)]
        public string CfgKey { get; set; }

        /// <summary>
        /// 参数状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 检查参数值
        /// </summary>
        [JsonProperty("cfg_value", NullValueHandling = NullValueHandling.Ignore)]
        public string CfgValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskCheckSettingsItem {\n");
            sb.Append("  cfgKey: ").Append(CfgKey).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  cfgValue: ").Append(CfgValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskCheckSettingsItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskCheckSettingsItem input)
        {
            if (input == null) return false;
            if (this.CfgKey != input.CfgKey || (this.CfgKey != null && !this.CfgKey.Equals(input.CfgKey))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CfgValue != input.CfgValue || (this.CfgValue != null && !this.CfgValue.Equals(input.CfgValue))) return false;

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
                if (this.CfgKey != null) hashCode = hashCode * 59 + this.CfgKey.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CfgValue != null) hashCode = hashCode * 59 + this.CfgValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
