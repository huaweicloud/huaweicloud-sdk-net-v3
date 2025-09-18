using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VideoScriptBaseInfo 
    {
        /// <summary>
        /// 数字人模型类型。  * HUMAN_MODEL_2D：分身数字人
        /// </summary>
        /// <value>数字人模型类型。  * HUMAN_MODEL_2D：分身数字人</value>
        [JsonConverter(typeof(EnumClassConverter<ModelAssetTypeEnum>))]
        public class ModelAssetTypeEnum
        {
            /// <summary>
            /// Enum HUMAN_MODEL_2D for value: HUMAN_MODEL_2D
            /// </summary>
            public static readonly ModelAssetTypeEnum HUMAN_MODEL_2D = new ModelAssetTypeEnum("HUMAN_MODEL_2D");

            private static readonly Dictionary<string, ModelAssetTypeEnum> StaticFields =
            new Dictionary<string, ModelAssetTypeEnum>()
            {
                { "HUMAN_MODEL_2D", HUMAN_MODEL_2D },
            };

            private string _value;

            public ModelAssetTypeEnum()
            {

            }

            public ModelAssetTypeEnum(string value)
            {
                _value = value;
            }

            public static ModelAssetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ModelAssetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelAssetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelAssetTypeEnum a, ModelAssetTypeEnum b)
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

            public static bool operator !=(ModelAssetTypeEnum a, ModelAssetTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 剧本ID。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 剧本名称。
        /// </summary>
        [JsonProperty("script_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptName { get; set; }

        /// <summary>
        /// 剧本描述。
        /// </summary>
        [JsonProperty("script_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptDescription { get; set; }

        /// <summary>
        /// 数字人模型资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 数字人模型类型。  * HUMAN_MODEL_2D：分身数字人
        /// </summary>
        [JsonProperty("model_asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public ModelAssetTypeEnum ModelAssetType { get; set; }
        /// <summary>
        /// 剧本封面下载url。
        /// </summary>
        [JsonProperty("script_cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptCoverUrl { get; set; }

        /// <summary>
        /// 脚本类型，即视频制作的驱动方式。默认TEXT * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动
        /// </summary>
        [JsonProperty("script_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptType { get; set; }

        /// <summary>
        /// 台词脚本。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoScriptBaseInfo {\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  scriptName: ").Append(ScriptName).Append("\n");
            sb.Append("  scriptDescription: ").Append(ScriptDescription).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  modelAssetType: ").Append(ModelAssetType).Append("\n");
            sb.Append("  scriptCoverUrl: ").Append(ScriptCoverUrl).Append("\n");
            sb.Append("  scriptType: ").Append(ScriptType).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoScriptBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoScriptBaseInfo input)
        {
            if (input == null) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.ScriptName != input.ScriptName || (this.ScriptName != null && !this.ScriptName.Equals(input.ScriptName))) return false;
            if (this.ScriptDescription != input.ScriptDescription || (this.ScriptDescription != null && !this.ScriptDescription.Equals(input.ScriptDescription))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.ModelAssetType != input.ModelAssetType) return false;
            if (this.ScriptCoverUrl != input.ScriptCoverUrl || (this.ScriptCoverUrl != null && !this.ScriptCoverUrl.Equals(input.ScriptCoverUrl))) return false;
            if (this.ScriptType != input.ScriptType || (this.ScriptType != null && !this.ScriptType.Equals(input.ScriptType))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                if (this.ScriptName != null) hashCode = hashCode * 59 + this.ScriptName.GetHashCode();
                if (this.ScriptDescription != null) hashCode = hashCode * 59 + this.ScriptDescription.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                hashCode = hashCode * 59 + this.ModelAssetType.GetHashCode();
                if (this.ScriptCoverUrl != null) hashCode = hashCode * 59 + this.ScriptCoverUrl.GetHashCode();
                if (this.ScriptType != null) hashCode = hashCode * 59 + this.ScriptType.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
