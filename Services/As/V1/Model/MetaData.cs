using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 创建磁盘的元数据
    /// </summary>
    public class MetaData 
    {

        /// <summary>
        /// metadata中的表示加密功能的字段，0代表不加密，1代表加密。  该字段不存在时，云硬盘默认为不加密。 说明： 系统盘不支持加密。
        /// </summary>
        [JsonProperty("__system__encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemEncrypted { get; set; }

        /// <summary>
        /// 用户主密钥ID，是metadata中的表示加密功能的字段，与__system__encrypted配合使用。说明：- 系统盘不支持加密。- 请参考[查询密钥列表](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;KMS&amp;api&#x3D;ListKeys&amp;version&#x3D;v2)，通过HTTPS请求获取密钥ID。
        /// </summary>
        [JsonProperty("__system__cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemCmkid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaData {\n");
            sb.Append("  systemEncrypted: ").Append(SystemEncrypted).Append("\n");
            sb.Append("  systemCmkid: ").Append(SystemCmkid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaData input)
        {
            if (input == null) return false;
            if (this.SystemEncrypted != input.SystemEncrypted || (this.SystemEncrypted != null && !this.SystemEncrypted.Equals(input.SystemEncrypted))) return false;
            if (this.SystemCmkid != input.SystemCmkid || (this.SystemCmkid != null && !this.SystemCmkid.Equals(input.SystemCmkid))) return false;

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
                if (this.SystemEncrypted != null) hashCode = hashCode * 59 + this.SystemEncrypted.GetHashCode();
                if (this.SystemCmkid != null) hashCode = hashCode * 59 + this.SystemCmkid.GetHashCode();
                return hashCode;
            }
        }
    }
}
