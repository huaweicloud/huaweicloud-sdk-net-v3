using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// &gt; 说明： &gt;  &gt; 如果是从镜像创建云硬盘，则不支持传入“__system__encrypted”和“__system__cmkid”字段，创建出来的云硬盘与镜像的加密属性一致。
    /// </summary>
    public class PrePaidServerDataVolumeMetadata 
    {

        /// <summary>
        /// metadata中的表示加密功能的字段，0代表不加密，1代表加密。  该字段不存在时，云硬盘默认为不加密。
        /// </summary>
        [JsonProperty("__system__encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemEncrypted { get; set; }

        /// <summary>
        /// metadata中的加密cmkid字段，与__system__encrypted配合表示需要加密，cmkid长度固定为36个字节。  &gt; 说明：  - 请参考[查询密钥列表](https://support.huaweicloud.com/api-dew/ListKeys.html)，通过HTTPS请求获取密钥ID。
        /// </summary>
        [JsonProperty("__system__cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemCmkid { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidServerDataVolumeMetadata {\n");
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
            return this.Equals(input as PrePaidServerDataVolumeMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidServerDataVolumeMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemEncrypted == input.SystemEncrypted ||
                    (this.SystemEncrypted != null &&
                    this.SystemEncrypted.Equals(input.SystemEncrypted))
                ) && 
                (
                    this.SystemCmkid == input.SystemCmkid ||
                    (this.SystemCmkid != null &&
                    this.SystemCmkid.Equals(input.SystemCmkid))
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
                if (this.SystemEncrypted != null)
                    hashCode = hashCode * 59 + this.SystemEncrypted.GetHashCode();
                if (this.SystemCmkid != null)
                    hashCode = hashCode * 59 + this.SystemCmkid.GetHashCode();
                return hashCode;
            }
        }
    }
}
