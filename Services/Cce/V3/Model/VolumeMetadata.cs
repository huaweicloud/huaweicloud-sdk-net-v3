using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 云硬盘加密信息，仅在创建节点系统盘或数据盘需加密时须填写。
    /// </summary>
    public class VolumeMetadata 
    {

        /// <summary>
        /// 表示云硬盘加密功能的字段，&#39;0&#39;代表不加密，&#39;1&#39;代表加密。  该字段不存在时，云硬盘默认为不加密。
        /// </summary>
        [JsonProperty("__system__encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemEncrypted { get; set; }

        /// <summary>
        /// 用户主密钥ID，是metadata中的表示加密功能的字段，与__system__encrypted配合使用。
        /// </summary>
        [JsonProperty("__system__cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemCmkid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeMetadata {\n");
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
            return this.Equals(input as VolumeMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeMetadata input)
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
