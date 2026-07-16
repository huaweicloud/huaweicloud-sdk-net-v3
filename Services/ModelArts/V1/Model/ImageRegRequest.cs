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
    /// 
    /// </summary>
    public class ImageRegRequest 
    {
        /// <summary>
        /// **参数解释**：该镜像所支持处理器架构类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - X86_64：x86处理器架构。 - AARCH64：ARM体系架构。  **默认取值**：X86_64。
        /// </summary>
        /// <value>**参数解释**：该镜像所支持处理器架构类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - X86_64：x86处理器架构。 - AARCH64：ARM体系架构。  **默认取值**：X86_64。</value>
        [JsonConverter(typeof(EnumClassConverter<ArchEnum>))]
        public class ArchEnum
        {
            /// <summary>
            /// Enum AARCH64 for value: AARCH64
            /// </summary>
            public static readonly ArchEnum AARCH64 = new ArchEnum("AARCH64");

            /// <summary>
            /// Enum X86_64 for value: X86_64
            /// </summary>
            public static readonly ArchEnum X86_64 = new ArchEnum("X86_64");

            private static readonly Dictionary<string, ArchEnum> StaticFields =
            new Dictionary<string, ArchEnum>()
            {
                { "AARCH64", AARCH64 },
                { "X86_64", X86_64 },
            };

            private string _value;

            public ArchEnum()
            {

            }

            public ArchEnum(string value)
            {
                _value = value;
            }

            public static ArchEnum FromValue(string value)
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

                if (this.Equals(obj as ArchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ArchEnum a, ArchEnum b)
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

            public static bool operator !=(ArchEnum a, ArchEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：指定镜像来源，可选项。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - CUSTOMIZE: 用户自定义构建镜像。 - IMAGE_SAVE：Notebook实例保存镜像。  **默认取值**：CUSTOMIZE。
        /// </summary>
        /// <value>**参数解释**：指定镜像来源，可选项。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - CUSTOMIZE: 用户自定义构建镜像。 - IMAGE_SAVE：Notebook实例保存镜像。  **默认取值**：CUSTOMIZE。</value>
        [JsonConverter(typeof(EnumClassConverter<OriginEnum>))]
        public class OriginEnum
        {
            /// <summary>
            /// Enum CUSTOMIZE for value: CUSTOMIZE
            /// </summary>
            public static readonly OriginEnum CUSTOMIZE = new OriginEnum("CUSTOMIZE");

            /// <summary>
            /// Enum IMAGE_SAVE for value: IMAGE_SAVE
            /// </summary>
            public static readonly OriginEnum IMAGE_SAVE = new OriginEnum("IMAGE_SAVE");

            private static readonly Dictionary<string, OriginEnum> StaticFields =
            new Dictionary<string, OriginEnum>()
            {
                { "CUSTOMIZE", CUSTOMIZE },
                { "IMAGE_SAVE", IMAGE_SAVE },
            };

            private string _value;

            public OriginEnum()
            {

            }

            public OriginEnum(string value)
            {
                _value = value;
            }

            public static OriginEnum FromValue(string value)
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

                if (this.Equals(obj as OriginEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginEnum a, OriginEnum b)
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

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines resourceCategory
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ResourceCategoryEnum>))]
        public class ResourceCategoryEnum
        {
            /// <summary>
            /// Enum ASCEND for value: ASCEND
            /// </summary>
            public static readonly ResourceCategoryEnum ASCEND = new ResourceCategoryEnum("ASCEND");

            /// <summary>
            /// Enum CPU for value: CPU
            /// </summary>
            public static readonly ResourceCategoryEnum CPU = new ResourceCategoryEnum("CPU");

            /// <summary>
            /// Enum GPU for value: GPU
            /// </summary>
            public static readonly ResourceCategoryEnum GPU = new ResourceCategoryEnum("GPU");

            private static readonly Dictionary<string, ResourceCategoryEnum> StaticFields =
            new Dictionary<string, ResourceCategoryEnum>()
            {
                { "ASCEND", ASCEND },
                { "CPU", CPU },
                { "GPU", GPU },
            };

            private string _value;

            public ResourceCategoryEnum()
            {

            }

            public ResourceCategoryEnum(string value)
            {
                _value = value;
            }

            public static ResourceCategoryEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceCategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceCategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceCategoryEnum a, ResourceCategoryEnum b)
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

            public static bool operator !=(ResourceCategoryEnum a, ResourceCategoryEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：镜像支持服务类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - COMMON：通用镜像。 - INFERENCE: 建议仅在推理部署场景使用。 - TRAIN: 建议仅在训练任务场景使用。 - DEV: 建议仅在开发调测场景使用。 - UNKNOWN: 未明确设置的镜像支持的服务类型。  **默认取值**：UNKNOWN。
        /// </summary>
        /// <value>**参数解释**：镜像支持服务类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - COMMON：通用镜像。 - INFERENCE: 建议仅在推理部署场景使用。 - TRAIN: 建议仅在训练任务场景使用。 - DEV: 建议仅在开发调测场景使用。 - UNKNOWN: 未明确设置的镜像支持的服务类型。  **默认取值**：UNKNOWN。</value>
        [JsonConverter(typeof(EnumClassConverter<ServiceTypeEnum>))]
        public class ServiceTypeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly ServiceTypeEnum COMMON = new ServiceTypeEnum("COMMON");

            /// <summary>
            /// Enum DEV for value: DEV
            /// </summary>
            public static readonly ServiceTypeEnum DEV = new ServiceTypeEnum("DEV");

            /// <summary>
            /// Enum INFERENCE for value: INFERENCE
            /// </summary>
            public static readonly ServiceTypeEnum INFERENCE = new ServiceTypeEnum("INFERENCE");

            /// <summary>
            /// Enum TRAIN for value: TRAIN
            /// </summary>
            public static readonly ServiceTypeEnum TRAIN = new ServiceTypeEnum("TRAIN");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly ServiceTypeEnum UNKNOWN = new ServiceTypeEnum("UNKNOWN");

            private static readonly Dictionary<string, ServiceTypeEnum> StaticFields =
            new Dictionary<string, ServiceTypeEnum>()
            {
                { "COMMON", COMMON },
                { "DEV", DEV },
                { "INFERENCE", INFERENCE },
                { "TRAIN", TRAIN },
                { "UNKNOWN", UNKNOWN },
            };

            private string _value;

            public ServiceTypeEnum()
            {

            }

            public ServiceTypeEnum(string value)
            {
                _value = value;
            }

            public static ServiceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ServiceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServiceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServiceTypeEnum a, ServiceTypeEnum b)
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

            public static bool operator !=(ServiceTypeEnum a, ServiceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines services
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ServicesEnum>))]
        public class ServicesEnum
        {
            /// <summary>
            /// Enum AI_FLOW for value: AI_FLOW
            /// </summary>
            public static readonly ServicesEnum AI_FLOW = new ServicesEnum("AI_FLOW");

            /// <summary>
            /// Enum MA_STUDIO for value: MA_STUDIO
            /// </summary>
            public static readonly ServicesEnum MA_STUDIO = new ServicesEnum("MA_STUDIO");

            /// <summary>
            /// Enum NOTEBOOK for value: NOTEBOOK
            /// </summary>
            public static readonly ServicesEnum NOTEBOOK = new ServicesEnum("NOTEBOOK");

            /// <summary>
            /// Enum SSH for value: SSH
            /// </summary>
            public static readonly ServicesEnum SSH = new ServicesEnum("SSH");

            /// <summary>
            /// Enum TENSOR_BOARD for value: TENSOR_BOARD
            /// </summary>
            public static readonly ServicesEnum TENSOR_BOARD = new ServicesEnum("TENSOR_BOARD");

            /// <summary>
            /// Enum WEB_IDE for value: WEB_IDE
            /// </summary>
            public static readonly ServicesEnum WEB_IDE = new ServicesEnum("WEB_IDE");

            private static readonly Dictionary<string, ServicesEnum> StaticFields =
            new Dictionary<string, ServicesEnum>()
            {
                { "AI_FLOW", AI_FLOW },
                { "MA_STUDIO", MA_STUDIO },
                { "NOTEBOOK", NOTEBOOK },
                { "SSH", SSH },
                { "TENSOR_BOARD", TENSOR_BOARD },
                { "WEB_IDE", WEB_IDE },
            };

            private string _value;

            public ServicesEnum()
            {

            }

            public ServicesEnum(string value)
            {
                _value = value;
            }

            public static ServicesEnum FromValue(string value)
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

                if (this.Equals(obj as ServicesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ServicesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ServicesEnum a, ServicesEnum b)
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

            public static bool operator !=(ServicesEnum a, ServicesEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：镜像可见度。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - PRIVATE：私有镜像。 - PUBLIC: 所有用户可以根据image_id来进行只读使用。  **默认取值**：PRIVATE。
        /// </summary>
        /// <value>**参数解释**：镜像可见度。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - PRIVATE：私有镜像。 - PUBLIC: 所有用户可以根据image_id来进行只读使用。  **默认取值**：PRIVATE。</value>
        [JsonConverter(typeof(EnumClassConverter<VisibilityEnum>))]
        public class VisibilityEnum
        {
            /// <summary>
            /// Enum HIDDEN for value: HIDDEN
            /// </summary>
            public static readonly VisibilityEnum HIDDEN = new VisibilityEnum("HIDDEN");

            /// <summary>
            /// Enum PRIVATE for value: PRIVATE
            /// </summary>
            public static readonly VisibilityEnum PRIVATE = new VisibilityEnum("PRIVATE");

            /// <summary>
            /// Enum PUBLIC for value: PUBLIC
            /// </summary>
            public static readonly VisibilityEnum PUBLIC = new VisibilityEnum("PUBLIC");

            private static readonly Dictionary<string, VisibilityEnum> StaticFields =
            new Dictionary<string, VisibilityEnum>()
            {
                { "HIDDEN", HIDDEN },
                { "PRIVATE", PRIVATE },
                { "PUBLIC", PUBLIC },
            };

            private string _value;

            public VisibilityEnum()
            {

            }

            public VisibilityEnum(string value)
            {
                _value = value;
            }

            public static VisibilityEnum FromValue(string value)
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

                if (this.Equals(obj as VisibilityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VisibilityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VisibilityEnum a, VisibilityEnum b)
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

            public static bool operator !=(VisibilityEnum a, VisibilityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：该镜像所支持处理器架构类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - X86_64：x86处理器架构。 - AARCH64：ARM体系架构。  **默认取值**：X86_64。
        /// </summary>
        [JsonProperty("arch", NullValueHandling = NullValueHandling.Ignore)]
        public ArchEnum Arch { get; set; }
        /// <summary>
        /// **参数解释**：该镜像所对应的描述信息。 **约束限制**：不涉及。 **取值范围**：长度限制512个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：指定镜像来源，可选项。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - CUSTOMIZE: 用户自定义构建镜像。 - IMAGE_SAVE：Notebook实例保存镜像。  **默认取值**：CUSTOMIZE。
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// **参数解释**：镜像支持的规格，默认值CPU、GPU。 枚举值如下： - CPU - GPU - [ASCEND](tag:hc,hk,fcs_super)。  **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("resource_category", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceCategoryEnum> ResourceCategory { get; set; }
        /// <summary>
        /// **参数解释**：镜像支持服务类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - COMMON：通用镜像。 - INFERENCE: 建议仅在推理部署场景使用。 - TRAIN: 建议仅在训练任务场景使用。 - DEV: 建议仅在开发调测场景使用。 - UNKNOWN: 未明确设置的镜像支持的服务类型。  **默认取值**：UNKNOWN。
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceTypeEnum ServiceType { get; set; }
        /// <summary>
        /// **参数解释**：镜像支持的服务，默认值NOTEBOOK、SSH。枚举值如下: - NOTEBOOK：镜像支持通过https协议访问Notebook。 - SSH：镜像支持本地IDE通过SSH协议远程连接Notebook。  **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("services", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServicesEnum> Services { get; set; }
        /// <summary>
        /// **参数解释**：SWR镜像地址。 **约束限制**：不涉及。 **取值范围**：长度最长为2048个字符，最短为16个字符，地址格式为：[仓库地址[:端口]]/[命名空间]/[镜像名称]:[标签]。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("swr_path", NullValueHandling = NullValueHandling.Ignore)]
        public string SwrPath { get; set; }

        /// <summary>
        /// **参数解释**：镜像可见度。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - PRIVATE：私有镜像。 - PUBLIC: 所有用户可以根据image_id来进行只读使用。  **默认取值**：PRIVATE。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// **参数解释**：工作空间ID。[获取方法请参见[查询工作空间列表](ListWorkspace.xml)。](tag:hc)未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **约束限制**：不涉及。 **取值范围**：0或32位仅包含字符0-9或小写字母a-z的字符串。 **默认取值**：0。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释**：资源类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： -ASCEND_SNT9：昇腾910芯片。 -ASCEND_SNT9B：昇腾910B芯片。 -ASCEND_SNT3：昇腾310芯片。  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorType { get; set; }

        /// <summary>
        /// **参数解释**：该镜像所属镜像组对应的标签。 **约束限制**：最大支持20个标签。 **取值范围**：key值最大支持长度128，value值最大支持255。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// **参数解释**：企业版SWR仓库ID。 **参数约束**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("swr_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SwrInstanceId { get; set; }

        /// <summary>
        /// **参数解释**：镜像指导。 **参数约束**：不涉及。 **取值范围**：字符串长度限制为3000个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("read_me", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadMe { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageRegRequest {\n");
            sb.Append("  arch: ").Append(Arch).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("  resourceCategory: ").Append(ResourceCategory).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  services: ").Append(Services).Append("\n");
            sb.Append("  swrPath: ").Append(SwrPath).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  flavorType: ").Append(FlavorType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  swrInstanceId: ").Append(SwrInstanceId).Append("\n");
            sb.Append("  readMe: ").Append(ReadMe).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageRegRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageRegRequest input)
        {
            if (input == null) return false;
            if (this.Arch != input.Arch) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Origin != input.Origin) return false;
            if (this.ResourceCategory != input.ResourceCategory || (this.ResourceCategory != null && input.ResourceCategory != null && !this.ResourceCategory.SequenceEqual(input.ResourceCategory))) return false;
            if (this.ServiceType != input.ServiceType) return false;
            if (this.Services != input.Services || (this.Services != null && input.Services != null && !this.Services.SequenceEqual(input.Services))) return false;
            if (this.SwrPath != input.SwrPath || (this.SwrPath != null && !this.SwrPath.Equals(input.SwrPath))) return false;
            if (this.Visibility != input.Visibility) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.FlavorType != input.FlavorType || (this.FlavorType != null && !this.FlavorType.Equals(input.FlavorType))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.SwrInstanceId != input.SwrInstanceId || (this.SwrInstanceId != null && !this.SwrInstanceId.Equals(input.SwrInstanceId))) return false;
            if (this.ReadMe != input.ReadMe || (this.ReadMe != null && !this.ReadMe.Equals(input.ReadMe))) return false;

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
                hashCode = hashCode * 59 + this.Arch.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Origin.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceCategory.GetHashCode();
                hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                hashCode = hashCode * 59 + this.Services.GetHashCode();
                if (this.SwrPath != null) hashCode = hashCode * 59 + this.SwrPath.GetHashCode();
                hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.FlavorType != null) hashCode = hashCode * 59 + this.FlavorType.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SwrInstanceId != null) hashCode = hashCode * 59 + this.SwrInstanceId.GetHashCode();
                if (this.ReadMe != null) hashCode = hashCode * 59 + this.ReadMe.GetHashCode();
                return hashCode;
            }
        }
    }
}
