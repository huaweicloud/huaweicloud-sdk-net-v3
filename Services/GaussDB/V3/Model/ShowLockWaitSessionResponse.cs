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
    /// Response Object
    /// </summary>
    public class ShowLockWaitSessionResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("abnormal_root_cause", NullValueHandling = NullValueHandling.Ignore)]
        public AbnormalRootCause AbnormalRootCause { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLockWaitSessionResponse {\n");
            sb.Append("  abnormalRootCause: ").Append(AbnormalRootCause).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLockWaitSessionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLockWaitSessionResponse input)
        {
            if (input == null) return false;
            if (this.AbnormalRootCause != input.AbnormalRootCause || (this.AbnormalRootCause != null && !this.AbnormalRootCause.Equals(input.AbnormalRootCause))) return false;

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
                if (this.AbnormalRootCause != null) hashCode = hashCode * 59 + this.AbnormalRootCause.GetHashCode();
                return hashCode;
            }
        }
    }
}
