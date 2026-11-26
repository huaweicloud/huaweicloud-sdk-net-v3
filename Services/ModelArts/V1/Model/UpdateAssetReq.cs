using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 更新资产请求体
    /// </summary>
    public class UpdateAssetReq 
    {
        /// <summary>
        /// **参数解释**：数据集资产的上下线状态。 **约束限制**：不涉及。 **取值范围**：枚举值： - online：上线 - offline：下线 - waiting: 等待中 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：数据集资产的上下线状态。 **约束限制**：不涉及。 **取值范围**：枚举值： - online：上线 - offline：下线 - waiting: 等待中 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: online
            /// </summary>
            public static readonly StatusEnum ONLINE = new StatusEnum("online");

            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly StatusEnum OFFLINE = new StatusEnum("offline");

            /// <summary>
            /// Enum WAITING for value: waiting
            /// </summary>
            public static readonly StatusEnum WAITING = new StatusEnum("waiting");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "online", ONLINE },
                { "offline", OFFLINE },
                { "waiting", WAITING },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：资产名称。 **约束限制**：1-128位字符，只包含中文、字母、数字、中划线、下划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// **参数解释**：资产描述。 **约束限制**：0-512位字符，不能包含英文尖括号（即 &lt; 或 &gt;）。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetDesc { get; set; }

        /// <summary>
        /// **参数解释**：资产组描述。 **约束限制**：0-512位字符，不能包含英文尖括号（即 &lt; 或 &gt;）。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_group_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetGroupDesc { get; set; }

        /// <summary>
        /// **参数解释**：资产品牌，例如DeepSeek,Qwen,Wan,GPT,Llama,GLM,ERNIE,Mistral,Kimi,Other。 **约束限制**：1-40位字符，仅支持英文字母、数字、下划线和中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("asset_series", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetSeries { get; set; }

        /// <summary>
        /// **参数解释**：资产能力，为自由文本字符串列表(非严格枚举)。推荐使用以下约定值：例如TextGeneration,ImageUnderstanding,ImageGeneration,VideoGeneration,AgenticRL,Other。 **约束限制**：每个元素1-40位字符，仅支持英文字母、数字、下划线和中划线；最多10个元素。
        /// </summary>
        [JsonProperty("asset_capabilities", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetCapabilities { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产的上下线状态。 **约束限制**：不涉及。 **取值范围**：枚举值： - online：上线 - offline：下线 - waiting: 等待中 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：资产是否可用。 **约束限制**：不涉及。 **取值范围**： - true：可用 - false：不可用 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// **参数解释**：数据集资产是否被软删除。 **约束限制**：不涉及。 **取值范围**： - true：已删除 - false：未删除 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("is_deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// **参数解释**：资产tag。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, List<string>> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public Properties Properties { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAssetReq {\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetDesc: ").Append(AssetDesc).Append("\n");
            sb.Append("  assetGroupDesc: ").Append(AssetGroupDesc).Append("\n");
            sb.Append("  assetSeries: ").Append(AssetSeries).Append("\n");
            sb.Append("  assetCapabilities: ").Append(AssetCapabilities).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  isDeleted: ").Append(IsDeleted).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  properties: ").Append(Properties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAssetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAssetReq input)
        {
            if (input == null) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetDesc != input.AssetDesc || (this.AssetDesc != null && !this.AssetDesc.Equals(input.AssetDesc))) return false;
            if (this.AssetGroupDesc != input.AssetGroupDesc || (this.AssetGroupDesc != null && !this.AssetGroupDesc.Equals(input.AssetGroupDesc))) return false;
            if (this.AssetSeries != input.AssetSeries || (this.AssetSeries != null && !this.AssetSeries.Equals(input.AssetSeries))) return false;
            if (this.AssetCapabilities != input.AssetCapabilities || (this.AssetCapabilities != null && input.AssetCapabilities != null && !this.AssetCapabilities.SequenceEqual(input.AssetCapabilities))) return false;
            if (this.Status != input.Status) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;
            if (this.IsDeleted != input.IsDeleted || (this.IsDeleted != null && !this.IsDeleted.Equals(input.IsDeleted))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Properties != input.Properties || (this.Properties != null && !this.Properties.Equals(input.Properties))) return false;

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
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetDesc != null) hashCode = hashCode * 59 + this.AssetDesc.GetHashCode();
                if (this.AssetGroupDesc != null) hashCode = hashCode * 59 + this.AssetGroupDesc.GetHashCode();
                if (this.AssetSeries != null) hashCode = hashCode * 59 + this.AssetSeries.GetHashCode();
                if (this.AssetCapabilities != null) hashCode = hashCode * 59 + this.AssetCapabilities.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.IsDeleted != null) hashCode = hashCode * 59 + this.IsDeleted.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Properties != null) hashCode = hashCode * 59 + this.Properties.GetHashCode();
                return hashCode;
            }
        }
    }
}
