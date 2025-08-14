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
    /// 创建个人文件夹。
    /// </summary>
    public class CreateUserAssignmentInfo 
    {

        /// <summary>
        /// 目标用户id。
        /// </summary>
        [JsonProperty("attach_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachId { get; set; }

        /// <summary>
        /// 目标用户。
        /// </summary>
        [JsonProperty("attach_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AttachName { get; set; }

        /// <summary>
        /// 配额。
        /// </summary>
        [JsonProperty("file_system_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSystemQuota { get; set; }

        /// <summary>
        /// 云存储于本地设备的权限，上传： true : 允许上传。 false: 不允许上传。
        /// </summary>
        [JsonProperty("action_put", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionPut { get; set; }

        /// <summary>
        /// 云存储于本地设备的权限，下载： true : 允许下载。 false: 不允许下载。
        /// </summary>
        [JsonProperty("action_get", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionGet { get; set; }

        /// <summary>
        /// 云存储于云桌面/云应用权限，上传： true : 允许上传。 false: 不允许上传。
        /// </summary>
        [JsonProperty("roam_action_put", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RoamActionPut { get; set; }

        /// <summary>
        /// 云存储于云桌面/云应用权限，下载： true : 允许下载。 false: 不允许下载。
        /// </summary>
        [JsonProperty("roam_action_get", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RoamActionGet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserAssignmentInfo {\n");
            sb.Append("  attachId: ").Append(AttachId).Append("\n");
            sb.Append("  attachName: ").Append(AttachName).Append("\n");
            sb.Append("  fileSystemQuota: ").Append(FileSystemQuota).Append("\n");
            sb.Append("  actionPut: ").Append(ActionPut).Append("\n");
            sb.Append("  actionGet: ").Append(ActionGet).Append("\n");
            sb.Append("  roamActionPut: ").Append(RoamActionPut).Append("\n");
            sb.Append("  roamActionGet: ").Append(RoamActionGet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUserAssignmentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUserAssignmentInfo input)
        {
            if (input == null) return false;
            if (this.AttachId != input.AttachId || (this.AttachId != null && !this.AttachId.Equals(input.AttachId))) return false;
            if (this.AttachName != input.AttachName || (this.AttachName != null && !this.AttachName.Equals(input.AttachName))) return false;
            if (this.FileSystemQuota != input.FileSystemQuota || (this.FileSystemQuota != null && !this.FileSystemQuota.Equals(input.FileSystemQuota))) return false;
            if (this.ActionPut != input.ActionPut || (this.ActionPut != null && !this.ActionPut.Equals(input.ActionPut))) return false;
            if (this.ActionGet != input.ActionGet || (this.ActionGet != null && !this.ActionGet.Equals(input.ActionGet))) return false;
            if (this.RoamActionPut != input.RoamActionPut || (this.RoamActionPut != null && !this.RoamActionPut.Equals(input.RoamActionPut))) return false;
            if (this.RoamActionGet != input.RoamActionGet || (this.RoamActionGet != null && !this.RoamActionGet.Equals(input.RoamActionGet))) return false;

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
                if (this.AttachId != null) hashCode = hashCode * 59 + this.AttachId.GetHashCode();
                if (this.AttachName != null) hashCode = hashCode * 59 + this.AttachName.GetHashCode();
                if (this.FileSystemQuota != null) hashCode = hashCode * 59 + this.FileSystemQuota.GetHashCode();
                if (this.ActionPut != null) hashCode = hashCode * 59 + this.ActionPut.GetHashCode();
                if (this.ActionGet != null) hashCode = hashCode * 59 + this.ActionGet.GetHashCode();
                if (this.RoamActionPut != null) hashCode = hashCode * 59 + this.RoamActionPut.GetHashCode();
                if (this.RoamActionGet != null) hashCode = hashCode * 59 + this.RoamActionGet.GetHashCode();
                return hashCode;
            }
        }
    }
}
