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
    /// 桌面属性
    /// </summary>
    public class ModifyDesktopAttributesReqDesktop 
    {

        /// <summary>
        /// 桌面名
        /// </summary>
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 是否开启快照的操作类型,\&quot;0\&quot;:关闭 \&quot;1\&quot;:开启
        /// </summary>
        [JsonProperty("self_backup_management", NullValueHandling = NullValueHandling.Ignore)]
        public string SelfBackupManagement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyDesktopAttributesReqDesktop {\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  selfBackupManagement: ").Append(SelfBackupManagement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyDesktopAttributesReqDesktop);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyDesktopAttributesReqDesktop input)
        {
            if (input == null) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.SelfBackupManagement != input.SelfBackupManagement || (this.SelfBackupManagement != null && !this.SelfBackupManagement.Equals(input.SelfBackupManagement))) return false;

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
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.SelfBackupManagement != null) hashCode = hashCode * 59 + this.SelfBackupManagement.GetHashCode();
                return hashCode;
            }
        }
    }
}
