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
    /// **参数解释**：实例存储信息。
    /// </summary>
    public class VolumeRes 
    {
        /// <summary>
        /// **参数解释**：EVS扩容状态，扩容时的状态为RESIZING，此时实例可以正常使用。 **取值范围**：不涉及。
        /// </summary>
        /// <value>**参数解释**：EVS扩容状态，扩容时的状态为RESIZING，此时实例可以正常使用。 **取值范围**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum DELETE_FAILED for value: DELETE_FAILED
            /// </summary>
            public static readonly StatusEnum DELETE_FAILED = new StatusEnum("DELETE_FAILED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            /// <summary>
            /// Enum IN_USE for value: IN_USE
            /// </summary>
            public static readonly StatusEnum IN_USE = new StatusEnum("IN_USE");

            /// <summary>
            /// Enum MOUNTED for value: MOUNTED
            /// </summary>
            public static readonly StatusEnum MOUNTED = new StatusEnum("MOUNTED");

            /// <summary>
            /// Enum MOUNTING for value: MOUNTING
            /// </summary>
            public static readonly StatusEnum MOUNTING = new StatusEnum("MOUNTING");

            /// <summary>
            /// Enum MOUNT_FAILED for value: MOUNT_FAILED
            /// </summary>
            public static readonly StatusEnum MOUNT_FAILED = new StatusEnum("MOUNT_FAILED");

            /// <summary>
            /// Enum RESIZING for value: RESIZING
            /// </summary>
            public static readonly StatusEnum RESIZING = new StatusEnum("RESIZING");

            /// <summary>
            /// Enum UNMOUNTED for value: UNMOUNTED
            /// </summary>
            public static readonly StatusEnum UNMOUNTED = new StatusEnum("UNMOUNTED");

            /// <summary>
            /// Enum UNMOUNTING for value: UNMOUNTING
            /// </summary>
            public static readonly StatusEnum UNMOUNTING = new StatusEnum("UNMOUNTING");

            /// <summary>
            /// Enum UNMOUNT_FAILED for value: UNMOUNT_FAILED
            /// </summary>
            public static readonly StatusEnum UNMOUNT_FAILED = new StatusEnum("UNMOUNT_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "DELETED", DELETED },
                { "DELETE_FAILED", DELETE_FAILED },
                { "DELETING", DELETING },
                { "IN_USE", IN_USE },
                { "MOUNTED", MOUNTED },
                { "MOUNTING", MOUNTING },
                { "MOUNT_FAILED", MOUNT_FAILED },
                { "RESIZING", RESIZING },
                { "UNMOUNTED", UNMOUNTED },
                { "UNMOUNTING", UNMOUNTING },
                { "UNMOUNT_FAILED", UNMOUNT_FAILED },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：存储容量。 **取值范围**：EVS默认5G，EFS默认50G，最大限制4096G。
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Capacity { get; set; }

        /// <summary>
        /// **参数解释**：支持的存储类型。不同存储类型的差异，详见[[开发环境中如何选择存储](https://support.huaweicloud.com/usermanual-standard-modelarts/devtool-modelarts_0004.html#section6)](tag:hc)[[开发环境中如何选择存储](https://support.huaweicloud.com/intl/zh-cn/usermanual-standard-modelarts/devtool-modelarts_0004.html#section5)](tag:hk)[《用户指南》的“开发环境中如何选择存储”章节](tag:fcs,fcs-super)。 **取值范围**：枚举类型，取值如下： - SFS：弹性文件服务 - EVS：云硬盘 - OBS：对象存储服务 - OBSFS：并行文件系统 - EFS：弹性文件服务（SFS Turbo）
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**：存储挂载至Notebook实例的目录，当前固定在/home/ma-user/work/下。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释**：资源所属。 **取值范围**：枚举类型，取值如下： - MANAGED：托管，即资源在服务上。 - DEDICATED：非托管，即资源在用户账号上，只有在category为EFS时支持。
        /// </summary>
        [JsonProperty("ownership", NullValueHandling = NullValueHandling.Ignore)]
        public string Ownership { get; set; }

        /// <summary>
        /// **参数解释**：EVS扩容状态，扩容时的状态为RESIZING，此时实例可以正常使用。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：EFS专属存储盘ID或OBS存储ID，只有作为扩展存储时返回。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：扩展存储挂载目录是否只读。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("read_only", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// **参数解释**：DEW存储的用户AKSK凭据名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("dew_secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DewSecretName { get; set; }

        /// <summary>
        /// **参数解释**：规格包含的evs时，evs存储的sku编码。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("evs_sku_code", NullValueHandling = NullValueHandling.Ignore)]
        public string EvsSkuCode { get; set; }

        /// <summary>
        /// **参数解释**：只有当category为EFS或OBS或OBSFS时，挂载存储源路径。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**：存储挂载类型。 **取值范围**：枚举类型，取值如下：  - STATIC:不支持在实例运行期间挂载以及卸载的存储 - DYNAMIC:支持在实例运行期间挂载以及卸载的存储
        /// </summary>
        [JsonProperty("mount_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MountType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeRes {\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  ownership: ").Append(Ownership).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  readOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  dewSecretName: ").Append(DewSecretName).Append("\n");
            sb.Append("  evsSkuCode: ").Append(EvsSkuCode).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  mountType: ").Append(MountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeRes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeRes input)
        {
            if (input == null) return false;
            if (this.Capacity != input.Capacity || (this.Capacity != null && !this.Capacity.Equals(input.Capacity))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.Ownership != input.Ownership || (this.Ownership != null && !this.Ownership.Equals(input.Ownership))) return false;
            if (this.Status != input.Status) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ReadOnly != input.ReadOnly || (this.ReadOnly != null && !this.ReadOnly.Equals(input.ReadOnly))) return false;
            if (this.DewSecretName != input.DewSecretName || (this.DewSecretName != null && !this.DewSecretName.Equals(input.DewSecretName))) return false;
            if (this.EvsSkuCode != input.EvsSkuCode || (this.EvsSkuCode != null && !this.EvsSkuCode.Equals(input.EvsSkuCode))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.MountType != input.MountType || (this.MountType != null && !this.MountType.Equals(input.MountType))) return false;

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
                if (this.Capacity != null) hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.Ownership != null) hashCode = hashCode * 59 + this.Ownership.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ReadOnly != null) hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.DewSecretName != null) hashCode = hashCode * 59 + this.DewSecretName.GetHashCode();
                if (this.EvsSkuCode != null) hashCode = hashCode * 59 + this.EvsSkuCode.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.MountType != null) hashCode = hashCode * 59 + this.MountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
