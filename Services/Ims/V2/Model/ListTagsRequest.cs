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
    public class ListTagsRequest 
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
        /// Defines memberStatus
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<MemberStatusEnum>))]
        public class MemberStatusEnum
        {
            /// <summary>
            /// Enum ACCEPTED for value: accepted
            /// </summary>
            public static readonly MemberStatusEnum ACCEPTED = new MemberStatusEnum("accepted");

            /// <summary>
            /// Enum REJECTED for value: rejected
            /// </summary>
            public static readonly MemberStatusEnum REJECTED = new MemberStatusEnum("rejected");

            /// <summary>
            /// Enum PENDING for value: pending
            /// </summary>
            public static readonly MemberStatusEnum PENDING = new MemberStatusEnum("pending");

            private static readonly Dictionary<string, MemberStatusEnum> StaticFields =
            new Dictionary<string, MemberStatusEnum>()
            {
                { "accepted", ACCEPTED },
                { "rejected", REJECTED },
                { "pending", PENDING },
            };

            private string Value;

            private MemberStatusEnum(string value)
            {
                this.Value = value;
            }

            public static MemberStatusEnum FromValue(string value)
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

                if (this.Equals(obj as MemberStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MemberStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(MemberStatusEnum a, MemberStatusEnum b)
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

            public static bool operator !=(MemberStatusEnum a, MemberStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines virtualEnvType
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<VirtualEnvTypeEnum>))]
        public class VirtualEnvTypeEnum
        {
            /// <summary>
            /// Enum FUSIONCOMPUTE for value: FusionCompute
            /// </summary>
            public static readonly VirtualEnvTypeEnum FUSIONCOMPUTE = new VirtualEnvTypeEnum("FusionCompute");

            /// <summary>
            /// Enum IRONIC for value: Ironic
            /// </summary>
            public static readonly VirtualEnvTypeEnum IRONIC = new VirtualEnvTypeEnum("Ironic");

            /// <summary>
            /// Enum DATAIMAGE for value: DataImage
            /// </summary>
            public static readonly VirtualEnvTypeEnum DATAIMAGE = new VirtualEnvTypeEnum("DataImage");

            private static readonly Dictionary<string, VirtualEnvTypeEnum> StaticFields =
            new Dictionary<string, VirtualEnvTypeEnum>()
            {
                { "FusionCompute", FUSIONCOMPUTE },
                { "Ironic", IRONIC },
                { "DataImage", DATAIMAGE },
            };

            private string Value;

            private VirtualEnvTypeEnum(string value)
            {
                this.Value = value;
            }

            public static VirtualEnvTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VirtualEnvTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VirtualEnvTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(VirtualEnvTypeEnum a, VirtualEnvTypeEnum b)
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

            public static bool operator !=(VirtualEnvTypeEnum a, VirtualEnvTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Defines architecture
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ArchitectureEnum>))]
        public class ArchitectureEnum
        {
            /// <summary>
            /// Enum X86 for value: x86
            /// </summary>
            public static readonly ArchitectureEnum X86 = new ArchitectureEnum("x86");

            /// <summary>
            /// Enum ARM for value: arm
            /// </summary>
            public static readonly ArchitectureEnum ARM = new ArchitectureEnum("arm");

            private static readonly Dictionary<string, ArchitectureEnum> StaticFields =
            new Dictionary<string, ArchitectureEnum>()
            {
                { "x86", X86 },
                { "arm", ARM },
            };

            private string Value;

            private ArchitectureEnum(string value)
            {
                this.Value = value;
            }

            public static ArchitectureEnum FromValue(string value)
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

                if (this.Equals(obj as ArchitectureEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ArchitectureEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ArchitectureEnum a, ArchitectureEnum b)
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

            public static bool operator !=(ArchitectureEnum a, ArchitectureEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__imagetype", IsQuery = true)]
        [JsonProperty("__imagetype", NullValueHandling = NullValueHandling.Ignore)]
        public ImagetypeEnum Imagetype { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("min_disk", IsQuery = true)]
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__platform", IsQuery = true)]
        [JsonProperty("__platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("__os_type", IsQuery = true)]
        [JsonProperty("__os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("member_status", IsQuery = true)]
        [JsonProperty("member_status", NullValueHandling = NullValueHandling.Ignore)]
        public MemberStatusEnum MemberStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("virtual_env_type", IsQuery = true)]
        [JsonProperty("virtual_env_type", NullValueHandling = NullValueHandling.Ignore)]
        public VirtualEnvTypeEnum VirtualEnvType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("architecture", IsQuery = true)]
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public ArchitectureEnum Architecture { get; set; }
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
            sb.Append("class ListTagsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  imagetype: ").Append(Imagetype).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  memberStatus: ").Append(MemberStatus).Append("\n");
            sb.Append("  virtualEnvType: ").Append(VirtualEnvType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
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
            return this.Equals(input as ListTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTagsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Imagetype == input.Imagetype ||
                    (this.Imagetype != null &&
                    this.Imagetype.Equals(input.Imagetype))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.OsType == input.OsType ||
                    (this.OsType != null &&
                    this.OsType.Equals(input.OsType))
                ) && 
                (
                    this.MemberStatus == input.MemberStatus ||
                    (this.MemberStatus != null &&
                    this.MemberStatus.Equals(input.MemberStatus))
                ) && 
                (
                    this.VirtualEnvType == input.VirtualEnvType ||
                    (this.VirtualEnvType != null &&
                    this.VirtualEnvType.Equals(input.VirtualEnvType))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Imagetype != null)
                    hashCode = hashCode * 59 + this.Imagetype.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.Platform != null)
                    hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.OsType != null)
                    hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.MemberStatus != null)
                    hashCode = hashCode * 59 + this.MemberStatus.GetHashCode();
                if (this.VirtualEnvType != null)
                    hashCode = hashCode * 59 + this.VirtualEnvType.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
