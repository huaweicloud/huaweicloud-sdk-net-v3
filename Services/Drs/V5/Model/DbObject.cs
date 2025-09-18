using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据库对象信息体。实时迁移、实时同步需要迁移或同步的库或者表，支持实时同步场景对数据库对象进行加工，即可以为数据库对象添加过滤规则、高级设置、列加工、附加列等。 数据加工相关具体约束参考：https://support.huaweicloud.com/realtimesyn-drs/drs_03_0035.html
    /// </summary>
    public class DbObject 
    {
        /// <summary>
        /// 数据库对象迁移或同步范围。取值： - all：全部迁移。 - database：库级迁移或同步。 - table：表级迁移或同步。
        /// </summary>
        /// <value>数据库对象迁移或同步范围。取值： - all：全部迁移。 - database：库级迁移或同步。 - table：表级迁移或同步。</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectScopeEnum>))]
        public class ObjectScopeEnum
        {
            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly ObjectScopeEnum ALL = new ObjectScopeEnum("all");

            /// <summary>
            /// Enum DATABASE for value: database
            /// </summary>
            public static readonly ObjectScopeEnum DATABASE = new ObjectScopeEnum("database");

            /// <summary>
            /// Enum TABLE for value: table
            /// </summary>
            public static readonly ObjectScopeEnum TABLE = new ObjectScopeEnum("table");

            private static readonly Dictionary<string, ObjectScopeEnum> StaticFields =
            new Dictionary<string, ObjectScopeEnum>()
            {
                { "all", ALL },
                { "database", DATABASE },
                { "table", TABLE },
            };

            private string _value;

            public ObjectScopeEnum()
            {

            }

            public ObjectScopeEnum(string value)
            {
                _value = value;
            }

            public static ObjectScopeEnum FromValue(string value)
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

                if (this.Equals(obj as ObjectScopeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectScopeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ObjectScopeEnum a, ObjectScopeEnum b)
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

            public static bool operator !=(ObjectScopeEnum a, ObjectScopeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库对象迁移或同步范围。取值： - all：全部迁移。 - database：库级迁移或同步。 - table：表级迁移或同步。
        /// </summary>
        [JsonProperty("object_scope", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectScopeEnum ObjectScope { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_root_db", NullValueHandling = NullValueHandling.Ignore)]
        public TargetRootDb TargetRootDb { get; set; }

        /// <summary>
        /// 数据库对象迁移或同步信息，object_scope为all时不填，为库级或表级时必填。
        /// </summary>
        [JsonProperty("object_info", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, DatabaseObject> ObjectInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbObject {\n");
            sb.Append("  objectScope: ").Append(ObjectScope).Append("\n");
            sb.Append("  targetRootDb: ").Append(TargetRootDb).Append("\n");
            sb.Append("  objectInfo: ").Append(ObjectInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbObject input)
        {
            if (input == null) return false;
            if (this.ObjectScope != input.ObjectScope) return false;
            if (this.TargetRootDb != input.TargetRootDb || (this.TargetRootDb != null && !this.TargetRootDb.Equals(input.TargetRootDb))) return false;
            if (this.ObjectInfo != input.ObjectInfo || (this.ObjectInfo != null && input.ObjectInfo != null && !this.ObjectInfo.SequenceEqual(input.ObjectInfo))) return false;

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
                hashCode = hashCode * 59 + this.ObjectScope.GetHashCode();
                if (this.TargetRootDb != null) hashCode = hashCode * 59 + this.TargetRootDb.GetHashCode();
                if (this.ObjectInfo != null) hashCode = hashCode * 59 + this.ObjectInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
