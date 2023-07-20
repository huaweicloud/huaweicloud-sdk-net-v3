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
    /// Response Object
    /// </summary>
    public class ShowAuditLogResponse : SdkResponse
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
            sb.Append("class ShowAuditLogResponse {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuditLogResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuditLogResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SwitchStatus == input.SwitchStatus ||
                    (this.SwitchStatus != null &&
                    this.SwitchStatus.Equals(input.SwitchStatus))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SwitchStatus != null)
                    hashCode = hashCode * 59 + this.SwitchStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
