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
    public class ListFlavorsRequest 
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
        /// 数据库版本号，获取方法请参见5.1查询数据库引擎的版本。（可输入小版本号）
        /// </summary>
        [SDKProperty("version_name", IsQuery = true)]
        [JsonProperty("version_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionName { get; set; }

        /// <summary>
        /// 规格编码
        /// </summary>
        [SDKProperty("spec_code", IsQuery = true)]
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 是否查询serverless规格。取值范围如下，区分大小写： true：查询serverless规格 false：查询非serverless规格 默认值 false。
        /// </summary>
        [SDKProperty("is_serverless", IsQuery = true)]
        [JsonProperty("is_serverless", NullValueHandling = NullValueHandling.Ignore)]
        public string IsServerless { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlavorsRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  databaseName: ").Append(DatabaseName).Append("\n");
            sb.Append("  versionName: ").Append(VersionName).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  isServerless: ").Append(IsServerless).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlavorsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlavorsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
                ) && 
                (
                    this.DatabaseName == input.DatabaseName ||
                    (this.DatabaseName != null &&
                    this.DatabaseName.Equals(input.DatabaseName))
                ) && 
                (
                    this.VersionName == input.VersionName ||
                    (this.VersionName != null &&
                    this.VersionName.Equals(input.VersionName))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.IsServerless == input.IsServerless ||
                    (this.IsServerless != null &&
                    this.IsServerless.Equals(input.IsServerless))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.DatabaseName != null)
                    hashCode = hashCode * 59 + this.DatabaseName.GetHashCode();
                if (this.VersionName != null)
                    hashCode = hashCode * 59 + this.VersionName.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.IsServerless != null)
                    hashCode = hashCode * 59 + this.IsServerless.GetHashCode();
                return hashCode;
            }
        }
    }
}
