using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TrashcanResultData 
    {

        /// <summary>
        /// **参数解释**： 成功数目。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("successNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }

        /// <summary>
        /// **参数解释**： 失败数目。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("failedNum", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// **参数解释**： 失败原因。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("failedMessages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> FailedMessages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrashcanResultData {\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  failedMessages: ").Append(FailedMessages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrashcanResultData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrashcanResultData input)
        {
            if (input == null) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailedNum != input.FailedNum || (this.FailedNum != null && !this.FailedNum.Equals(input.FailedNum))) return false;
            if (this.FailedMessages != input.FailedMessages || (this.FailedMessages != null && input.FailedMessages != null && !this.FailedMessages.SequenceEqual(input.FailedMessages))) return false;

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
                if (this.SuccessNum != null) hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                if (this.FailedNum != null) hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.FailedMessages != null) hashCode = hashCode * 59 + this.FailedMessages.GetHashCode();
                return hashCode;
            }
        }
    }
}
