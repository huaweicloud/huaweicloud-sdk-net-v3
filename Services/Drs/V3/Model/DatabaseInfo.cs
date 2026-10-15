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
        /// **参数解释**：  数据库对象的类型，用于标识迁移或同步对象是数据库、表、模式还是视图。  **约束限制**：  不涉及。  **取值范围**：  - database：数据库 - table：表 - schema：模式 - view：视图  **默认取值**：  不涉及
        /// </summary>
        /// <value>**参数解释**：  数据库对象的类型，用于标识迁移或同步对象是数据库、表、模式还是视图。  **约束限制**：  不涉及。  **取值范围**：  - database：数据库 - table：表 - schema：模式 - view：视图  **默认取值**：  不涉及</value>
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
        /// **参数解释**：  数据库对象的标识，具体含义取决于object_type的取值。object_type为database时，为库名；object_type为table或view时，字段值参考请求示例。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**：  数据库对象的父级标识，object_type为table或view时需要填写，为库名。  **约束限制**：  - object_type为table或view时必填。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**：  数据库对象的类型，用于标识迁移或同步对象是数据库、表、模式还是视图。  **约束限制**：  不涉及。  **取值范围**：  - database：数据库 - table：表 - schema：模式 - view：视图  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// **参数解释**：  数据库对象名称，可以是库名、表名或视图名。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// **参数解释**：  数据库对象的别名，即映射后的新名称。  **约束限制**：  - 仅支持同步任务使用。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("object_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectAliasName { get; set; }

        /// <summary>
        /// **参数解释**：  是否选中该数据库对象进行迁移，用于控制对象级别的迁移选择。  **约束限制**：  不涉及。  **取值范围**：  - true：选中，该数据库对象会进行迁移 - false：不选中，该数据库对象不会迁移 - partial：部分选择，迁移库下面的部分表  **默认取值**：  false
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
