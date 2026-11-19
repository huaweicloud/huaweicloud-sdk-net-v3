using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 开启/关闭Binlog参数体。
    /// </summary>
    public class OperateBinlogRequestV3Body 
    {

        /// <summary>
        /// **参数解释**：  Binlog日志开关状态。  **约束限制**：  不涉及。  **取值范围**：  - ON：表示开启。 - OFF：表示关闭。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }

        /// <summary>
        /// **参数解释**：  Binlog日志保存的天数。  **约束限制**：  - switch_status为ON时必选。 - switch_status为OFF时不可选。  **取值范围**：  1~180。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? KeepDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateBinlogRequestV3Body {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateBinlogRequestV3Body);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateBinlogRequestV3Body input)
        {
            if (input == null) return false;
            if (this.SwitchStatus != input.SwitchStatus || (this.SwitchStatus != null && !this.SwitchStatus.Equals(input.SwitchStatus))) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;

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
                if (this.SwitchStatus != null) hashCode = hashCode * 59 + this.SwitchStatus.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
