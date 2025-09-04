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
    /// 配置文件夹重定向。
    /// </summary>
    public class PoliciesFolderRedirection 
    {

        /// <summary>
        /// 配置文件夹重定向状态： 0: 已禁用 1: 已启用 2: 未配置
        /// </summary>
        [JsonProperty("folder_redirection_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? FolderRedirectionStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public FolderRedirectionOptions Options { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliciesFolderRedirection {\n");
            sb.Append("  folderRedirectionStatus: ").Append(FolderRedirectionStatus).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoliciesFolderRedirection);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoliciesFolderRedirection input)
        {
            if (input == null) return false;
            if (this.FolderRedirectionStatus != input.FolderRedirectionStatus || (this.FolderRedirectionStatus != null && !this.FolderRedirectionStatus.Equals(input.FolderRedirectionStatus))) return false;
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
                if (this.FolderRedirectionStatus != null) hashCode = hashCode * 59 + this.FolderRedirectionStatus.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                return hashCode;
            }
        }
    }
}
