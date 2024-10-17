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
    /// 数据库表过滤规则响应体
    /// </summary>
    public class DbObjectFilteringResult 
    {
        /// <summary>
        /// 对比的来源 - job 表示数据同步时的过滤 - compare 表示数据对比的过滤
        /// </summary>
        /// <value>对比的来源 - job 表示数据同步时的过滤 - compare 表示数据对比的过滤</value>
        [JsonConverter(typeof(EnumClassConverter<SourceEnum>))]
        public class SourceEnum
        {
            /// <summary>
            /// Enum JOB for value: job
            /// </summary>
            public static readonly SourceEnum JOB = new SourceEnum("job");

            /// <summary>
            /// Enum COMPARE for value: compare
            /// </summary>
            public static readonly SourceEnum COMPARE = new SourceEnum("compare");

            private static readonly Dictionary<string, SourceEnum> StaticFields =
            new Dictionary<string, SourceEnum>()
            {
                { "job", JOB },
                { "compare", COMPARE },
            };

            private string _value;

            public SourceEnum()
            {

            }

            public SourceEnum(string value)
            {
                _value = value;
            }

            public static SourceEnum FromValue(string value)
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

                if (this.Equals(obj as SourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SourceEnum a, SourceEnum b)
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

            public static bool operator !=(SourceEnum a, SourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库库名。
        /// </summary>
        [JsonProperty("db_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DbName { get; set; }

        /// <summary>
        /// 数据库Schema名称。
        /// </summary>
        [JsonProperty("schema_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SchemaName { get; set; }

        /// <summary>
        /// 数据库表名称。
        /// </summary>
        [JsonProperty("table_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableName { get; set; }

        /// <summary>
        /// 数据过滤校验结果。
        /// </summary>
        [JsonProperty("is_success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// 当数据过滤校验结果是false，返回校验失败的原因。
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// 对比的来源 - job 表示数据同步时的过滤 - compare 表示数据对比的过滤
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// 校验目标库比对条件过滤的结果
        /// </summary>
        [JsonProperty("target_result", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetResult { get; set; }

        /// <summary>
        /// 校验源库比对条件过滤的结果
        /// </summary>
        [JsonProperty("source_result", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceResult { get; set; }

        /// <summary>
        /// 校验目标库比对条件过滤的失败原因
        /// </summary>
        [JsonProperty("target_message", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetMessage { get; set; }

        /// <summary>
        /// 校验源库比对条件过滤的失败原因
        /// </summary>
        [JsonProperty("source_message", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DbObjectFilteringResult {\n");
            sb.Append("  dbName: ").Append(DbName).Append("\n");
            sb.Append("  schemaName: ").Append(SchemaName).Append("\n");
            sb.Append("  tableName: ").Append(TableName).Append("\n");
            sb.Append("  isSuccess: ").Append(IsSuccess).Append("\n");
            sb.Append("  message: ").Append(Message).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  targetResult: ").Append(TargetResult).Append("\n");
            sb.Append("  sourceResult: ").Append(SourceResult).Append("\n");
            sb.Append("  targetMessage: ").Append(TargetMessage).Append("\n");
            sb.Append("  sourceMessage: ").Append(SourceMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DbObjectFilteringResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DbObjectFilteringResult input)
        {
            if (input == null) return false;
            if (this.DbName != input.DbName || (this.DbName != null && !this.DbName.Equals(input.DbName))) return false;
            if (this.SchemaName != input.SchemaName || (this.SchemaName != null && !this.SchemaName.Equals(input.SchemaName))) return false;
            if (this.TableName != input.TableName || (this.TableName != null && !this.TableName.Equals(input.TableName))) return false;
            if (this.IsSuccess != input.IsSuccess || (this.IsSuccess != null && !this.IsSuccess.Equals(input.IsSuccess))) return false;
            if (this.Message != input.Message || (this.Message != null && !this.Message.Equals(input.Message))) return false;
            if (this.Source != input.Source) return false;
            if (this.TargetResult != input.TargetResult || (this.TargetResult != null && !this.TargetResult.Equals(input.TargetResult))) return false;
            if (this.SourceResult != input.SourceResult || (this.SourceResult != null && !this.SourceResult.Equals(input.SourceResult))) return false;
            if (this.TargetMessage != input.TargetMessage || (this.TargetMessage != null && !this.TargetMessage.Equals(input.TargetMessage))) return false;
            if (this.SourceMessage != input.SourceMessage || (this.SourceMessage != null && !this.SourceMessage.Equals(input.SourceMessage))) return false;

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
                if (this.DbName != null) hashCode = hashCode * 59 + this.DbName.GetHashCode();
                if (this.SchemaName != null) hashCode = hashCode * 59 + this.SchemaName.GetHashCode();
                if (this.TableName != null) hashCode = hashCode * 59 + this.TableName.GetHashCode();
                if (this.IsSuccess != null) hashCode = hashCode * 59 + this.IsSuccess.GetHashCode();
                if (this.Message != null) hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.TargetResult != null) hashCode = hashCode * 59 + this.TargetResult.GetHashCode();
                if (this.SourceResult != null) hashCode = hashCode * 59 + this.SourceResult.GetHashCode();
                if (this.TargetMessage != null) hashCode = hashCode * 59 + this.TargetMessage.GetHashCode();
                if (this.SourceMessage != null) hashCode = hashCode * 59 + this.SourceMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
