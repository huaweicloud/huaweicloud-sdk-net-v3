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
    /// 动态挂载存储请求体。
    /// </summary>
    public class DataVolumesReq 
    {
        /// <summary>
        /// **参数解释**：动态挂载存储类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - OBS：对象存储服务 - OBSFS：并行文件系统PFS - EFS：高性能弹性文件服务SFS Turbo  **默认取值**：无。
        /// </summary>
        /// <value>**参数解释**：动态挂载存储类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - OBS：对象存储服务 - OBSFS：并行文件系统PFS - EFS：高性能弹性文件服务SFS Turbo  **默认取值**：无。</value>
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
        /// **参数解释**：动态挂载存储类型。 **约束限制**：不涉及。 **取值范围**：枚举类型，取值如下： - OBS：对象存储服务 - OBSFS：并行文件系统PFS - EFS：高性能弹性文件服务SFS Turbo  **默认取值**：无。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**：在Notebook实例中挂载的路径。 **约束限制**：必须是/data目录的子目录。 **取值范围**：限制长度为256个字符，必须在Notebook的/data/的子目录下。 **默认取值**：无。
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释**：存储路径，示例：obs://modelarts/notebook/ 或 da669f6e-5591-4c10-b2a7-18d053a75677.sfsturbo.internal:/notebook。 **约束限制**：并行文件系统PFS 或 高性能弹性文件服务SFS Turbo中合法的挂载路径。 **取值范围**：限制长度为256个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// **参数解释**：高性能弹性文件服务SFS Turbo实例id。 **约束限制**：若category字段为EFS，则此字段必填。 **取值范围**：合法UUID类型。 **默认取值**：无
        /// </summary>
        [JsonProperty("efs_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EfsId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataVolumesReq {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  efsId: ").Append(EfsId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DataVolumesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DataVolumesReq input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.EfsId != input.EfsId || (this.EfsId != null && !this.EfsId.Equals(input.EfsId))) return false;

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
                if (this.MountPath != null) hashCode = hashCode * 59 + this.MountPath.GetHashCode();
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.EfsId != null) hashCode = hashCode * 59 + this.EfsId.GetHashCode();
                return hashCode;
            }
        }
    }
}
