using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AbnormalRootCause 
    {

        /// <summary>
        /// **参数解释**： 异常类型。 **取值范围**： LOCK_WAIT：锁等待。 
        /// </summary>
        [JsonProperty("abnormal_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AbnormalType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lock_root_cause", NullValueHandling = NullValueHandling.Ignore)]
        public LockRootCause LockRootCause { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbnormalRootCause {\n");
            sb.Append("  abnormalType: ").Append(AbnormalType).Append("\n");
            sb.Append("  lockRootCause: ").Append(LockRootCause).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AbnormalRootCause);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AbnormalRootCause input)
        {
            if (input == null) return false;
            if (this.AbnormalType != input.AbnormalType || (this.AbnormalType != null && !this.AbnormalType.Equals(input.AbnormalType))) return false;
            if (this.LockRootCause != input.LockRootCause || (this.LockRootCause != null && !this.LockRootCause.Equals(input.LockRootCause))) return false;

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
                if (this.AbnormalType != null) hashCode = hashCode * 59 + this.AbnormalType.GetHashCode();
                if (this.LockRootCause != null) hashCode = hashCode * 59 + this.LockRootCause.GetHashCode();
                return hashCode;
            }
        }
    }
}
