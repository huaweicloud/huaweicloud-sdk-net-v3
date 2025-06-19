using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PublicAwLib 
    {

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// 创建时间字符串
        /// </summary>
        [JsonProperty("create_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeString { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("create_user", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUser { get; set; }

        /// <summary>
        /// 文档链接
        /// </summary>
        [JsonProperty("document_link", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentLink { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 蓝区:Blue,绿区:Green,黄区:Yellow
        /// </summary>
        [JsonProperty("net_area", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NetArea { get; set; }

        /// <summary>
        /// obs临时url
        /// </summary>
        [JsonProperty("obs_temp_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsTempUrl { get; set; }

        /// <summary>
        /// 产品线
        /// </summary>
        [JsonProperty("product_line", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductLine { get; set; }

        /// <summary>
        /// 仓库分支
        /// </summary>
        [JsonProperty("repo_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoBranch { get; set; }

        /// <summary>
        /// 存公共aw依赖jar包的目录
        /// </summary>
        [JsonProperty("repo_lib_path", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoLibPath { get; set; }

        /// <summary>
        /// 仓库密码
        /// </summary>
        [JsonProperty("repo_password", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoPassword { get; set; }

        /// <summary>
        /// 仓库秘钥
        /// </summary>
        [JsonProperty("repo_private_key", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoPrivateKey { get; set; }

        /// <summary>
        /// 仓库地址
        /// </summary>
        [JsonProperty("repo_url", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// 仓库用户名
        /// </summary>
        [JsonProperty("repo_username", NullValueHandling = NullValueHandling.Ignore)]
        public string RepoUsername { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 更新时间戳
        /// </summary>
        [JsonProperty("update_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeStamp { get; set; }

        /// <summary>
        /// 更新时间字符串
        /// </summary>
        [JsonProperty("update_time_string", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimeString { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [JsonProperty("update_user", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicAwLib {\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  createTimeString: ").Append(CreateTimeString).Append("\n");
            sb.Append("  createUser: ").Append(CreateUser).Append("\n");
            sb.Append("  documentLink: ").Append(DocumentLink).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  netArea: ").Append(NetArea).Append("\n");
            sb.Append("  obsTempUrl: ").Append(ObsTempUrl).Append("\n");
            sb.Append("  productLine: ").Append(ProductLine).Append("\n");
            sb.Append("  repoBranch: ").Append(RepoBranch).Append("\n");
            sb.Append("  repoLibPath: ").Append(RepoLibPath).Append("\n");
            sb.Append("  repoPassword: ").Append(RepoPassword).Append("\n");
            sb.Append("  repoPrivateKey: ").Append(RepoPrivateKey).Append("\n");
            sb.Append("  repoUrl: ").Append(RepoUrl).Append("\n");
            sb.Append("  repoUsername: ").Append(RepoUsername).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeStamp: ").Append(UpdateTimeStamp).Append("\n");
            sb.Append("  updateTimeString: ").Append(UpdateTimeString).Append("\n");
            sb.Append("  updateUser: ").Append(UpdateUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicAwLib);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicAwLib input)
        {
            if (input == null) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.CreateTimeString != input.CreateTimeString || (this.CreateTimeString != null && !this.CreateTimeString.Equals(input.CreateTimeString))) return false;
            if (this.CreateUser != input.CreateUser || (this.CreateUser != null && !this.CreateUser.Equals(input.CreateUser))) return false;
            if (this.DocumentLink != input.DocumentLink || (this.DocumentLink != null && !this.DocumentLink.Equals(input.DocumentLink))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NetArea != input.NetArea || (this.NetArea != null && input.NetArea != null && !this.NetArea.SequenceEqual(input.NetArea))) return false;
            if (this.ObsTempUrl != input.ObsTempUrl || (this.ObsTempUrl != null && !this.ObsTempUrl.Equals(input.ObsTempUrl))) return false;
            if (this.ProductLine != input.ProductLine || (this.ProductLine != null && !this.ProductLine.Equals(input.ProductLine))) return false;
            if (this.RepoBranch != input.RepoBranch || (this.RepoBranch != null && !this.RepoBranch.Equals(input.RepoBranch))) return false;
            if (this.RepoLibPath != input.RepoLibPath || (this.RepoLibPath != null && !this.RepoLibPath.Equals(input.RepoLibPath))) return false;
            if (this.RepoPassword != input.RepoPassword || (this.RepoPassword != null && !this.RepoPassword.Equals(input.RepoPassword))) return false;
            if (this.RepoPrivateKey != input.RepoPrivateKey || (this.RepoPrivateKey != null && !this.RepoPrivateKey.Equals(input.RepoPrivateKey))) return false;
            if (this.RepoUrl != input.RepoUrl || (this.RepoUrl != null && !this.RepoUrl.Equals(input.RepoUrl))) return false;
            if (this.RepoUsername != input.RepoUsername || (this.RepoUsername != null && !this.RepoUsername.Equals(input.RepoUsername))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeStamp != input.UpdateTimeStamp || (this.UpdateTimeStamp != null && !this.UpdateTimeStamp.Equals(input.UpdateTimeStamp))) return false;
            if (this.UpdateTimeString != input.UpdateTimeString || (this.UpdateTimeString != null && !this.UpdateTimeString.Equals(input.UpdateTimeString))) return false;
            if (this.UpdateUser != input.UpdateUser || (this.UpdateUser != null && !this.UpdateUser.Equals(input.UpdateUser))) return false;

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
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.CreateTimeString != null) hashCode = hashCode * 59 + this.CreateTimeString.GetHashCode();
                if (this.CreateUser != null) hashCode = hashCode * 59 + this.CreateUser.GetHashCode();
                if (this.DocumentLink != null) hashCode = hashCode * 59 + this.DocumentLink.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetArea != null) hashCode = hashCode * 59 + this.NetArea.GetHashCode();
                if (this.ObsTempUrl != null) hashCode = hashCode * 59 + this.ObsTempUrl.GetHashCode();
                if (this.ProductLine != null) hashCode = hashCode * 59 + this.ProductLine.GetHashCode();
                if (this.RepoBranch != null) hashCode = hashCode * 59 + this.RepoBranch.GetHashCode();
                if (this.RepoLibPath != null) hashCode = hashCode * 59 + this.RepoLibPath.GetHashCode();
                if (this.RepoPassword != null) hashCode = hashCode * 59 + this.RepoPassword.GetHashCode();
                if (this.RepoPrivateKey != null) hashCode = hashCode * 59 + this.RepoPrivateKey.GetHashCode();
                if (this.RepoUrl != null) hashCode = hashCode * 59 + this.RepoUrl.GetHashCode();
                if (this.RepoUsername != null) hashCode = hashCode * 59 + this.RepoUsername.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeStamp != null) hashCode = hashCode * 59 + this.UpdateTimeStamp.GetHashCode();
                if (this.UpdateTimeString != null) hashCode = hashCode * 59 + this.UpdateTimeString.GetHashCode();
                if (this.UpdateUser != null) hashCode = hashCode * 59 + this.UpdateUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
