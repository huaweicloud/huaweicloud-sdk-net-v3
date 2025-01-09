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
    /// 桌面连接状态信息。
    /// </summary>
    public class ConnectDesktopsInfo 
    {

        /// <summary>
        /// 桌面id。
        /// </summary>
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopId { get; set; }

        /// <summary>
        /// 桌面名称。
        /// </summary>
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面的连接状态。  - UNREGISTER：表示桌面未注册时的状态（桌面启动后，会自动注册）。关机后也会出现未注册的状态。 - REGISTERED：表示桌面注册以后，等待用户连接的状态。 - CONNECTED：表示用户已经成功连接，正在使用桌面。 - DISCONNECTED：表示桌面与客户端断开会话后显示的状态，可能为关闭客户端窗口，或客户端与桌面网络断开引起。
        /// </summary>
        [JsonProperty("connect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectStatus { get; set; }

        /// <summary>
        /// 桌面已分配的用户或用户组信息列表。
        /// </summary>
        [JsonProperty("attach_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachUsersInfo> AttachUsers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectDesktopsInfo {\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  connectStatus: ").Append(ConnectStatus).Append("\n");
            sb.Append("  attachUsers: ").Append(AttachUsers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectDesktopsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConnectDesktopsInfo input)
        {
            if (input == null) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && !this.DesktopId.Equals(input.DesktopId))) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.ConnectStatus != input.ConnectStatus || (this.ConnectStatus != null && !this.ConnectStatus.Equals(input.ConnectStatus))) return false;
            if (this.AttachUsers != input.AttachUsers || (this.AttachUsers != null && input.AttachUsers != null && !this.AttachUsers.SequenceEqual(input.AttachUsers))) return false;

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
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.ConnectStatus != null) hashCode = hashCode * 59 + this.ConnectStatus.GetHashCode();
                if (this.AttachUsers != null) hashCode = hashCode * 59 + this.AttachUsers.GetHashCode();
                return hashCode;
            }
        }
    }
}
