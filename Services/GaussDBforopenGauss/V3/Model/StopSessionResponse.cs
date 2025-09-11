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
    public class StopSessionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 查杀指定会话ID列表。
        /// </summary>
        [JsonProperty("session_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SessionIds { get; set; }

        /// <summary>
        /// **参数解释**： 结束会话操作执行是否成功。 **取值范围**: - true：成功。 - false：失败。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopSessionResponse {\n");
            sb.Append("  sessionIds: ").Append(SessionIds).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopSessionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopSessionResponse input)
        {
            if (input == null) return false;
            if (this.SessionIds != input.SessionIds || (this.SessionIds != null && input.SessionIds != null && !this.SessionIds.SequenceEqual(input.SessionIds))) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;

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
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                return hashCode;
            }
        }
    }
}
