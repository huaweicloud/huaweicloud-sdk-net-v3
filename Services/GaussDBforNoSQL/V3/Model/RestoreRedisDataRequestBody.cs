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
    /// 参数解释： 恢复到已有实例的请求body。 约束限制： 不涉及。 取值范围： 不涉及。 默认取值： 不涉及。
    /// </summary>
    public class RestoreRedisDataRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("recovery_info", NullValueHandling = NullValueHandling.Ignore)]
        public RecoveryInfo RecoveryInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreRedisDataRequestBody {\n");
            sb.Append("  recoveryInfo: ").Append(RecoveryInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreRedisDataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreRedisDataRequestBody input)
        {
            if (input == null) return false;
            if (this.RecoveryInfo != input.RecoveryInfo || (this.RecoveryInfo != null && !this.RecoveryInfo.Equals(input.RecoveryInfo))) return false;

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
                if (this.RecoveryInfo != null) hashCode = hashCode * 59 + this.RecoveryInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
