using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateRemoteAssistanceResponse : SdkResponse
    {

        /// <summary>
        /// 协同空间ID。
        /// </summary>
        [JsonProperty("share_space_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ShareSpaceId { get; set; }

        /// <summary>
        /// 协同空间状态 - OPEN 协同空间已创建 - CLOSE 协同空间已关闭 - WAIT_USER_CONFIRM 等待用户确认进入远程协助 - WAIT_USER_ACCESS 等待用户进入远程协助
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 桌面的desktopId。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 发起方类型 - ADMIN_INITIATE 管理员发起 - ENDUSER_INITIATE 终端用户发起
        /// </summary>
        [JsonProperty("initiator_type", NullValueHandling = NullValueHandling.Ignore)]
        public string InitiatorType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRemoteAssistanceResponse {\n");
            sb.Append("  shareSpaceId: ").Append(ShareSpaceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  initiatorType: ").Append(InitiatorType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRemoteAssistanceResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRemoteAssistanceResponse input)
        {
            if (input == null) return false;
            if (this.ShareSpaceId != input.ShareSpaceId || (this.ShareSpaceId != null && !this.ShareSpaceId.Equals(input.ShareSpaceId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.InitiatorType != input.InitiatorType || (this.InitiatorType != null && !this.InitiatorType.Equals(input.InitiatorType))) return false;

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
                if (this.ShareSpaceId != null) hashCode = hashCode * 59 + this.ShareSpaceId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.InitiatorType != null) hashCode = hashCode * 59 + this.InitiatorType.GetHashCode();
                return hashCode;
            }
        }
    }
}
