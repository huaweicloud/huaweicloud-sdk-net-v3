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
    /// Response Object
    /// </summary>
    public class AttachDynamicStorageResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**：存储类型。可选值为OBS/OBSFS/EFS。 **取值范围**：不涉及。
        /// </summary>
        /// <value>**参数解释**：存储类型。可选值为OBS/OBSFS/EFS。 **取值范围**：不涉及。</value>
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
        /// **参数解释**：存储类型。可选值为OBS/OBSFS/EFS。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**：动态挂载实例ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：在Notebook实例中挂载的路径。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释**：动态挂载状态。 **取值范围**：枚举类型，取值如下： - MOUNTING：挂载中 - MOUNT_FAILED：挂载失败 - MOUNTED：已挂载 - UNMOUNTING：卸载中 - UNMOUNT_FAILED：卸载失败 - UNMOUNTED：卸载完成
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：存储路径。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**：挂载失败原因，动态挂载状态为MOUNT_FAILED时返回。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("failure_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureReason { get; set; }

        /// <summary>
        /// **参数解释**：EFS存储实例ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("efs_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EfsId { get; set; }

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
            sb.Append("class AttachDynamicStorageResponse {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  failureReason: ").Append(FailureReason).Append("\n");
            sb.Append("  efsId: ").Append(EfsId).Append("\n");
            sb.Append("  mountType: ").Append(MountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachDynamicStorageResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachDynamicStorageResponse input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.FailureReason != input.FailureReason || (this.FailureReason != null && !this.FailureReason.Equals(input.FailureReason))) return false;
            if (this.EfsId != input.EfsId || (this.EfsId != null && !this.EfsId.Equals(input.EfsId))) return false;
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
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.FailureReason != null) hashCode = hashCode * 59 + this.FailureReason.GetHashCode();
                if (this.EfsId != null) hashCode = hashCode * 59 + this.EfsId.GetHashCode();
                if (this.MountType != null) hashCode = hashCode * 59 + this.MountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
