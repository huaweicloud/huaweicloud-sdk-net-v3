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
    /// 创建或取消对比任务信息体。
    /// </summary>
    public class CompareTaskParams 
    {
        /// <summary>
        /// 对比任务模式。取值： - object：对象对比。 - lines：行数对比。 - contents：内容对比。
        /// </summary>
        /// <value>对比任务模式。取值： - object：对象对比。 - lines：行数对比。 - contents：内容对比。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum OBJECT for value: object
            /// </summary>
            public static readonly TypeEnum OBJECT = new TypeEnum("object");

            /// <summary>
            /// Enum LINES for value: lines
            /// </summary>
            public static readonly TypeEnum LINES = new TypeEnum("lines");

            /// <summary>
            /// Enum CONTENTS for value: contents
            /// </summary>
            public static readonly TypeEnum CONTENTS = new TypeEnum("contents");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "object", OBJECT },
                { "lines", LINES },
                { "contents", CONTENTS },
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
        /// 取消对比任务必填。
        /// </summary>
        [JsonProperty("compare_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CompareTaskId { get; set; }

        /// <summary>
        /// 对比任务模式。取值： - object：对象对比。 - lines：行数对比。 - contents：内容对比。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 定时启动时间，时间戳格式。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 对比策略。
        /// </summary>
        [JsonProperty("option", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Option { get; set; }

        /// <summary>
        /// 对比选择对象。
        /// </summary>
        [JsonProperty("db_object", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, DatabaseObject> DbObject { get; set; }

        /// <summary>
        /// 更新数据加工规则请求体
        /// </summary>
        [JsonProperty("data_process_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataProcessInfo> DataProcessInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompareTaskParams {\n");
            sb.Append("  compareTaskId: ").Append(CompareTaskId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  option: ").Append(Option).Append("\n");
            sb.Append("  dbObject: ").Append(DbObject).Append("\n");
            sb.Append("  dataProcessInfo: ").Append(DataProcessInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CompareTaskParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CompareTaskParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CompareTaskId == input.CompareTaskId ||
                    (this.CompareTaskId != null &&
                    this.CompareTaskId.Equals(input.CompareTaskId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Option == input.Option ||
                    this.Option != null &&
                    input.Option != null &&
                    this.Option.SequenceEqual(input.Option)
                ) && 
                (
                    this.DbObject == input.DbObject ||
                    this.DbObject != null &&
                    input.DbObject != null &&
                    this.DbObject.SequenceEqual(input.DbObject)
                ) && 
                (
                    this.DataProcessInfo == input.DataProcessInfo ||
                    this.DataProcessInfo != null &&
                    input.DataProcessInfo != null &&
                    this.DataProcessInfo.SequenceEqual(input.DataProcessInfo)
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
                if (this.CompareTaskId != null)
                    hashCode = hashCode * 59 + this.CompareTaskId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
                if (this.DbObject != null)
                    hashCode = hashCode * 59 + this.DbObject.GetHashCode();
                if (this.DataProcessInfo != null)
                    hashCode = hashCode * 59 + this.DataProcessInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
