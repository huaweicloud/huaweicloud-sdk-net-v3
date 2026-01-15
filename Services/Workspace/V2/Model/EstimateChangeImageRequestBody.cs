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
    /// 包周期桌面池由不收费镜像切换至收费镜像的询价请求体。
    /// </summary>
    public class EstimateChangeImageRequestBody 
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
        /// 包周期桌面ID列表。 不可同时存在普通桌面和池桌面ID。
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EstimateChangeImageRequestBody {\n");
            sb.Append("  desktopPoolId: ").Append(DesktopPoolId).Append("\n");
            sb.Append("  desktopIds: ").Append(DesktopIds).Append("\n");
            sb.Append("  promotionPlanId: ").Append(PromotionPlanId).Append("\n");
            sb.Append("  handleType: ").Append(HandleType).Append("\n");
            sb.Append("  imageSpecCode: ").Append(ImageSpecCode).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  imageType: ").Append(ImageType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EstimateChangeImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EstimateChangeImageRequestBody input)
        {
            if (input == null) return false;
            if (this.DesktopPoolId != input.DesktopPoolId || (this.DesktopPoolId != null && !this.DesktopPoolId.Equals(input.DesktopPoolId))) return false;
            if (this.DesktopIds != input.DesktopIds || (this.DesktopIds != null && input.DesktopIds != null && !this.DesktopIds.SequenceEqual(input.DesktopIds))) return false;
            if (this.PromotionPlanId != input.PromotionPlanId || (this.PromotionPlanId != null && !this.PromotionPlanId.Equals(input.PromotionPlanId))) return false;
            if (this.HandleType != input.HandleType) return false;
            if (this.ImageSpecCode != input.ImageSpecCode || (this.ImageSpecCode != null && !this.ImageSpecCode.Equals(input.ImageSpecCode))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ImageType != input.ImageType || (this.ImageType != null && !this.ImageType.Equals(input.ImageType))) return false;

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
                return hashCode;
            }
        }
    }
}
