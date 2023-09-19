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
    /// Response Object
    /// </summary>
    public class ShowAdminConfigResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_converge_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogConvergeSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAdminConfigResponse {\n");
            sb.Append("  logConvergeSwitch: ").Append(LogConvergeSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAdminConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAdminConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogConvergeSwitch == input.LogConvergeSwitch ||
                    (this.LogConvergeSwitch != null &&
                    this.LogConvergeSwitch.Equals(input.LogConvergeSwitch))
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
                if (this.LogConvergeSwitch != null)
                    hashCode = hashCode * 59 + this.LogConvergeSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
