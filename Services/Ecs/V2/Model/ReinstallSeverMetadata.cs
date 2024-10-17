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
    /// 
    /// </summary>
    public class ReinstallSeverMetadata 
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
        /// 重装云服务器过程中注入用户数据。  支持注入文本、文本文件或gzip文件。注入内容最大长度32KB。注入内容，需要进行base64格式编码。  了解更多用户数据注入请参考[用户数据注入](https://support.huaweicloud.com/usermanual-ecs/zh-cn_topic_0032380449.html)。
        /// </summary>
        [JsonProperty("user_data", NullValueHandling = NullValueHandling.Ignore)]
        public string UserData { get; set; }

        /// <summary>
        /// 如果您已拥有操作系统或软件的许可证（一般是指按物理插槽数、物理内核数等进行认证的许可证），您可以通过自带许可（BYOL）的方式将业务完整迁移到云平台，继续使用您的许可证。 - true： 使用自有license - 其他值： 视为非法参数，接口报错
        /// </summary>
        [JsonProperty("BYOL", NullValueHandling = NullValueHandling.Ignore)]
        public string Byol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReinstallSeverMetadata {\n");
            sb.Append("  systemEncrypted: ").Append(SystemEncrypted).Append("\n");
            sb.Append("  systemCmkid: ").Append(SystemCmkid).Append("\n");
            sb.Append("  userData: ").Append(UserData).Append("\n");
            sb.Append("  byol: ").Append(Byol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReinstallSeverMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReinstallSeverMetadata input)
        {
            if (input == null) return false;
            if (this.SystemEncrypted != input.SystemEncrypted || (this.SystemEncrypted != null && !this.SystemEncrypted.Equals(input.SystemEncrypted))) return false;
            if (this.SystemCmkid != input.SystemCmkid || (this.SystemCmkid != null && !this.SystemCmkid.Equals(input.SystemCmkid))) return false;
            if (this.UserData != input.UserData || (this.UserData != null && !this.UserData.Equals(input.UserData))) return false;
            if (this.Byol != input.Byol || (this.Byol != null && !this.Byol.Equals(input.Byol))) return false;

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
                if (this.UserData != null) hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Byol != null) hashCode = hashCode * 59 + this.Byol.GetHashCode();
                return hashCode;
            }
        }
    }
}
