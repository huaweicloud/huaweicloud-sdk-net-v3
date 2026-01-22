using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDiagnosisStackForRocketMqRequest 
    {

        /// <summary>
        /// **参数解释**： 堆ID。 从查询实例诊断报告接口获取。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("stack_id", IsPath = true)]
        [JsonProperty("stack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StackId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDiagnosisStackForRocketMqRequest {\n");
            sb.Append("  stackId: ").Append(StackId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDiagnosisStackForRocketMqRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDiagnosisStackForRocketMqRequest input)
        {
            if (input == null) return false;
            if (this.StackId != input.StackId || (this.StackId != null && !this.StackId.Equals(input.StackId))) return false;

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
                if (this.StackId != null) hashCode = hashCode * 59 + this.StackId.GetHashCode();
                return hashCode;
            }
        }
    }
}
