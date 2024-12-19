using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateConformancePackRequest 
    {

        /// <summary>
        /// 合规规则包ID。
        /// </summary>
        [SDKProperty("conformance_pack_id", IsPath = true)]
        [JsonProperty("conformance_pack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConformancePackId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateConformancePackRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateConformancePackRequest {\n");
            sb.Append("  conformancePackId: ").Append(ConformancePackId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateConformancePackRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateConformancePackRequest input)
        {
            if (input == null) return false;
            if (this.ConformancePackId != input.ConformancePackId || (this.ConformancePackId != null && !this.ConformancePackId.Equals(input.ConformancePackId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ConformancePackId != null) hashCode = hashCode * 59 + this.ConformancePackId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
