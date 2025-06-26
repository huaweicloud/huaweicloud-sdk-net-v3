using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListSessionByUserNameResponse : SdkResponse
    {

        /// <summary>
        /// 会话信息列表。
        /// </summary>
        [JsonProperty("session_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppSession> SessionInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSessionByUserNameResponse {\n");
            sb.Append("  sessionInfoList: ").Append(SessionInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSessionByUserNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSessionByUserNameResponse input)
        {
            if (input == null) return false;
            if (this.SessionInfoList != input.SessionInfoList || (this.SessionInfoList != null && input.SessionInfoList != null && !this.SessionInfoList.SequenceEqual(input.SessionInfoList))) return false;

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
                if (this.SessionInfoList != null) hashCode = hashCode * 59 + this.SessionInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
