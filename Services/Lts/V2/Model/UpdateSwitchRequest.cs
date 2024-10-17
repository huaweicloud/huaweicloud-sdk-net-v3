using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateSwitchRequest 
    {

        /// <summary>
        /// 开关参数
        /// </summary>
        [SDKProperty("log_converge_switch", IsQuery = true)]
        [JsonProperty("log_converge_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string LogConvergeSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSwitchRequest {\n");
            sb.Append("  logConvergeSwitch: ").Append(LogConvergeSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSwitchRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSwitchRequest input)
        {
            if (input == null) return false;
            if (this.LogConvergeSwitch != input.LogConvergeSwitch || (this.LogConvergeSwitch != null && !this.LogConvergeSwitch.Equals(input.LogConvergeSwitch))) return false;

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
                if (this.LogConvergeSwitch != null) hashCode = hashCode * 59 + this.LogConvergeSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
