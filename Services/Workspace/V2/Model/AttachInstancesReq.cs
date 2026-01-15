using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 分配用户请求。
    /// </summary>
    public class AttachInstancesReq 
    {

        /// <summary>
        /// 桌面信息列表。
        /// </summary>
        [JsonProperty("desktops", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInstancesDesktopInfo> Desktops { get; set; }

        /// <summary>
        /// 镜像类型，涉及变更镜像时需传（可选）。
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 模板ID，涉及变更镜像时需传（可选）。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 策略id，用于指定生成桌面名称策略，如果指定了桌面名称则优先使用指定的桌面名称。
        /// </summary>
        [JsonProperty("desktop_name_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopNamePolicyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encrypt_type", NullValueHandling = NullValueHandling.Ignore)]
        public EncryptType? EncryptType { get; set; }

        /// <summary>
        /// 密钥ID，encrypt_type为ENCRYPTED时必传。
        /// </summary>
        [JsonProperty("kms_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachInstancesReq {\n");
            sb.Append("  desktops: ").Append(Desktops).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  desktopNamePolicyId: ").Append(DesktopNamePolicyId).Append("\n");
            sb.Append("  encryptType: ").Append(EncryptType).Append("\n");
            sb.Append("  kmsId: ").Append(KmsId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachInstancesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachInstancesReq input)
        {
            if (input == null) return false;
            if (this.Desktops != input.Desktops || (this.Desktops != null && input.Desktops != null && !this.Desktops.SequenceEqual(input.Desktops))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.DesktopNamePolicyId != input.DesktopNamePolicyId || (this.DesktopNamePolicyId != null && !this.DesktopNamePolicyId.Equals(input.DesktopNamePolicyId))) return false;
            if (this.EncryptType != input.EncryptType || (this.EncryptType != null && !this.EncryptType.Equals(input.EncryptType))) return false;
            if (this.KmsId != input.KmsId || (this.KmsId != null && !this.KmsId.Equals(input.KmsId))) return false;

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
                if (this.Desktops != null) hashCode = hashCode * 59 + this.Desktops.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.DesktopNamePolicyId != null) hashCode = hashCode * 59 + this.DesktopNamePolicyId.GetHashCode();
                if (this.EncryptType != null) hashCode = hashCode * 59 + this.EncryptType.GetHashCode();
                if (this.KmsId != null) hashCode = hashCode * 59 + this.KmsId.GetHashCode();
                return hashCode;
            }
        }
    }
}
