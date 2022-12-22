using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrePaidServerRootVolumeExtendParam 
    {

        /// <summary>
        /// 磁盘产品资源规格编码，如SATA，SAS和SSD。  &gt; 说明： &gt;  &gt; 废弃字段。
        /// </summary>
        [JsonProperty("resourceSpecCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceSpecCode { get; set; }

        /// <summary>
        /// 磁盘产品资源类型。  &gt; 说明： &gt;  &gt; 废弃字段。
        /// </summary>
        [JsonProperty("resourceType", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 整机镜像中自带的原始数据盘（简称“原数据盘”）所对应的快照ID或原始数据盘ID。  使用场景：  使用整机镜像创建云服务器，并且选择的整机镜像自带1个或者多个数据盘。  用途：  使用整机镜像创建云服务器时，系统会自动恢复整机镜像中自带数据盘（如果有）的数据，但是磁盘类型将被恢复为默认属性：普通I/O、VBD、非共享盘。此时，您可以通过snapshotID，修改指定原数据盘恢复后的磁盘类型。  &gt; 说明： &gt;  &gt; - 建议对每块原数据盘都指定snapshotID，否则，未指定的原数据盘将按默认属性进行创建。 &gt; - 如需修改磁盘大小，修改后的磁盘大小需大于等于原数据盘大小。否则，会影响原数据盘的数据恢复。  实现原理：  snapshotId是整机镜像自带原始数据盘的唯一标识，通过snapshotId可以获取原数据盘的磁盘信息，从而恢复数据盘数据。  快照ID的获取方法：  登录管理控制台，打开\&quot;云硬盘 &gt; 快照\&quot;页面，根据原始数据盘的磁盘名称找到对应的快照ID。
        /// </summary>
        [JsonProperty("snapshotId", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrePaidServerRootVolumeExtendParam {\n");
            sb.Append("  resourceSpecCode: ").Append(ResourceSpecCode).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrePaidServerRootVolumeExtendParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrePaidServerRootVolumeExtendParam input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceSpecCode == input.ResourceSpecCode ||
                    (this.ResourceSpecCode != null &&
                    this.ResourceSpecCode.Equals(input.ResourceSpecCode))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResourceSpecCode != null)
                    hashCode = hashCode * 59 + this.ResourceSpecCode.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                return hashCode;
            }
        }
    }
}
