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
    public class NotebookCreateRequest 
    {
        /// <summary>
        /// **参数解释**：实例类别。 **约束限制**：不涉及。 **取值范围**： - DEFAULT：CodeLab免费规格实例，每个用户最多只能创建一个。 - NOTEBOOK：计费规格实例。  **默认取值**：NOTEBOOK。
        /// </summary>
        /// <value>**参数解释**：实例类别。 **约束限制**：不涉及。 **取值范围**： - DEFAULT：CodeLab免费规格实例，每个用户最多只能创建一个。 - NOTEBOOK：计费规格实例。  **默认取值**：NOTEBOOK。</value>
        [JsonConverter(typeof(EnumClassConverter<FeatureEnum>))]
        public class FeatureEnum
        {
            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly FeatureEnum DEFAULT = new FeatureEnum("DEFAULT");

            /// <summary>
            /// Enum NOTEBOOK for value: NOTEBOOK
            /// </summary>
            public static readonly FeatureEnum NOTEBOOK = new FeatureEnum("NOTEBOOK");

            private static readonly Dictionary<string, FeatureEnum> StaticFields =
            new Dictionary<string, FeatureEnum>()
            {
                { "DEFAULT", DEFAULT },
                { "NOTEBOOK", NOTEBOOK },
            };

            private string _value;

            public FeatureEnum()
            {

            }

            public FeatureEnum(string value)
            {
                _value = value;
            }

            public static FeatureEnum FromValue(string value)
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

                if (this.Equals(obj as FeatureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FeatureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FeatureEnum a, FeatureEnum b)
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

            public static bool operator !=(FeatureEnum a, FeatureEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：实例描述信息。 **约束限制**：不涉及。 **取值范围**：长度限制为512字符，且不能包含字符&amp;&lt;&gt;\&quot;&#39;/。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：仅在本地IDE（如PyCharm、VS Code）或SSH客户端接入Notebook。 **约束限制**：仅在本地IDE（如PyCharm、VS Code）或SSH客户端，通过SSH远程接入Notebook实例时需要的相关配置。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<EndpointsReq> Endpoints { get; set; }

        /// <summary>
        /// **参数解释**：实例类别。 **约束限制**：不涉及。 **取值范围**： - DEFAULT：CodeLab免费规格实例，每个用户最多只能创建一个。 - NOTEBOOK：计费规格实例。  **默认取值**：NOTEBOOK。
        /// </summary>
        [JsonProperty("feature", NullValueHandling = NullValueHandling.Ignore)]
        public FeatureEnum Feature { get; set; }
        /// <summary>
        /// **参数解释**：实例的机器规格。如下规格仅供参考，实际支持的规格以具体区域为准。 - modelarts.vm.cpu.2u：Intel CPU通用规格，用于快速数据探索和实验。 - modelarts.vm.cpu.8u：Intel CPU算力增强型，适用于密集计算场景下运算。  **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_spec", NullValueHandling = NullValueHandling.Ignore)]
        public NotebookCustomSpec CustomSpec { get; set; }

        /// <summary>
        /// **参数解释**：待创建Notebook实例的镜像，需要指定镜像ID。ID格式为通用唯一识别码（Universally Unique Identifier，简称UUID）。镜像的ID可通过调用[[查询支持的镜像列表](https://support.huaweicloud.com/api-modelarts/ListImage.html)](tag:hc)[[查询支持的镜像列表](https://support.huaweicloud.com/intl/zh-cn/api-modelarts/ListImage.html)](tag:hk)接口获取。 **约束限制**：不涉及。 **取值范围**：调用[[查询支持的镜像列表](https://support.huaweicloud.com/api-modelarts/ListImage.html)](tag:hc)[[查询支持的镜像列表](https://support.huaweicloud.com/intl/zh-cn/api-modelarts/ListImage.html)](tag:hk)接口获取的合法镜像ID列表。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**：实例名称。 **约束限制**：不涉及。 **取值范围**：长度限制为128个字符，支持大小写字母、数字、中划线和下划线，名称可重复。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：专属资源池ID，若需要指定专属资源池创建实例时必填。专属资源池ID可通过[[查询资源池列表](https://support.huaweicloud.com/api-modelarts/ListPools.html)](tag:hc)[[查询资源池列表](https://support.huaweicloud.com/intl/zh-cn/api-modelarts/ListPools.html)](tag:hk)接口获取。 **约束限制**：不涉及。 **取值范围**：调用[[查询资源池列表](https://support.huaweicloud.com/api-modelarts/ListPools.html)](tag:hc)[[查询资源池列表](https://support.huaweicloud.com/intl/zh-cn/api-modelarts/ListPools.html)](tag:hk)接口获取的合法资源池ID列表。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeMountRequest Volume { get; set; }

        /// <summary>
        /// **参数解释**：工作空间ID。未创建工作空间时默认值为“0”，存在创建并使用的工作空间，以实际取值为准。 **约束限制**：不涉及。 **取值范围**：0或32位仅包含字符0-9或小写字母a-z的字符串。 **默认取值**：0。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hooks", NullValueHandling = NullValueHandling.Ignore)]
        public CustomHooks Hooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lease", NullValueHandling = NullValueHandling.Ignore)]
        public LeaseReq Lease { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
        public AffinityType Affinity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("run_user", NullValueHandling = NullValueHandling.Ignore)]
        public RunUserRequest RunUser { get; set; }

        /// <summary>
        /// **参数解释**：实例存储配置。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeMountRequest> DataVolumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_vpc", NullValueHandling = NullValueHandling.Ignore)]
        public UserVpcRequest UserVpc { get; set; }

        /// <summary>
        /// **参数解释**：定时停止，以当前时刻为起点，运行的时长（到期后自动停止）。单位：毫秒。 **约束限制**：不涉及。 **取值范围**：3600000-259200000。 **默认取值**：3600000。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotebookCreateRequest {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  feature: ").Append(Feature).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  customSpec: ").Append(CustomSpec).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  hooks: ").Append(Hooks).Append("\n");
            sb.Append("  lease: ").Append(Lease).Append("\n");
            sb.Append("  affinity: ").Append(Affinity).Append("\n");
            sb.Append("  runUser: ").Append(RunUser).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("  userVpc: ").Append(UserVpc).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotebookCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotebookCreateRequest input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && input.Endpoints != null && !this.Endpoints.SequenceEqual(input.Endpoints))) return false;
            if (this.Feature != input.Feature) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.CustomSpec != input.CustomSpec || (this.CustomSpec != null && !this.CustomSpec.Equals(input.CustomSpec))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Hooks != input.Hooks || (this.Hooks != null && !this.Hooks.Equals(input.Hooks))) return false;
            if (this.Lease != input.Lease || (this.Lease != null && !this.Lease.Equals(input.Lease))) return false;
            if (this.Affinity != input.Affinity || (this.Affinity != null && !this.Affinity.Equals(input.Affinity))) return false;
            if (this.RunUser != input.RunUser || (this.RunUser != null && !this.RunUser.Equals(input.RunUser))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;
            if (this.UserVpc != input.UserVpc || (this.UserVpc != null && !this.UserVpc.Equals(input.UserVpc))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Endpoints != null) hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                hashCode = hashCode * 59 + this.Feature.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.CustomSpec != null) hashCode = hashCode * 59 + this.CustomSpec.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Hooks != null) hashCode = hashCode * 59 + this.Hooks.GetHashCode();
                if (this.Lease != null) hashCode = hashCode * 59 + this.Lease.GetHashCode();
                if (this.Affinity != null) hashCode = hashCode * 59 + this.Affinity.GetHashCode();
                if (this.RunUser != null) hashCode = hashCode * 59 + this.RunUser.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                if (this.UserVpc != null) hashCode = hashCode * 59 + this.UserVpc.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
