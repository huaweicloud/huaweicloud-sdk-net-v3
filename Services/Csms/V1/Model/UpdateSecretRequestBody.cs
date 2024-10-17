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
    /// 更新凭据对象的元数据信息请求体
    /// </summary>
    public class UpdateSecretRequestBody 
    {

        /// <summary>
        /// 用于加密保护凭据值的KMS主密钥ID。更新凭据的主密钥后，仅新创建的凭据版本使用更新后的主密钥ID加密，之前的凭据版本依旧使用之前的主密钥ID解密。 
        /// </summary>
        [JsonProperty("kms_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// 凭据的描述信息。 约束：2048字节。 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 自动轮转  取值：true 开启 false 关 
        /// </summary>
        [JsonProperty("auto_rotation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoRotation { get; set; }

        /// <summary>
        /// 轮转周期  约束：6小时-8,760小时 （365天）  类型：Integer[unit] ，Integer表示时间长度 。unit表示时间单位，d（天）、h（小时）、m（分钟）、s（秒）。例如 1d 表示一天，24h也表示一天  说明：当开启自动轮转时，必须填写该值 
        /// </summary>
        [JsonProperty("rotation_period", NullValueHandling = NullValueHandling.Ignore)]
        public string RotationPeriod { get; set; }

        /// <summary>
        /// 凭据订阅的事件列表，当前最大可订阅一个事件。当事件包含的基础事件触发时，通知消息将发送到事件对应的通知主题。 
        /// </summary>
        [JsonProperty("event_subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventSubscriptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSecretRequestBody {\n");
            sb.Append("  kmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  autoRotation: ").Append(AutoRotation).Append("\n");
            sb.Append("  rotationPeriod: ").Append(RotationPeriod).Append("\n");
            sb.Append("  eventSubscriptions: ").Append(EventSubscriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSecretRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSecretRequestBody input)
        {
            if (input == null) return false;
            if (this.KmsKeyId != input.KmsKeyId || (this.KmsKeyId != null && !this.KmsKeyId.Equals(input.KmsKeyId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AutoRotation != input.AutoRotation || (this.AutoRotation != null && !this.AutoRotation.Equals(input.AutoRotation))) return false;
            if (this.RotationPeriod != input.RotationPeriod || (this.RotationPeriod != null && !this.RotationPeriod.Equals(input.RotationPeriod))) return false;
            if (this.EventSubscriptions != input.EventSubscriptions || (this.EventSubscriptions != null && input.EventSubscriptions != null && !this.EventSubscriptions.SequenceEqual(input.EventSubscriptions))) return false;

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
                if (this.KmsKeyId != null) hashCode = hashCode * 59 + this.KmsKeyId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AutoRotation != null) hashCode = hashCode * 59 + this.AutoRotation.GetHashCode();
                if (this.RotationPeriod != null) hashCode = hashCode * 59 + this.RotationPeriod.GetHashCode();
                if (this.EventSubscriptions != null) hashCode = hashCode * 59 + this.EventSubscriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
