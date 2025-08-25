using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAccessKeyResponse : SdkResponse
    {

        /// <summary>
        /// 访问密钥的access key
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 访问密钥的secret key
        /// </summary>
        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 密钥名称
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 是否导入
        /// </summary>
        [JsonProperty("is_imported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImported { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAccessKeyResponse {\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  secretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  isImported: ").Append(IsImported).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAccessKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAccessKeyResponse input)
        {
            if (input == null) return false;
            if (this.AccessKey != input.AccessKey || (this.AccessKey != null && !this.AccessKey.Equals(input.AccessKey))) return false;
            if (this.SecretKey != input.SecretKey || (this.SecretKey != null && !this.SecretKey.Equals(input.SecretKey))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.IsImported != input.IsImported || (this.IsImported != null && !this.IsImported.Equals(input.IsImported))) return false;

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
                if (this.AccessKey != null) hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.SecretKey != null) hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.IsImported != null) hashCode = hashCode * 59 + this.IsImported.GetHashCode();
                return hashCode;
            }
        }
    }
}
