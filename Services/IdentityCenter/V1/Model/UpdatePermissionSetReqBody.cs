using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// UpdatePermissionSet请求体
    /// </summary>
    public class UpdatePermissionSetReqBody 
    {

        /// <summary>
        /// 权限集描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 用于在联合身份验证过程中重定向应用程序中的用户
        /// </summary>
        [JsonProperty("relay_state", NullValueHandling = NullValueHandling.Ignore)]
        public string RelayState { get; set; }

        /// <summary>
        /// 应用程序用户会话在ISO-8601标准中有效的时间长度
        /// </summary>
        [JsonProperty("session_duration", NullValueHandling = NullValueHandling.Ignore)]
        public string SessionDuration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePermissionSetReqBody {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  relayState: ").Append(RelayState).Append("\n");
            sb.Append("  sessionDuration: ").Append(SessionDuration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.RelayState != input.RelayState || (this.RelayState != null && !this.RelayState.Equals(input.RelayState))) return false;
            if (this.SessionDuration != input.SessionDuration || (this.SessionDuration != null && !this.SessionDuration.Equals(input.SessionDuration))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RelayState != null) hashCode = hashCode * 59 + this.RelayState.GetHashCode();
                if (this.SessionDuration != null) hashCode = hashCode * 59 + this.SessionDuration.GetHashCode();
                return hashCode;
            }
        }
    }
}
