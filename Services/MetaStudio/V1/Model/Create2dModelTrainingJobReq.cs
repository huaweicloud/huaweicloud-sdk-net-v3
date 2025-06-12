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
    /// 创建或更新分身数字人模型训练任务请求。
    /// </summary>
    public class Create2dModelTrainingJobReq 
    {
        /// <summary>
        /// 命令类型： * UPDATE_VIDEO: 更新视频 * UPLOAD_VIDEO：上传视频 * CONFIRM_ACTION_VIDEO: 确认动作编排视频 * GET_ACTION_VIDEO_MULTIPART: 获取动作编排视频分片
        /// </summary>
        /// <value>命令类型： * UPDATE_VIDEO: 更新视频 * UPLOAD_VIDEO：上传视频 * CONFIRM_ACTION_VIDEO: 确认动作编排视频 * GET_ACTION_VIDEO_MULTIPART: 获取动作编排视频分片</value>
        [JsonConverter(typeof(EnumClassConverter<CommandMessageEnum>))]
        public class CommandMessageEnum
        {
            /// <summary>
            /// Enum UPDATE_VIDEO for value: UPDATE_VIDEO
            /// </summary>
            public static readonly CommandMessageEnum UPDATE_VIDEO = new CommandMessageEnum("UPDATE_VIDEO");

            /// <summary>
            /// Enum UPLOAD_VIDEO for value: UPLOAD_VIDEO
            /// </summary>
            public static readonly CommandMessageEnum UPLOAD_VIDEO = new CommandMessageEnum("UPLOAD_VIDEO");

            /// <summary>
            /// Enum CONFIRM_ACTION_VIDEO for value: CONFIRM_ACTION_VIDEO
            /// </summary>
            public static readonly CommandMessageEnum CONFIRM_ACTION_VIDEO = new CommandMessageEnum("CONFIRM_ACTION_VIDEO");

            /// <summary>
            /// Enum GET_ACTION_VIDEO_MULTIPART for value: GET_ACTION_VIDEO_MULTIPART
            /// </summary>
            public static readonly CommandMessageEnum GET_ACTION_VIDEO_MULTIPART = new CommandMessageEnum("GET_ACTION_VIDEO_MULTIPART");

            private static readonly Dictionary<string, CommandMessageEnum> StaticFields =
            new Dictionary<string, CommandMessageEnum>()
            {
                { "UPDATE_VIDEO", UPDATE_VIDEO },
                { "UPLOAD_VIDEO", UPLOAD_VIDEO },
                { "CONFIRM_ACTION_VIDEO", CONFIRM_ACTION_VIDEO },
                { "GET_ACTION_VIDEO_MULTIPART", GET_ACTION_VIDEO_MULTIPART },
            };

            private string _value;

            public CommandMessageEnum()
            {

            }

            public CommandMessageEnum(string value)
            {
                _value = value;
            }

            public static CommandMessageEnum FromValue(string value)
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

                if (this.Equals(obj as CommandMessageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CommandMessageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CommandMessageEnum a, CommandMessageEnum b)
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

            public static bool operator !=(CommandMessageEnum a, CommandMessageEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 &gt; * V3和V2版本已废弃不用
        /// </summary>
        /// <value>分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 &gt; * V3和V2版本已废弃不用</value>
        [JsonConverter(typeof(EnumClassConverter<ModelVersionEnum>))]
        public class ModelVersionEnum
        {
            /// <summary>
            /// Enum V2 for value: V2
            /// </summary>
            public static readonly ModelVersionEnum V2 = new ModelVersionEnum("V2");

            /// <summary>
            /// Enum V3 for value: V3
            /// </summary>
            public static readonly ModelVersionEnum V3 = new ModelVersionEnum("V3");

            /// <summary>
            /// Enum V3_2 for value: V3.2
            /// </summary>
            public static readonly ModelVersionEnum V3_2 = new ModelVersionEnum("V3.2");

            private static readonly Dictionary<string, ModelVersionEnum> StaticFields =
            new Dictionary<string, ModelVersionEnum>()
            {
                { "V2", V2 },
                { "V3", V3 },
                { "V3.2", V3_2 },
            };

            private string _value;

            public ModelVersionEnum()
            {

            }

            public ModelVersionEnum(string value)
            {
                _value = value;
            }

            public static ModelVersionEnum FromValue(string value)
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

                if (this.Equals(obj as ModelVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelVersionEnum a, ModelVersionEnum b)
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

            public static bool operator !=(ModelVersionEnum a, ModelVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 声音来源类型 * VIDEO：视频中抽取音频 * AUDIO：单独上传的音频
        /// </summary>
        /// <value>声音来源类型 * VIDEO：视频中抽取音频 * AUDIO：单独上传的音频</value>
        [JsonConverter(typeof(EnumClassConverter<AudioSourceTypeEnum>))]
        public class AudioSourceTypeEnum
        {
            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly AudioSourceTypeEnum VIDEO = new AudioSourceTypeEnum("VIDEO");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly AudioSourceTypeEnum AUDIO = new AudioSourceTypeEnum("AUDIO");

            private static readonly Dictionary<string, AudioSourceTypeEnum> StaticFields =
            new Dictionary<string, AudioSourceTypeEnum>()
            {
                { "VIDEO", VIDEO },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public AudioSourceTypeEnum()
            {

            }

            public AudioSourceTypeEnum(string value)
            {
                _value = value;
            }

            public static AudioSourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AudioSourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioSourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioSourceTypeEnum a, AudioSourceTypeEnum b)
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

            public static bool operator !=(AudioSourceTypeEnum a, AudioSourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 分身数字人模型名称。该名称会作为资产库中分身数字人模型资产名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 分身数字人训练任务创建者的手机号。
        /// </summary>
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        /// <summary>
        /// 命令类型： * UPDATE_VIDEO: 更新视频 * UPLOAD_VIDEO：上传视频 * CONFIRM_ACTION_VIDEO: 确认动作编排视频 * GET_ACTION_VIDEO_MULTIPART: 获取动作编排视频分片
        /// </summary>
        [JsonProperty("command_message", NullValueHandling = NullValueHandling.Ignore)]
        public CommandMessageEnum CommandMessage { get; set; }
        /// <summary>
        /// 训练视频上传分片数（上传时对唯一训练视频文件的数据分片，用于对该文件的并发上传，不是分多个视频文件上传）。
        /// </summary>
        [JsonProperty("video_multipart_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoMultipartCount { get; set; }

        /// <summary>
        /// 动作视频上传分片数。
        /// </summary>
        [JsonProperty("action_video_multipart_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionVideoMultipartCount { get; set; }

        /// <summary>
        /// 分身数字人是否需要背景替换。需要背景替换的分身数字人训练视频需要绿幕拍摄。
        /// </summary>
        [JsonProperty("is_background_replacement", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBackgroundReplacement { get; set; }

        /// <summary>
        /// 分身数字人训练任务的批次名称。
        /// </summary>
        [JsonProperty("batch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BatchName { get; set; }

        /// <summary>
        /// 分身数字人训练任务标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 分身数字人模型版本。默认是V3.2版本模型。 * V3.2：V3.2版本模型 &gt; * V3和V2版本已废弃不用
        /// </summary>
        [JsonProperty("model_version", NullValueHandling = NullValueHandling.Ignore)]
        public ModelVersionEnum ModelVersion { get; set; }
        /// <summary>
        /// 是否是基础版的形象训练
        /// </summary>
        [JsonProperty("is_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFlexus { get; set; }

        /// <summary>
        /// 是否只训练形象模型，不训练声音模型。仅Flexus版本时有效，默认false。
        /// </summary>
        [JsonProperty("is_only_human_model", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnlyHumanModel { get; set; }

        /// <summary>
        /// 声音来源类型 * VIDEO：视频中抽取音频 * AUDIO：单独上传的音频
        /// </summary>
        [JsonProperty("audio_source_type", NullValueHandling = NullValueHandling.Ignore)]
        public AudioSourceTypeEnum AudioSourceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_properties", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceProperties VoiceProperties { get; set; }

        /// <summary>
        /// 该任务所生成的模型支持的业务类型，可多选。  Flexus版数字人仅支持选择“VIDEO_2D”。
        /// </summary>
        [JsonProperty("supported_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedServiceEnum> SupportedService { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Create2dModelTrainingJobReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  contact: ").Append(Contact).Append("\n");
            sb.Append("  commandMessage: ").Append(CommandMessage).Append("\n");
            sb.Append("  videoMultipartCount: ").Append(VideoMultipartCount).Append("\n");
            sb.Append("  actionVideoMultipartCount: ").Append(ActionVideoMultipartCount).Append("\n");
            sb.Append("  isBackgroundReplacement: ").Append(IsBackgroundReplacement).Append("\n");
            sb.Append("  batchName: ").Append(BatchName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  modelVersion: ").Append(ModelVersion).Append("\n");
            sb.Append("  isFlexus: ").Append(IsFlexus).Append("\n");
            sb.Append("  isOnlyHumanModel: ").Append(IsOnlyHumanModel).Append("\n");
            sb.Append("  audioSourceType: ").Append(AudioSourceType).Append("\n");
            sb.Append("  voiceProperties: ").Append(VoiceProperties).Append("\n");
            sb.Append("  supportedService: ").Append(SupportedService).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Create2dModelTrainingJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Create2dModelTrainingJobReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Contact != input.Contact || (this.Contact != null && !this.Contact.Equals(input.Contact))) return false;
            if (this.CommandMessage != input.CommandMessage) return false;
            if (this.VideoMultipartCount != input.VideoMultipartCount || (this.VideoMultipartCount != null && !this.VideoMultipartCount.Equals(input.VideoMultipartCount))) return false;
            if (this.ActionVideoMultipartCount != input.ActionVideoMultipartCount || (this.ActionVideoMultipartCount != null && !this.ActionVideoMultipartCount.Equals(input.ActionVideoMultipartCount))) return false;
            if (this.IsBackgroundReplacement != input.IsBackgroundReplacement || (this.IsBackgroundReplacement != null && !this.IsBackgroundReplacement.Equals(input.IsBackgroundReplacement))) return false;
            if (this.BatchName != input.BatchName || (this.BatchName != null && !this.BatchName.Equals(input.BatchName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.ModelVersion != input.ModelVersion) return false;
            if (this.IsFlexus != input.IsFlexus || (this.IsFlexus != null && !this.IsFlexus.Equals(input.IsFlexus))) return false;
            if (this.IsOnlyHumanModel != input.IsOnlyHumanModel || (this.IsOnlyHumanModel != null && !this.IsOnlyHumanModel.Equals(input.IsOnlyHumanModel))) return false;
            if (this.AudioSourceType != input.AudioSourceType) return false;
            if (this.VoiceProperties != input.VoiceProperties || (this.VoiceProperties != null && !this.VoiceProperties.Equals(input.VoiceProperties))) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Contact != null) hashCode = hashCode * 59 + this.Contact.GetHashCode();
                hashCode = hashCode * 59 + this.CommandMessage.GetHashCode();
                if (this.VideoMultipartCount != null) hashCode = hashCode * 59 + this.VideoMultipartCount.GetHashCode();
                if (this.ActionVideoMultipartCount != null) hashCode = hashCode * 59 + this.ActionVideoMultipartCount.GetHashCode();
                if (this.IsBackgroundReplacement != null) hashCode = hashCode * 59 + this.IsBackgroundReplacement.GetHashCode();
                if (this.BatchName != null) hashCode = hashCode * 59 + this.BatchName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.ModelVersion.GetHashCode();
                if (this.IsFlexus != null) hashCode = hashCode * 59 + this.IsFlexus.GetHashCode();
                if (this.IsOnlyHumanModel != null) hashCode = hashCode * 59 + this.IsOnlyHumanModel.GetHashCode();
                hashCode = hashCode * 59 + this.AudioSourceType.GetHashCode();
                if (this.VoiceProperties != null) hashCode = hashCode * 59 + this.VoiceProperties.GetHashCode();
                if (this.SupportedService != null) hashCode = hashCode * 59 + this.SupportedService.GetHashCode();
                return hashCode;
            }
        }
    }
}
