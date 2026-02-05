using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ResetParameterGroupResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  是否需要重启。  **参数范围**：  false、true。
        /// </summary>
        [JsonProperty("need_restart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedRestart { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResetParameterGroupResponse {\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResetParameterGroupResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResetParameterGroupResponse input)
        {
            if (input == null) return false;
            if (this.NeedRestart != input.NeedRestart || (this.NeedRestart != null && !this.NeedRestart.Equals(input.NeedRestart))) return false;

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
                if (this.NeedRestart != null) hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                return hashCode;
            }
        }
    }
}
