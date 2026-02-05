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
    /// 用户漫游profiles配置。
    /// </summary>
    public class UserProfileManagementProfiles 
    {

        /// <summary>
        /// 配置VHD会话回写状态： 0: 已禁用 1: 已启用 2: 未配置
        /// </summary>
        [JsonProperty("vhd_write_back", NullValueHandling = NullValueHandling.Ignore)]
        public string VhdWriteBack { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserProfileManagementProfiles {\n");
            sb.Append("  vhdWriteBack: ").Append(VhdWriteBack).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserProfileManagementProfiles);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserProfileManagementProfiles input)
        {
            if (input == null) return false;
            if (this.VhdWriteBack != input.VhdWriteBack || (this.VhdWriteBack != null && !this.VhdWriteBack.Equals(input.VhdWriteBack))) return false;

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
                if (this.VhdWriteBack != null) hashCode = hashCode * 59 + this.VhdWriteBack.GetHashCode();
                return hashCode;
            }
        }
    }
}
