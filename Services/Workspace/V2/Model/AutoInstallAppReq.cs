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
    /// 自动安装应用。
    /// </summary>
    public class AutoInstallAppReq 
    {

        /// <summary>
        /// 安装命令(静默安装命令)。 例: ${FILE_PATH} /S 预定义变量将采用以下值: ${FILE_PATH}: 应用安装包在桌面本地的存储路径。
        /// </summary>
        [JsonProperty("install_command", NullValueHandling = NullValueHandling.Ignore)]
        public string InstallCommand { get; set; }

        /// <summary>
        /// 卸载命令(静默卸载命令)。 例: msiexec /uninstall ${FILE_PATH} /quiet。 预定义变量将采用以下值: ${FILE_PATH}: 应用安装包在桌面本地的存储路径。
        /// </summary>
        [JsonProperty("uninstall_command", NullValueHandling = NullValueHandling.Ignore)]
        public string UninstallCommand { get; set; }

        /// <summary>
        /// 指定安装用户。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccountInfo> Users { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutoInstallAppReq {\n");
            sb.Append("  installCommand: ").Append(InstallCommand).Append("\n");
            sb.Append("  uninstallCommand: ").Append(UninstallCommand).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AutoInstallAppReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AutoInstallAppReq input)
        {
            if (input == null) return false;
            if (this.InstallCommand != input.InstallCommand || (this.InstallCommand != null && !this.InstallCommand.Equals(input.InstallCommand))) return false;
            if (this.UninstallCommand != input.UninstallCommand || (this.UninstallCommand != null && !this.UninstallCommand.Equals(input.UninstallCommand))) return false;
            if (this.Users != input.Users || (this.Users != null && input.Users != null && !this.Users.SequenceEqual(input.Users))) return false;

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
                if (this.InstallCommand != null) hashCode = hashCode * 59 + this.InstallCommand.GetHashCode();
                if (this.UninstallCommand != null) hashCode = hashCode * 59 + this.UninstallCommand.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                return hashCode;
            }
        }
    }
}
