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
    public class ShowAssetResponse : SdkResponse
    {
        /// <summary>
        /// 资产类型。  公共资产类型： * VOICE_MODEL：音色模型 * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产类型： * HUMAN_MODEL_2D：分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板
        /// </summary>
        /// <value>资产类型。  公共资产类型： * VOICE_MODEL：音色模型 * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产类型： * HUMAN_MODEL_2D：分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板</value>
        [JsonConverter(typeof(EnumClassConverter<AssetTypeEnum>))]
        public class AssetTypeEnum
        {
            /// <summary>
            /// Enum HUMAN_MODEL for value: HUMAN_MODEL
            /// </summary>
            public static readonly AssetTypeEnum HUMAN_MODEL = new AssetTypeEnum("HUMAN_MODEL");

            /// <summary>
            /// Enum VOICE_MODEL for value: VOICE_MODEL
            /// </summary>
            public static readonly AssetTypeEnum VOICE_MODEL = new AssetTypeEnum("VOICE_MODEL");

            /// <summary>
            /// Enum SCENE for value: SCENE
            /// </summary>
            public static readonly AssetTypeEnum SCENE = new AssetTypeEnum("SCENE");

            /// <summary>
            /// Enum ANIMATION for value: ANIMATION
            /// </summary>
            public static readonly AssetTypeEnum ANIMATION = new AssetTypeEnum("ANIMATION");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly AssetTypeEnum VIDEO = new AssetTypeEnum("VIDEO");

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly AssetTypeEnum IMAGE = new AssetTypeEnum("IMAGE");

            /// <summary>
            /// Enum PPT for value: PPT
            /// </summary>
            public static readonly AssetTypeEnum PPT = new AssetTypeEnum("PPT");

            /// <summary>
            /// Enum MATERIAL for value: MATERIAL
            /// </summary>
            public static readonly AssetTypeEnum MATERIAL = new AssetTypeEnum("MATERIAL");

            /// <summary>
            /// Enum NORMAL_MODEL for value: NORMAL_MODEL
            /// </summary>
            public static readonly AssetTypeEnum NORMAL_MODEL = new AssetTypeEnum("NORMAL_MODEL");

            /// <summary>
            /// Enum COMMON_FILE for value: COMMON_FILE
            /// </summary>
            public static readonly AssetTypeEnum COMMON_FILE = new AssetTypeEnum("COMMON_FILE");

            /// <summary>
            /// Enum HUMAN_MODEL_2D for value: HUMAN_MODEL_2D
            /// </summary>
            public static readonly AssetTypeEnum HUMAN_MODEL_2D = new AssetTypeEnum("HUMAN_MODEL_2D");

            /// <summary>
            /// Enum BUSINESS_CARD_TEMPLET for value: BUSINESS_CARD_TEMPLET
            /// </summary>
            public static readonly AssetTypeEnum BUSINESS_CARD_TEMPLET = new AssetTypeEnum("BUSINESS_CARD_TEMPLET");

            /// <summary>
            /// Enum MUSIC for value: MUSIC
            /// </summary>
            public static readonly AssetTypeEnum MUSIC = new AssetTypeEnum("MUSIC");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly AssetTypeEnum AUDIO = new AssetTypeEnum("AUDIO");

            private static readonly Dictionary<string, AssetTypeEnum> StaticFields =
            new Dictionary<string, AssetTypeEnum>()
            {
                { "HUMAN_MODEL", HUMAN_MODEL },
                { "VOICE_MODEL", VOICE_MODEL },
                { "SCENE", SCENE },
                { "ANIMATION", ANIMATION },
                { "VIDEO", VIDEO },
                { "IMAGE", IMAGE },
                { "PPT", PPT },
                { "MATERIAL", MATERIAL },
                { "NORMAL_MODEL", NORMAL_MODEL },
                { "COMMON_FILE", COMMON_FILE },
                { "HUMAN_MODEL_2D", HUMAN_MODEL_2D },
                { "BUSINESS_CARD_TEMPLET", BUSINESS_CARD_TEMPLET },
                { "MUSIC", MUSIC },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public AssetTypeEnum()
            {

            }

            public AssetTypeEnum(string value)
            {
                _value = value;
            }

            public static AssetTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssetTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetTypeEnum a, AssetTypeEnum b)
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

            public static bool operator !=(AssetTypeEnum a, AssetTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资产状态。 * CREATING：资产创建中，主文件尚未上传 * FAILED：主文件上传失败 * UNACTIVED：主文件上传成功，资产未激活，资产不可用于其他业务（用户可更新状态） * ACTIVED：主文件上传成功，资产激活，资产可用于其他业务（用户可更新状态） * DELETING：资产删除中，资产不可用，资产可恢复 * DELETED：资产文件已删除，资产不可用，资产不可恢复 * BLOCK: 资产被冻结，资产不可用，不可查看文件。 * WAITING_DELETE：资产将被下线
        /// </summary>
        /// <value>资产状态。 * CREATING：资产创建中，主文件尚未上传 * FAILED：主文件上传失败 * UNACTIVED：主文件上传成功，资产未激活，资产不可用于其他业务（用户可更新状态） * ACTIVED：主文件上传成功，资产激活，资产可用于其他业务（用户可更新状态） * DELETING：资产删除中，资产不可用，资产可恢复 * DELETED：资产文件已删除，资产不可用，资产不可恢复 * BLOCK: 资产被冻结，资产不可用，不可查看文件。 * WAITING_DELETE：资产将被下线</value>
        [JsonConverter(typeof(EnumClassConverter<AssetStateEnum>))]
        public class AssetStateEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly AssetStateEnum CREATING = new AssetStateEnum("CREATING");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly AssetStateEnum FAILED = new AssetStateEnum("FAILED");

            /// <summary>
            /// Enum UNACTIVED for value: UNACTIVED
            /// </summary>
            public static readonly AssetStateEnum UNACTIVED = new AssetStateEnum("UNACTIVED");

            /// <summary>
            /// Enum ACTIVED for value: ACTIVED
            /// </summary>
            public static readonly AssetStateEnum ACTIVED = new AssetStateEnum("ACTIVED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly AssetStateEnum DELETING = new AssetStateEnum("DELETING");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly AssetStateEnum DELETED = new AssetStateEnum("DELETED");

            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            public static readonly AssetStateEnum BLOCK = new AssetStateEnum("BLOCK");

            /// <summary>
            /// Enum WAITING_DELETE for value: WAITING_DELETE
            /// </summary>
            public static readonly AssetStateEnum WAITING_DELETE = new AssetStateEnum("WAITING_DELETE");

            private static readonly Dictionary<string, AssetStateEnum> StaticFields =
            new Dictionary<string, AssetStateEnum>()
            {
                { "CREATING", CREATING },
                { "FAILED", FAILED },
                { "UNACTIVED", UNACTIVED },
                { "ACTIVED", ACTIVED },
                { "DELETING", DELETING },
                { "DELETED", DELETED },
                { "BLOCK", BLOCK },
                { "WAITING_DELETE", WAITING_DELETE },
            };

            private string _value;

            public AssetStateEnum()
            {

            }

            public AssetStateEnum(string value)
            {
                _value = value;
            }

            public static AssetStateEnum FromValue(string value)
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

                if (this.Equals(obj as AssetStateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetStateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetStateEnum a, AssetStateEnum b)
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

            public static bool operator !=(AssetStateEnum a, AssetStateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 失败原因。 * AUTOMATIC_REVIEW_REJECT：自动审核失败 * MANUAL_REVIEW_REJECT：人工审核失败
        /// </summary>
        /// <value>失败原因。 * AUTOMATIC_REVIEW_REJECT：自动审核失败 * MANUAL_REVIEW_REJECT：人工审核失败</value>
        [JsonConverter(typeof(EnumClassConverter<FailTypeEnum>))]
        public class FailTypeEnum
        {
            /// <summary>
            /// Enum AUTOMATIC_REVIEW_REJECT for value: AUTOMATIC_REVIEW_REJECT
            /// </summary>
            public static readonly FailTypeEnum AUTOMATIC_REVIEW_REJECT = new FailTypeEnum("AUTOMATIC_REVIEW_REJECT");

            /// <summary>
            /// Enum MANUAL_REVIEW_REJECT for value: MANUAL_REVIEW_REJECT
            /// </summary>
            public static readonly FailTypeEnum MANUAL_REVIEW_REJECT = new FailTypeEnum("MANUAL_REVIEW_REJECT");

            private static readonly Dictionary<string, FailTypeEnum> StaticFields =
            new Dictionary<string, FailTypeEnum>()
            {
                { "AUTOMATIC_REVIEW_REJECT", AUTOMATIC_REVIEW_REJECT },
                { "MANUAL_REVIEW_REJECT", MANUAL_REVIEW_REJECT },
            };

            private string _value;

            public FailTypeEnum()
            {

            }

            public FailTypeEnum(string value)
            {
                _value = value;
            }

            public static FailTypeEnum FromValue(string value)
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

                if (this.Equals(obj as FailTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FailTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FailTypeEnum a, FailTypeEnum b)
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

            public static bool operator !=(FailTypeEnum a, FailTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 租户id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// ai标识ID。
        /// </summary>
        [JsonProperty("produce_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProduceId { get; set; }

        /// <summary>
        /// 资产名称。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 资产描述。
        /// </summary>
        [JsonProperty("asset_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetDescription { get; set; }

        /// <summary>
        /// 第三方用户ID。 &gt; * 即创建资产是通过X-App-UserId头域传入的值。
        /// </summary>
        [JsonProperty("app_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUserId { get; set; }

        /// <summary>
        /// 资产创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 资产更新时间。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 资产类型。  公共资产类型： * VOICE_MODEL：音色模型 * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产类型： * HUMAN_MODEL_2D：分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// 资产状态。 * CREATING：资产创建中，主文件尚未上传 * FAILED：主文件上传失败 * UNACTIVED：主文件上传成功，资产未激活，资产不可用于其他业务（用户可更新状态） * ACTIVED：主文件上传成功，资产激活，资产可用于其他业务（用户可更新状态） * DELETING：资产删除中，资产不可用，资产可恢复 * DELETED：资产文件已删除，资产不可用，资产不可恢复 * BLOCK: 资产被冻结，资产不可用，不可查看文件。 * WAITING_DELETE：资产将被下线
        /// </summary>
        [JsonProperty("asset_state", NullValueHandling = NullValueHandling.Ignore)]
        public AssetStateEnum AssetState { get; set; }
        /// <summary>
        /// 失败原因。 * AUTOMATIC_REVIEW_REJECT：自动审核失败 * MANUAL_REVIEW_REJECT：人工审核失败
        /// </summary>
        [JsonProperty("fail_type", NullValueHandling = NullValueHandling.Ignore)]
        public FailTypeEnum FailType { get; set; }
        /// <summary>
        /// 冻结原因编号。
        /// </summary>
        [JsonProperty("block_reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string BlockReasonCode { get; set; }

        /// <summary>
        /// 冻结/解冻/失败 原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 标签列表。 &gt; 分身形象系统资产的tag定义如下： &gt; - 行业：NEWS,BUSINESS,E-COMMERCE,MARKETING,KNOWLEDGE,EDUCATION,SPORTS &gt; - 性别：MALE,FEMALE &gt; - 姿势：FULL-BODY,HALF-BODY,STANDING,SITTING,WALKING &gt; - 区域：ASIAN,WESTERN,MIDDLE-EASTERNER,AFRICAN,LATINO
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("asset_extra_meta", NullValueHandling = NullValueHandling.Ignore)]
        public AssetExtraMeta AssetExtraMeta { get; set; }

        /// <summary>
        /// 设置系统属性。
        /// </summary>
        [JsonProperty("system_properties", NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemProperty> SystemProperties { get; set; }

        /// <summary>
        /// 资产下的文件。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssetFileInfo> Files { get; set; }

        /// <summary>
        /// 展示顺序
        /// </summary>
        [JsonProperty("asset_order", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetOrder { get; set; }

        /// <summary>
        /// 支持的业务类型。： * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互
        /// </summary>
        [JsonProperty("supported_service", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportedServiceEnum> SupportedService { get; set; }

        /// <summary>
        /// 资产自动处理任务。
        /// </summary>
        [JsonProperty("auto_operation_config", NullValueHandling = NullValueHandling.Ignore)]
        public List<AutoOperationConfig> AutoOperationConfig { get; set; }

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
            sb.Append("class ShowAssetResponse {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  produceId: ").Append(ProduceId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetDescription: ").Append(AssetDescription).Append("\n");
            sb.Append("  appUserId: ").Append(AppUserId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  assetState: ").Append(AssetState).Append("\n");
            sb.Append("  failType: ").Append(FailType).Append("\n");
            sb.Append("  blockReasonCode: ").Append(BlockReasonCode).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  assetExtraMeta: ").Append(AssetExtraMeta).Append("\n");
            sb.Append("  systemProperties: ").Append(SystemProperties).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("  assetOrder: ").Append(AssetOrder).Append("\n");
            sb.Append("  supportedService: ").Append(SupportedService).Append("\n");
            sb.Append("  autoOperationConfig: ").Append(AutoOperationConfig).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAssetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAssetResponse input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.ProduceId != input.ProduceId || (this.ProduceId != null && !this.ProduceId.Equals(input.ProduceId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetDescription != input.AssetDescription || (this.AssetDescription != null && !this.AssetDescription.Equals(input.AssetDescription))) return false;
            if (this.AppUserId != input.AppUserId || (this.AppUserId != null && !this.AppUserId.Equals(input.AppUserId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.AssetType != input.AssetType) return false;
            if (this.AssetState != input.AssetState) return false;
            if (this.FailType != input.FailType) return false;
            if (this.BlockReasonCode != input.BlockReasonCode || (this.BlockReasonCode != null && !this.BlockReasonCode.Equals(input.BlockReasonCode))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.AssetExtraMeta != input.AssetExtraMeta || (this.AssetExtraMeta != null && !this.AssetExtraMeta.Equals(input.AssetExtraMeta))) return false;
            if (this.SystemProperties != input.SystemProperties || (this.SystemProperties != null && input.SystemProperties != null && !this.SystemProperties.SequenceEqual(input.SystemProperties))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;
            if (this.AssetOrder != input.AssetOrder || (this.AssetOrder != null && !this.AssetOrder.Equals(input.AssetOrder))) return false;
            if (this.SupportedService != input.SupportedService || (this.SupportedService != null && input.SupportedService != null && !this.SupportedService.SequenceEqual(input.SupportedService))) return false;
            if (this.AutoOperationConfig != input.AutoOperationConfig || (this.AutoOperationConfig != null && input.AutoOperationConfig != null && !this.AutoOperationConfig.SequenceEqual(input.AutoOperationConfig))) return false;
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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.ProduceId != null) hashCode = hashCode * 59 + this.ProduceId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                if (this.AssetDescription != null) hashCode = hashCode * 59 + this.AssetDescription.GetHashCode();
                if (this.AppUserId != null) hashCode = hashCode * 59 + this.AppUserId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                hashCode = hashCode * 59 + this.AssetState.GetHashCode();
                hashCode = hashCode * 59 + this.FailType.GetHashCode();
                if (this.BlockReasonCode != null) hashCode = hashCode * 59 + this.BlockReasonCode.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AssetExtraMeta != null) hashCode = hashCode * 59 + this.AssetExtraMeta.GetHashCode();
                if (this.SystemProperties != null) hashCode = hashCode * 59 + this.SystemProperties.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.AssetOrder != null) hashCode = hashCode * 59 + this.AssetOrder.GetHashCode();
                if (this.SupportedService != null) hashCode = hashCode * 59 + this.SupportedService.GetHashCode();
                if (this.AutoOperationConfig != null) hashCode = hashCode * 59 + this.AutoOperationConfig.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
