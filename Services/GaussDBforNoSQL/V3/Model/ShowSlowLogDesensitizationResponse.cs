using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowSlowLogDesensitizationResponse : SdkResponse
    {

        /// <summary>
        /// 实例慢日志脱敏开启状态，取值：  - on 开启  - off 关闭
        /// </summary>
        [JsonProperty("desensitization_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DesensitizationStatus { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowSlowLogDesensitizationResponse {\n");
            sb.Append("  desensitizationStatus: ").Append(DesensitizationStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowSlowLogDesensitizationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowSlowLogDesensitizationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DesensitizationStatus == input.DesensitizationStatus ||
                    (this.DesensitizationStatus != null &&
                    this.DesensitizationStatus.Equals(input.DesensitizationStatus))
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
                if (this.DesensitizationStatus != null)
                    hashCode = hashCode * 59 + this.DesensitizationStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
