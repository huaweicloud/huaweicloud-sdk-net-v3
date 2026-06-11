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
    /// 配置文件夹重定向(v2)。
    /// </summary>
    public class PoliciesFolderRedirectionV2 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 关闭 1: 已启用
        /// </summary>
        [JsonProperty("folder_redirection_v2_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? FolderRedirectionV2Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public FolderRedirectionV2Options Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFolderRedirectionV2 {\n");
            sb.Append("  folderRedirectionV2Status: ").Append(FolderRedirectionV2Status).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFolderRedirectionV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFolderRedirectionV2 input)
        {
            if (input == null) return false;
            if (this.FolderRedirectionV2Status != input.FolderRedirectionV2Status || (this.FolderRedirectionV2Status != null && !this.FolderRedirectionV2Status.Equals(input.FolderRedirectionV2Status))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;

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
                if (this.FolderRedirectionV2Status != null) hashCode = hashCode * 59 + this.FolderRedirectionV2Status.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
