using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteSecretForScheduleRequestBody 
    {

        /// <summary>
        /// 创建定时删除凭据的任务，且指定可恢复的天数。  约束：7~30。  默认值：30。 
        /// </summary>
        [JsonProperty("recovery_window_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RecoveryWindowInDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteSecretForScheduleRequestBody {\n");
            sb.Append("  recoveryWindowInDays: ").Append(RecoveryWindowInDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteSecretForScheduleRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteSecretForScheduleRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecoveryWindowInDays == input.RecoveryWindowInDays ||
                    (this.RecoveryWindowInDays != null &&
                    this.RecoveryWindowInDays.Equals(input.RecoveryWindowInDays))
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
                if (this.RecoveryWindowInDays != null)
                    hashCode = hashCode * 59 + this.RecoveryWindowInDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
