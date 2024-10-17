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
    /// 数据库信息
    /// </summary>
    public class CreateDatabaseRequestDatabase 
    {
        /// <summary>
        /// 字符集。 - GBK - UTF8
        /// </summary>
        /// <value>字符集。 - GBK - UTF8</value>
        [JsonConverter(typeof(EnumClassConverter<CharsetEnum>))]
        public class CharsetEnum
        {
            /// <summary>
            /// Enum GBK for value: GBK
            /// </summary>
            public static readonly CharsetEnum GBK = new CharsetEnum("GBK");

            /// <summary>
            /// Enum UTF8 for value: UTF8
            /// </summary>
            public static readonly CharsetEnum UTF8 = new CharsetEnum("UTF8");

            private static readonly Dictionary<string, CharsetEnum> StaticFields =
            new Dictionary<string, CharsetEnum>()
            {
                { "GBK", GBK },
                { "UTF8", UTF8 },
            };

            private string _value;

            public CharsetEnum()
            {

            }

            public CharsetEnum(string value)
            {
                _value = value;
            }

            public static CharsetEnum FromValue(string value)
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

                if (this.Equals(obj as CharsetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CharsetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CharsetEnum a, CharsetEnum b)
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

            public static bool operator !=(CharsetEnum a, CharsetEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库分类 - RDS: RDS数据库 - ECS:自建数据库
        /// </summary>
        [JsonProperty("db_classification", NullValueHandling = NullValueHandling.Ignore)]
        public string DbClassification { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 数据库类型 - MYSQL - ORACLE - POSTGRESQL - SQLSERVER - DAMENG - TAURUS - DWS - KINGBASE - GAUSSDBOPENGAUSS - GREENPLUM - HIGHGO - SHENTONG - GBASE8A - GBASE8S - GBASEXDM - MONGODB - DDS
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 数据库版本
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 字符集。 - GBK - UTF8
        /// </summary>
        [JsonProperty("charset", NullValueHandling = NullValueHandling.Ignore)]
        public CharsetEnum Charset { get; set; }
        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 数据库操作系统 - LINUX64 - WINDOWS64 - UNIX
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public string Os { get; set; }

        /// <summary>
        /// 数据库实例名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDatabaseRequestDatabase {\n");
            sb.Append("  dbClassification: ").Append(DbClassification).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  charset: ").Append(Charset).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDatabaseRequestDatabase);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDatabaseRequestDatabase input)
        {
            if (input == null) return false;
            if (this.DbClassification != input.DbClassification || (this.DbClassification != null && !this.DbClassification.Equals(input.DbClassification))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Charset != input.Charset) return false;
            if (this.Ip != input.Ip || (this.Ip != null && !this.Ip.Equals(input.Ip))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Os != input.Os || (this.Os != null && !this.Os.Equals(input.Os))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;

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
                if (this.DbClassification != null) hashCode = hashCode * 59 + this.DbClassification.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.Ip != null) hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Os != null) hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
