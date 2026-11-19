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
    public class ListRealTimeSessionsUseOpsTunnelResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**： 数据库实例的实时会话列表。
        /// </summary>
        [JsonProperty("sessions", NullValueHandling = NullValueHandling.Ignore)]
        public List<RealTimeSessionResult> Sessions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRealTimeSessionsUseOpsTunnelResponse {\n");
            sb.Append("  sessions: ").Append(Sessions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRealTimeSessionsUseOpsTunnelResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRealTimeSessionsUseOpsTunnelResponse input)
        {
            if (input == null) return false;
            if (this.Sessions != input.Sessions || (this.Sessions != null && input.Sessions != null && !this.Sessions.SequenceEqual(input.Sessions))) return false;

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
                if (this.Sessions != null) hashCode = hashCode * 59 + this.Sessions.GetHashCode();
                return hashCode;
            }
        }
    }
}
