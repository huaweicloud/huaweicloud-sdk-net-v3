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
    public class DigitalAssetSummary 
    {
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
        /// 资产类型。 公共资产类型： * VOICE_MODEL：音色模型（仅系统管理员可上传，普通租户仅可查询） * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产： * HUMAN_MODEL_2D: 分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板
        /// </summary>
        /// <value>资产类型。 公共资产类型： * VOICE_MODEL：音色模型（仅系统管理员可上传，普通租户仅可查询） * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产： * HUMAN_MODEL_2D: 分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板</value>
        [JsonConverter(typeof(EnumClassConverter<AssetTypeEnum>))]
        public class AssetTypeEnum
        {
            /// <summary>
            /// Enum HUMAN_MODEL for value: HUMAN_MODEL
            /// </summary>
            public static readonly AssetTypeEnum HUMAN_MODEL = new AssetTypeEnum("HUMAN_MODEL");

            /// <summary>
            /// Enum MODEL for value: MODEL
            /// </summary>
            public static readonly AssetTypeEnum MODEL = new AssetTypeEnum("MODEL");

            /// <summary>
            /// Enum ANIMATION for value: ANIMATION
            /// </summary>
            public static readonly AssetTypeEnum ANIMATION = new AssetTypeEnum("ANIMATION");

            /// <summary>
            /// Enum SCENE for value: SCENE
            /// </summary>
            public static readonly AssetTypeEnum SCENE = new AssetTypeEnum("SCENE");

            /// <summary>
            /// Enum PPT for value: PPT
            /// </summary>
            public static readonly AssetTypeEnum PPT = new AssetTypeEnum("PPT");

            /// <summary>
            /// Enum VIDEO for value: VIDEO
            /// </summary>
            public static readonly AssetTypeEnum VIDEO = new AssetTypeEnum("VIDEO");

            /// <summary>
            /// Enum IMAGE for value: IMAGE
            /// </summary>
            public static readonly AssetTypeEnum IMAGE = new AssetTypeEnum("IMAGE");

            /// <summary>
            /// Enum MATERIAL for value: MATERIAL
            /// </summary>
            public static readonly AssetTypeEnum MATERIAL = new AssetTypeEnum("MATERIAL");

            /// <summary>
            /// Enum VOICE_MODEL for value: VOICE_MODEL
            /// </summary>
            public static readonly AssetTypeEnum VOICE_MODEL = new AssetTypeEnum("VOICE_MODEL");

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
                { "MODEL", MODEL },
                { "ANIMATION", ANIMATION },
                { "SCENE", SCENE },
                { "PPT", PPT },
                { "VIDEO", VIDEO },
                { "IMAGE", IMAGE },
                { "MATERIAL", MATERIAL },
                { "VOICE_MODEL", VOICE_MODEL },
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
        /// 资产ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产名称。
        /// </summary>
        [JsonProperty("asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetName { get; set; }

        /// <summary>
        /// 资产状态。 * CREATING：资产创建中，主文件尚未上传 * FAILED：主文件上传失败 * UNACTIVED：主文件上传成功，资产未激活，资产不可用于其他业务（用户可更新状态） * ACTIVED：主文件上传成功，资产激活，资产可用于其他业务（用户可更新状态） * DELETING：资产删除中，资产不可用，资产可恢复 * DELETED：资产文件已删除，资产不可用，资产不可恢复 * BLOCK: 资产被冻结，资产不可用，不可查看文件。 * WAITING_DELETE：资产将被下线
        /// </summary>
        [JsonProperty("asset_state", NullValueHandling = NullValueHandling.Ignore)]
        public AssetStateEnum AssetState { get; set; }
        /// <summary>
        /// 资产类型。 公共资产类型： * VOICE_MODEL：音色模型（仅系统管理员可上传，普通租户仅可查询） * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MUSIC: 音乐 * AUDIO: 音频 * COMMON_FILE：通用文件  分身数字人资产： * HUMAN_MODEL_2D: 分身数字人模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板
        /// </summary>
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssetTypeEnum AssetType { get; set; }
        /// <summary>
        /// 封面图片路径。
        /// </summary>
        [JsonProperty("cover_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 缩略图路径。
        /// </summary>
        [JsonProperty("thumbnail_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DigitalAssetSummary {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  assetName: ").Append(AssetName).Append("\n");
            sb.Append("  assetState: ").Append(AssetState).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  coverUrl: ").Append(CoverUrl).Append("\n");
            sb.Append("  thumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DigitalAssetSummary);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DigitalAssetSummary input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.AssetName != input.AssetName || (this.AssetName != null && !this.AssetName.Equals(input.AssetName))) return false;
            if (this.AssetState != input.AssetState) return false;
            if (this.AssetType != input.AssetType) return false;
            if (this.CoverUrl != input.CoverUrl || (this.CoverUrl != null && !this.CoverUrl.Equals(input.CoverUrl))) return false;
            if (this.ThumbnailUrl != input.ThumbnailUrl || (this.ThumbnailUrl != null && !this.ThumbnailUrl.Equals(input.ThumbnailUrl))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.AssetName != null) hashCode = hashCode * 59 + this.AssetName.GetHashCode();
                hashCode = hashCode * 59 + this.AssetState.GetHashCode();
                hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.CoverUrl != null) hashCode = hashCode * 59 + this.CoverUrl.GetHashCode();
                if (this.ThumbnailUrl != null) hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
