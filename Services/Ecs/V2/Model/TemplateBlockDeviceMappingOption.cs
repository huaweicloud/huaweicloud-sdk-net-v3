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
    public class TemplateBlockDeviceMappingOption 
    {
        /// <summary>
        /// 卷设备源头类型
        /// </summary>
        /// <value>卷设备源头类型</value>
        [JsonConverter(typeof(EnumClassConverter<SourceTypeEnum>))]
        public class SourceTypeEnum
        {
            /// <summary>
            /// Enum BLANK for value: blank
            /// </summary>
            public static readonly SourceTypeEnum BLANK = new SourceTypeEnum("blank");

            /// <summary>
            /// Enum IMAGE for value: image
            /// </summary>
            public static readonly SourceTypeEnum IMAGE = new SourceTypeEnum("image");

            private static readonly Dictionary<string, SourceTypeEnum> StaticFields =
            new Dictionary<string, SourceTypeEnum>()
            {
                { "blank", BLANK },
                { "image", IMAGE },
            };

            private string _value;

            public SourceTypeEnum()
            {

            }

            public SourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceTypeEnum a, SourceTypeEnum b)
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

            public static bool operator !=(SourceTypeEnum a, SourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 虚拟机卷数据源类型：blank, image_id
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// 卷设备源头类型
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public SourceTypeEnum SourceType { get; set; }
        /// <summary>
        /// 是否加密
        /// </summary>
        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// 秘钥ID
        /// </summary>
        [JsonProperty("cmk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkId { get; set; }

        /// <summary>
        /// 卷类型
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }

        /// <summary>
        /// 卷大小
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? VolumeSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attachment", NullValueHandling = NullValueHandling.Ignore)]
        public TemplateBlockDeviceMappingAttachmentOption Attachment { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateBlockDeviceMappingOption {\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  cmkId: ").Append(CmkId).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  attachment: ").Append(Attachment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateBlockDeviceMappingOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateBlockDeviceMappingOption input)
        {
            if (input == null) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.SourceType != input.SourceType) return false;
            if (this.Encrypted != input.Encrypted || (this.Encrypted != null && !this.Encrypted.Equals(input.Encrypted))) return false;
            if (this.CmkId != input.CmkId || (this.CmkId != null && !this.CmkId.Equals(input.CmkId))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;
            if (this.VolumeSize != input.VolumeSize || (this.VolumeSize != null && !this.VolumeSize.Equals(input.VolumeSize))) return false;
            if (this.Attachment != input.Attachment || (this.Attachment != null && !this.Attachment.Equals(input.Attachment))) return false;

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
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.Encrypted != null) hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.CmkId != null) hashCode = hashCode * 59 + this.CmkId.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.VolumeSize != null) hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.Attachment != null) hashCode = hashCode * 59 + this.Attachment.GetHashCode();
                return hashCode;
            }
        }
    }
}
