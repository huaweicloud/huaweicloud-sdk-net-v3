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
    /// **参数解释：** 服务密钥挂载。 **约束限制：** 不涉及。
    /// </summary>
    public class ServiceSecret 
    {

        /// <summary>
        /// **参数解释：** 是否启用密钥。 **约束限制：** 不涉及。 **取值范围：** - true：启用密钥。 - false：不启用密钥。 **默认取值：** false。
        /// </summary>
        [JsonProperty("secret_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SecretEnable { get; set; }

        /// <summary>
        /// **参数解释：** 密钥类型。 **约束限制：** 不涉及。 **取值范围：** - custom：自定义密钥。 - [dew：DEW密钥。](tag:hws,hws_hk,fcs) **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }

        /// <summary>
        /// **参数解释：** 密钥挂载。 **约束限制：** 上限30个。
        /// </summary>
        [JsonProperty("secret_volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecretVolume> SecretVolumes { get; set; }

        /// <summary>
        /// **参数解释：** 是否启用镜像的用户组。 **约束限制：** 不涉及。 **取值范围：** - true：启用镜像的用户组。 - false：不启用镜像的用户组。 **默认取值：** false。
        /// </summary>
        [JsonProperty("group_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupEnable { get; set; }

        /// <summary>
        /// **参数解释：** 镜像的用户组ID。 **约束限制：** 不涉及。 **取值范围：** 1000~4294967294。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? GroupId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceSecret {\n");
            sb.Append("  secretEnable: ").Append(SecretEnable).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  secretVolumes: ").Append(SecretVolumes).Append("\n");
            sb.Append("  groupEnable: ").Append(GroupEnable).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceSecret);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceSecret input)
        {
            if (input == null) return false;
            if (this.SecretEnable != input.SecretEnable || (this.SecretEnable != null && !this.SecretEnable.Equals(input.SecretEnable))) return false;
            if (this.SecretType != input.SecretType || (this.SecretType != null && !this.SecretType.Equals(input.SecretType))) return false;
            if (this.SecretVolumes != input.SecretVolumes || (this.SecretVolumes != null && input.SecretVolumes != null && !this.SecretVolumes.SequenceEqual(input.SecretVolumes))) return false;
            if (this.GroupEnable != input.GroupEnable || (this.GroupEnable != null && !this.GroupEnable.Equals(input.GroupEnable))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;

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
                if (this.SecretEnable != null) hashCode = hashCode * 59 + this.SecretEnable.GetHashCode();
                if (this.SecretType != null) hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.SecretVolumes != null) hashCode = hashCode * 59 + this.SecretVolumes.GetHashCode();
                if (this.GroupEnable != null) hashCode = hashCode * 59 + this.GroupEnable.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
