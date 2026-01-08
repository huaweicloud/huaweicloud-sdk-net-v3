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
    /// 关联桌面池信息
    /// </summary>
    public class AttachDesktopPoolsInfo 
    {

        /// <summary>
        /// 桌面池id
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 桌面池名称
        /// </summary>
        [JsonProperty("desktop_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolName { get; set; }

        /// <summary>
        /// 是否分配了桌面
        /// </summary>
        [JsonProperty("is_attached", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAttached { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachDesktopPoolsInfo {\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  desktopPoolName: ").Append(DesktopPoolName).Append("\n");
            sb.Append("  isAttached: ").Append(IsAttached).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachDesktopPoolsInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachDesktopPoolsInfo input)
        {
            if (input == null) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.DesktopPoolName != input.DesktopPoolName || (this.DesktopPoolName != null && !this.DesktopPoolName.Equals(input.DesktopPoolName))) return false;
            if (this.IsAttached != input.IsAttached || (this.IsAttached != null && !this.IsAttached.Equals(input.IsAttached))) return false;

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
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.DesktopPoolName != null) hashCode = hashCode * 59 + this.DesktopPoolName.GetHashCode();
                if (this.IsAttached != null) hashCode = hashCode * 59 + this.IsAttached.GetHashCode();
                return hashCode;
            }
        }
    }
}
