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
    /// 文件分享
    /// </summary>
    public class TransferFileReq 
    {

        /// <summary>
        /// 操作方式, 0:个人-&gt;共享, 1:共享-&gt;个人。
        /// </summary>
        [JsonProperty("transfer_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TransferType { get; set; }

        /// <summary>
        /// 分享者或接收者的用户标识。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 待流转文件url。
        /// </summary>
        [JsonProperty("file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUrl { get; set; }

        /// <summary>
        /// 文件编码(仅接收文件使用，从分享返回体获取)。
        /// </summary>
        [JsonProperty("file_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileCode { get; set; }

        /// <summary>
        /// 文件提取码(仅接收文件使用，从分享返回体获取)。
        /// </summary>
        [JsonProperty("file_acc_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FileAccCode { get; set; }

        /// <summary>
        /// 目标文件url。
        /// </summary>
        [JsonProperty("target_file_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetFileUrl { get; set; }

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
            sb.Append("class TransferFileReq {\n");
            sb.Append("  transferType: ").Append(TransferType).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  fileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  fileCode: ").Append(FileCode).Append("\n");
            sb.Append("  fileAccCode: ").Append(FileAccCode).Append("\n");
            sb.Append("  targetFileUrl: ").Append(TargetFileUrl).Append("\n");
            sb.Append("  fileSystemName: ").Append(FileSystemName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferFileReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransferFileReq input)
        {
            if (input == null) return false;
            if (this.TransferType != input.TransferType || (this.TransferType != null && !this.TransferType.Equals(input.TransferType))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.FileUrl != input.FileUrl || (this.FileUrl != null && !this.FileUrl.Equals(input.FileUrl))) return false;
            if (this.FileCode != input.FileCode || (this.FileCode != null && !this.FileCode.Equals(input.FileCode))) return false;
            if (this.FileAccCode != input.FileAccCode || (this.FileAccCode != null && !this.FileAccCode.Equals(input.FileAccCode))) return false;
            if (this.TargetFileUrl != input.TargetFileUrl || (this.TargetFileUrl != null && !this.TargetFileUrl.Equals(input.TargetFileUrl))) return false;
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
                if (this.TransferType != null) hashCode = hashCode * 59 + this.TransferType.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.FileUrl != null) hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                if (this.FileCode != null) hashCode = hashCode * 59 + this.FileCode.GetHashCode();
                if (this.FileAccCode != null) hashCode = hashCode * 59 + this.FileAccCode.GetHashCode();
                if (this.TargetFileUrl != null) hashCode = hashCode * 59 + this.TargetFileUrl.GetHashCode();
                if (this.FileSystemName != null) hashCode = hashCode * 59 + this.FileSystemName.GetHashCode();
                return hashCode;
            }
        }
    }
}
