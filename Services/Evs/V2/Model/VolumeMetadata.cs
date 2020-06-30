using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 说明： 以上表格中仅提供了部分“metadata”字段信息说明供您参考，您还可以根据创建磁盘的要求输入其他字段。 如果是从快照创建云硬盘，则不支持传入“__system__encrypted”和“__system__cmkid”字段，创建出来的云硬盘与快照源云硬盘的加密属性一致。 如果是从镜像创建云硬盘，则不支持传入“__system__encrypted”和“__system__cmkid”字段，创建出来的云硬盘与镜像的加密属性一致。 如果是从快照创建云硬盘，则不支持传入“hw:passthrough”字段，创建出来的云硬盘的设备类型与快照源云硬盘保持一致。 如果是从镜像创建云硬盘，则不支持传入“hw:passthrough”字段，创建出来的云硬盘的设备类型为VBD类型。
    /// </summary>
    public class VolumeMetadata 
    {

        /// <summary>
        /// metadata中的加密cmkid字段，与__system__encrypted配合表示需要加密，cmkid长度固定为36个字节。  说明： 请参考 [查询密钥列表](https://support.huaweicloud.com/api-dew/dew_02_0017.html)，通过HTTPS请求获取密钥ID。
        /// </summary>
        [JsonProperty("__system__cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemCmkid { get; set; }

        /// <summary>
        /// metadata中的表示加密功能的字段，0代表不加密，1代表加密。 该字段不存在时，云硬盘默认为不加密。
        /// </summary>
        [JsonProperty("__system__encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemEncrypted { get; set; }

        /// <summary>
        /// 从快照创建云硬盘时，如需使用link克隆方式，请指定该字段的值为0。
        /// </summary>
        [JsonProperty("full_clone", NullValueHandling = NullValueHandling.Ignore)]
        public string FullClone { get; set; }

        /// <summary>
        /// true表示云硬盘的设备类型为SCSI类型，即允许ECS操作系统直接访问底层存储介质。支持SCSI锁命令。 false表示云硬盘的设备类型为VBD (虚拟块存储设备 , Virtual Block Device)类型，即为默认类型，VBD只能支持简单的SCSI读写命令。 该字段不存在时，云硬盘默认为VBD类型。  &gt;说明： &gt;当shareable参数值设置为true，不指定hw:passthrough参数值时，创建的云硬盘为VBD类型共享云硬盘。
        /// </summary>
        [JsonProperty("hw:passthrough", NullValueHandling = NullValueHandling.Ignore)]
        public string Hwpassthrough { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeMetadata {\n");
            sb.Append("  systemCmkid: ").Append(SystemCmkid).Append("\n");
            sb.Append("  systemEncrypted: ").Append(SystemEncrypted).Append("\n");
            sb.Append("  fullClone: ").Append(FullClone).Append("\n");
            sb.Append("  hwpassthrough: ").Append(Hwpassthrough).Append("\n");
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
                    this.SystemCmkid == input.SystemCmkid ||
                    (this.SystemCmkid != null &&
                    this.SystemCmkid.Equals(input.SystemCmkid))
                ) && 
                (
                    this.SystemEncrypted == input.SystemEncrypted ||
                    (this.SystemEncrypted != null &&
                    this.SystemEncrypted.Equals(input.SystemEncrypted))
                ) && 
                (
                    this.FullClone == input.FullClone ||
                    (this.FullClone != null &&
                    this.FullClone.Equals(input.FullClone))
                ) && 
                (
                    this.Hwpassthrough == input.Hwpassthrough ||
                    (this.Hwpassthrough != null &&
                    this.Hwpassthrough.Equals(input.Hwpassthrough))
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
                if (this.SystemCmkid != null)
                    hashCode = hashCode * 59 + this.SystemCmkid.GetHashCode();
                if (this.SystemEncrypted != null)
                    hashCode = hashCode * 59 + this.SystemEncrypted.GetHashCode();
                if (this.FullClone != null)
                    hashCode = hashCode * 59 + this.FullClone.GetHashCode();
                if (this.Hwpassthrough != null)
                    hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                return hashCode;
            }
        }
    }
}
