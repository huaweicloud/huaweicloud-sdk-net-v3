using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDatastoresRequest 
    {
        /// <summary>
        /// 数据库引擎。支持的引擎如下，不区分大小写： MySQL PostgreSQL SQLServer
        /// </summary>
        /// <value>数据库引擎。支持的引擎如下，不区分大小写： MySQL PostgreSQL SQLServer</value>
        [JsonConverter(typeof(EnumClassConverter<DatabaseNameEnum>))]
        public class DatabaseNameEnum
        {
            /// <summary>
            /// Enum MYSQL for value: MySQL
            /// </summary>
            public static readonly DatabaseNameEnum MYSQL = new DatabaseNameEnum("MySQL");

            /// <summary>
            /// Enum POSTGRESQL for value: PostgreSQL
            /// </summary>
            public static readonly DatabaseNameEnum POSTGRESQL = new DatabaseNameEnum("PostgreSQL");

            /// <summary>
            /// Enum SQLSERVER for value: SQLServer
            /// </summary>
            public static readonly DatabaseNameEnum SQLSERVER = new DatabaseNameEnum("SQLServer");

            /// <summary>
            /// Enum MARIADB for value: MariaDB
            /// </summary>
            public static readonly DatabaseNameEnum MARIADB = new DatabaseNameEnum("MariaDB");

            private static readonly Dictionary<string, DatabaseNameEnum> StaticFields =
            new Dictionary<string, DatabaseNameEnum>()
            {
                { "MySQL", MYSQL },
                { "PostgreSQL", POSTGRESQL },
                { "SQLServer", SQLSERVER },
                { "MariaDB", MARIADB },
            };

            private string _value;

            public DatabaseNameEnum()
            {

            }

            public DatabaseNameEnum(string value)
            {
                _value = value;
            }

            public static DatabaseNameEnum FromValue(string value)
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

                if (this.Equals(obj as DatabaseNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DatabaseNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DatabaseNameEnum a, DatabaseNameEnum b)
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

            public static bool operator !=(DatabaseNameEnum a, DatabaseNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 数据库引擎。支持的引擎如下，不区分大小写： MySQL PostgreSQL SQLServer
        /// </summary>
        [SDKProperty("database_name", IsPath = true)]
        [JsonProperty("database_name", NullValueHandling = NullValueHandling.Ignore)]
        public DatabaseNameEnum DatabaseName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDatastoresRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDatastoresRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDatastoresRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.DatabaseName != input.DatabaseName) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                return hashCode;
            }
        }
    }
}
