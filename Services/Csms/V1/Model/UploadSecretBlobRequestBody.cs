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
    /// 恢复凭据对象请求体
    /// </summary>
    public class UploadSecretBlobRequestBody 
    {

        /// <summary>
        /// 将指定凭据对象进行备份后得到的凭据备份文件，备份文件包含有凭据当前所有的凭据版本信息，备份文件经过加密与编码，内容不可直接读。 
        /// </summary>
        [JsonProperty("secret_blob", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretBlob { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadSecretBlobRequestBody {\n");
            sb.Append("  secretBlob: ").Append(SecretBlob).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadSecretBlobRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadSecretBlobRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SecretBlob == input.SecretBlob ||
                    (this.SecretBlob != null &&
                    this.SecretBlob.Equals(input.SecretBlob))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SecretBlob != null)
                    hashCode = hashCode * 59 + this.SecretBlob.GetHashCode();
                return hashCode;
            }
        }
    }
}
