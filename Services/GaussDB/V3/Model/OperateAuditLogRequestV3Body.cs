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
    /// 开启/关闭全量SQL参数体
    /// </summary>
    public class OperateAuditLogRequestV3Body 
    {

        /// <summary>
        /// 全量SQL开关状态。 取值： - ON，表示开启 - OFF，表示关闭
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateAuditLogRequestV3Body {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateAuditLogRequestV3Body);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateAuditLogRequestV3Body input)
        {
            if (input == null) return false;
            if (this.SwitchStatus != input.SwitchStatus || (this.SwitchStatus != null && !this.SwitchStatus.Equals(input.SwitchStatus))) return false;

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
                return hashCode;
            }
        }
    }
}
