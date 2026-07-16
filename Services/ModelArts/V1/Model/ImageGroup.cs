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
    public class ImageGroup 
    {

        /// <summary>
        /// **参数解释**：镜像名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：镜像创建的时间，单位：UTC毫秒。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// **参数解释**：镜像所属的SWR组织。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释**：镜像最后更新的时间，单位：UTC毫秒。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// **参数解释**：镜像版本个数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("version_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionCount { get; set; }

        /// <summary>
        /// **参数解释**：镜像描述信息。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**：镜像指导。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("read_me", NullValueHandling = NullValueHandling.Ignore)]
        public string ReadMe { get; set; }

        /// <summary>
        /// **参数解释**：镜像图标名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("icon_name", NullValueHandling = NullValueHandling.Ignore)]
        public string IconName { get; set; }

        /// <summary>
        /// **参数解释**：镜像id。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：SWR企业版镜像仓库名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("swr_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SwrInstanceName { get; set; }

        /// <summary>
        /// **参数解释**：SWR企业版镜像仓库ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("swr_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SwrInstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageGroup {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  versionCount: ").Append(VersionCount).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  readMe: ").Append(ReadMe).Append("\n");
            sb.Append("  iconName: ").Append(IconName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  swrInstanceName: ").Append(SwrInstanceName).Append("\n");
            sb.Append("  swrInstanceId: ").Append(SwrInstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImageGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImageGroup input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.VersionCount != input.VersionCount || (this.VersionCount != null && !this.VersionCount.Equals(input.VersionCount))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ReadMe != input.ReadMe || (this.ReadMe != null && !this.ReadMe.Equals(input.ReadMe))) return false;
            if (this.IconName != input.IconName || (this.IconName != null && !this.IconName.Equals(input.IconName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SwrInstanceName != input.SwrInstanceName || (this.SwrInstanceName != null && !this.SwrInstanceName.Equals(input.SwrInstanceName))) return false;
            if (this.SwrInstanceId != input.SwrInstanceId || (this.SwrInstanceId != null && !this.SwrInstanceId.Equals(input.SwrInstanceId))) return false;

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
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.VersionCount != null) hashCode = hashCode * 59 + this.VersionCount.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ReadMe != null) hashCode = hashCode * 59 + this.ReadMe.GetHashCode();
                if (this.IconName != null) hashCode = hashCode * 59 + this.IconName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SwrInstanceName != null) hashCode = hashCode * 59 + this.SwrInstanceName.GetHashCode();
                if (this.SwrInstanceId != null) hashCode = hashCode * 59 + this.SwrInstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
