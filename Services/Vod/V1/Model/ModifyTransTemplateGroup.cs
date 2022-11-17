using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyTransTemplateGroup 
    {
        /// <summary>
        /// 是否设置默认。
        /// </summary>
        /// <value>是否设置默认。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly StatusEnum _1 = new StatusEnum("1");

            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly StatusEnum _0 = new StatusEnum("0");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "1", _1 },
                { "0", _0 },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 模板组名称。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 模板组名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否设置默认。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 是否自动加密。  取值如下： - 0：表示不加密。 - 1：表示需要加密。  默认值：0。  加密与转码必须要一起进行，当需要加密时，转码参数不能为空，且转码输出格式必须要为HLS。
        /// </summary>
        [JsonProperty("auto_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoEncrypt { get; set; }

        /// <summary>
        /// 画质配置信息列表。
        /// </summary>
        [JsonProperty("quality_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<QualityInfo> QualityInfoList { get; set; }

        /// <summary>
        /// 绑定的水印模板组ID数组。
        /// </summary>
        [JsonProperty("watermark_template_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> WatermarkTemplateIds { get; set; }

        /// <summary>
        /// 模板介绍。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("common", NullValueHandling = NullValueHandling.Ignore)]
        public Common Common { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyTransTemplateGroup {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  autoEncrypt: ").Append(AutoEncrypt).Append("\n");
            sb.Append("  qualityInfoList: ").Append(QualityInfoList).Append("\n");
            sb.Append("  watermarkTemplateIds: ").Append(WatermarkTemplateIds).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  common: ").Append(Common).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyTransTemplateGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyTransTemplateGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AutoEncrypt == input.AutoEncrypt ||
                    (this.AutoEncrypt != null &&
                    this.AutoEncrypt.Equals(input.AutoEncrypt))
                ) && 
                (
                    this.QualityInfoList == input.QualityInfoList ||
                    this.QualityInfoList != null &&
                    input.QualityInfoList != null &&
                    this.QualityInfoList.SequenceEqual(input.QualityInfoList)
                ) && 
                (
                    this.WatermarkTemplateIds == input.WatermarkTemplateIds ||
                    this.WatermarkTemplateIds != null &&
                    input.WatermarkTemplateIds != null &&
                    this.WatermarkTemplateIds.SequenceEqual(input.WatermarkTemplateIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Common == input.Common ||
                    (this.Common != null &&
                    this.Common.Equals(input.Common))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AutoEncrypt != null)
                    hashCode = hashCode * 59 + this.AutoEncrypt.GetHashCode();
                if (this.QualityInfoList != null)
                    hashCode = hashCode * 59 + this.QualityInfoList.GetHashCode();
                if (this.WatermarkTemplateIds != null)
                    hashCode = hashCode * 59 + this.WatermarkTemplateIds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Common != null)
                    hashCode = hashCode * 59 + this.Common.GetHashCode();
                return hashCode;
            }
        }
    }
}
