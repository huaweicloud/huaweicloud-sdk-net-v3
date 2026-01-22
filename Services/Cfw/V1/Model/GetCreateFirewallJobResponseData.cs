using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class GetCreateFirewallJobResponseData 
    {
        /// <summary>
        /// **参数解释**： 任务执行状态，用于展示创建防火墙是否成功。 **取值范围**： - Running：表示任务正在执行。 - Success：表示任务执行成功。 - Failed：表示任务执行失败。
        /// </summary>
        /// <value>**参数解释**： 任务执行状态，用于展示创建防火墙是否成功。 **取值范围**： - Running：表示任务正在执行。 - Success：表示任务执行成功。 - Failed：表示任务执行失败。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: Running
            /// </summary>
            public static readonly StatusEnum RUNNING = new StatusEnum("Running");

            /// <summary>
            /// Enum SUCCESS for value: Success
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("Success");

            /// <summary>
            /// Enum FAILED for value: Failed
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("Failed");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "Running", RUNNING },
                { "Success", SUCCESS },
                { "Failed", FAILED },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 创建按需防火墙任务ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 任务执行状态，用于展示创建防火墙是否成功。 **取值范围**： - Running：表示任务正在执行。 - Success：表示任务执行成功。 - Failed：表示任务执行失败。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释**： 创建时间 **取值范围**： 格式为“yyyy-mm-ddThh:mm:ssZ”，其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 例如： - 2023-10-26T10:30:00Z 表示： 2023年10月26日10点30分00秒，UTC时间 - 2023-10-26T10:30:00+0800 表示： 2023年10月26日10点30分00秒，比UTC时间快8小时，也就是北京时间。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        /// <summary>
        /// **参数解释**： 结束时间 **取值范围**： 格式为“yyyy-mm-ddThh:mm:ssZ”，其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 例如： - 2023-10-26T10:30:00Z 表示： 2023年10月26日10点30分00秒，UTC时间 - 2023-10-26T10:30:00+0800 表示： 2023年10月26日10点30分00秒，比UTC时间快8小时，也就是北京时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCreateFirewallJobResponseData {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCreateFirewallJobResponseData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetCreateFirewallJobResponseData input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
