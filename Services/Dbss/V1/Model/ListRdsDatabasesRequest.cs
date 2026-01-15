using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRdsDatabasesRequest 
    {
        /// <summary>
        /// **参数解释**： 数据库类型 **约束限制**： 区分大小写，只能传递取值范围内的值 **取值范围**：   - MYSQL: Mysql   - ORACLE: Oracle   - POSTGRESQL: PostgreSQL   - SQLSERVER: SQL Server   - DAMENG: DAMENG   - TAURUS: TaurusDB   - DWS: GaussDB DWS   - KINGBASE: KINGBASE   - MARIADB: MariaDB   - GAUSSDBOPENGAUSS: GaussDB/openGauss **默认取值**： 不涉及 
        /// </summary>
        /// <value>**参数解释**： 数据库类型 **约束限制**： 区分大小写，只能传递取值范围内的值 **取值范围**：   - MYSQL: Mysql   - ORACLE: Oracle   - POSTGRESQL: PostgreSQL   - SQLSERVER: SQL Server   - DAMENG: DAMENG   - TAURUS: TaurusDB   - DWS: GaussDB DWS   - KINGBASE: KINGBASE   - MARIADB: MariaDB   - GAUSSDBOPENGAUSS: GaussDB/openGauss **默认取值**： 不涉及 </value>
        [JsonConverter(typeof(EnumClassConverter<DbTypeEnum>))]
        public class DbTypeEnum
        {
            /// <summary>
            /// Enum MYSQL for value: MYSQL
            /// </summary>
            public static readonly DbTypeEnum MYSQL = new DbTypeEnum("MYSQL");

            /// <summary>
            /// Enum ORACLE for value: ORACLE
            /// </summary>
            public static readonly DbTypeEnum ORACLE = new DbTypeEnum("ORACLE");

            /// <summary>
            /// Enum POSTGRESQL for value: POSTGRESQL
            /// </summary>
            public static readonly DbTypeEnum POSTGRESQL = new DbTypeEnum("POSTGRESQL");

            /// <summary>
            /// Enum SQLSERVER for value: SQLSERVER
            /// </summary>
            public static readonly DbTypeEnum SQLSERVER = new DbTypeEnum("SQLSERVER");

            /// <summary>
            /// Enum DAMENG for value: DAMENG
            /// </summary>
            public static readonly DbTypeEnum DAMENG = new DbTypeEnum("DAMENG");

            /// <summary>
            /// Enum TAURUS for value: TAURUS
            /// </summary>
            public static readonly DbTypeEnum TAURUS = new DbTypeEnum("TAURUS");

            /// <summary>
            /// Enum DWS for value: DWS
            /// </summary>
            public static readonly DbTypeEnum DWS = new DbTypeEnum("DWS");

            /// <summary>
            /// Enum KINGBASE for value: KINGBASE
            /// </summary>
            public static readonly DbTypeEnum KINGBASE = new DbTypeEnum("KINGBASE");

            /// <summary>
            /// Enum MARIADB for value: MARIADB
            /// </summary>
            public static readonly DbTypeEnum MARIADB = new DbTypeEnum("MARIADB");

            /// <summary>
            /// Enum GAUSSDBOPENGAUSS for value: GAUSSDBOPENGAUSS
            /// </summary>
            public static readonly DbTypeEnum GAUSSDBOPENGAUSS = new DbTypeEnum("GAUSSDBOPENGAUSS");

            private static readonly Dictionary<string, DbTypeEnum> StaticFields =
            new Dictionary<string, DbTypeEnum>()
            {
                { "MYSQL", MYSQL },
                { "ORACLE", ORACLE },
                { "POSTGRESQL", POSTGRESQL },
                { "SQLSERVER", SQLSERVER },
                { "DAMENG", DAMENG },
                { "TAURUS", TAURUS },
                { "DWS", DWS },
                { "KINGBASE", KINGBASE },
                { "MARIADB", MARIADB },
                { "GAUSSDBOPENGAUSS", GAUSSDBOPENGAUSS },
            };

            private string _value;

            public DbTypeEnum()
            {

            }

            public DbTypeEnum(string value)
            {
                _value = value;
            }

            public static DbTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DbTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DbTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DbTypeEnum a, DbTypeEnum b)
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

            public static bool operator !=(DbTypeEnum a, DbTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 数据库类型 **约束限制**： 区分大小写，只能传递取值范围内的值 **取值范围**：   - MYSQL: Mysql   - ORACLE: Oracle   - POSTGRESQL: PostgreSQL   - SQLSERVER: SQL Server   - DAMENG: DAMENG   - TAURUS: TaurusDB   - DWS: GaussDB DWS   - KINGBASE: KINGBASE   - MARIADB: MariaDB   - GAUSSDBOPENGAUSS: GaussDB/openGauss **默认取值**： 不涉及 
        /// </summary>
        [SDKProperty("db_type", IsQuery = true)]
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public DbTypeEnum DbType { get; set; }
        /// <summary>
        /// **参数解释**： 分页偏移量，从第一条数据偏移offset条数据后开始查询 **约束限制**： 仅支持大于等于0的整数 **取值范围**： 大于等于0 **默认取值**： 默认值为0 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// **参数解释**： 每页查询记录数。 **约束限制**： 仅支持大于0的整数 **取值范围**： 大于0小于等于100 **默认取值**： 默认值为100 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRdsDatabasesRequest {\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRdsDatabasesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRdsDatabasesRequest input)
        {
            if (input == null) return false;
            if (this.DbType != input.DbType) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
