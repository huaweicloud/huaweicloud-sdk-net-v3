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
    /// 
    /// </summary>
    public class CreateAppAccessKeyRequestBody 
    {

        /// <summary>
        /// 访问密钥名称
        /// </summary>
        [JsonProperty("key_name", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyName { get; set; }

        /// <summary>
        /// 访问密钥ak，默认为空，系统自动生成
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 访问密钥sk，默认为空，系统自动生成
        /// </summary>
        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAppAccessKeyRequestBody {\n");
            sb.Append("  keyName: ").Append(KeyName).Append("\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  secretKey: ").Append(SecretKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateAppAccessKeyRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAppAccessKeyRequestBody input)
        {
            if (input == null) return false;
            if (this.KeyName != input.KeyName || (this.KeyName != null && !this.KeyName.Equals(input.KeyName))) return false;
            if (this.AccessKey != input.AccessKey || (this.AccessKey != null && !this.AccessKey.Equals(input.AccessKey))) return false;
            if (this.SecretKey != input.SecretKey || (this.SecretKey != null && !this.SecretKey.Equals(input.SecretKey))) return false;

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
                if (this.KeyName != null) hashCode = hashCode * 59 + this.KeyName.GetHashCode();
                if (this.AccessKey != null) hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.SecretKey != null) hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
