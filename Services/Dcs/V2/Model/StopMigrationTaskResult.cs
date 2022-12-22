using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StopMigrationTaskResult 
    {
        /// <summary>
        /// 下发停止迁移任务操作结果。
        /// </summary>
        /// <value>下发停止迁移任务操作结果。</value>
        [JsonConverter(typeof(EnumClassConverter<ResultEnum>))]
        public class ResultEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: success
            /// </summary>
            public static readonly ResultEnum SUCCESS = new ResultEnum("success");

            /// <summary>
            /// Enum FAILED for value: failed
            /// </summary>
            public static readonly ResultEnum FAILED = new ResultEnum("failed");

            private static readonly Dictionary<string, ResultEnum> StaticFields =
            new Dictionary<string, ResultEnum>()
            {
                { "success", SUCCESS },
                { "failed", FAILED },
            };

            private string _value;

            public ResultEnum()
            {

            }

            public ResultEnum(string value)
            {
                _value = value;
            }

            public static ResultEnum FromValue(string value)
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

                if (this.Equals(obj as ResultEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResultEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResultEnum a, ResultEnum b)
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

            public static bool operator !=(ResultEnum a, ResultEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 下发停止迁移任务操作结果。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public ResultEnum Result { get; set; }
        /// <summary>
        /// 数据迁移任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopMigrationTaskResult {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopMigrationTaskResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopMigrationTaskResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                return hashCode;
            }
        }
    }
}
