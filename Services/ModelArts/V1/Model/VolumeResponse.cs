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
    /// 
    /// </summary>
    public class VolumeResponse 
    {
        /// <summary>
        /// **参数解释**：notebook返回的扩展存储类型 **参数约束**：不涉及 - OBS：对象存储服务 - OBSFS：并行文件存储 - EFS：弹性文件服务
        /// </summary>
        /// <value>**参数解释**：notebook返回的扩展存储类型 **参数约束**：不涉及 - OBS：对象存储服务 - OBSFS：并行文件存储 - EFS：弹性文件服务</value>
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
        /// **参数解释**：存储状态 - MOUNTING: 正在挂载中； - MOUNTED: 已挂载成功； - UNMOUNTING: 正在卸载中； - UNMOUNTED: 已卸载完成； - MOUNT_FAILED: 挂载失败 - UNMOUNT_FAILED：卸载失败； **参数约束**：不涉及
        /// </summary>
        /// <value>**参数解释**：存储状态 - MOUNTING: 正在挂载中； - MOUNTED: 已挂载成功； - UNMOUNTING: 正在卸载中； - UNMOUNTED: 已卸载完成； - MOUNT_FAILED: 挂载失败 - UNMOUNT_FAILED：卸载失败； **参数约束**：不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum MOUNTING for value: MOUNTING
            /// </summary>
            public static readonly StatusEnum MOUNTING = new StatusEnum("MOUNTING");

            /// <summary>
            /// Enum MOUNTED for value: MOUNTED
            /// </summary>
            public static readonly StatusEnum MOUNTED = new StatusEnum("MOUNTED");

            /// <summary>
            /// Enum UNMOUNTING for value: UNMOUNTING
            /// </summary>
            public static readonly StatusEnum UNMOUNTING = new StatusEnum("UNMOUNTING");

            /// <summary>
            /// Enum UNMOUNTED for value: UNMOUNTED
            /// </summary>
            public static readonly StatusEnum UNMOUNTED = new StatusEnum("UNMOUNTED");

            /// <summary>
            /// Enum MOUNT_FAILED for value: MOUNT_FAILED
            /// </summary>
            public static readonly StatusEnum MOUNT_FAILED = new StatusEnum("MOUNT_FAILED");

            /// <summary>
            /// Enum UNMOUNT_FAILED for value: UNMOUNT_FAILED
            /// </summary>
            public static readonly StatusEnum UNMOUNT_FAILED = new StatusEnum("UNMOUNT_FAILED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "MOUNTING", MOUNTING },
                { "MOUNTED", MOUNTED },
                { "UNMOUNTING", UNMOUNTING },
                { "UNMOUNTED", UNMOUNTED },
                { "MOUNT_FAILED", MOUNT_FAILED },
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
        /// **参数解释**：存储挂载类型，枚举类。 **约束限制**：无限制。 - STATIC:不支持在实例运行期间挂载以及卸载的存储 - DYNAMIC:支持在实例运行期间挂载以及卸载的存储
        /// </summary>
        /// <value>**参数解释**：存储挂载类型，枚举类。 **约束限制**：无限制。 - STATIC:不支持在实例运行期间挂载以及卸载的存储 - DYNAMIC:支持在实例运行期间挂载以及卸载的存储</value>
        [JsonConverter(typeof(EnumClassConverter<MountTypeEnum>))]
        public class MountTypeEnum
        {
            /// <summary>
            /// Enum STATIC for value: STATIC
            /// </summary>
            public static readonly MountTypeEnum STATIC = new MountTypeEnum("STATIC");

            /// <summary>
            /// Enum DYNAMIC for value: DYNAMIC
            /// </summary>
            public static readonly MountTypeEnum DYNAMIC = new MountTypeEnum("DYNAMIC");

            private static readonly Dictionary<string, MountTypeEnum> StaticFields =
            new Dictionary<string, MountTypeEnum>()
            {
                { "STATIC", STATIC },
                { "DYNAMIC", DYNAMIC },
            };

            private string _value;

            public MountTypeEnum()
            {

            }

            public MountTypeEnum(string value)
            {
                _value = value;
            }

            public static MountTypeEnum FromValue(string value)
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

                if (this.Equals(obj as MountTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MountTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MountTypeEnum a, MountTypeEnum b)
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

            public static bool operator !=(MountTypeEnum a, MountTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**：notebook返回的扩展存储类型 **参数约束**：不涉及 - OBS：对象存储服务 - OBSFS：并行文件存储 - EFS：弹性文件服务
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// **参数解释**：存储挂载至Notebook实例的目录 **参数约束**：不涉及
        /// </summary>
        [JsonProperty("mount_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MountPath { get; set; }

        /// <summary>
        /// **参数解释**：当category为OBS、OBSFS时，挂载存储源路径。 **参数约束**：不涉及
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// **参数解释**：存储状态 - MOUNTING: 正在挂载中； - MOUNTED: 已挂载成功； - UNMOUNTING: 正在卸载中； - UNMOUNTED: 已卸载完成； - MOUNT_FAILED: 挂载失败 - UNMOUNT_FAILED：卸载失败； **参数约束**：不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**：存储挂载类型，枚举类。 **约束限制**：无限制。 - STATIC:不支持在实例运行期间挂载以及卸载的存储 - DYNAMIC:支持在实例运行期间挂载以及卸载的存储
        /// </summary>
        [JsonProperty("mount_type", NullValueHandling = NullValueHandling.Ignore)]
        public MountTypeEnum MountType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeResponse {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  mountPath: ").Append(MountPath).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  mountType: ").Append(MountType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeResponse input)
        {
            if (input == null) return false;
            if (this.Category != input.Category) return false;
            if (this.MountPath != input.MountPath || (this.MountPath != null && !this.MountPath.Equals(input.MountPath))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;
            if (this.Status != input.Status) return false;
            if (this.MountType != input.MountType) return false;

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
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.MountType.GetHashCode();
                return hashCode;
            }
        }
    }
}
