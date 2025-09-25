using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class BatchSetBackupPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**: 设置成功的实例数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("succeeded_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SucceededNum { get; set; }

        /// <summary>
        /// **参数解释**: 设置失败的实例数量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// **参数解释**: 设置失败的实例记录。
        /// </summary>
        [JsonProperty("failed_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchSetBackupPolicyFailedRecordResult> FailedInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchSetBackupPolicyResponse {\n");
            sb.Append("  succeededNum: ").Append(SucceededNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  failedInstances: ").Append(FailedInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchSetBackupPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchSetBackupPolicyResponse input)
        {
            if (input == null) return false;
            if (this.SucceededNum != input.SucceededNum || (this.SucceededNum != null && !this.SucceededNum.Equals(input.SucceededNum))) return false;
            if (this.FailedNum != input.FailedNum || (this.FailedNum != null && !this.FailedNum.Equals(input.FailedNum))) return false;
            if (this.FailedInstances != input.FailedInstances || (this.FailedInstances != null && input.FailedInstances != null && !this.FailedInstances.SequenceEqual(input.FailedInstances))) return false;

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
                if (this.SucceededNum != null) hashCode = hashCode * 59 + this.SucceededNum.GetHashCode();
                if (this.FailedNum != null) hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.FailedInstances != null) hashCode = hashCode * 59 + this.FailedInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
