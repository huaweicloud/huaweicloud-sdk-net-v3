using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// **参数解释**： 如果出现同名模板，返回是否覆盖的结果信息。 
    /// </summary>
    public class OverwriteResultResp 
    {

        /// <summary>
        /// **参数解释**：已覆盖的模板ID值。 **取值范围**：长度为[2,64]个字符。 
        /// </summary>
        [JsonProperty("success_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string SuccessIds { get; set; }

        /// <summary>
        /// **参数解释**：未覆盖的模板ID值。 **取值范围**：长度为[2,64]个字符。 
        /// </summary>
        [JsonProperty("failed_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string FailedIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverwriteResultResp {\n");
            sb.Append("  successIds: ").Append(SuccessIds).Append("\n");
            sb.Append("  failedIds: ").Append(FailedIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OverwriteResultResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OverwriteResultResp input)
        {
            if (input == null) return false;
            if (this.SuccessIds != input.SuccessIds || (this.SuccessIds != null && !this.SuccessIds.Equals(input.SuccessIds))) return false;
            if (this.FailedIds != input.FailedIds || (this.FailedIds != null && !this.FailedIds.Equals(input.FailedIds))) return false;

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
                if (this.SuccessIds != null) hashCode = hashCode * 59 + this.SuccessIds.GetHashCode();
                if (this.FailedIds != null) hashCode = hashCode * 59 + this.FailedIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
