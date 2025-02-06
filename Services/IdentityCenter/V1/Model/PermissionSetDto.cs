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
    /// 包含权限集详细信息的对象
    /// </summary>
    public class PermissionSetDto 
    {

        /// <summary>
        /// 权限集的创建时间
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// 权限集的描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 权限集的名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 权限集的唯一标识
        /// </summary>
        [JsonProperty("permission_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionSetId { get; set; }

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
        /// 权限集的统一资源名称（URN）
        /// </summary>
        [JsonProperty("permission_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionSetDto {\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  permissionSetId: ").Append(PermissionSetId).Append("\n");
            sb.Append("  relayState: ").Append(RelayState).Append("\n");
            sb.Append("  sessionDuration: ").Append(SessionDuration).Append("\n");
            sb.Append("  permissionUrn: ").Append(PermissionUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionSetDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionSetDto input)
        {
            if (input == null) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PermissionSetId != input.PermissionSetId || (this.PermissionSetId != null && !this.PermissionSetId.Equals(input.PermissionSetId))) return false;
            if (this.RelayState != input.RelayState || (this.RelayState != null && !this.RelayState.Equals(input.RelayState))) return false;
            if (this.SessionDuration != input.SessionDuration || (this.SessionDuration != null && !this.SessionDuration.Equals(input.SessionDuration))) return false;
            if (this.PermissionUrn != input.PermissionUrn || (this.PermissionUrn != null && !this.PermissionUrn.Equals(input.PermissionUrn))) return false;

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
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PermissionSetId != null) hashCode = hashCode * 59 + this.PermissionSetId.GetHashCode();
                if (this.RelayState != null) hashCode = hashCode * 59 + this.RelayState.GetHashCode();
                if (this.SessionDuration != null) hashCode = hashCode * 59 + this.SessionDuration.GetHashCode();
                if (this.PermissionUrn != null) hashCode = hashCode * 59 + this.PermissionUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
