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
    /// 每个用户所关联的桌面池列表信息
    /// </summary>
    public class ShowDesktopPoolListByUsersInfo 
    {

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 桌面池数
        /// </summary>
        [JsonProperty("desktop_pool_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesktopPoolCount { get; set; }

        /// <summary>
        /// 运行状态统计
        /// </summary>
        [JsonProperty("desktop_pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachDesktopPoolsInfo> DesktopPools { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDesktopPoolListByUsersInfo {\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  desktopPoolCount: ").Append(DesktopPoolCount).Append("\n");
            sb.Append("  desktopPools: ").Append(DesktopPools).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDesktopPoolListByUsersInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDesktopPoolListByUsersInfo input)
        {
            if (input == null) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.DesktopPoolCount != input.DesktopPoolCount || (this.DesktopPoolCount != null && !this.DesktopPoolCount.Equals(input.DesktopPoolCount))) return false;
            if (this.DesktopPools != input.DesktopPools || (this.DesktopPools != null && input.DesktopPools != null && !this.DesktopPools.SequenceEqual(input.DesktopPools))) return false;

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
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.DesktopPoolCount != null) hashCode = hashCode * 59 + this.DesktopPoolCount.GetHashCode();
                if (this.DesktopPools != null) hashCode = hashCode * 59 + this.DesktopPools.GetHashCode();
                return hashCode;
            }
        }
    }
}
