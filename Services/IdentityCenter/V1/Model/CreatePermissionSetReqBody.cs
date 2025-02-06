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
    /// 创建权限集的请求体
    /// </summary>
    public class CreatePermissionSetReqBody 
    {

        /// <summary>
        /// 权限集描述.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 权限集名称.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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
        /// 要附加到新权限集的标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagDto> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePermissionSetReqBody {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  relayState: ").Append(RelayState).Append("\n");
            sb.Append("  sessionDuration: ").Append(SessionDuration).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.RelayState != input.RelayState || (this.RelayState != null && !this.RelayState.Equals(input.RelayState))) return false;
            if (this.SessionDuration != input.SessionDuration || (this.SessionDuration != null && !this.SessionDuration.Equals(input.SessionDuration))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RelayState != null) hashCode = hashCode * 59 + this.RelayState.GetHashCode();
                if (this.SessionDuration != null) hashCode = hashCode * 59 + this.SessionDuration.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
