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
    public class ShowRiskInfoResponse : SdkResponse
    {

        /// <summary>
        /// 内核风险提醒信息。
        /// </summary>
        [JsonProperty("risks", NullValueHandling = NullValueHandling.Ignore)]
        public List<Risks> Risks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRiskInfoResponse {\n");
            sb.Append("  risks: ").Append(Risks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRiskInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRiskInfoResponse input)
        {
            if (input == null) return false;
            if (this.Risks != input.Risks || (this.Risks != null && input.Risks != null && !this.Risks.SequenceEqual(input.Risks))) return false;

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
                if (this.Risks != null) hashCode = hashCode * 59 + this.Risks.GetHashCode();
                return hashCode;
            }
        }
    }
}
