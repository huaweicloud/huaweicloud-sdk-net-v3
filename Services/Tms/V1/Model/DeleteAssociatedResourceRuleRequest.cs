using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteAssociatedResourceRuleRequest 
    {

        /// <summary>
        /// 规则的配置名称。
        /// </summary>
        [SDKProperty("setting_name", IsPath = true)]
        [JsonProperty("setting_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SettingName { get; set; }

        /// <summary>
        /// 要关闭的规则所在的region集合。
        /// </summary>
        [SDKProperty("region_id", IsQuery = true)]
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> RegionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteAssociatedResourceRuleRequest {\n");
            sb.Append("  settingName: ").Append(SettingName).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteAssociatedResourceRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteAssociatedResourceRuleRequest input)
        {
            if (input == null) return false;
            if (this.SettingName != input.SettingName || (this.SettingName != null && !this.SettingName.Equals(input.SettingName))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && input.RegionId != null && !this.RegionId.SequenceEqual(input.RegionId))) return false;

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
                if (this.SettingName != null) hashCode = hashCode * 59 + this.SettingName.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
