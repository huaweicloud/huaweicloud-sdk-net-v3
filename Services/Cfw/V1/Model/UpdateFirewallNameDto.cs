using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateFirewallNameDto 
    {

        /// <summary>
        /// **参数解释**： 防火墙名称 **约束限制**： 防火墙名称为中英文，包含数字，下划线，中划线，长度为1-48 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("fw_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFirewallNameDto {\n");
            sb.Append("  fwInstanceName: ").Append(FwInstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFirewallNameDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFirewallNameDto input)
        {
            if (input == null) return false;
            if (this.FwInstanceName != input.FwInstanceName || (this.FwInstanceName != null && !this.FwInstanceName.Equals(input.FwInstanceName))) return false;

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
                if (this.FwInstanceName != null) hashCode = hashCode * 59 + this.FwInstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
