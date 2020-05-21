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
    /// 将云硬盘导出为镜像的请求参数。
    /// </summary>
    public class CinderExportToImageOption 
    {
        /// <summary>
        /// 云硬盘导出镜像的容器类型。  目前支持ami、ari、aki、ovf、bare。默认是bare。
        /// </summary>
        /// <value>云硬盘导出镜像的容器类型。  目前支持ami、ari、aki、ovf、bare。默认是bare。</value>
        [JsonConverter(typeof(EnumClassConverter<ContainerFormatEnum>))]
        public class ContainerFormatEnum
        {
            /// <summary>
            /// Enum AMI for value: ami
            /// </summary>
            public static readonly ContainerFormatEnum AMI = new ContainerFormatEnum("ami");

            /// <summary>
            /// Enum ARI for value: ari
            /// </summary>
            public static readonly ContainerFormatEnum ARI = new ContainerFormatEnum("ari");

            /// <summary>
            /// Enum AKI for value: aki
            /// </summary>
            public static readonly ContainerFormatEnum AKI = new ContainerFormatEnum("aki");

            /// <summary>
            /// Enum OVF for value: ovf
            /// </summary>
            public static readonly ContainerFormatEnum OVF = new ContainerFormatEnum("ovf");

            /// <summary>
            /// Enum BARE for value: bare
            /// </summary>
            public static readonly ContainerFormatEnum BARE = new ContainerFormatEnum("bare");

            public static readonly Dictionary<string, ContainerFormatEnum> StaticFields =
            new Dictionary<string, ContainerFormatEnum>()
            {
                {"ami", AMI},
                {"ari", ARI},
                {"aki", AKI},
                {"ovf", OVF},
                {"bare", BARE},
            };

            private string Value;

            public ContainerFormatEnum(string Value)
            {
                this.Value = Value;
            }

            public static ContainerFormatEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
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

                if (this.Equals(obj as ContainerFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ContainerFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ContainerFormatEnum a, ContainerFormatEnum b)
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

            public static bool operator !=(ContainerFormatEnum a, ContainerFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 云硬盘导出镜像的格式。  目前支持vhd、zvhd、zvhd2、raw、qcow2。默认是vhd。
        /// </summary>
        /// <value>云硬盘导出镜像的格式。  目前支持vhd、zvhd、zvhd2、raw、qcow2。默认是vhd。</value>
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

            public static readonly Dictionary<string, DiskFormatEnum> StaticFields =
            new Dictionary<string, DiskFormatEnum>()
            {
                {"vhd", VHD},
                {"zvhd", ZVHD},
                {"zvhd2", ZVHD2},
                {"raw", RAW},
                {"qcow2", QCOW2},
            };

            private string Value;

            public DiskFormatEnum(string Value)
            {
                this.Value = Value;
            }

            public static DiskFormatEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
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
        /// 云硬盘导出镜像的系统类型。目前只支持“windows”和“linux”，默认值是“linux”。 只有云硬盘的volume_image_metadata信息中无“__os_type”字段且云硬盘状态为“available”时，设置的__os_type才会生效。
        /// </summary>
        /// <value>云硬盘导出镜像的系统类型。目前只支持“windows”和“linux”，默认值是“linux”。 只有云硬盘的volume_image_metadata信息中无“__os_type”字段且云硬盘状态为“available”时，设置的__os_type才会生效。</value>
        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("windows");

            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("linux");

            public static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                {"windows", WINDOWS},
                {"linux", LINUX},
            };

            private string Value;

            public OsTypeEnum(string Value)
            {
                this.Value = Value;
            }

            public static OsTypeEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
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

                if (this.Equals(obj as OsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OsTypeEnum a, OsTypeEnum b)
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

            public static bool operator !=(OsTypeEnum a, OsTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云硬盘导出镜像的容器类型。  目前支持ami、ari、aki、ovf、bare。默认是bare。
        /// </summary>
        [JsonProperty("container_format", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerFormatEnum ContainerFormat { get; set; }
        /// <summary>
        /// 云硬盘导出镜像的格式。  目前支持vhd、zvhd、zvhd2、raw、qcow2。默认是vhd。
        /// </summary>
        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public DiskFormatEnum DiskFormat { get; set; }
        /// <summary>
        /// 强制导出镜像的标示，默认值是false。  当force标记为false时，云硬盘处于正在使用状态时，不能强制导出镜像。 当force标记为true时，即使云硬盘处于正在使用状态时，仍可以导出镜像。
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <summary>
        /// 云硬盘导出镜像的名称。  名称的长度范围为1～128位。 名称只能包含以下字符：大写字母、小写字母、中文、数字、特殊字符包含“-”、“.”、“_”和空格。
        /// </summary>
        [JsonProperty("image_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageName { get; set; }

        /// <summary>
        /// 云硬盘导出镜像的系统类型。目前只支持“windows”和“linux”，默认值是“linux”。 只有云硬盘的volume_image_metadata信息中无“__os_type”字段且云硬盘状态为“available”时，设置的__os_type才会生效。
        /// </summary>
        [JsonProperty("__os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderExportToImageOption {\n");
            sb.Append("  containerFormat: ").Append(ContainerFormat).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  force: ").Append(Force).Append("\n");
            sb.Append("  imageName: ").Append(ImageName).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderExportToImageOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderExportToImageOption input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Force == input.Force ||
                    (this.Force != null &&
                    this.Force.Equals(input.Force))
                ) && 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
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
                if (this.ContainerFormat != null)
                    hashCode = hashCode * 59 + this.ContainerFormat.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.Force != null)
                    hashCode = hashCode * 59 + this.Force.GetHashCode();
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                return hashCode;
            }
        }
    }
}
