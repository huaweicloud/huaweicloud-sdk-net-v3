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
    /// 创建训练任务请求。
    /// </summary>
    public class CreateTrainingJobReq 
    {
        /// <summary>
        /// 语音性别,是男性声音还是女性声音。 * FEMALE: 女性 * MALE: 男性
        /// </summary>
        /// <value>语音性别,是男性声音还是女性声音。 * FEMALE: 女性 * MALE: 男性</value>
        [JsonConverter(typeof(EnumClassConverter<SexEnum>))]
        public class SexEnum
        {
            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            public static readonly SexEnum FEMALE = new SexEnum("FEMALE");

            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            public static readonly SexEnum MALE = new SexEnum("MALE");

            private static readonly Dictionary<string, SexEnum> StaticFields =
            new Dictionary<string, SexEnum>()
            {
                { "FEMALE", FEMALE },
                { "MALE", MALE },
            };

            private string _value;

            public SexEnum()
            {

            }

            public SexEnum(string value)
            {
                _value = value;
            }

            public static SexEnum FromValue(string value)
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

                if (this.Equals(obj as SexEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SexEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SexEnum a, SexEnum b)
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

            public static bool operator !=(SexEnum a, SexEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public JobTag? Tag { get; set; }

        /// <summary>
        /// 一段描述信息,会呈现在资产库中。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 语音性别,是男性声音还是女性声音。 * FEMALE: 女性 * MALE: 男性
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public SexEnum Sex { get; set; }
        /// <summary>
        /// 音色名称。该名称会作为资产库中音色模型资产名称。
        /// </summary>
        [JsonProperty("voice_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceName { get; set; }

        /// <summary>
        /// 训练语言,当前仅支持中文。 * CN: 中文 * EN: 英文
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("create_type", NullValueHandling = NullValueHandling.Ignore)]
        public CreateType? CreateType { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// 形象制作任务id
        /// </summary>
        [JsonProperty("dhtms_job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DhtmsJobId { get; set; }

        /// <summary>
        /// 批次名称
        /// </summary>
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 模型输出语言类型
        /// </summary>
        [JsonProperty("output_language", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputLanguage { get; set; }

        /// <summary>
        /// 自定义试听文本
        /// </summary>
        [JsonProperty("custom_text", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomText { get; set; }

        /// <summary>
        /// 是否使用按需资源
        /// </summary>
        [JsonProperty("is_ondemand_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOndemandResource { get; set; }

        /// <summary>
        /// 支持的业务类型。： * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互
        /// </summary>
        [JsonProperty("supported_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedServiceEnum> SupportedService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrainingJobReq {\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  voiceName: ").Append(VoiceName).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  createType: ").Append(CreateType).Append("\n");
            sb.Append("  phone: ").Append(Phone).Append("\n");
            sb.Append("  dhtmsJobId: ").Append(DhtmsJobId).Append("\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  outputLanguage: ").Append(OutputLanguage).Append("\n");
            sb.Append("  customText: ").Append(CustomText).Append("\n");
            sb.Append("  isOndemandResource: ").Append(IsOndemandResource).Append("\n");
            sb.Append("  supportedService: ").Append(SupportedService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrainingJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrainingJobReq input)
        {
            if (input == null) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Sex != input.Sex) return false;
            if (this.VoiceName != input.VoiceName || (this.VoiceName != null && !this.VoiceName.Equals(input.VoiceName))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.CreateType != input.CreateType || (this.CreateType != null && !this.CreateType.Equals(input.CreateType))) return false;
            if (this.Phone != input.Phone || (this.Phone != null && !this.Phone.Equals(input.Phone))) return false;
            if (this.DhtmsJobId != input.DhtmsJobId || (this.DhtmsJobId != null && !this.DhtmsJobId.Equals(input.DhtmsJobId))) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
            if (this.OutputLanguage != input.OutputLanguage || (this.OutputLanguage != null && !this.OutputLanguage.Equals(input.OutputLanguage))) return false;
            if (this.CustomText != input.CustomText || (this.CustomText != null && !this.CustomText.Equals(input.CustomText))) return false;
            if (this.IsOndemandResource != input.IsOndemandResource || (this.IsOndemandResource != null && !this.IsOndemandResource.Equals(input.IsOndemandResource))) return false;
            if (this.SupportedService != input.SupportedService || (this.SupportedService != null && input.SupportedService != null && !this.SupportedService.SequenceEqual(input.SupportedService))) return false;

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
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.VoiceName != null) hashCode = hashCode * 59 + this.VoiceName.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.CreateType != null) hashCode = hashCode * 59 + this.CreateType.GetHashCode();
                if (this.Phone != null) hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.DhtmsJobId != null) hashCode = hashCode * 59 + this.DhtmsJobId.GetHashCode();
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.OutputLanguage != null) hashCode = hashCode * 59 + this.OutputLanguage.GetHashCode();
                if (this.CustomText != null) hashCode = hashCode * 59 + this.CustomText.GetHashCode();
                if (this.IsOndemandResource != null) hashCode = hashCode * 59 + this.IsOndemandResource.GetHashCode();
                if (this.SupportedService != null) hashCode = hashCode * 59 + this.SupportedService.GetHashCode();
                return hashCode;
            }
        }
    }
}
