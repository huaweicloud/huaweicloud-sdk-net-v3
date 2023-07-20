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
    /// 开启/关闭SQL限流参数体
    /// </summary>
    public class OperateSqlFilterControlReq 
    {

        /// <summary>
        /// SQL限流开关状态。 取值： - ON，表示开启。 - OFF，表示关闭。
        /// </summary>
        [JsonProperty("switch_status", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperateSqlFilterControlReq {\n");
            sb.Append("  switchStatus: ").Append(SwitchStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OperateSqlFilterControlReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OperateSqlFilterControlReq input)
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
