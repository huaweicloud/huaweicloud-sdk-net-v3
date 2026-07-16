using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchDeleteInferServicesResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 服务响应返回体。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("service_responses", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceResponse> ServiceResponses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteInferServicesResponse {\n");
            sb.Append("  serviceResponses: ").Append(ServiceResponses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteInferServicesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteInferServicesResponse input)
        {
            if (input == null) return false;
            if (this.ServiceResponses != input.ServiceResponses || (this.ServiceResponses != null && input.ServiceResponses != null && !this.ServiceResponses.SequenceEqual(input.ServiceResponses))) return false;

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
                if (this.ServiceResponses != null) hashCode = hashCode * 59 + this.ServiceResponses.GetHashCode();
                return hashCode;
            }
        }
    }
}
