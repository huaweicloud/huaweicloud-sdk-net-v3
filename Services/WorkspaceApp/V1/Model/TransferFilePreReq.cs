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
    /// 文件预流转请求体
    /// </summary>
    public class TransferFilePreReq 
    {

        /// <summary>
        /// 分享者或接收者的用户标识。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 待流转的文件名称，不包含完整路径。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件编码。
        /// </summary>
        [JsonProperty("file_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileCode { get; set; }

        /// <summary>
        /// 文件提取码。
        /// </summary>
        [JsonProperty("file_acc_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileAccCode { get; set; }

        /// <summary>
        /// 文件系统名称。
        /// </summary>
        [JsonProperty("file_system_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSystemName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferFilePreReq {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileCode: ").Append(FileCode).Append("\n");
            sb.Append("  fileAccCode: ").Append(FileAccCode).Append("\n");
            sb.Append("  fileSystemName: ").Append(FileSystemName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferFilePreReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferFilePreReq input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileCode != input.FileCode || (this.FileCode != null && !this.FileCode.Equals(input.FileCode))) return false;
            if (this.FileAccCode != input.FileAccCode || (this.FileAccCode != null && !this.FileAccCode.Equals(input.FileAccCode))) return false;
            if (this.FileSystemName != input.FileSystemName || (this.FileSystemName != null && !this.FileSystemName.Equals(input.FileSystemName))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileCode != null) hashCode = hashCode * 59 + this.FileCode.GetHashCode();
                if (this.FileAccCode != null) hashCode = hashCode * 59 + this.FileAccCode.GetHashCode();
                if (this.FileSystemName != null) hashCode = hashCode * 59 + this.FileSystemName.GetHashCode();
                return hashCode;
            }
        }
    }
}
