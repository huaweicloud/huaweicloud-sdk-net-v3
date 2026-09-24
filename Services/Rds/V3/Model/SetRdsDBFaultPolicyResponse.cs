using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SetRdsDBFaultPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  请求状态。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// **参数解释**：  错误信息。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("errmsg", NullValueHandling = NullValueHandling.Ignore)]
        public string Errmsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetRdsDBFaultPolicyResponse {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  errmsg: ").Append(Errmsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetRdsDBFaultPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetRdsDBFaultPolicyResponse input)
        {
            if (input == null) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Errmsg != input.Errmsg || (this.Errmsg != null && !this.Errmsg.Equals(input.Errmsg))) return false;

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
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Errmsg != null) hashCode = hashCode * 59 + this.Errmsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
