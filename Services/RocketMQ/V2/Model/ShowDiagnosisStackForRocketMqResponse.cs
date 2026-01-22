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
    /// Response Object
    /// </summary>
    public class ShowDiagnosisStackForRocketMqResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 线程名。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("thread_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ThreadName { get; set; }

        /// <summary>
        /// **参数解释**： 客户端的栈信息。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("stack", NullValueHandling = NullValueHandling.Ignore)]
        public string Stack { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDiagnosisStackForRocketMqResponse {\n");
            sb.Append("  threadName: ").Append(ThreadName).Append("\n");
            sb.Append("  stack: ").Append(Stack).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDiagnosisStackForRocketMqResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDiagnosisStackForRocketMqResponse input)
        {
            if (input == null) return false;
            if (this.ThreadName != input.ThreadName || (this.ThreadName != null && !this.ThreadName.Equals(input.ThreadName))) return false;
            if (this.Stack != input.Stack || (this.Stack != null && !this.Stack.Equals(input.Stack))) return false;

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
                if (this.ThreadName != null) hashCode = hashCode * 59 + this.ThreadName.GetHashCode();
                if (this.Stack != null) hashCode = hashCode * 59 + this.Stack.GetHashCode();
                return hashCode;
            }
        }
    }
}
