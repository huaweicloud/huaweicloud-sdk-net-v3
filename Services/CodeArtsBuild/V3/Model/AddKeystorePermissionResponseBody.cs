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
    /// 执行任务接口请求体
    /// </summary>
    public class AddKeystorePermissionResponseBody 
    {

        /// <summary>
        /// 权限id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 编辑权限
        /// </summary>
        [JsonProperty("setting", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setting { get; set; }

        /// <summary>
        /// 是否有删除权限
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete { get; set; }

        /// <summary>
        /// 文件密钥id
        /// </summary>
        [JsonProperty("keystore_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeystoreId { get; set; }

        /// <summary>
        /// 是否有修改权限
        /// </summary>
        [JsonProperty("modify", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Modify { get; set; }

        /// <summary>
        /// 是否有使用权限
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usage { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 是否是创建者
        /// </summary>
        [JsonProperty("is_creator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsCreator { get; set; }

        /// <summary>
        /// 是否可编辑
        /// </summary>
        [JsonProperty("can_absent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanAbsent { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddKeystorePermissionResponseBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  setting: ").Append(Setting).Append("\n");
            sb.Append("  delete: ").Append(Delete).Append("\n");
            sb.Append("  keystoreId: ").Append(KeystoreId).Append("\n");
            sb.Append("  modify: ").Append(Modify).Append("\n");
            sb.Append("  usage: ").Append(Usage).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  isCreator: ").Append(IsCreator).Append("\n");
            sb.Append("  canAbsent: ").Append(CanAbsent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddKeystorePermissionResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddKeystorePermissionResponseBody input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Setting != input.Setting || (this.Setting != null && !this.Setting.Equals(input.Setting))) return false;
            if (this.Delete != input.Delete || (this.Delete != null && !this.Delete.Equals(input.Delete))) return false;
            if (this.KeystoreId != input.KeystoreId || (this.KeystoreId != null && !this.KeystoreId.Equals(input.KeystoreId))) return false;
            if (this.Modify != input.Modify || (this.Modify != null && !this.Modify.Equals(input.Modify))) return false;
            if (this.Usage != input.Usage || (this.Usage != null && !this.Usage.Equals(input.Usage))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.IsCreator != input.IsCreator || (this.IsCreator != null && !this.IsCreator.Equals(input.IsCreator))) return false;
            if (this.CanAbsent != input.CanAbsent || (this.CanAbsent != null && !this.CanAbsent.Equals(input.CanAbsent))) return false;

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
                if (this.Setting != null) hashCode = hashCode * 59 + this.Setting.GetHashCode();
                if (this.Delete != null) hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.KeystoreId != null) hashCode = hashCode * 59 + this.KeystoreId.GetHashCode();
                if (this.Modify != null) hashCode = hashCode * 59 + this.Modify.GetHashCode();
                if (this.Usage != null) hashCode = hashCode * 59 + this.Usage.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.IsCreator != null) hashCode = hashCode * 59 + this.IsCreator.GetHashCode();
                if (this.CanAbsent != null) hashCode = hashCode * 59 + this.CanAbsent.GetHashCode();
                return hashCode;
            }
        }
    }
}
