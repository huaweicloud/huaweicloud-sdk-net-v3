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
    /// **参数解释：** 模型存储挂载配置。 **约束限制：** 不涉及。
    /// </summary>
    public class GroupModel 
    {

        /// <summary>
        /// **参数解释：** 代码来源类别。 **约束限制：** 不涉及。 **取值范围：** 如下参数不区分大小写 - OBS：对象存储服务。 - OBSFS：OBS的文件系统接口。 - EFS：弹性文件服务。 - [TRAIN：训练作业。](tag:hws) - LOCAL：挂载宿主机本地存储目录。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// **参数解释：** 代码来源地址，格式遵循不同存储系统。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// **参数解释：** 挂载到容器内的路径，要求以/开头，后面可包含中划线，反斜杠，下划线，点号，字母，数字。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释：** 是否支持模型本地缓存，默认是不支持。 **约束限制：** 不涉及。 **取值范围：** - true：支持。 - false：不支持。 **默认取值：** false。
        /// </summary>
        [JsonProperty("host_cache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HostCache { get; set; }

        /// <summary>
        /// **参数解释：** 当存储类别为EFS时，支持配置子目录。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("efs_sub_path", NullValueHandling = NullValueHandling.Ignore)]
        public string EfsSubPath { get; set; }

        /// <summary>
        /// **参数解释：** 挂载权限设置，是否只读。 **约束限制：** 不涉及。 **取值范围：** - true：只读。 - false：非只读。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// **参数解释：** os预热。 **约束限制：** 不涉及。 **取值范围：** - true：预热。 - false：不预热。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("os_warm_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OsWarmUp { get; set; }

        /// <summary>
        /// **参数解释：** 预热名称。 **约束限制：** os_warm_up为true时必填。 **取值范围：** 支持1-64位字符，可包含字母、中文、数字、中划线、下划线。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("source_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceName { get; set; }

        /// <summary>
        /// 参数解释： 预置资产id。 取值范围： 支持1-64位字符，可包含字母、中文、数字、中划线、下划线。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupModel {\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  hostCache: ").Append(HostCache).Append("\n");
            sb.Append("  efsSubPath: ").Append(EfsSubPath).Append("\n");
            sb.Append("  readOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  osWarmUp: ").Append(OsWarmUp).Append("\n");
            sb.Append("  sourceName: ").Append(SourceName).Append("\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupModel input)
        {
            if (input == null) return false;
            if (this.Source != input.Source || (this.Source != null && !this.Source.Equals(input.Source))) return false;
            if (this.Address != input.Address || (this.Address != null && !this.Address.Equals(input.Address))) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.HostCache != input.HostCache || (this.HostCache != null && !this.HostCache.Equals(input.HostCache))) return false;
            if (this.EfsSubPath != input.EfsSubPath || (this.EfsSubPath != null && !this.EfsSubPath.Equals(input.EfsSubPath))) return false;
            if (this.ReadOnly != input.ReadOnly || (this.ReadOnly != null && !this.ReadOnly.Equals(input.ReadOnly))) return false;
            if (this.OsWarmUp != input.OsWarmUp || (this.OsWarmUp != null && !this.OsWarmUp.Equals(input.OsWarmUp))) return false;
            if (this.SourceName != input.SourceName || (this.SourceName != null && !this.SourceName.Equals(input.SourceName))) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;

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
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.HostCache != null) hashCode = hashCode * 59 + this.HostCache.GetHashCode();
                if (this.EfsSubPath != null) hashCode = hashCode * 59 + this.EfsSubPath.GetHashCode();
                if (this.ReadOnly != null) hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.OsWarmUp != null) hashCode = hashCode * 59 + this.OsWarmUp.GetHashCode();
                if (this.SourceName != null) hashCode = hashCode * 59 + this.SourceName.GetHashCode();
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
