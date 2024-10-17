using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 凭据版本被标记的状态。
    /// </summary>
    public class VersionMetadata 
    {

        /// <summary>
        /// 凭据的版本号标识符，凭据对象下唯一。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 凭据版本创建时间，时间戳，即从1970年1月1日至该时间的总秒数。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 凭据版本过期时间，时间戳，即从1970年1月1日至该时间的总秒数。默认为空，凭据订阅“版本过期”事件类型时，有效期判断所依据的值。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExpireTime { get; set; }

        /// <summary>
        /// 加密版本凭据值的KMS主密钥ID。
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 凭据名称。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// 凭据版本被标记的状态列表。每个版本标签对于凭据对象下版本是唯一存在的，如果你创建版本时，指定的是同一凭据对象下的一个已经标记在其他版本上的状态，该标签将自动从其他版本上删除，并附加到此版本上。  如果未指定version_stage的值，则凭据管理服务会自动移动临时标签SYSCURRENT到此新版本。
        /// </summary>
        [JsonProperty("version_stages", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VersionStages { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VersionMetadata {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  versionStages: ").Append(VersionStages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VersionMetadata input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.KmsKeyId != input.KmsKeyId || (this.KmsKeyId != null && !this.KmsKeyId.Equals(input.KmsKeyId))) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.VersionStages != input.VersionStages || (this.VersionStages != null && input.VersionStages != null && !this.VersionStages.SequenceEqual(input.VersionStages))) return false;

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
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.KmsKeyId != null) hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.VersionStages != null) hashCode = hashCode * 59 + this.VersionStages.GetHashCode();
                return hashCode;
            }
        }
    }
}
