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
    /// 应用对象信息
    /// </summary>
    public class ApplyObjectInfo 
    {
        /// <summary>
        /// 应用对象类型，包括DESKTOP（单桌面）、ALL_DESKTOPS（全部桌面）、DESKTOP_POOL（桌面池）、DESKTOP_TAG（桌面标签）、ALL_USERS（全部用户）、USER（单个用户）、USER_GROUP（用户组）
        /// </summary>
        /// <value>应用对象类型，包括DESKTOP（单桌面）、ALL_DESKTOPS（全部桌面）、DESKTOP_POOL（桌面池）、DESKTOP_TAG（桌面标签）、ALL_USERS（全部用户）、USER（单个用户）、USER_GROUP（用户组）</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            public static readonly ObjectTypeEnum DESKTOP = new ObjectTypeEnum("DESKTOP");

            /// <summary>
            /// Enum ALL_DESKTOPS for value: ALL_DESKTOPS
            /// </summary>
            public static readonly ObjectTypeEnum ALL_DESKTOPS = new ObjectTypeEnum("ALL_DESKTOPS");

            /// <summary>
            /// Enum DESKTOP_POOL for value: DESKTOP_POOL
            /// </summary>
            public static readonly ObjectTypeEnum DESKTOP_POOL = new ObjectTypeEnum("DESKTOP_POOL");

            /// <summary>
            /// Enum DESKTOP_TAG for value: DESKTOP_TAG
            /// </summary>
            public static readonly ObjectTypeEnum DESKTOP_TAG = new ObjectTypeEnum("DESKTOP_TAG");

            /// <summary>
            /// Enum ALL_USERS for value: ALL_USERS
            /// </summary>
            public static readonly ObjectTypeEnum ALL_USERS = new ObjectTypeEnum("ALL_USERS");

            /// <summary>
            /// Enum USER for value: USER
            /// </summary>
            public static readonly ObjectTypeEnum USER = new ObjectTypeEnum("USER");

            /// <summary>
            /// Enum USER_GROUP for value: USER_GROUP
            /// </summary>
            public static readonly ObjectTypeEnum USER_GROUP = new ObjectTypeEnum("USER_GROUP");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "DESKTOP", DESKTOP },
                { "ALL_DESKTOPS", ALL_DESKTOPS },
                { "DESKTOP_POOL", DESKTOP_POOL },
                { "DESKTOP_TAG", DESKTOP_TAG },
                { "ALL_USERS", ALL_USERS },
                { "USER", USER },
                { "USER_GROUP", USER_GROUP },
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

            public static bool operator !=(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用对象类型，包括DESKTOP（单桌面）、ALL_DESKTOPS（全部桌面）、DESKTOP_POOL（桌面池）、DESKTOP_TAG（桌面标签）、ALL_USERS（全部用户）、USER（单个用户）、USER_GROUP（用户组）
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 对象ID（object_type为ALL_DESKTOPS或ALL_USERS时可为null）
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyObjectInfo {\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyObjectInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyObjectInfo input)
        {
            if (input == null) return false;
            if (this.ObjectType != input.ObjectType) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;

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
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
