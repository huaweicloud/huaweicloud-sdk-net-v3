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
    /// Response Object
    /// </summary>
    public class Show2DDigitalHumanVideoResponse : SdkResponse
    {
        /// <summary>
        /// 任务的状态。 * WAITING：等待 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败 * CANCELED：取消 * BLOCK: 冻结
        /// </summary>
        /// <value>任务的状态。 * WAITING：等待 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败 * CANCELED：取消 * BLOCK: 冻结</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly StateEnum WAITING = new StateEnum("WAITING");

            /// <summary>
            /// Enum PROCESSING for value: PROCESSING
            /// </summary>
            public static readonly StateEnum PROCESSING = new StateEnum("PROCESSING");

            /// <summary>
            /// Enum SUCCEED for value: SUCCEED
            /// </summary>
            public static readonly StateEnum SUCCEED = new StateEnum("SUCCEED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StateEnum FAILED = new StateEnum("FAILED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly StateEnum CANCELED = new StateEnum("CANCELED");

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            public static readonly StateEnum BLOCK = new StateEnum("BLOCK");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "WAITING", WAITING },
                { "PROCESSING", PROCESSING },
                { "SUCCEED", SUCCEED },
                { "FAILED", FAILED },
                { "CANCELED", CANCELED },
                { "BLOCK", BLOCK },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务类型。 * 2D_DIGITAL_HUMAN_VIDEO: 分身数字人视频制作任务 * DIGITAL_HUMAN_PHOTO_VIDEO: 照片数字人视频制作任务
        /// </summary>
        /// <value>任务类型。 * 2D_DIGITAL_HUMAN_VIDEO: 分身数字人视频制作任务 * DIGITAL_HUMAN_PHOTO_VIDEO: 照片数字人视频制作任务</value>
        [JsonConverter(typeof(EnumClassConverter<JobTypeEnum>))]
        public class JobTypeEnum
        {
            /// <summary>
            /// Enum _2D_DIGITAL_HUMAN_VIDEO for value: 2D_DIGITAL_HUMAN_VIDEO
            /// </summary>
            public static readonly JobTypeEnum _2D_DIGITAL_HUMAN_VIDEO = new JobTypeEnum("2D_DIGITAL_HUMAN_VIDEO");

            /// <summary>
            /// Enum DIGITAL_HUMAN_PHOTO_VIDEO for value: DIGITAL_HUMAN_PHOTO_VIDEO
            /// </summary>
            public static readonly JobTypeEnum DIGITAL_HUMAN_PHOTO_VIDEO = new JobTypeEnum("DIGITAL_HUMAN_PHOTO_VIDEO");

            private static readonly Dictionary<string, JobTypeEnum> StaticFields =
            new Dictionary<string, JobTypeEnum>()
            {
                { "2D_DIGITAL_HUMAN_VIDEO", _2D_DIGITAL_HUMAN_VIDEO },
                { "DIGITAL_HUMAN_PHOTO_VIDEO", DIGITAL_HUMAN_PHOTO_VIDEO },
            };

            private string _value;

            public JobTypeEnum()
            {

            }

            public JobTypeEnum(string value)
            {
                _value = value;
            }

            public static JobTypeEnum FromValue(string value)
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

                if (this.Equals(obj as JobTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JobTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JobTypeEnum a, JobTypeEnum b)
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

            public static bool operator !=(JobTypeEnum a, JobTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 视频生成类型。该参数取值是MODEL时，model_asset_id必填；取值是PICTURE时，human_image必填。 * MODEL：通过分身数字人模型生成视频 * PICTURE： 通过单张照片生成视频 &gt; * 该参数已废弃，照片数字人视频制作使用“创建照片分身数字人视频制作任务”接口。
        /// </summary>
        /// <value>视频生成类型。该参数取值是MODEL时，model_asset_id必填；取值是PICTURE时，human_image必填。 * MODEL：通过分身数字人模型生成视频 * PICTURE： 通过单张照片生成视频 &gt; * 该参数已废弃，照片数字人视频制作使用“创建照片分身数字人视频制作任务”接口。</value>
        [JsonConverter(typeof(EnumClassConverter<VideoMakingTypeEnum>))]
        public class VideoMakingTypeEnum
        {
            /// <summary>
            /// Enum MODEL for value: MODEL
            /// </summary>
            public static readonly VideoMakingTypeEnum MODEL = new VideoMakingTypeEnum("MODEL");

            /// <summary>
            /// Enum PICTURE for value: PICTURE
            /// </summary>
            public static readonly VideoMakingTypeEnum PICTURE = new VideoMakingTypeEnum("PICTURE");

            private static readonly Dictionary<string, VideoMakingTypeEnum> StaticFields =
            new Dictionary<string, VideoMakingTypeEnum>()
            {
                { "MODEL", MODEL },
                { "PICTURE", PICTURE },
            };

            private string _value;

            public VideoMakingTypeEnum()
            {

            }

            public VideoMakingTypeEnum(string value)
            {
                _value = value;
            }

            public static VideoMakingTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VideoMakingTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoMakingTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoMakingTypeEnum a, VideoMakingTypeEnum b)
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

            public static bool operator !=(VideoMakingTypeEnum a, VideoMakingTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 任务的状态。 * WAITING：等待 * PROCESSING：处理中 * SUCCEED：成功 * FAILED：失败 * CANCELED：取消 * BLOCK: 冻结
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 任务类型。 * 2D_DIGITAL_HUMAN_VIDEO: 分身数字人视频制作任务 * DIGITAL_HUMAN_PHOTO_VIDEO: 照片数字人视频制作任务
        /// </summary>
        [JsonProperty("job_type", NullValueHandling = NullValueHandling.Ignore)]
        public JobTypeEnum JobType { get; set; }
        /// <summary>
        /// 数字人视频制作开始时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 数字人视频制作结束时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**： 数字人视频内容时长。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_asset_config", NullValueHandling = NullValueHandling.Ignore)]
        public OutputAssetInfo OutputAssetConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务更新时间。
        /// </summary>
        [JsonProperty("lastupdate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastupdateTime { get; set; }

        /// <summary>
        /// 剧本ID。
        /// </summary>
        [JsonProperty("script_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptId { get; set; }

        /// <summary>
        /// 视频生成类型。该参数取值是MODEL时，model_asset_id必填；取值是PICTURE时，human_image必填。 * MODEL：通过分身数字人模型生成视频 * PICTURE： 通过单张照片生成视频 &gt; * 该参数已废弃，照片数字人视频制作使用“创建照片分身数字人视频制作任务”接口。
        /// </summary>
        [JsonProperty("video_making_type", NullValueHandling = NullValueHandling.Ignore)]
        public VideoMakingTypeEnum VideoMakingType { get; set; }
        /// <summary>
        /// 人物照片，需要Base64编码。 &gt; * 该参数已废弃，照片数字人视频制作使用“创建照片分身数字人视频制作任务”接口。
        /// </summary>
        [JsonProperty("human_image", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanImage { get; set; }

        /// <summary>
        /// 分身数字人模型资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("model_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_config", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceConfig VoiceConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_config", NullValueHandling = NullValueHandling.Ignore)]
        public VideoConfig VideoConfig { get; set; }

        /// <summary>
        /// 拍摄脚本列表。
        /// </summary>
        [JsonProperty("shoot_scripts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShootScriptItem> ShootScripts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("background_music_config", NullValueHandling = NullValueHandling.Ignore)]
        public BackgroundMusicConfig BackgroundMusicConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Show2DDigitalHumanVideoResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  jobType: ").Append(JobType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  outputAssetConfig: ").Append(OutputAssetConfig).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastupdateTime: ").Append(LastupdateTime).Append("\n");
            sb.Append("  scriptId: ").Append(ScriptId).Append("\n");
            sb.Append("  videoMakingType: ").Append(VideoMakingType).Append("\n");
            sb.Append("  humanImage: ").Append(HumanImage).Append("\n");
            sb.Append("  modelAssetId: ").Append(ModelAssetId).Append("\n");
            sb.Append("  voiceConfig: ").Append(VoiceConfig).Append("\n");
            sb.Append("  videoConfig: ").Append(VideoConfig).Append("\n");
            sb.Append("  shootScripts: ").Append(ShootScripts).Append("\n");
            sb.Append("  backgroundMusicConfig: ").Append(BackgroundMusicConfig).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Show2DDigitalHumanVideoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Show2DDigitalHumanVideoResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.State != input.State) return false;
            if (this.JobType != input.JobType) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.OutputAssetConfig != input.OutputAssetConfig || (this.OutputAssetConfig != null && !this.OutputAssetConfig.Equals(input.OutputAssetConfig))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastupdateTime != input.LastupdateTime || (this.LastupdateTime != null && !this.LastupdateTime.Equals(input.LastupdateTime))) return false;
            if (this.ScriptId != input.ScriptId || (this.ScriptId != null && !this.ScriptId.Equals(input.ScriptId))) return false;
            if (this.VideoMakingType != input.VideoMakingType) return false;
            if (this.HumanImage != input.HumanImage || (this.HumanImage != null && !this.HumanImage.Equals(input.HumanImage))) return false;
            if (this.ModelAssetId != input.ModelAssetId || (this.ModelAssetId != null && !this.ModelAssetId.Equals(input.ModelAssetId))) return false;
            if (this.VoiceConfig != input.VoiceConfig || (this.VoiceConfig != null && !this.VoiceConfig.Equals(input.VoiceConfig))) return false;
            if (this.VideoConfig != input.VideoConfig || (this.VideoConfig != null && !this.VideoConfig.Equals(input.VideoConfig))) return false;
            if (this.ShootScripts != input.ShootScripts || (this.ShootScripts != null && input.ShootScripts != null && !this.ShootScripts.SequenceEqual(input.ShootScripts))) return false;
            if (this.BackgroundMusicConfig != input.BackgroundMusicConfig || (this.BackgroundMusicConfig != null && !this.BackgroundMusicConfig.Equals(input.BackgroundMusicConfig))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.JobType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.OutputAssetConfig != null) hashCode = hashCode * 59 + this.OutputAssetConfig.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastupdateTime != null) hashCode = hashCode * 59 + this.LastupdateTime.GetHashCode();
                if (this.ScriptId != null) hashCode = hashCode * 59 + this.ScriptId.GetHashCode();
                hashCode = hashCode * 59 + this.VideoMakingType.GetHashCode();
                if (this.HumanImage != null) hashCode = hashCode * 59 + this.HumanImage.GetHashCode();
                if (this.ModelAssetId != null) hashCode = hashCode * 59 + this.ModelAssetId.GetHashCode();
                if (this.VoiceConfig != null) hashCode = hashCode * 59 + this.VoiceConfig.GetHashCode();
                if (this.VideoConfig != null) hashCode = hashCode * 59 + this.VideoConfig.GetHashCode();
                if (this.ShootScripts != null) hashCode = hashCode * 59 + this.ShootScripts.GetHashCode();
                if (this.BackgroundMusicConfig != null) hashCode = hashCode * 59 + this.BackgroundMusicConfig.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
