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
    /// **参数解释：** 代码挂载配置 **约束限制：** 不涉及。
    /// </summary>
    public class Code 
    {

        /// <summary>
        /// **参数解释：** 代码来源类别。 **约束限制：** 不涉及。 **取值范围：** - OBS：对象存储服务。 - OBSFS：OBS的文件系统接口。 - EFS：弹性文件服务。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释：** 代码来源地址，格式遵循不同存储系统。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// **参数解释：** 代码来源ID，与address二选一，当且仅当source为EFS时，可以传入sfs turbo的ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("source_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceId { get; set; }

        /// <summary>
        /// **参数解释：** 挂载到容器内的路径。 **约束限制：** 不涉及。 **取值范围：** 以(/)开头和结尾，可包含字母、数字、中划线、下划线，整个挂载路径长度不能超过255位。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释：** EFS子路径。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("efs_sub_path", NullValueHandling = NullValueHandling.Ignore)]
        public string EfsSubPath { get; set; }

        /// <summary>
        /// **参数解释：** 挂载权限设置, 是否只读。 **约束限制：** 不涉及。 **取值范围：** - true：只读。 - false：非只读。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Code {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  sourceId: ").Append(SourceId).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  efsSubPath: ").Append(EfsSubPath).Append("\n");
            sb.Append("  readOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Code);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Code input)
        {
            if (input == null) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.SourceId != input.SourceId || (this.SourceId != null && !this.SourceId.Equals(input.SourceId))) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.EfsSubPath != input.EfsSubPath || (this.EfsSubPath != null && !this.EfsSubPath.Equals(input.EfsSubPath))) return false;
            if (this.ReadOnly != input.ReadOnly || (this.ReadOnly != null && !this.ReadOnly.Equals(input.ReadOnly))) return false;

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
                if (this.Source != null) hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Address != null) hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.SourceId != null) hashCode = hashCode * 59 + this.SourceId.GetHashCode();
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.EfsSubPath != null) hashCode = hashCode * 59 + this.EfsSubPath.GetHashCode();
                if (this.ReadOnly != null) hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                return hashCode;
            }
        }
    }
}
