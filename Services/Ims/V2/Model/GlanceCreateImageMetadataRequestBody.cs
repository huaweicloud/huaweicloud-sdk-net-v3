using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ims.V2.Model
{
    /// <summary>
    /// 创建镜像请求体
    /// </summary>
    public class GlanceCreateImageMetadataRequestBody 
    {
        /// <summary>
        /// 镜像文件格式。目前支持vhd，zvhd、zvhd2、raw，qcow2。默认取值为vhd
        /// </summary>
        /// <value>镜像文件格式。目前支持vhd，zvhd、zvhd2、raw，qcow2。默认取值为vhd</value>
        [JsonConverter(typeof(EnumClassConverter<DiskFormatEnum>))]
        public class DiskFormatEnum
        {
            /// <summary>
            /// Enum VHD for value: vhd
            /// </summary>
            public static readonly DiskFormatEnum VHD = new DiskFormatEnum("vhd");

            /// <summary>
            /// Enum ZVHD for value: zvhd
            /// </summary>
            public static readonly DiskFormatEnum ZVHD = new DiskFormatEnum("zvhd");

            /// <summary>
            /// Enum ZVHD2 for value: zvhd2
            /// </summary>
            public static readonly DiskFormatEnum ZVHD2 = new DiskFormatEnum("zvhd2");

            /// <summary>
            /// Enum RAW for value: raw
            /// </summary>
            public static readonly DiskFormatEnum RAW = new DiskFormatEnum("raw");

            /// <summary>
            /// Enum QCOW2 for value: qcow2
            /// </summary>
            public static readonly DiskFormatEnum QCOW2 = new DiskFormatEnum("qcow2");

            private static readonly Dictionary<string, DiskFormatEnum> StaticFields =
            new Dictionary<string, DiskFormatEnum>()
            {
                { "vhd", VHD },
                { "zvhd", ZVHD },
                { "zvhd2", ZVHD2 },
                { "raw", RAW },
                { "qcow2", QCOW2 },
            };

            private string Value;

            public DiskFormatEnum(string value)
            {
                Value = value;
            }

            public static DiskFormatEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as DiskFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DiskFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DiskFormatEnum a, DiskFormatEnum b)
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

            public static bool operator !=(DiskFormatEnum a, DiskFormatEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 镜像的操作系统具体版本,如果未指定__os_version，则默认设置为Other Linux(64 bit)，不保证该镜像能成功创建虚拟机以及通过该镜像创建的虚拟机能够正常使用。
        /// </summary>
        [JsonProperty("__os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 容器格式。默认取值为bare。
        /// </summary>
        [JsonProperty("container_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerFormat { get; set; }

        /// <summary>
        /// 镜像文件格式。目前支持vhd，zvhd、zvhd2、raw，qcow2。默认取值为vhd
        /// </summary>
        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public DiskFormatEnum DiskFormat { get; set; }
        /// <summary>
        /// 镜像运行需要的最小磁盘，单位为GB 。必须大于镜像系统盘容量，否则创建云主机云服务器可能失败。
        /// </summary>
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 镜像运行需要的最小内存，单位为MB。参数取值依据云主机云服务器的规格限制。默认取值为0。
        /// </summary>
        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        /// <summary>
        /// 镜像名称，如果未指定name的取值，则默认为空，但是使用该镜像创建虚拟机会失败。名称的长度为1-255位。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像是否被保护，保护后的镜像不可删除。默认取值为false。
        /// </summary>
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        /// <summary>
        /// 镜像标签列表。长度为1-255位。默认为空。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 其他租户是否可见。默认取值为private。创建镜像元数据时，visibility取值只能为private。
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceCreateImageMetadataRequestBody {\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  containerFormat: ").Append(ContainerFormat).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceCreateImageMetadataRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceCreateImageMetadataRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.ContainerFormat == input.ContainerFormat ||
                    (this.ContainerFormat != null &&
                    this.ContainerFormat.Equals(input.ContainerFormat))
                ) && 
                (
                    this.DiskFormat == input.DiskFormat ||
                    (this.DiskFormat != null &&
                    this.DiskFormat.Equals(input.DiskFormat))
                ) && 
                (
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.MinRam == input.MinRam ||
                    (this.MinRam != null &&
                    this.MinRam.Equals(input.MinRam))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Protected == input.Protected ||
                    (this.Protected != null &&
                    this.Protected.Equals(input.Protected))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ContainerFormat != null)
                    hashCode = hashCode * 59 + this.ContainerFormat.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Protected != null)
                    hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                return hashCode;
            }
        }
    }
}
