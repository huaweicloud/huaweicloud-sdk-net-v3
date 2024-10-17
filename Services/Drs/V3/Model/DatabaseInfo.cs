using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 数据库对象选择信息
    /// </summary>
    public class DatabaseInfo 
    {
        /// <summary>
        /// 类型
        /// </summary>
        /// <value>类型</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum DATABASE for value: database
            /// </summary>
            public static readonly ObjectTypeEnum DATABASE = new ObjectTypeEnum("database");

            /// <summary>
            /// Enum TABLE for value: table
            /// </summary>
            public static readonly ObjectTypeEnum TABLE = new ObjectTypeEnum("table");

            /// <summary>
            /// Enum SCHEMA for value: schema
            /// </summary>
            public static readonly ObjectTypeEnum SCHEMA = new ObjectTypeEnum("schema");

            /// <summary>
            /// Enum VIEW for value: view
            /// </summary>
            public static readonly ObjectTypeEnum VIEW = new ObjectTypeEnum("view");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "database", DATABASE },
                { "table", TABLE },
                { "schema", SCHEMA },
                { "view", VIEW },
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
        /// object_type为database时，为库名；object_type为table或者view时，字段值参考示例。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// object_type为table或view时需要填写，为库名
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 数据库对象名称，库名、表名、视图名
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// 别名，映射的新名称。
        /// </summary>
        [JsonProperty("object_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectAliasName { get; set; }

        /// <summary>
        /// 是否选中，值为true会进行迁移，false该数据库对象不会迁移，partial为迁移库下面的部分表，不填默认为false
        /// </summary>
        [JsonProperty("select", NullValueHandling = NullValueHandling.Ignore)]
        public string Select { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatabaseInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("  objectAliasName: ").Append(ObjectAliasName).Append("\n");
            sb.Append("  select: ").Append(Select).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DatabaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DatabaseInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.ObjectType != input.ObjectType) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;
            if (this.ObjectAliasName != input.ObjectAliasName || (this.ObjectAliasName != null && !this.ObjectAliasName.Equals(input.ObjectAliasName))) return false;
            if (this.Select != input.Select || (this.Select != null && !this.Select.Equals(input.Select))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.ObjectAliasName != null) hashCode = hashCode * 59 + this.ObjectAliasName.GetHashCode();
                if (this.Select != null) hashCode = hashCode * 59 + this.Select.GetHashCode();
                return hashCode;
            }
        }
    }
}
