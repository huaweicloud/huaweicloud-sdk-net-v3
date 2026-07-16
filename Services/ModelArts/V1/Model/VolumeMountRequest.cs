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
    /// **参数解释**：实例的扩展存储配置 **约束限制**：最大数量为30。
    /// </summary>
    public class VolumeMountRequest 
    {
        /// <summary>
        /// **参数解释**：notebook支持的扩展存储类型，详见[[开发环境中如何选择存储](https://support.huaweicloud.com/usermanual-standard-modelarts/devtool-modelarts_0004.html#section7)](tag:hc)[[开发环境中如何选择存储](https://support.huaweicloud.com/intl/zh-cn/usermanual-standard-modelarts/devtool-modelarts_0004.html#section6)](tag:hk)[《用户指南》的“开发环境中如何选择存储”章节](tag:fcs,fcs-super) **约束限制**：不涉及 **默认取值**：不涉及。 **取值范围**：枚举类型，取值如下： - EVS：云硬盘 - OBS：对象存储服务 - OBSFS：并行文件系统（PFS） - EFS：弹性文件服务（SFS Turbo）
        /// </summary>
        /// <value>**参数解释**：notebook支持的扩展存储类型，详见[[开发环境中如何选择存储](https://support.huaweicloud.com/usermanual-standard-modelarts/devtool-modelarts_0004.html#section7)](tag:hc)[[开发环境中如何选择存储](https://support.huaweicloud.com/intl/zh-cn/usermanual-standard-modelarts/devtool-modelarts_0004.html#section6)](tag:hk)[《用户指南》的“开发环境中如何选择存储”章节](tag:fcs,fcs-super) **约束限制**：不涉及 **默认取值**：不涉及。 **取值范围**：枚举类型，取值如下： - EVS：云硬盘 - OBS：对象存储服务 - OBSFS：并行文件系统（PFS） - EFS：弹性文件服务（SFS Turbo）</value>
        [JsonConverter(typeof(EnumClassConverter<CategoryEnum>))]
        public class CategoryEnum
        {
            /// <summary>
            /// Enum OBS for value: OBS
            /// </summary>
            public static readonly CategoryEnum OBS = new CategoryEnum("OBS");

            /// <summary>
            /// Enum OBSFS for value: OBSFS
            /// </summary>
            public static readonly CategoryEnum OBSFS = new CategoryEnum("OBSFS");

            /// <summary>
            /// Enum EFS for value: EFS
            /// </summary>
            public static readonly CategoryEnum EFS = new CategoryEnum("EFS");

            private static readonly Dictionary<string, CategoryEnum> StaticFields =
            new Dictionary<string, CategoryEnum>()
            {
                { "OBS", OBS },
                { "OBSFS", OBSFS },
                { "EFS", EFS },
            };

            private string _value;

            public CategoryEnum()
            {

            }

            public CategoryEnum(string value)
            {
                _value = value;
            }

            public static CategoryEnum FromValue(string value)
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

                if (this.Equals(obj as CategoryEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CategoryEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CategoryEnum a, CategoryEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CategoryEnum a, CategoryEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**：资源所属 **参数约束**：不涉及。 **取值范围**：枚举类型，取值如下： - MANAGED：托管，即资源在服务上。 - DEDICATED：非托管，即资源在用户账号上，只有在category为EFS时支持。 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：资源所属 **参数约束**：不涉及。 **取值范围**：枚举类型，取值如下： - MANAGED：托管，即资源在服务上。 - DEDICATED：非托管，即资源在用户账号上，只有在category为EFS时支持。 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<OwnershipEnum>))]
        public class OwnershipEnum
        {
            /// <summary>
            /// Enum MANAGED for value: MANAGED
            /// </summary>
            public static readonly OwnershipEnum MANAGED = new OwnershipEnum("MANAGED");

            /// <summary>
            /// Enum DEDICATED for value: DEDICATED
            /// </summary>
            public static readonly OwnershipEnum DEDICATED = new OwnershipEnum("DEDICATED");

            private static readonly Dictionary<string, OwnershipEnum> StaticFields =
            new Dictionary<string, OwnershipEnum>()
            {
                { "MANAGED", MANAGED },
                { "DEDICATED", DEDICATED },
            };

            private string _value;

            public OwnershipEnum()
            {

            }

            public OwnershipEnum(string value)
            {
                _value = value;
            }

            public static OwnershipEnum FromValue(string value)
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

                if (this.Equals(obj as OwnershipEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OwnershipEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OwnershipEnum a, OwnershipEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OwnershipEnum a, OwnershipEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：notebook支持的扩展存储类型，详见[[开发环境中如何选择存储](https://support.huaweicloud.com/usermanual-standard-modelarts/devtool-modelarts_0004.html#section7)](tag:hc)[[开发环境中如何选择存储](https://support.huaweicloud.com/intl/zh-cn/usermanual-standard-modelarts/devtool-modelarts_0004.html#section6)](tag:hk)[《用户指南》的“开发环境中如何选择存储”章节](tag:fcs,fcs-super) **约束限制**：不涉及 **默认取值**：不涉及。 **取值范围**：枚举类型，取值如下： - EVS：云硬盘 - OBS：对象存储服务 - OBSFS：并行文件系统（PFS） - EFS：弹性文件服务（SFS Turbo）
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**：资源所属 **参数约束**：不涉及。 **取值范围**：枚举类型，取值如下： - MANAGED：托管，即资源在服务上。 - DEDICATED：非托管，即资源在用户账号上，只有在category为EFS时支持。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("ownership", NullValueHandling = NullValueHandling.Ignore)]
        public OwnershipEnum Ownership { get; set; }
        /// <summary>
        /// **参数解释**：EFS专属存储盘uri或OBS并行文件系统路径 - EFS：登录弹性文件服务控制台，在文件系统列表中，单击文件系统名称进入详情页。其中，“共享路径”即为此参数的参数值。 - OBS：并行文件系统命名格式为：obs://&lt;桶名&gt;/&lt;目录路径&gt;/。登录对象存储服务控制台，在并行文件系统列表中，文件系统名称为桶名。单击文件系统名称进入详情页，在文件栏选择特定目录后，单击右侧“更多/复制路径”，该路径即为目录路径。 **参数约束**：只有当category为EFS或OBS或OBSFS，同时ownership为DEDICATED时必填，最大长度1024字符
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**：EFS专属存储盘ID，参数值获取方式如下：登录弹性文件服务控制台，在文件系统列表中，单击文件系统名称进入详情页。其中，“ID”即为此参数的参数值。 **参数约束**：只有当category为EFS，同时ownership为DEDICATED时必填。必须符合 UUID 格式（如 280a8bd5-03e2-4a5c-bea1-83d81e75bc53）。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：在Notebook实例中挂载的路径 **参数约束**：最大长度 256 字符
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释**：扩展存储挂载目录是否只读。默认值为false，可读写 **参数约束**：不涉及
        /// </summary>
        [JsonProperty("read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// **参数解释**：DEW存储的用户AKSK凭据名称 **参数约束**：当category为OBS时必填，仅支持大小写字母、数字、中划线、下划线，长度 1-64 字符
        /// </summary>
        [JsonProperty("dew_secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DewSecretName { get; set; }

        /// <summary>
        /// **参数解释**：EVS云硬盘存储容量，单位GB。 **约束限制**：category为EVS时有效。 **取值范围**：不涉及。 **默认取值**：5。
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Capacity { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeMountRequest {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  ownership: ").Append(Ownership).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  readOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  dewSecretName: ").Append(DewSecretName).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeMountRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeMountRequest input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.Ownership != input.Ownership) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.ReadOnly != input.ReadOnly || (this.ReadOnly != null && !this.ReadOnly.Equals(input.ReadOnly))) return false;
            if (this.DewSecretName != input.DewSecretName || (this.DewSecretName != null && !this.DewSecretName.Equals(input.DewSecretName))) return false;
            if (this.Capacity != input.Capacity || (this.Capacity != null && !this.Capacity.Equals(input.Capacity))) return false;

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
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.ReadOnly != null) hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.DewSecretName != null) hashCode = hashCode * 59 + this.DewSecretName.GetHashCode();
                if (this.Capacity != null) hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                return hashCode;
            }
        }
    }
}
