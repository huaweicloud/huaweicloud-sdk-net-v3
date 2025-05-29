using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// metadata字段数据结构说明
    /// </summary>
    public class MetadataInstall 
    {

        /// <summary>
        /// 重装裸金属服务器过程中注入Linux镜像root密码，用户自定义初始化密码。注：修改密码脚本需经Base64编码。建议密码复杂度如下：长度为8-26位。密码至少必须包含大写字母（A-Z）、小写字母（a-z）、数字（0-9）和特殊字符（!@$%^-_&#x3D;+[{}]:,./?）中的三种
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

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
            sb.Append("class MetadataInstall {\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
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
            return this.Equals(input as MetadataInstall);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetadataInstall input)
        {
            if (input == null) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
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
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.SystemEncrypted != null) hashCode = hashCode * 59 + this.SystemEncrypted.GetHashCode();
                if (this.SystemCmkid != null) hashCode = hashCode * 59 + this.SystemCmkid.GetHashCode();
                return hashCode;
            }
        }
    }
}
