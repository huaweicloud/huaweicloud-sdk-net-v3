using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListKeystoreSearchResponseBodyResultKeystoreList 
    {

        /// <summary>
        /// 文件ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public ListKeystoreSearchResponseBodyResultPermission Permission { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("create_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTimeStamp { get; set; }

        /// <summary>
        /// 修改时间戳
        /// </summary>
        [JsonProperty("update_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimeStamp { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 租户名
        /// </summary>
        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("keystore_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreName { get; set; }

        /// <summary>
        /// 文件创建者用户ID
        /// </summary>
        [JsonProperty("create_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// 文件创建者用户名
        /// </summary>
        [JsonProperty("create_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// 文件修改者用户ID
        /// </summary>
        [JsonProperty("update_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUserId { get; set; }

        /// <summary>
        /// 文件修改者用户名
        /// </summary>
        [JsonProperty("update_user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateUserName { get; set; }

        /// <summary>
        /// 是否共享，开启后允许租户内所有成员在编译构建中使用该文件
        /// </summary>
        [JsonProperty("share", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Share { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeystoreSearchResponseBodyResultKeystoreList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  updateTimeStamp: ").Append(UpdateTimeStamp).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  keystoreName: ").Append(KeystoreName).Append("\n");
            sb.Append("  createUserId: ").Append(CreateUserId).Append("\n");
            sb.Append("  createUserName: ").Append(CreateUserName).Append("\n");
            sb.Append("  updateUserId: ").Append(UpdateUserId).Append("\n");
            sb.Append("  updateUserName: ").Append(UpdateUserName).Append("\n");
            sb.Append("  share: ").Append(Share).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeystoreSearchResponseBodyResultKeystoreList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeystoreSearchResponseBodyResultKeystoreList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Permission != input.Permission || (this.Permission != null && !this.Permission.Equals(input.Permission))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.UpdateTimeStamp != input.UpdateTimeStamp || (this.UpdateTimeStamp != null && !this.UpdateTimeStamp.Equals(input.UpdateTimeStamp))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.DomainName != input.DomainName || (this.DomainName != null && !this.DomainName.Equals(input.DomainName))) return false;
            if (this.KeystoreName != input.KeystoreName || (this.KeystoreName != null && !this.KeystoreName.Equals(input.KeystoreName))) return false;
            if (this.CreateUserId != input.CreateUserId || (this.CreateUserId != null && !this.CreateUserId.Equals(input.CreateUserId))) return false;
            if (this.CreateUserName != input.CreateUserName || (this.CreateUserName != null && !this.CreateUserName.Equals(input.CreateUserName))) return false;
            if (this.UpdateUserId != input.UpdateUserId || (this.UpdateUserId != null && !this.UpdateUserId.Equals(input.UpdateUserId))) return false;
            if (this.UpdateUserName != input.UpdateUserName || (this.UpdateUserName != null && !this.UpdateUserName.Equals(input.UpdateUserName))) return false;
            if (this.Share != input.Share || (this.Share != null && !this.Share.Equals(input.Share))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Permission != null) hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.UpdateTimeStamp != null) hashCode = hashCode * 59 + this.UpdateTimeStamp.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.DomainName != null) hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.KeystoreName != null) hashCode = hashCode * 59 + this.KeystoreName.GetHashCode();
                if (this.CreateUserId != null) hashCode = hashCode * 59 + this.CreateUserId.GetHashCode();
                if (this.CreateUserName != null) hashCode = hashCode * 59 + this.CreateUserName.GetHashCode();
                if (this.UpdateUserId != null) hashCode = hashCode * 59 + this.UpdateUserId.GetHashCode();
                if (this.UpdateUserName != null) hashCode = hashCode * 59 + this.UpdateUserName.GetHashCode();
                if (this.Share != null) hashCode = hashCode * 59 + this.Share.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
