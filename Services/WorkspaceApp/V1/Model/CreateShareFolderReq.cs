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
    /// 创建共享存储声明。
    /// </summary>
    public class CreateShareFolderReq 
    {

        /// <summary>
        /// - 仅支持创建单层级的文件夹。 - 单个文件夹名称仅支持以下字符: 英文字母、数字、空格、下划线、中划线。 - 名称不能超过32字符。 - 不能为全空格或者以空格开头。
        /// </summary>
        [JsonProperty("folder_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FolderName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateShareFolderReq {\n");
            sb.Append("  folderName: ").Append(FolderName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateShareFolderReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateShareFolderReq input)
        {
            if (input == null) return false;
            if (this.FolderName != input.FolderName || (this.FolderName != null && !this.FolderName.Equals(input.FolderName))) return false;

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
                if (this.FolderName != null) hashCode = hashCode * 59 + this.FolderName.GetHashCode();
                return hashCode;
            }
        }
    }
}
