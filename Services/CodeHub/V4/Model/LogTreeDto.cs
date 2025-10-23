using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// **参数解释：** 文件/文件夹信息
    /// </summary>
    public class LogTreeDto 
    {

        /// <summary>
        /// **参数解释：** 文件名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// **参数解释：** 文件类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 最近提交信息
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public RepositoryCommitDto Commit { get; set; }

        /// <summary>
        /// **参数解释：** 文件id
        /// </summary>
        [JsonProperty("blob_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlobId { get; set; }

        /// <summary>
        /// **参数解释：** 子模块url地址
        /// </summary>
        [JsonProperty("submodule_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmoduleUrl { get; set; }

        /// <summary>
        /// **参数解释：** 文件是否受限
        /// </summary>
        [JsonProperty("is_limited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLimited { get; set; }

        /// <summary>
        /// **参数解释：** 子模块链接
        /// </summary>
        [JsonProperty("submodule_link", NullValueHandling = NullValueHandling.Ignore)]
        public string SubmoduleLink { get; set; }

        /// <summary>
        /// **参数解释：** 文件md5
        /// </summary>
        [JsonProperty("md5", NullValueHandling = NullValueHandling.Ignore)]
        public string Md5 { get; set; }

        /// <summary>
        /// **参数解释：** 最近提交作者昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// **参数解释：** 租户名称
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }

        /// <summary>
        /// **参数解释：** 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogTreeDto {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  blobId: ").Append(BlobId).Append("\n");
            sb.Append("  submoduleUrl: ").Append(SubmoduleUrl).Append("\n");
            sb.Append("  isLimited: ").Append(IsLimited).Append("\n");
            sb.Append("  submoduleLink: ").Append(SubmoduleLink).Append("\n");
            sb.Append("  md5: ").Append(Md5).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogTreeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogTreeDto input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.BlobId != input.BlobId || (this.BlobId != null && !this.BlobId.Equals(input.BlobId))) return false;
            if (this.SubmoduleUrl != input.SubmoduleUrl || (this.SubmoduleUrl != null && !this.SubmoduleUrl.Equals(input.SubmoduleUrl))) return false;
            if (this.IsLimited != input.IsLimited || (this.IsLimited != null && !this.IsLimited.Equals(input.IsLimited))) return false;
            if (this.SubmoduleLink != input.SubmoduleLink || (this.SubmoduleLink != null && !this.SubmoduleLink.Equals(input.SubmoduleLink))) return false;
            if (this.Md5 != input.Md5 || (this.Md5 != null && !this.Md5.Equals(input.Md5))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Commit != null) hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.BlobId != null) hashCode = hashCode * 59 + this.BlobId.GetHashCode();
                if (this.SubmoduleUrl != null) hashCode = hashCode * 59 + this.SubmoduleUrl.GetHashCode();
                if (this.IsLimited != null) hashCode = hashCode * 59 + this.IsLimited.GetHashCode();
                if (this.SubmoduleLink != null) hashCode = hashCode * 59 + this.SubmoduleLink.GetHashCode();
                if (this.Md5 != null) hashCode = hashCode * 59 + this.Md5.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                return hashCode;
            }
        }
    }
}
