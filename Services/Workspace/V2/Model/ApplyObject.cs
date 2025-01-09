using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 定时任务应用对象。
    /// </summary>
    public class ApplyObject 
    {
        /// <summary>
        /// 对象类型，可选值为： - DESKTOP：桌面。 - DESKTOP_POOL：桌面池。 - ALL_DESKTOPS: 所有桌面，仅供触发式任务使用。 - DESKTOP_TAG：桌面标签
        /// </summary>
        /// <value>对象类型，可选值为： - DESKTOP：桌面。 - DESKTOP_POOL：桌面池。 - ALL_DESKTOPS: 所有桌面，仅供触发式任务使用。 - DESKTOP_TAG：桌面标签</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            public static readonly ObjectTypeEnum DESKTOP = new ObjectTypeEnum("DESKTOP");

            /// <summary>
            /// Enum DESKTOP_POOL for value: DESKTOP_POOL
            /// </summary>
            public static readonly ObjectTypeEnum DESKTOP_POOL = new ObjectTypeEnum("DESKTOP_POOL");

            /// <summary>
            /// Enum ALL_DESKTOPS for value: ALL_DESKTOPS
            /// </summary>
            public static readonly ObjectTypeEnum ALL_DESKTOPS = new ObjectTypeEnum("ALL_DESKTOPS");

            /// <summary>
            /// Enum DESKTOP_TAG for value: DESKTOP_TAG
            /// </summary>
            public static readonly ObjectTypeEnum DESKTOP_TAG = new ObjectTypeEnum("DESKTOP_TAG");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "DESKTOP", DESKTOP },
                { "DESKTOP_POOL", DESKTOP_POOL },
                { "ALL_DESKTOPS", ALL_DESKTOPS },
                { "DESKTOP_TAG", DESKTOP_TAG },
            };

            private string _value;

            public ObjectTypeEnum()
            {

            }

            public ObjectTypeEnum(string value)
            {
                _value = value;
            }

            public static ObjectTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ObjectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObjectTypeEnum a, ObjectTypeEnum b)
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

            public static bool operator !=(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 对象ID。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 对象类型，可选值为： - DESKTOP：桌面。 - DESKTOP_POOL：桌面池。 - ALL_DESKTOPS: 所有桌面，仅供触发式任务使用。 - DESKTOP_TAG：桌面标签
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 对象名称。
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyObject {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyObject input)
        {
            if (input == null) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ObjectType != input.ObjectType) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                return hashCode;
            }
        }
    }
}
