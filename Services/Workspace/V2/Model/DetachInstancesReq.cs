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
    /// 解绑用户请求
    /// </summary>
    public class DetachInstancesReq 
    {

        /// <summary>
        /// 桌面id,不能为空
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 解绑后是否关机。
        /// </summary>
        [JsonProperty("shutoff_after_detach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShutoffAfterDetach { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DetachInstancesReq {\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  shutoffAfterDetach: ").Append(ShutoffAfterDetach).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DetachInstancesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DetachInstancesReq input)
        {
            if (input == null) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.ShutoffAfterDetach != input.ShutoffAfterDetach || (this.ShutoffAfterDetach != null && !this.ShutoffAfterDetach.Equals(input.ShutoffAfterDetach))) return false;

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
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.ShutoffAfterDetach != null) hashCode = hashCode * 59 + this.ShutoffAfterDetach.GetHashCode();
                return hashCode;
            }
        }
    }
}
