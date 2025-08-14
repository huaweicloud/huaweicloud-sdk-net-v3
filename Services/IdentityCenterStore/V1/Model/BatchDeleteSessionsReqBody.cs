using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterStore.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteSessionsReqBody 
    {

        /// <summary>
        /// 用户登录会话标识符（ID）
        /// </summary>
        [JsonProperty("session_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SessionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteSessionsReqBody {\n");
            sb.Append("  sessionIds: ").Append(SessionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteSessionsReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteSessionsReqBody input)
        {
            if (input == null) return false;
            if (this.SessionIds != input.SessionIds || (this.SessionIds != null && input.SessionIds != null && !this.SessionIds.SequenceEqual(input.SessionIds))) return false;

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
                if (this.SessionIds != null) hashCode = hashCode * 59 + this.SessionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
