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
    /// 快速通道创建镜像的请求体
    /// </summary>
    public class QuickImportImageByFileRequestBody 
    {
        /// <summary>
        /// 制作的镜像类型。系统盘镜像为ECS/BMS，数据盘镜像为DataImage. 制作数据盘镜像时该参数必选.
        /// </summary>
        /// <value>制作的镜像类型。系统盘镜像为ECS/BMS，数据盘镜像为DataImage. 制作数据盘镜像时该参数必选.</value>
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
            /// Enum DATAIMAGE for value: DataImage
            /// </summary>
            public static readonly TypeEnum DATAIMAGE = new TypeEnum("DataImage");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "ECS", ECS },
                { "BMS", BMS },
                { "DataImage", DATAIMAGE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 镜像的架构类型。取值包括： x86 arm 默认使用“x86”。
        /// </summary>
        /// <value>镜像的架构类型。取值包括： x86 arm 默认使用“x86”。</value>
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

            private string _value;

            public ArchitectureEnum()
            {

            }

            public ArchitectureEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 操作系统版本。 创建数据盘镜像时该参数取值为Linux或Windows，默认Linux。
        /// </summary>
        /// <value>操作系统版本。 创建数据盘镜像时该参数取值为Linux或Windows，默认Linux。</value>
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

            private static readonly Dictionary<string, OsTypeEnum> StaticFields =
            new Dictionary<string, OsTypeEnum>()
            {
                { "Linux", LINUX },
                { "Windows", WINDOWS },
            };

            private string _value;

            public OsTypeEnum()
            {

            }

            public OsTypeEnum(string value)
            {
                _value = value;
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 镜像名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 镜像描述信息。_description参数说明请参考镜像属性。支持字母、数字、中文等，不支持回车、&lt;、 &gt;，长度不能超过1024个字符。默认为空。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 操作系统版本。使用上传至OBS桶中的外部镜像文件制作镜像时生效
        /// </summary>
        [JsonProperty("os_version", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVersion { get; set; }

        /// <summary>
        /// OBS桶中外部镜像文件地址。在使用OBS桶的外部镜像文件制作镜像时生效且为必选字段。格式为&lt;OBS桶名&gt;:&lt;OBS镜像文件名称&gt;。注意：此处的OBS桶和镜像文件的存储类别必须是OBS标准存储。
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 最小系统盘大小。在使用OBS桶的外部镜像文件制作镜像时生效且为必选字段。取值为1至1024GB。
        /// </summary>
        [JsonProperty("min_disk", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinDisk { get; set; }

        /// <summary>
        /// 操作系统使用的许可证类型。取值范围： platform：华为云官方许可证 byol：自带许可证（Bring Your Own License） 目前仅Windows操作系统支持设置该参数。
        /// </summary>
        [JsonProperty("license_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LicenseType { get; set; }

        /// <summary>
        /// 镜像标签列表。默认为空。 tags和image_tags只能使用一个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 制作的镜像类型。系统盘镜像为ECS/BMS，数据盘镜像为DataImage. 制作数据盘镜像时该参数必选.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 表示当前镜像所属的企业项目。 取值为0或无该值，表示属于default企业项目。 取值为UUID，表示属于该UUID对应的企业项目。 关于企业项目ID的获取及企业项目特性的详细信息，请参考《企业管理用户指南》。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 镜像的架构类型。取值包括： x86 arm 默认使用“x86”。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public ArchitectureEnum Architecture { get; set; }
        /// <summary>
        /// 操作系统版本。 创建数据盘镜像时该参数取值为Linux或Windows，默认Linux。
        /// </summary>
        [JsonProperty("os_type", NullValueHandling = NullValueHandling.Ignore)]
        public OsTypeEnum OsType { get; set; }
        /// <summary>
        /// 新规范的镜像标签列表。默认为空。 tags和image_tags只能使用一个。
        /// </summary>
        [JsonProperty("image_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> ImageTags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickImportImageByFileRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  osVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  minDisk: ").Append(MinDisk).Append("\n");
            sb.Append("  licenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  osType: ").Append(OsType).Append("\n");
            sb.Append("  imageTags: ").Append(ImageTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QuickImportImageByFileRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QuickImportImageByFileRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.OsVersion != input.OsVersion || (this.OsVersion != null && !this.OsVersion.Equals(input.OsVersion))) return false;
            if (this.ImageUrl != input.ImageUrl || (this.ImageUrl != null && !this.ImageUrl.Equals(input.ImageUrl))) return false;
            if (this.MinDisk != input.MinDisk || (this.MinDisk != null && !this.MinDisk.Equals(input.MinDisk))) return false;
            if (this.LicenseType != input.LicenseType || (this.LicenseType != null && !this.LicenseType.Equals(input.LicenseType))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Type != input.Type) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Architecture != input.Architecture) return false;
            if (this.OsType != input.OsType) return false;
            if (this.ImageTags != input.ImageTags || (this.ImageTags != null && input.ImageTags != null && !this.ImageTags.SequenceEqual(input.ImageTags))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.OsVersion != null) hashCode = hashCode * 59 + this.OsVersion.GetHashCode();
                if (this.ImageUrl != null) hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MinDisk != null) hashCode = hashCode * 59 + this.MinDisk.GetHashCode();
                if (this.LicenseType != null) hashCode = hashCode * 59 + this.LicenseType.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                hashCode = hashCode * 59 + this.OsType.GetHashCode();
                if (this.ImageTags != null) hashCode = hashCode * 59 + this.ImageTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
