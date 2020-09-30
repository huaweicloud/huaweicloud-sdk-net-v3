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
    /// Request Object
    /// </summary>
    public class GlanceListImagesRequest 
    {
        /// <summary>
        /// Defines imagetype
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ImagetypeEnum>))]
        public class ImagetypeEnum
        {
            /// <summary>
            /// Enum GOLD for value: gold
            /// </summary>
            public static readonly ImagetypeEnum GOLD = new ImagetypeEnum("gold");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly ImagetypeEnum PRIVATE = new ImagetypeEnum("private");

            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly ImagetypeEnum SHARED = new ImagetypeEnum("shared");

            private static readonly Dictionary<string, ImagetypeEnum> StaticFields =
            new Dictionary<string, ImagetypeEnum>()
            {
                { "gold", GOLD },
                { "private", PRIVATE },
                { "shared", SHARED },
            };

            private string Value;

            private ImagetypeEnum(string value)
            {
                this.Value = value;
            }

            public static ImagetypeEnum FromValue(string value)
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

                if (this.Equals(obj as ImagetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImagetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ImagetypeEnum a, ImagetypeEnum b)
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

            public static bool operator !=(ImagetypeEnum a, ImagetypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines osBit
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<OsBitEnum>))]
        public class OsBitEnum
        {
            /// <summary>
            /// Enum _32 for value: 32
            /// </summary>
            public static readonly OsBitEnum _32 = new OsBitEnum("32");

            /// <summary>
            /// Enum _64 for value: 64
            /// </summary>
            public static readonly OsBitEnum _64 = new OsBitEnum("64");

            private static readonly Dictionary<string, OsBitEnum> StaticFields =
            new Dictionary<string, OsBitEnum>()
            {
                { "32", _32 },
                { "64", _64 },
            };

            private string Value;

            private OsBitEnum(string value)
            {
                this.Value = value;
            }

            public static OsBitEnum FromValue(string value)
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

                if (this.Equals(obj as OsBitEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsBitEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OsBitEnum a, OsBitEnum b)
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

            public static bool operator !=(OsBitEnum a, OsBitEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines osType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<OsTypeEnum>))]
        public class OsTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: Linux
            /// </summary>
            public static readonly OsTypeEnum LINUX = new OsTypeEnum("Linux");

            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly OsTypeEnum WINDOWS = new OsTypeEnum("Windows");

            /// <summary>
            /// Enum OTHER for value: Other
            /// </summary>
            public static readonly OsTypeEnum OTHER = new OsTypeEnum("Other");

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "Linux", LINUX },
                { "Windows", WINDOWS },
                { "Other", OTHER },
            };

            private string Value;

            private OsTypeEnum(string value)
            {
                this.Value = value;
            }

            public static OsTypeEnum FromValue(string value)
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
        /// Defines platform
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<PlatformEnum>))]
        public class PlatformEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: Windows
            /// </summary>
            public static readonly PlatformEnum WINDOWS = new PlatformEnum("Windows");

            /// <summary>
            /// Enum UBUNTU for value: Ubuntu
            /// </summary>
            public static readonly PlatformEnum UBUNTU = new PlatformEnum("Ubuntu");

            /// <summary>
            /// Enum REDHAT for value: RedHat
            /// </summary>
            public static readonly PlatformEnum REDHAT = new PlatformEnum("RedHat");

            /// <summary>
            /// Enum SUSE for value: SUSE
            /// </summary>
            public static readonly PlatformEnum SUSE = new PlatformEnum("SUSE");

            /// <summary>
            /// Enum CENTOS for value: CentOS
            /// </summary>
            public static readonly PlatformEnum CENTOS = new PlatformEnum("CentOS");

            /// <summary>
            /// Enum DEBIAN for value: Debian
            /// </summary>
            public static readonly PlatformEnum DEBIAN = new PlatformEnum("Debian");

            /// <summary>
            /// Enum OPENSUSE for value: OpenSUSE
            /// </summary>
            public static readonly PlatformEnum OPENSUSE = new PlatformEnum("OpenSUSE");

            /// <summary>
            /// Enum ORACLE_LINUX for value: Oracle Linux
            /// </summary>
            public static readonly PlatformEnum ORACLE_LINUX = new PlatformEnum("Oracle Linux");

            /// <summary>
            /// Enum FEDORA for value: Fedora
            /// </summary>
            public static readonly PlatformEnum FEDORA = new PlatformEnum("Fedora");

            /// <summary>
            /// Enum OTHER for value: Other
            /// </summary>
            public static readonly PlatformEnum OTHER = new PlatformEnum("Other");

            /// <summary>
            /// Enum COREOS for value: CoreOS
            /// </summary>
            public static readonly PlatformEnum COREOS = new PlatformEnum("CoreOS");

            /// <summary>
            /// Enum EULEOS for value: EuleOS
            /// </summary>
            public static readonly PlatformEnum EULEOS = new PlatformEnum("EuleOS");

            private static readonly Dictionary<string, PlatformEnum> StaticFields =
            new Dictionary<string, PlatformEnum>()
            {
                { "Windows", WINDOWS },
                { "Ubuntu", UBUNTU },
                { "RedHat", REDHAT },
                { "SUSE", SUSE },
                { "CentOS", CENTOS },
                { "Debian", DEBIAN },
                { "OpenSUSE", OPENSUSE },
                { "Oracle Linux", ORACLE_LINUX },
                { "Fedora", FEDORA },
                { "Other", OTHER },
                { "CoreOS", COREOS },
                { "EuleOS", EULEOS },
            };

            private string Value;

            private PlatformEnum(string value)
            {
                this.Value = value;
            }

            public static PlatformEnum FromValue(string value)
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

                if (this.Equals(obj as PlatformEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlatformEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PlatformEnum a, PlatformEnum b)
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

            public static bool operator !=(PlatformEnum a, PlatformEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines diskFormat
        /// </summary>
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
                { "raw", RAW },
                { "qcow2", QCOW2 },
            };

            private string Value;

            private DiskFormatEnum(string value)
            {
                this.Value = value;
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
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum QUEUED for value: queued
            /// </summary>
            public static readonly StatusEnum QUEUED = new StatusEnum("queued");

            /// <summary>
            /// Enum SAVING for value: saving
            /// </summary>
            public static readonly StatusEnum SAVING = new StatusEnum("saving");

            /// <summary>
            /// Enum DELETED for value: deleted
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("deleted");

            /// <summary>
            /// Enum KILLED for value: killed
            /// </summary>
            public static readonly StatusEnum KILLED = new StatusEnum("killed");

            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("active");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "queued", QUEUED },
                { "saving", SAVING },
                { "deleted", DELETED },
                { "killed", KILLED },
                { "active", ACTIVE },
            };

            private string Value;

            private StatusEnum(string value)
            {
                this.Value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines visibility
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<VisibilityEnum>))]
        public class VisibilityEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly VisibilityEnum PUBLIC = new VisibilityEnum("public");

            /// <summary>
            /// Enum PRIVATE for value: private
            /// </summary>
            public static readonly VisibilityEnum PRIVATE = new VisibilityEnum("private");

            /// <summary>
            /// Enum SHARED for value: shared
            /// </summary>
            public static readonly VisibilityEnum SHARED = new VisibilityEnum("shared");

            private static readonly Dictionary<string, VisibilityEnum> StaticFields =
            new Dictionary<string, VisibilityEnum>()
            {
                { "public", PUBLIC },
                { "private", PRIVATE },
                { "shared", SHARED },
            };

            private string Value;

            private VisibilityEnum(string value)
            {
                this.Value = value;
            }

            public static VisibilityEnum FromValue(string value)
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

                if (this.Equals(obj as VisibilityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VisibilityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(VisibilityEnum a, VisibilityEnum b)
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

            public static bool operator !=(VisibilityEnum a, VisibilityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__imagetype", IsQuery = true)]
        [JsonProperty("__imagetype", NullValueHandling = NullValueHandling.Ignore)]
        public ImagetypeEnum Imagetype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__isregistered", IsQuery = true)]
        [JsonProperty("__isregistered", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isregistered { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__os_bit", IsQuery = true)]
        [JsonProperty("__os_bit", NullValueHandling = NullValueHandling.Ignore)]
        public OsBitEnum OsBit { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__os_type", IsQuery = true)]
        [JsonProperty("__os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__platform", IsQuery = true)]
        [JsonProperty("__platform", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformEnum Platform { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_diskintensive", IsQuery = true)]
        [JsonProperty("__support_diskintensive", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportDiskintensive { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_highperformance", IsQuery = true)]
        [JsonProperty("__support_highperformance", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportHighperformance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_kvm", IsQuery = true)]
        [JsonProperty("__support_kvm", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportKvm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_kvm_gpu_type", IsQuery = true)]
        [JsonProperty("__support_kvm_gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportKvmGpuType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_kvm_infiniband", IsQuery = true)]
        [JsonProperty("__support_kvm_infiniband", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportKvmInfiniband { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_largememory", IsQuery = true)]
        [JsonProperty("__support_largememory", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportLargememory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_xen", IsQuery = true)]
        [JsonProperty("__support_xen", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportXen { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_xen_gpu_type", IsQuery = true)]
        [JsonProperty("__support_xen_gpu_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportXenGpuType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__support_xen_hana", IsQuery = true)]
        [JsonProperty("__support_xen_hana", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportXenHana { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("container_format", IsQuery = true)]
        [JsonProperty("container_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("disk_format", IsQuery = true)]
        [JsonProperty("disk_format", NullValueHandling = NullValueHandling.Ignore)]
        public DiskFormatEnum DiskFormat { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("member_status", IsQuery = true)]
        [JsonProperty("member_status", NullValueHandling = NullValueHandling.Ignore)]
        public string MemberStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("min_disk", IsQuery = true)]
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("min_ram", IsQuery = true)]
        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("owner", IsQuery = true)]
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public string Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("protected", IsQuery = true)]
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public string SortDir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("visibility", IsQuery = true)]
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public VisibilityEnum Visibility { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("created_at", IsQuery = true)]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("updated_at", IsQuery = true)]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlanceListImagesRequest {\n");
            sb.Append("  imagetype: ").Append(Imagetype).Append("\n");
            sb.Append("  isregistered: ").Append(Isregistered).Append("\n");
            sb.Append("  osBit: ").Append(OsBit).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  supportDiskintensive: ").Append(SupportDiskintensive).Append("\n");
            sb.Append("  supportHighperformance: ").Append(SupportHighperformance).Append("\n");
            sb.Append("  supportKvm: ").Append(SupportKvm).Append("\n");
            sb.Append("  supportKvmGpuType: ").Append(SupportKvmGpuType).Append("\n");
            sb.Append("  supportKvmInfiniband: ").Append(SupportKvmInfiniband).Append("\n");
            sb.Append("  supportLargememory: ").Append(SupportLargememory).Append("\n");
            sb.Append("  supportXen: ").Append(SupportXen).Append("\n");
            sb.Append("  supportXenGpuType: ").Append(SupportXenGpuType).Append("\n");
            sb.Append("  supportXenHana: ").Append(SupportXenHana).Append("\n");
            sb.Append("  containerFormat: ").Append(ContainerFormat).Append("\n");
            sb.Append("  diskFormat: ").Append(DiskFormat).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  memberStatus: ").Append(MemberStatus).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  visibility: ").Append(Visibility).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlanceListImagesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlanceListImagesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Imagetype == input.Imagetype ||
                    (this.Imagetype != null &&
                    this.Imagetype.Equals(input.Imagetype))
                ) && 
                (
                    this.Isregistered == input.Isregistered ||
                    (this.Isregistered != null &&
                    this.Isregistered.Equals(input.Isregistered))
                ) && 
                (
                    this.OsBit == input.OsBit ||
                    (this.OsBit != null &&
                    this.OsBit.Equals(input.OsBit))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.SupportDiskintensive == input.SupportDiskintensive ||
                    (this.SupportDiskintensive != null &&
                    this.SupportDiskintensive.Equals(input.SupportDiskintensive))
                ) && 
                (
                    this.SupportHighperformance == input.SupportHighperformance ||
                    (this.SupportHighperformance != null &&
                    this.SupportHighperformance.Equals(input.SupportHighperformance))
                ) && 
                (
                    this.SupportKvm == input.SupportKvm ||
                    (this.SupportKvm != null &&
                    this.SupportKvm.Equals(input.SupportKvm))
                ) && 
                (
                    this.SupportKvmGpuType == input.SupportKvmGpuType ||
                    (this.SupportKvmGpuType != null &&
                    this.SupportKvmGpuType.Equals(input.SupportKvmGpuType))
                ) && 
                (
                    this.SupportKvmInfiniband == input.SupportKvmInfiniband ||
                    (this.SupportKvmInfiniband != null &&
                    this.SupportKvmInfiniband.Equals(input.SupportKvmInfiniband))
                ) && 
                (
                    this.SupportLargememory == input.SupportLargememory ||
                    (this.SupportLargememory != null &&
                    this.SupportLargememory.Equals(input.SupportLargememory))
                ) && 
                (
                    this.SupportXen == input.SupportXen ||
                    (this.SupportXen != null &&
                    this.SupportXen.Equals(input.SupportXen))
                ) && 
                (
                    this.SupportXenGpuType == input.SupportXenGpuType ||
                    (this.SupportXenGpuType != null &&
                    this.SupportXenGpuType.Equals(input.SupportXenGpuType))
                ) && 
                (
                    this.SupportXenHana == input.SupportXenHana ||
                    (this.SupportXenHana != null &&
                    this.SupportXenHana.Equals(input.SupportXenHana))
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.MemberStatus == input.MemberStatus ||
                    (this.MemberStatus != null &&
                    this.MemberStatus.Equals(input.MemberStatus))
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
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
                ) && 
                (
                    this.Protected == input.Protected ||
                    (this.Protected != null &&
                    this.Protected.Equals(input.Protected))
                ) && 
                (
                    this.SortDir == input.SortDir ||
                    (this.SortDir != null &&
                    this.SortDir.Equals(input.SortDir))
                ) && 
                (
                    this.SortKey == input.SortKey ||
                    (this.SortKey != null &&
                    this.SortKey.Equals(input.SortKey))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Imagetype != null)
                    hashCode = hashCode * 59 + this.Imagetype.GetHashCode();
                if (this.Isregistered != null)
                    hashCode = hashCode * 59 + this.Isregistered.GetHashCode();
                if (this.OsBit != null)
                    hashCode = hashCode * 59 + this.OsBit.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.SupportDiskintensive != null)
                    hashCode = hashCode * 59 + this.SupportDiskintensive.GetHashCode();
                if (this.SupportHighperformance != null)
                    hashCode = hashCode * 59 + this.SupportHighperformance.GetHashCode();
                if (this.SupportKvm != null)
                    hashCode = hashCode * 59 + this.SupportKvm.GetHashCode();
                if (this.SupportKvmGpuType != null)
                    hashCode = hashCode * 59 + this.SupportKvmGpuType.GetHashCode();
                if (this.SupportKvmInfiniband != null)
                    hashCode = hashCode * 59 + this.SupportKvmInfiniband.GetHashCode();
                if (this.SupportLargememory != null)
                    hashCode = hashCode * 59 + this.SupportLargememory.GetHashCode();
                if (this.SupportXen != null)
                    hashCode = hashCode * 59 + this.SupportXen.GetHashCode();
                if (this.SupportXenGpuType != null)
                    hashCode = hashCode * 59 + this.SupportXenGpuType.GetHashCode();
                if (this.SupportXenHana != null)
                    hashCode = hashCode * 59 + this.SupportXenHana.GetHashCode();
                if (this.ContainerFormat != null)
                    hashCode = hashCode * 59 + this.ContainerFormat.GetHashCode();
                if (this.DiskFormat != null)
                    hashCode = hashCode * 59 + this.DiskFormat.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.MemberStatus != null)
                    hashCode = hashCode * 59 + this.MemberStatus.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Protected != null)
                    hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.SortDir != null)
                    hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.SortKey != null)
                    hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
