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
    /// 模板对象
    /// </summary>
    public class TemplateBean 
    {
        /// <summary>
        /// 类型 - COMPREHENSIVE: 综合报表 - COMPLIANCE: 合规报表 - DB_SPECIAL：数据库专项报表 - CLIENT_SPECIAL：客户端专项报表 - SQL_SPECIAL：SQL
        /// </summary>
        /// <value>类型 - COMPREHENSIVE: 综合报表 - COMPLIANCE: 合规报表 - DB_SPECIAL：数据库专项报表 - CLIENT_SPECIAL：客户端专项报表 - SQL_SPECIAL：SQL</value>
        [JsonConverter(typeof(EnumClassConverter<GroupEnum>))]
        public class GroupEnum
        {
            /// <summary>
            /// Enum COMPREHENSIVE for value: COMPREHENSIVE
            /// </summary>
            public static readonly GroupEnum COMPREHENSIVE = new GroupEnum("COMPREHENSIVE");

            /// <summary>
            /// Enum COMPLIANCE for value: COMPLIANCE
            /// </summary>
            public static readonly GroupEnum COMPLIANCE = new GroupEnum("COMPLIANCE");

            /// <summary>
            /// Enum DB_SPECIAL for value: DB_SPECIAL
            /// </summary>
            public static readonly GroupEnum DB_SPECIAL = new GroupEnum("DB_SPECIAL");

            /// <summary>
            /// Enum CLIENT_SPECIAL for value: CLIENT_SPECIAL
            /// </summary>
            public static readonly GroupEnum CLIENT_SPECIAL = new GroupEnum("CLIENT_SPECIAL");

            /// <summary>
            /// Enum SQL_SPECIAL for value: SQL_SPECIAL
            /// </summary>
            public static readonly GroupEnum SQL_SPECIAL = new GroupEnum("SQL_SPECIAL");

            private static readonly Dictionary<string, GroupEnum> StaticFields =
            new Dictionary<string, GroupEnum>()
            {
                { "COMPREHENSIVE", COMPREHENSIVE },
                { "COMPLIANCE", COMPLIANCE },
                { "DB_SPECIAL", DB_SPECIAL },
                { "CLIENT_SPECIAL", CLIENT_SPECIAL },
                { "SQL_SPECIAL", SQL_SPECIAL },
            };

            private string _value;

            public GroupEnum()
            {

            }

            public GroupEnum(string value)
            {
                _value = value;
            }

            public static GroupEnum FromValue(string value)
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

                if (this.Equals(obj as GroupEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GroupEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GroupEnum a, GroupEnum b)
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

            public static bool operator !=(GroupEnum a, GroupEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 状态 - OFF：已关闭 - ON：已开启
        /// </summary>
        /// <value>状态 - OFF：已关闭 - ON：已开启</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly StatusEnum OFF = new StatusEnum("OFF");

            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly StatusEnum ON = new StatusEnum("ON");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "OFF", OFF },
                { "ON", ON },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 报表类型 - COMPREHENSIVE: 数据库安全综合报表 - COMPLIANCE: 数据库安全合规报表 - SOX: SOX-萨班斯报表 - PCI: 行业标准安全报表 - DB_ANALYSIS: 数据库服务器分析报表 - CLIENT_IP_ANALYSIS: 客户端IP分析报表 - SQL_DCL_COMMAND: DCL命令报表 - SQL_DDL_COMMAND: DDL命令报表 - SQL_DML_COMMAND: DML命令报表
        /// </summary>
        /// <value>报表类型 - COMPREHENSIVE: 数据库安全综合报表 - COMPLIANCE: 数据库安全合规报表 - SOX: SOX-萨班斯报表 - PCI: 行业标准安全报表 - DB_ANALYSIS: 数据库服务器分析报表 - CLIENT_IP_ANALYSIS: 客户端IP分析报表 - SQL_DCL_COMMAND: DCL命令报表 - SQL_DDL_COMMAND: DDL命令报表 - SQL_DML_COMMAND: DML命令报表</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum COMPREHENSIVE for value: COMPREHENSIVE
            /// </summary>
            public static readonly TypeEnum COMPREHENSIVE = new TypeEnum("COMPREHENSIVE");

            /// <summary>
            /// Enum COMPLIANCE for value: COMPLIANCE
            /// </summary>
            public static readonly TypeEnum COMPLIANCE = new TypeEnum("COMPLIANCE");

            /// <summary>
            /// Enum SOX for value: SOX
            /// </summary>
            public static readonly TypeEnum SOX = new TypeEnum("SOX");

            /// <summary>
            /// Enum PCI for value: PCI
            /// </summary>
            public static readonly TypeEnum PCI = new TypeEnum("PCI");

            /// <summary>
            /// Enum DB_ANALYSIS for value: DB_ANALYSIS
            /// </summary>
            public static readonly TypeEnum DB_ANALYSIS = new TypeEnum("DB_ANALYSIS");

            /// <summary>
            /// Enum CLIENT_IP_ANALYSIS for value: CLIENT_IP_ANALYSIS
            /// </summary>
            public static readonly TypeEnum CLIENT_IP_ANALYSIS = new TypeEnum("CLIENT_IP_ANALYSIS");

            /// <summary>
            /// Enum SQL_DCL_COMMAND for value: SQL_DCL_COMMAND
            /// </summary>
            public static readonly TypeEnum SQL_DCL_COMMAND = new TypeEnum("SQL_DCL_COMMAND");

            /// <summary>
            /// Enum SQL_DDL_COMMAND for value: SQL_DDL_COMMAND
            /// </summary>
            public static readonly TypeEnum SQL_DDL_COMMAND = new TypeEnum("SQL_DDL_COMMAND");

            /// <summary>
            /// Enum SQL_DML_COMMAND for value: SQL_DML_COMMAND
            /// </summary>
            public static readonly TypeEnum SQL_DML_COMMAND = new TypeEnum("SQL_DML_COMMAND");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "COMPREHENSIVE", COMPREHENSIVE },
                { "COMPLIANCE", COMPLIANCE },
                { "SOX", SOX },
                { "PCI", PCI },
                { "DB_ANALYSIS", DB_ANALYSIS },
                { "CLIENT_IP_ANALYSIS", CLIENT_IP_ANALYSIS },
                { "SQL_DCL_COMMAND", SQL_DCL_COMMAND },
                { "SQL_DDL_COMMAND", SQL_DDL_COMMAND },
                { "SQL_DML_COMMAND", SQL_DML_COMMAND },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库ID
        /// </summary>
        [JsonProperty("db_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string DbIds { get; set; }

        /// <summary>
        /// 数据库名称
        /// </summary>
        [JsonProperty("db_names", NullValueHandling = NullValueHandling.Ignore)]
        public string DbNames { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        [JsonProperty("frequency", NullValueHandling = NullValueHandling.Ignore)]
        public string Frequency { get; set; }

        /// <summary>
        /// 类型 - COMPREHENSIVE: 综合报表 - COMPLIANCE: 合规报表 - DB_SPECIAL：数据库专项报表 - CLIENT_SPECIAL：客户端专项报表 - SQL_SPECIAL：SQL
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public GroupEnum Group { get; set; }
        /// <summary>
        /// 模板ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 报表模板名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 状态 - OFF：已关闭 - ON：已开启
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 报表类型 - COMPREHENSIVE: 数据库安全综合报表 - COMPLIANCE: 数据库安全合规报表 - SOX: SOX-萨班斯报表 - PCI: 行业标准安全报表 - DB_ANALYSIS: 数据库服务器分析报表 - CLIENT_IP_ANALYSIS: 客户端IP分析报表 - SQL_DCL_COMMAND: DCL命令报表 - SQL_DDL_COMMAND: DDL命令报表 - SQL_DML_COMMAND: DML命令报表
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateBean {\n");
            sb.Append("  dbIds: ").Append(DbIds).Append("\n");
            sb.Append("  dbNames: ").Append(DbNames).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("  frequency: ").Append(Frequency).Append("\n");
            sb.Append("  group: ").Append(Group).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateBean);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateBean input)
        {
            if (input == null) return false;
            if (this.DbIds != input.DbIds || (this.DbIds != null && !this.DbIds.Equals(input.DbIds))) return false;
            if (this.DbNames != input.DbNames || (this.DbNames != null && !this.DbNames.Equals(input.DbNames))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;
            if (this.Frequency != input.Frequency || (this.Frequency != null && !this.Frequency.Equals(input.Frequency))) return false;
            if (this.Group != input.Group) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status) return false;
            if (this.Type != input.Type) return false;

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
                if (this.DbIds != null) hashCode = hashCode * 59 + this.DbIds.GetHashCode();
                if (this.DbNames != null) hashCode = hashCode * 59 + this.DbNames.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                if (this.Frequency != null) hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                hashCode = hashCode * 59 + this.Group.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
