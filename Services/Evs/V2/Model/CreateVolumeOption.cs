using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 创建云硬盘的信息。
    /// </summary>
    public class CreateVolumeOption 
    {
        /// <summary>
        /// 是否为共享云硬盘。true为共享盘，false为普通云硬盘。 该字段已经废弃，请使用multiattach。
        /// </summary>
        /// <value>是否为共享云硬盘。true为共享盘，false为普通云硬盘。 该字段已经废弃，请使用multiattach。</value>
        [JsonConverter(typeof(EnumClassConverter<ShareableEnum>))]
        public class ShareableEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly ShareableEnum TRUE = new ShareableEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly ShareableEnum FALSE = new ShareableEnum("false");

            private static readonly Dictionary<string, ShareableEnum> StaticFields =
            new Dictionary<string, ShareableEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string Value;

            private ShareableEnum(string value)
            {
                this.Value = value;
            }

            public static ShareableEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as ShareableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ShareableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ShareableEnum a, ShareableEnum b)
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

            public static bool operator !=(ShareableEnum a, ShareableEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云硬盘类型。  目前支持“SSD”，“SAS”和“SATA”三种。 “SSD”为超高IO云硬盘 \&quot;GPSSD\&quot;为通用型SSD云硬盘 “SAS”为高IO云硬盘 “SATA”为普通IO云硬盘 当指定的云硬盘类型在avaliability_zone内不存在时，则创建云硬盘失败。  说明： 从快照创建云硬盘时，volume_type字段必须和快照源云硬盘保持一致。 了解不同磁盘类型的详细信息，请参见 [磁盘类型及性能介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        /// <value>云硬盘类型。  目前支持“SSD”，“SAS”和“SATA”三种。 “SSD”为超高IO云硬盘 \&quot;GPSSD\&quot;为通用型SSD云硬盘 “SAS”为高IO云硬盘 “SATA”为普通IO云硬盘 当指定的云硬盘类型在avaliability_zone内不存在时，则创建云硬盘失败。  说明： 从快照创建云硬盘时，volume_type字段必须和快照源云硬盘保持一致。 了解不同磁盘类型的详细信息，请参见 [磁盘类型及性能介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。</value>
        [JsonConverter(typeof(EnumClassConverter<VolumeTypeEnum>))]
        public class VolumeTypeEnum
        {
            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            public static readonly VolumeTypeEnum SSD = new VolumeTypeEnum("SSD");

            /// <summary>
            /// Enum GPSSD for value: GPSSD
            /// </summary>
            public static readonly VolumeTypeEnum GPSSD = new VolumeTypeEnum("GPSSD");

            /// <summary>
            /// Enum SAS for value: SAS
            /// </summary>
            public static readonly VolumeTypeEnum SAS = new VolumeTypeEnum("SAS");

            /// <summary>
            /// Enum SATA for value: SATA
            /// </summary>
            public static readonly VolumeTypeEnum SATA = new VolumeTypeEnum("SATA");

            private static readonly Dictionary<string, VolumeTypeEnum> StaticFields =
            new Dictionary<string, VolumeTypeEnum>()
            {
                { "SSD", SSD },
                { "GPSSD", GPSSD },
                { "SAS", SAS },
                { "SATA", SATA },
            };

            private string Value;

            private VolumeTypeEnum(string value)
            {
                this.Value = value;
            }

            public static VolumeTypeEnum FromValue(string value)
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
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as VolumeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(VolumeTypeEnum a, VolumeTypeEnum b)
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

            public static bool operator !=(VolumeTypeEnum a, VolumeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定要创建云硬盘的可用区。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 备份ID，从备份创建云硬盘时为必选。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 批量创云硬盘的个数。如果无该参数，表明只创建1个云硬盘，目前最多支持批量创建100个。 从备份创建云硬盘时，不支持批量创建，数量只能为“1”。  如果发送请求时，将参数值设置为小数，则默认取小数点前的整数。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 云硬盘的描述。最大支持255个字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 企业项目ID。创建云硬盘时，给云硬盘绑定企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 镜像ID，指定该参数表示创建云硬盘方式为从镜像创建云硬盘。
        /// </summary>
        [JsonProperty("imageRef", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageRef { get; set; }

        /// <summary>
        /// 创建云硬盘的metadata信息     可选参数如下:    [\\_\\_system\\_\\_cmkid]   metadata中的加密cmkid字段，与\\_\\_system\\_\\_encrypted配合表示需要加密，cmkid长度固定为36个字节。 &gt; 说明： &gt;  &gt; 请求获取密钥ID的方法请参考：\&quot;[查询密钥列表](https://support.huaweicloud.com/api-dew/dew_02_0017.html)\&quot;。   [\\_\\_system\\_\\_encrypted]   metadata中的表示加密功能的字段,0代表不加密,1代表加密。不指定该字段时,云硬盘的加密属性与数据源保持一致,如果不是从数据源创建的场景,则默认不加密。    [full_clone]   从快照创建云硬盘时，如需使用link克隆方式，请指定该字段的值为0。    [hw:passthrough]    * true表示云硬盘的设备类型为SCSI类型，即允许ECS操作系统直接访问底层存储介质。支持SCSI锁命令。   * false表示云硬盘的设备类型为VBD (虚拟块存储设备 , Virtual Block Device)类型，即为默认类型，VBD只能支持简单的SCSI读写命令。   * 该字段不存在时，云硬盘默认为VBD类型。   
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// 是否为共享云硬盘。true为共享盘，false为普通云硬盘。
        /// </summary>
        [JsonProperty("multiattach", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multiattach { get; set; }

        /// <summary>
        /// 云硬盘名称。 如果为创建单个云硬盘，name为云硬盘名称。最大支持255个字节。 创建的云硬盘数量（count字段对应的值）大于1时，为区分不同云硬盘，创建过程中系统会自动在名称后加“-0000”的类似标记。例如：volume-0001、volume-0002。最大支持250个字节。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否为共享云硬盘。true为共享盘，false为普通云硬盘。 该字段已经废弃，请使用multiattach。
        /// </summary>
        [JsonProperty("shareable", NullValueHandling = NullValueHandling.Ignore)]
        public ShareableEnum Shareable { get; set; }
        /// <summary>
        /// 云硬盘大小，单位为GB，其限制如下： 系统盘：1GB-1024GB 数据盘：10GB-32768GB 创建空白云硬盘和从 镜像/快照 创建云硬盘时，size为必选，且云硬盘大小不能小于 镜像/快照 大小。 从备份创建云硬盘时，size为可选，不指定size时，云硬盘大小和备份大小一致。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 快照ID，指定该参数表示创建云硬盘方式为从快照创建云硬盘
        /// </summary>
        [JsonProperty("snapshot_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 云硬盘类型。  目前支持“SSD”，“SAS”和“SATA”三种。 “SSD”为超高IO云硬盘 \&quot;GPSSD\&quot;为通用型SSD云硬盘 “SAS”为高IO云硬盘 “SATA”为普通IO云硬盘 当指定的云硬盘类型在avaliability_zone内不存在时，则创建云硬盘失败。  说明： 从快照创建云硬盘时，volume_type字段必须和快照源云硬盘保持一致。 了解不同磁盘类型的详细信息，请参见 [磁盘类型及性能介绍](https://support.huaweicloud.com/productdesc-evs/zh-cn_topic_0044524691.html)。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeTypeEnum VolumeType { get; set; }
        /// <summary>
        /// 云硬盘标签信息。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tags { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVolumeOption {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  imageRef: ").Append(ImageRef).Append("\n");
            sb.Append("  metadata: ").Append(Metadata).Append("\n");
            sb.Append("  multiattach: ").Append(Multiattach).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  shareable: ").Append(Shareable).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  snapshotId: ").Append(SnapshotId).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateVolumeOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateVolumeOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ImageRef == input.ImageRef ||
                    (this.ImageRef != null &&
                    this.ImageRef.Equals(input.ImageRef))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Multiattach == input.Multiattach ||
                    (this.Multiattach != null &&
                    this.Multiattach.Equals(input.Multiattach))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Shareable == input.Shareable ||
                    (this.Shareable != null &&
                    this.Shareable.Equals(input.Shareable))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.SnapshotId == input.SnapshotId ||
                    (this.SnapshotId != null &&
                    this.SnapshotId.Equals(input.SnapshotId))
                ) && 
                (
                    this.VolumeType == input.VolumeType ||
                    (this.VolumeType != null &&
                    this.VolumeType.Equals(input.VolumeType))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ImageRef != null)
                    hashCode = hashCode * 59 + this.ImageRef.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Multiattach != null)
                    hashCode = hashCode * 59 + this.Multiattach.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Shareable != null)
                    hashCode = hashCode * 59 + this.Shareable.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.SnapshotId != null)
                    hashCode = hashCode * 59 + this.SnapshotId.GetHashCode();
                if (this.VolumeType != null)
                    hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
