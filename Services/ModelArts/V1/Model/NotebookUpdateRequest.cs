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
    public class NotebookUpdateRequest 
    {

        /// <summary>
        /// **参数解释**：支持更新实例描述信息。 **约束限制**：不涉及。 **取值范围**：长度限制为512字符，且不能包含字符&amp;&lt;&gt;\&quot;&#39;/。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：仅在本地IDE（如PyCharm、VS Code）或SSH客户端接入Notebook。 **约束限制**：仅在本地IDE（如PyCharm、VS Code）或SSH客户端，通过SSH远程接入Notebook实例时需要的相关配置。
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<EndpointsReq> Endpoints { get; set; }

        /// <summary>
        /// **参数解释**：支持变更实例的机器规格。支持变更的规格可以通过本章节的[查询支持可切换规格列表](ShowSwitchableFlavors.xml)的API获取。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_spec", NullValueHandling = NullValueHandling.Ignore)]
        public NotebookCustomSpec CustomSpec { get; set; }

        /// <summary>
        /// **参数解释**：支持更新镜像ID，镜像ID参考[查询支持的镜像列表](ListImage.xml)获取。 **约束限制**：不涉及。 **取值范围**：调用[查询支持的镜像列表](ListImage.xml)接口获取的合法镜像ID列表。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// **参数解释**：支持更新实例名称。 **约束限制**：不涉及。 **取值范围**：长度限制为128个字符，支持大小写字母、数字、中划线和下划线，名称可重复。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：EVS实例支持动态扩充的容量，单位GB。只允许扩容，不允许缩容。 **约束限制**：不涉及。 **取值范围**：最大允许扩容至4096。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("storage_new_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? StorageNewSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("hooks", NullValueHandling = NullValueHandling.Ignore)]
        public CustomHooks Hooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
        public AffinityType Affinity { get; set; }

        /// <summary>
        /// **参数解释**：DEW存储的用户AKSK凭据名称。 **参数约束**：当category为OBS时必填，仅支持大小写字母、数字、中划线、下划线，长度 1-64 字符。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("dew_secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DewSecretName { get; set; }

        /// <summary>
        /// **参数解释**：扩展存储信息。 **约束限制**：不涉及。
        /// </summary>
        [JsonProperty("data_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeMountRequest> DataVolumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotebookUpdateRequest {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  customSpec: ").Append(CustomSpec).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  storageNewSize: ").Append(StorageNewSize).Append("\n");
            sb.Append("  hooks: ").Append(Hooks).Append("\n");
            sb.Append("  affinity: ").Append(Affinity).Append("\n");
            sb.Append("  dewSecretName: ").Append(DewSecretName).Append("\n");
            sb.Append("  dataVolumes: ").Append(DataVolumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotebookUpdateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NotebookUpdateRequest input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && input.Endpoints != null && !this.Endpoints.SequenceEqual(input.Endpoints))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.CustomSpec != input.CustomSpec || (this.CustomSpec != null && !this.CustomSpec.Equals(input.CustomSpec))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.StorageNewSize != input.StorageNewSize || (this.StorageNewSize != null && !this.StorageNewSize.Equals(input.StorageNewSize))) return false;
            if (this.Hooks != input.Hooks || (this.Hooks != null && !this.Hooks.Equals(input.Hooks))) return false;
            if (this.Affinity != input.Affinity || (this.Affinity != null && !this.Affinity.Equals(input.Affinity))) return false;
            if (this.DewSecretName != input.DewSecretName || (this.DewSecretName != null && !this.DewSecretName.Equals(input.DewSecretName))) return false;
            if (this.DataVolumes != input.DataVolumes || (this.DataVolumes != null && input.DataVolumes != null && !this.DataVolumes.SequenceEqual(input.DataVolumes))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.CustomSpec != null) hashCode = hashCode * 59 + this.CustomSpec.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StorageNewSize != null) hashCode = hashCode * 59 + this.StorageNewSize.GetHashCode();
                if (this.Hooks != null) hashCode = hashCode * 59 + this.Hooks.GetHashCode();
                if (this.Affinity != null) hashCode = hashCode * 59 + this.Affinity.GetHashCode();
                if (this.DewSecretName != null) hashCode = hashCode * 59 + this.DewSecretName.GetHashCode();
                if (this.DataVolumes != null) hashCode = hashCode * 59 + this.DataVolumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
