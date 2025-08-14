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
    /// Response Object
    /// </summary>
    public class ListSessionsResponse : SdkResponse
    {

        /// <summary>
        /// 用户登录会话列表
        /// </summary>
        [JsonProperty("session_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserSessionDto> SessionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionsResponse {\n");
            sb.Append("  sessionList: ").Append(SessionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionsResponse input)
        {
            if (input == null) return false;
            if (this.SessionList != input.SessionList || (this.SessionList != null && input.SessionList != null && !this.SessionList.SequenceEqual(input.SessionList))) return false;

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
                if (this.SessionList != null) hashCode = hashCode * 59 + this.SessionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
