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
    /// 创建镜像请求参数体
    /// </summary>
    public class CreateImageRequestBody 
    {
        /// <summary>
        /// 镜像的类型。 取值为ECS、BMS、FusionCompute、Ironic。默认使用“ECS”。 ECS/FusionCompute：表示是ECS服务器的镜像。 BMS/Ironic：表示是BMS服务器的镜像。
        /// </summary>
        /// <value>镜像的类型。 取值为ECS、BMS、FusionCompute、Ironic。默认使用“ECS”。 ECS/FusionCompute：表示是ECS服务器的镜像。 BMS/Ironic：表示是BMS服务器的镜像。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly TypeEnum ECS = new TypeEnum("ECS");

            /// <summary>
            /// Enum BMS for value: BMS
            /// </summary>
            public static readonly TypeEnum BMS = new TypeEnum("BMS");

            /// <summary>
            /// Enum FUSIONCOMPUTE for value: FusionCompute
            /// </summary>
            public static readonly TypeEnum FUSIONCOMPUTE = new TypeEnum("FusionCompute");

            /// <summary>
            /// Enum IRONIC for value: Ironic
            /// </summary>
            public static readonly TypeEnum IRONIC = new TypeEnum("Ironic");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ECS", ECS },
                { "BMS", BMS },
                { "FusionCompute", FUSIONCOMPUTE },
                { "Ironic", IRONIC },
            };

            private string Value;

            private TypeEnum(string value)
            {
                this.Value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 镜像的架构类型。取值包括： x86 arm 默认使用“x86”。 当架构类型为arm时，镜像引导方式将自动转为UEFI的引导方式。
        /// </summary>
        /// <value>镜像的架构类型。取值包括： x86 arm 默认使用“x86”。 当架构类型为arm时，镜像引导方式将自动转为UEFI的引导方式。</value>
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
        /// 需要转换的数据盘信息，其中，当使用云服务器上的数据盘进行私有数据盘镜像创建时，该字段必选。 如果不是用于制作数据盘镜像，该字段默认为空。
        /// </summary>
        [JsonProperty("data_images", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateDataImage> DataImages { get; set; }

        /// <summary>
        /// 镜像描述信息。支持字母、数字、中文等，不支持回车、&lt;、 &gt;，长度不能超过1024个字符。默认为空。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 表示当前镜像所属的企业项目。取值为0或无该值，表示属于default企业项目。取值为UUID，表示属于该UUID对应的企业项目。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 新规范的镜像标签列表。默认为空。tags和image_tags只能使用一个。
        /// </summary>
        [JsonProperty("image_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagKeyValue> ImageTags { get; set; }

        /// <summary>
        /// 需要转换的云服务器ID。使用instance_id字段，从云服务器制作私有镜像时，该字段填写云服务器ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像标签列表。默认为空。tags和image_tags只能使用一个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 表示镜像支持的最大内存，单位为MB。
        /// </summary>
        [JsonProperty("max_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRam { get; set; }

        /// <summary>
        /// 表示镜像支持的最小内存，单位为MB，默认为0，表示不受限制。
        /// </summary>
        [JsonProperty("min_ram", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinRam { get; set; }

        /// <summary>
        /// 操作系统版本。 使用上传至OBS桶中的外部镜像文件制作镜像时生效。 当“is_quick_import”的值为“true”时，即使用镜像文件快速导入方式导入系统盘镜像，则该参数为必填参数。
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// OBS桶中外部镜像文件地址。 在使用OBS桶的外部镜像文件制作镜像时生效且为必选字段。格式为&lt;OBS桶名&gt;:&lt;OBS镜像文件名称&gt;。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 最小系统盘大小。 在使用OBS桶的外部镜像文件制作镜像时生效且为必选字段。取值为40～1024GB。
        /// </summary>
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 是否自动配置。 取值为true或false。 如果需要后台自动配置，取值为true，否则为false。默认取值为false。
        /// </summary>
        [JsonProperty("is_config", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsConfig { get; set; }

        /// <summary>
        /// 创建加密镜像的用户主密钥，具体取值请参考《密钥管理服务用户指南》获取。
        /// </summary>
        [JsonProperty("cmk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CmkId { get; set; }

        /// <summary>
        /// 镜像的类型。 取值为ECS、BMS、FusionCompute、Ironic。默认使用“ECS”。 ECS/FusionCompute：表示是ECS服务器的镜像。 BMS/Ironic：表示是BMS服务器的镜像。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 是否使用镜像文件快速导入方式，导入系统盘镜像。 是，配置为true。 否，配置为false。 关于镜像文件快速导入的约束与限制请参见镜像文件快速导入。
        /// </summary>
        [JsonProperty("is_quick_import", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQuickImport { get; set; }

        /// <summary>
        /// 镜像的架构类型。取值包括： x86 arm 默认使用“x86”。 当架构类型为arm时，镜像引导方式将自动转为UEFI的引导方式。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public ArchitectureEnum Architecture { get; set; }
        /// <summary>
        /// 数据盘的卷ID。当数据盘创建系统盘镜像时，该参数必选
        /// </summary>
        [JsonProperty("volume_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateImageRequestBody {\n");
            sb.Append("  dataImages: ").Append(DataImages).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  imageTags: ").Append(ImageTags).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  maxRam: ").Append(MaxRam).Append("\n");
            sb.Append("  minRam: ").Append(MinRam).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  isConfig: ").Append(IsConfig).Append("\n");
            sb.Append("  cmkId: ").Append(CmkId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  isQuickImport: ").Append(IsQuickImport).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  volumeId: ").Append(VolumeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateImageRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateImageRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataImages == input.DataImages ||
                    this.DataImages != null &&
                    input.DataImages != null &&
                    this.DataImages.SequenceEqual(input.DataImages)
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
                    this.ImageTags == input.ImageTags ||
                    this.ImageTags != null &&
                    input.ImageTags != null &&
                    this.ImageTags.SequenceEqual(input.ImageTags)
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.MaxRam == input.MaxRam ||
                    (this.MaxRam != null &&
                    this.MaxRam.Equals(input.MaxRam))
                ) && 
                (
                    this.MinRam == input.MinRam ||
                    (this.MinRam != null &&
                    this.MinRam.Equals(input.MinRam))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MinDisk == input.MinDisk ||
                    (this.MinDisk != null &&
                    this.MinDisk.Equals(input.MinDisk))
                ) && 
                (
                    this.IsConfig == input.IsConfig ||
                    (this.IsConfig != null &&
                    this.IsConfig.Equals(input.IsConfig))
                ) && 
                (
                    this.CmkId == input.CmkId ||
                    (this.CmkId != null &&
                    this.CmkId.Equals(input.CmkId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsQuickImport == input.IsQuickImport ||
                    (this.IsQuickImport != null &&
                    this.IsQuickImport.Equals(input.IsQuickImport))
                ) && 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
                ) && 
                (
                    this.VolumeId == input.VolumeId ||
                    (this.VolumeId != null &&
                    this.VolumeId.Equals(input.VolumeId))
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
                if (this.DataImages != null)
                    hashCode = hashCode * 59 + this.DataImages.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ImageTags != null)
                    hashCode = hashCode * 59 + this.ImageTags.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.MaxRam != null)
                    hashCode = hashCode * 59 + this.MaxRam.GetHashCode();
                if (this.MinRam != null)
                    hashCode = hashCode * 59 + this.MinRam.GetHashCode();
                if (this.OsVersion != null)
                    hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MinDisk != null)
                    hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.IsConfig != null)
                    hashCode = hashCode * 59 + this.IsConfig.GetHashCode();
                if (this.CmkId != null)
                    hashCode = hashCode * 59 + this.CmkId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsQuickImport != null)
                    hashCode = hashCode * 59 + this.IsQuickImport.GetHashCode();
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.VolumeId != null)
                    hashCode = hashCode * 59 + this.VolumeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
