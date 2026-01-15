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
    /// 包周期重建系统盘询价请求体。
    /// </summary>
    public class CreateChangeImageOrderRequestBody 
    {
        /// <summary>
        /// 处理类型 - ONLY_FOR_EXPAND：仅对新扩容桌面生效 - FOR_EXPAND_AND_IDLE：对新扩容桌面与空闲桌面生效 - FOR_EXPAND_AND_ALL：对新扩容桌面与已有全部桌面生效
        /// </summary>
        /// <value>处理类型 - ONLY_FOR_EXPAND：仅对新扩容桌面生效 - FOR_EXPAND_AND_IDLE：对新扩容桌面与空闲桌面生效 - FOR_EXPAND_AND_ALL：对新扩容桌面与已有全部桌面生效</value>
        [JsonConverter(typeof(EnumClassConverter<HandleTypeEnum>))]
        public class HandleTypeEnum
        {
            /// <summary>
            /// Enum ONLY_FOR_EXPAND for value: ONLY_FOR_EXPAND
            /// </summary>
            public static readonly HandleTypeEnum ONLY_FOR_EXPAND = new HandleTypeEnum("ONLY_FOR_EXPAND");

            /// <summary>
            /// Enum FOR_EXPAND_AND_IDLE for value: FOR_EXPAND_AND_IDLE
            /// </summary>
            public static readonly HandleTypeEnum FOR_EXPAND_AND_IDLE = new HandleTypeEnum("FOR_EXPAND_AND_IDLE");

            /// <summary>
            /// Enum FOR_EXPAND_AND_ALL for value: FOR_EXPAND_AND_ALL
            /// </summary>
            public static readonly HandleTypeEnum FOR_EXPAND_AND_ALL = new HandleTypeEnum("FOR_EXPAND_AND_ALL");

            private static readonly Dictionary<string, HandleTypeEnum> StaticFields =
            new Dictionary<string, HandleTypeEnum>()
            {
                { "ONLY_FOR_EXPAND", ONLY_FOR_EXPAND },
                { "FOR_EXPAND_AND_IDLE", FOR_EXPAND_AND_IDLE },
                { "FOR_EXPAND_AND_ALL", FOR_EXPAND_AND_ALL },
            };

            private string _value;

            public HandleTypeEnum()
            {

            }

            public HandleTypeEnum(string value)
            {
                _value = value;
            }

            public static HandleTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as HandleTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HandleTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HandleTypeEnum a, HandleTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HandleTypeEnum a, HandleTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面池ID。当desktop_pool_id与desktop_ids同时存在时，取desktop_ids的值，两者不可同时为空。
        /// </summary>
        [JsonProperty("desktop_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolId { get; set; }

        /// <summary>
        /// 桌面id
        /// </summary>
        [JsonProperty("desktop_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopIds { get; set; }

        /// <summary>
        /// 促销计划ID。
        /// </summary>
        [JsonProperty("promotion_plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PromotionPlanId { get; set; }

        /// <summary>
        /// 处理类型 - ONLY_FOR_EXPAND：仅对新扩容桌面生效 - FOR_EXPAND_AND_IDLE：对新扩容桌面与空闲桌面生效 - FOR_EXPAND_AND_ALL：对新扩容桌面与已有全部桌面生效
        /// </summary>
        [JsonProperty("handle_type", NullValueHandling = NullValueHandling.Ignore)]
        public HandleTypeEnum HandleType { get; set; }
        /// <summary>
        /// 云市场镜像的specCode，即将停用。image_spec_code与image_id同时存在时取image_id的值，两者不可同时为空。
        /// </summary>
        [JsonProperty("image_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageSpecCode { get; set; }

        /// <summary>
        /// 云市场镜像ID，建议使用image_id。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像类型。仅重建系统盘/更换镜像使用  - private：私有镜像。 - gold：公共镜像。
        /// </summary>
        [JsonProperty("image_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageType { get; set; }

        /// <summary>
        /// 立即重建时给用户预留的保存数据的时间（单位：分钟）。
        /// </summary>
        [JsonProperty("delay_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? DelayTime { get; set; }

        /// <summary>
        /// 下发重建系统盘任务时，给用户发送的提示信息。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

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
            sb.Append("class CreateChangeImageOrderRequestBody {\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  promotionPlanId: ").Append(PromotionPlanId).Append("\n");
            sb.Append("  handleType: ").Append(HandleType).Append("\n");
            sb.Append("  imageSpecCode: ").Append(ImageSpecCode).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("  delayTime: ").Append(DelayTime).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
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
            return this.Equals(input as CreateChangeImageOrderRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateChangeImageOrderRequestBody input)
        {
            if (input == null) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.PromotionPlanId != input.PromotionPlanId || (this.PromotionPlanId != null && !this.PromotionPlanId.Equals(input.PromotionPlanId))) return false;
            if (this.HandleType != input.HandleType) return false;
            if (this.ImageSpecCode != input.ImageSpecCode || (this.ImageSpecCode != null && !this.ImageSpecCode.Equals(input.ImageSpecCode))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;
            if (this.DelayTime != input.DelayTime || (this.DelayTime != null && !this.DelayTime.Equals(input.DelayTime))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
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
                if (this.DesktopPoolId != null) hashCode = hashCode * 59 + this.DesktopPoolId.GetHashCode();
                if (this.DesktopIds != null) hashCode = hashCode * 59 + this.DesktopIds.GetHashCode();
                if (this.PromotionPlanId != null) hashCode = hashCode * 59 + this.PromotionPlanId.GetHashCode();
                hashCode = hashCode * 59 + this.HandleType.GetHashCode();
                if (this.ImageSpecCode != null) hashCode = hashCode * 59 + this.ImageSpecCode.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageType != null) hashCode = hashCode * 59 + this.ImageType.GetHashCode();
                if (this.DelayTime != null) hashCode = hashCode * 59 + this.DelayTime.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.EncryptType != null) hashCode = hashCode * 59 + this.EncryptType.GetHashCode();
                if (this.KmsId != null) hashCode = hashCode * 59 + this.KmsId.GetHashCode();
                return hashCode;
            }
        }
    }
}
