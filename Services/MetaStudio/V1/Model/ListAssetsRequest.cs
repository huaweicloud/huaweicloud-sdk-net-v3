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
    /// Request Object
    /// </summary>
    public class ListAssetsRequest 
    {
        /// <summary>
        /// 标签查询组合方式 INTERSECTION：交集 UNION_SET：并集
        /// </summary>
        /// <value>标签查询组合方式 INTERSECTION：交集 UNION_SET：并集</value>
        [JsonConverter(typeof(EnumClassConverter<TagCombinationTypeEnum>))]
        public class TagCombinationTypeEnum
        {
            /// <summary>
            /// Enum INTERSECTION for value: INTERSECTION
            /// </summary>
            public static readonly TagCombinationTypeEnum INTERSECTION = new TagCombinationTypeEnum("INTERSECTION");

            /// <summary>
            /// Enum UNION_SET for value: UNION_SET
            /// </summary>
            public static readonly TagCombinationTypeEnum UNION_SET = new TagCombinationTypeEnum("UNION_SET");

            private static readonly Dictionary<string, TagCombinationTypeEnum> StaticFields =
            new Dictionary<string, TagCombinationTypeEnum>()
            {
                { "INTERSECTION", INTERSECTION },
                { "UNION_SET", UNION_SET },
            };

            private string _value;

            public TagCombinationTypeEnum()
            {

            }

            public TagCombinationTypeEnum(string value)
            {
                _value = value;
            }

            public static TagCombinationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as TagCombinationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TagCombinationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TagCombinationTypeEnum a, TagCombinationTypeEnum b)
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

            public static bool operator !=(TagCombinationTypeEnum a, TagCombinationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资产来源。 * SYSTEM：系统资产 * CUSTOMIZATION：租户资产 * ALL：所有资产  默认查询租户资产。
        /// </summary>
        /// <value>资产来源。 * SYSTEM：系统资产 * CUSTOMIZATION：租户资产 * ALL：所有资产  默认查询租户资产。</value>
        [JsonConverter(typeof(EnumClassConverter<AssetSourceEnum>))]
        public class AssetSourceEnum
        {
            /// <summary>
            /// Enum SYSTEM for value: SYSTEM
            /// </summary>
            public static readonly AssetSourceEnum SYSTEM = new AssetSourceEnum("SYSTEM");

            /// <summary>
            /// Enum CUSTOMIZATION for value: CUSTOMIZATION
            /// </summary>
            public static readonly AssetSourceEnum CUSTOMIZATION = new AssetSourceEnum("CUSTOMIZATION");

            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly AssetSourceEnum ALL = new AssetSourceEnum("ALL");

            private static readonly Dictionary<string, AssetSourceEnum> StaticFields =
            new Dictionary<string, AssetSourceEnum>()
            {
                { "SYSTEM", SYSTEM },
                { "CUSTOMIZATION", CUSTOMIZATION },
                { "ALL", ALL },
            };

            private string _value;

            public AssetSourceEnum()
            {

            }

            public AssetSourceEnum(string value)
            {
                _value = value;
            }

            public static AssetSourceEnum FromValue(string value)
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

                if (this.Equals(obj as AssetSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssetSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssetSourceEnum a, AssetSourceEnum b)
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

            public static bool operator !=(AssetSourceEnum a, AssetSourceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 角色。 SHARER：共享方，SHAREE：被共享方
        /// </summary>
        /// <value>角色。 SHARER：共享方，SHAREE：被共享方</value>
        [JsonConverter(typeof(EnumClassConverter<RoleEnum>))]
        public class RoleEnum
        {
            /// <summary>
            /// Enum SHARER for value: SHARER
            /// </summary>
            public static readonly RoleEnum SHARER = new RoleEnum("SHARER");

            /// <summary>
            /// Enum SHAREE for value: SHAREE
            /// </summary>
            public static readonly RoleEnum SHAREE = new RoleEnum("SHAREE");

            private static readonly Dictionary<string, RoleEnum> StaticFields =
            new Dictionary<string, RoleEnum>()
            {
                { "SHARER", SHARER },
                { "SHAREE", SHAREE },
            };

            private string _value;

            public RoleEnum()
            {

            }

            public RoleEnum(string value)
            {
                _value = value;
            }

            public static RoleEnum FromValue(string value)
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

                if (this.Equals(obj as RoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RoleEnum a, RoleEnum b)
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

            public static bool operator !=(RoleEnum a, RoleEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 资产支持的业务类型。默认查询所有资产。 * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互
        /// </summary>
        /// <value>资产支持的业务类型。默认查询所有资产。 * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互</value>
        [JsonConverter(typeof(EnumClassConverter<SupportedServiceEnum>))]
        public class SupportedServiceEnum
        {
            /// <summary>
            /// Enum VIDEO_2D for value: VIDEO_2D
            /// </summary>
            public static readonly SupportedServiceEnum VIDEO_2D = new SupportedServiceEnum("VIDEO_2D");

            /// <summary>
            /// Enum LIVE_2D for value: LIVE_2D
            /// </summary>
            public static readonly SupportedServiceEnum LIVE_2D = new SupportedServiceEnum("LIVE_2D");

            /// <summary>
            /// Enum CHAT_2D for value: CHAT_2D
            /// </summary>
            public static readonly SupportedServiceEnum CHAT_2D = new SupportedServiceEnum("CHAT_2D");

            private static readonly Dictionary<string, SupportedServiceEnum> StaticFields =
            new Dictionary<string, SupportedServiceEnum>()
            {
                { "VIDEO_2D", VIDEO_2D },
                { "LIVE_2D", LIVE_2D },
                { "CHAT_2D", CHAT_2D },
            };

            private string _value;

            public SupportedServiceEnum()
            {

            }

            public SupportedServiceEnum(string value)
            {
                _value = value;
            }

            public static SupportedServiceEnum FromValue(string value)
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

                if (this.Equals(obj as SupportedServiceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SupportedServiceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SupportedServiceEnum a, SupportedServiceEnum b)
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

            public static bool operator !=(SupportedServiceEnum a, SupportedServiceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。  格式为(YYYYMMDD&#39;T&#39;HHMMSS&#39;Z&#39;)。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 按名称模糊查询。
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 按标签模糊查询。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 标签查询组合方式 INTERSECTION：交集 UNION_SET：并集
        /// </summary>
        [SDKProperty("tag_combination_type", IsQuery = true)]
        [JsonProperty("tag_combination_type", NullValueHandling = NullValueHandling.Ignore)]
        public TagCombinationTypeEnum TagCombinationType { get; set; }
        /// <summary>
        /// 起始时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间。格式遵循：RFC 3339 如\&quot;2021-01-10T10:43:17Z\&quot;。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 资产类型。多个类型使用英文逗号分隔。 * VOICE_MODEL：音色模型（仅系统管理员可上传） * VIDEO：视频文件 * IMAGE：图片文件 * PPT：幻灯片文件 * MATERIAL：风格化素材 * HUMAN_MODEL_2D: 2D数字人网络模型 * BUSINESS_CARD_TEMPLET: 数字人名片模板 * MUSIC: 音乐 * AUDIO: 音频
        /// </summary>
        [SDKProperty("asset_type", IsQuery = true)]
        [JsonProperty("asset_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetType { get; set; }

        /// <summary>
        /// 排序字段，支持的排序方式有： - 按创建时间排序：create_time - 按更新时间排序：update_time - 按资产排序：asset_order
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 排序方式。 * asc：升序 * desc：降序  默认asc升序。
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 资产来源。 * SYSTEM：系统资产 * CUSTOMIZATION：租户资产 * ALL：所有资产  默认查询租户资产。
        /// </summary>
        [SDKProperty("asset_source", IsQuery = true)]
        [JsonProperty("asset_source", NullValueHandling = NullValueHandling.Ignore)]
        public AssetSourceEnum AssetSource { get; set; }
        /// <summary>
        /// 资产状态。多个资产状态使用英文逗号分隔。 * CREATING：资产创建中，主文件尚未上传 * FAILED：主文件上传失败 * UNACTIVED：主文件上传成功，资产未激活，资产不可用于其他业务（用户可更新状态） * ACTIVED：主文件上传成功，资产激活，资产可用于其他业务（用户可更新状态） * DELETING：资产删除中，资产不可用，资产可恢复 * DELETED：资产文件已删除，资产不可用，资产不可恢复 * BLOCK：资产被冻结，资产不可用，不可查看文件。 * WAITING_DELETE：资产将被下线 默认查询所有状态的资产。
        /// </summary>
        [SDKProperty("asset_state", IsQuery = true)]
        [JsonProperty("asset_state", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetState { get; set; }

        /// <summary>
        /// 基于风格化ID查询关联资产。 * system_male_001：男性风格01 * system_female_001：女性风格01 * system_male_002：男性风格02  * system_female_002：女性风格02
        /// </summary>
        [SDKProperty("style_id", IsQuery = true)]
        [JsonProperty("style_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StyleId { get; set; }

        /// <summary>
        /// 使用精确查询的字段
        /// </summary>
        [SDKProperty("accurate_query_field", IsQuery = true)]
        [JsonProperty("accurate_query_field", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccurateQueryField { get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [SDKProperty("asset_id", IsQuery = true)]
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AssetId { get; set; }

        /// <summary>
        /// 性别。多选使用英文逗号分隔。
        /// </summary>
        [SDKProperty("sex", IsQuery = true)]
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public string Sex { get; set; }

        /// <summary>
        /// 语言。多选使用英文逗号分隔。
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 系统属性。  key和value间用\&quot;:\&quot;分隔，多个key之间用\&quot;,\&quot;分隔。  如system_property&#x3D;BACKGROUND_IMG:Yes,RENDER_ENGINE:MetaEngine。  不同Key对应Value取值如下：  公共资产属性： * BACKGROUND_IMG：视频制作的2D背景图片，可取值Yes * CREATED_BY_PLATFORM：是否平台生成，可取值Yes  分身数字人资产属性： * MATERIAL_IMG：素材图片，用作前景。可取值Yes * MATERIAL_VIDEO：素材视频，用作前景。可取值Yes  数字人资产属性： * BACKGROUND_SCENE：视频制作的2D背景场景，可取值Horizontal（横屏）或者Vertical（竖屏）
        /// </summary>
        [SDKProperty("system_property", IsQuery = true)]
        [JsonProperty("system_property", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemProperty { get; set; }

        /// <summary>
        /// 动作是否可编辑。仅在分身数字人模型查询时有效。
        /// </summary>
        [SDKProperty("action_editable", IsQuery = true)]
        [JsonProperty("action_editable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEditable { get; set; }

        /// <summary>
        /// 分身数字人是否带原子动作库。 &gt; * 带原子动作库的分身数字人可做动作编排。
        /// </summary>
        [SDKProperty("is_with_action_library", IsQuery = true)]
        [JsonProperty("is_with_action_library", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsWithActionLibrary { get; set; }

        /// <summary>
        /// 分身数字人是否支持走动。仅在分身数字人模型查询时有效。
        /// </summary>
        [SDKProperty("is_movable", IsQuery = true)]
        [JsonProperty("is_movable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMovable { get; set; }

        /// <summary>
        /// 取值：HUAWEI_METASTUDIO、MOBVOI。 HUAWEI_METASTUDIO：MetaStudio自研音色 MOBVOI：出门问问音色
        /// </summary>
        [SDKProperty("voice_provider", IsQuery = true)]
        [JsonProperty("voice_provider", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceProvider { get; set; }

        /// <summary>
        /// 角色。 SHARER：共享方，SHAREE：被共享方
        /// </summary>
        [SDKProperty("role", IsQuery = true)]
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// 音色是否支持实时合成。仅在音色查询时有效。 &gt; * 支持实时合成的音色，可以用于直播和智能交互场景。否则只能用于视频制作。
        /// </summary>
        [SDKProperty("is_realtime_voice", IsQuery = true)]
        [JsonProperty("is_realtime_voice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRealtimeVoice { get; set; }

        /// <summary>
        /// 模型版本
        /// </summary>
        [SDKProperty("human_model_2d_version", IsQuery = true)]
        [JsonProperty("human_model_2d_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HumanModel2dVersion { get; set; }

        /// <summary>
        /// 资产已执行的任务名称
        /// </summary>
        [SDKProperty("include_device_name", IsQuery = true)]
        [JsonProperty("include_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeDeviceName { get; set; }

        /// <summary>
        /// 资产已执行的任务名称
        /// </summary>
        [SDKProperty("exclude_device_name", IsQuery = true)]
        [JsonProperty("exclude_device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeDeviceName { get; set; }

        /// <summary>
        /// 资产支持的业务类型。默认查询所有资产。 * VIDEO_2D：分身数字人视频制作 * LIVE_2D：分身数字人直播 * CHAT_2D：分身数字人智能交互
        /// </summary>
        [SDKProperty("supported_service", IsQuery = true)]
        [JsonProperty("supported_service", NullValueHandling = NullValueHandling.Ignore)]
        public SupportedServiceEnum SupportedService { get; set; }
        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("app_user_id", IsQuery = true)]
        [JsonProperty("app_user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppUserId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAssetsRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  tagCombinationType: ").Append(TagCombinationType).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  assetType: ").Append(AssetType).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  assetSource: ").Append(AssetSource).Append("\n");
            sb.Append("  assetState: ").Append(AssetState).Append("\n");
            sb.Append("  styleId: ").Append(StyleId).Append("\n");
            sb.Append("  accurateQueryField: ").Append(AccurateQueryField).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  systemProperty: ").Append(SystemProperty).Append("\n");
            sb.Append("  actionEditable: ").Append(ActionEditable).Append("\n");
            sb.Append("  isWithActionLibrary: ").Append(IsWithActionLibrary).Append("\n");
            sb.Append("  isMovable: ").Append(IsMovable).Append("\n");
            sb.Append("  voiceProvider: ").Append(VoiceProvider).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  isRealtimeVoice: ").Append(IsRealtimeVoice).Append("\n");
            sb.Append("  humanModel2dVersion: ").Append(HumanModel2dVersion).Append("\n");
            sb.Append("  includeDeviceName: ").Append(IncludeDeviceName).Append("\n");
            sb.Append("  excludeDeviceName: ").Append(ExcludeDeviceName).Append("\n");
            sb.Append("  supportedService: ").Append(SupportedService).Append("\n");
            sb.Append("  appUserId: ").Append(AppUserId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAssetsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAssetsRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.TagCombinationType != input.TagCombinationType) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.AssetType != input.AssetType || (this.AssetType != null && !this.AssetType.Equals(input.AssetType))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && !this.SortDir.Equals(input.SortDir))) return false;
            if (this.AssetSource != input.AssetSource) return false;
            if (this.AssetState != input.AssetState || (this.AssetState != null && !this.AssetState.Equals(input.AssetState))) return false;
            if (this.StyleId != input.StyleId || (this.StyleId != null && !this.StyleId.Equals(input.StyleId))) return false;
            if (this.AccurateQueryField != input.AccurateQueryField || (this.AccurateQueryField != null && input.AccurateQueryField != null && !this.AccurateQueryField.SequenceEqual(input.AccurateQueryField))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && input.AssetId != null && !this.AssetId.SequenceEqual(input.AssetId))) return false;
            if (this.Sex != input.Sex || (this.Sex != null && !this.Sex.Equals(input.Sex))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.SystemProperty != input.SystemProperty || (this.SystemProperty != null && !this.SystemProperty.Equals(input.SystemProperty))) return false;
            if (this.ActionEditable != input.ActionEditable || (this.ActionEditable != null && !this.ActionEditable.Equals(input.ActionEditable))) return false;
            if (this.IsWithActionLibrary != input.IsWithActionLibrary || (this.IsWithActionLibrary != null && !this.IsWithActionLibrary.Equals(input.IsWithActionLibrary))) return false;
            if (this.IsMovable != input.IsMovable || (this.IsMovable != null && !this.IsMovable.Equals(input.IsMovable))) return false;
            if (this.VoiceProvider != input.VoiceProvider || (this.VoiceProvider != null && !this.VoiceProvider.Equals(input.VoiceProvider))) return false;
            if (this.Role != input.Role) return false;
            if (this.IsRealtimeVoice != input.IsRealtimeVoice || (this.IsRealtimeVoice != null && !this.IsRealtimeVoice.Equals(input.IsRealtimeVoice))) return false;
            if (this.HumanModel2dVersion != input.HumanModel2dVersion || (this.HumanModel2dVersion != null && !this.HumanModel2dVersion.Equals(input.HumanModel2dVersion))) return false;
            if (this.IncludeDeviceName != input.IncludeDeviceName || (this.IncludeDeviceName != null && !this.IncludeDeviceName.Equals(input.IncludeDeviceName))) return false;
            if (this.ExcludeDeviceName != input.ExcludeDeviceName || (this.ExcludeDeviceName != null && !this.ExcludeDeviceName.Equals(input.ExcludeDeviceName))) return false;
            if (this.SupportedService != input.SupportedService) return false;
            if (this.AppUserId != input.AppUserId || (this.AppUserId != null && !this.AppUserId.Equals(input.AppUserId))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                hashCode = hashCode * 59 + this.TagCombinationType.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.AssetType != null) hashCode = hashCode * 59 + this.AssetType.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.SortDir != null) hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                hashCode = hashCode * 59 + this.AssetSource.GetHashCode();
                if (this.AssetState != null) hashCode = hashCode * 59 + this.AssetState.GetHashCode();
                if (this.StyleId != null) hashCode = hashCode * 59 + this.StyleId.GetHashCode();
                if (this.AccurateQueryField != null) hashCode = hashCode * 59 + this.AccurateQueryField.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.Sex != null) hashCode = hashCode * 59 + this.Sex.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SystemProperty != null) hashCode = hashCode * 59 + this.SystemProperty.GetHashCode();
                if (this.ActionEditable != null) hashCode = hashCode * 59 + this.ActionEditable.GetHashCode();
                if (this.IsWithActionLibrary != null) hashCode = hashCode * 59 + this.IsWithActionLibrary.GetHashCode();
                if (this.IsMovable != null) hashCode = hashCode * 59 + this.IsMovable.GetHashCode();
                if (this.VoiceProvider != null) hashCode = hashCode * 59 + this.VoiceProvider.GetHashCode();
                hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.IsRealtimeVoice != null) hashCode = hashCode * 59 + this.IsRealtimeVoice.GetHashCode();
                if (this.HumanModel2dVersion != null) hashCode = hashCode * 59 + this.HumanModel2dVersion.GetHashCode();
                if (this.IncludeDeviceName != null) hashCode = hashCode * 59 + this.IncludeDeviceName.GetHashCode();
                if (this.ExcludeDeviceName != null) hashCode = hashCode * 59 + this.ExcludeDeviceName.GetHashCode();
                hashCode = hashCode * 59 + this.SupportedService.GetHashCode();
                if (this.AppUserId != null) hashCode = hashCode * 59 + this.AppUserId.GetHashCode();
                return hashCode;
            }
        }
    }
}
