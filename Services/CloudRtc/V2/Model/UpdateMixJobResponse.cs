using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateMixJobResponse : SdkResponse
    {
        /// <summary>
        /// 任务状态。  - INIT：任务正在初始化 - RUNNING：任务正在运行 - STOPPED：任务已停止 
        /// </summary>
        /// <value>任务状态。  - INIT：任务正在初始化 - RUNNING：任务正在运行 - STOPPED：任务已停止 </value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum INIT for value: INIT
            /// </summary>
            public static readonly StateEnum INIT = new StateEnum("INIT");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly StateEnum RUNNING = new StateEnum("RUNNING");

            /// <summary>
            /// Enum STOPPED for value: STOPPED
            /// </summary>
            public static readonly StateEnum STOPPED = new StateEnum("STOPPED");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "INIT", INIT },
                { "RUNNING", RUNNING },
                { "STOPPED", STOPPED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务结束原因 - TENANT_STOP - EXCEED_MAX_IDLE_TIME - INTERNAL_ERROR
        /// </summary>
        /// <value>任务结束原因 - TENANT_STOP - EXCEED_MAX_IDLE_TIME - INTERNAL_ERROR</value>
        [JsonConverter(typeof(EnumClassConverter<StopReasonEnum>))]
        public class StopReasonEnum
        {
            /// <summary>
            /// Enum TENANT_STOP for value: TENANT_STOP
            /// </summary>
            public static readonly StopReasonEnum TENANT_STOP = new StopReasonEnum("TENANT_STOP");

            /// <summary>
            /// Enum EXCEED_MAX_IDLE_TIME for value: EXCEED_MAX_IDLE_TIME
            /// </summary>
            public static readonly StopReasonEnum EXCEED_MAX_IDLE_TIME = new StopReasonEnum("EXCEED_MAX_IDLE_TIME");

            /// <summary>
            /// Enum INTERNAL_ERROR for value: INTERNAL_ERROR
            /// </summary>
            public static readonly StopReasonEnum INTERNAL_ERROR = new StopReasonEnum("INTERNAL_ERROR");

            private static readonly Dictionary<string, StopReasonEnum> StaticFields =
            new Dictionary<string, StopReasonEnum>()
            {
                { "TENANT_STOP", TENANT_STOP },
                { "EXCEED_MAX_IDLE_TIME", EXCEED_MAX_IDLE_TIME },
                { "INTERNAL_ERROR", INTERNAL_ERROR },
            };

            private string _value;

            public StopReasonEnum()
            {

            }

            public StopReasonEnum(string value)
            {
                _value = value;
            }

            public static StopReasonEnum FromValue(string value)
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

                if (this.Equals(obj as StopReasonEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StopReasonEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StopReasonEnum a, StopReasonEnum b)
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

            public static bool operator !=(StopReasonEnum a, StopReasonEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 任务编号，可以用于修改、查看和停止合流任务
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 流名
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 房间id
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("mix_param", NullValueHandling = NullValueHandling.Ignore)]
        public MixParam MixParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("record_param", NullValueHandling = NullValueHandling.Ignore)]
        public RecordParam RecordParam { get; set; }

        /// <summary>
        /// 任务创建的时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 任务中的布局更新的时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 任务状态。  - INIT：任务正在初始化 - RUNNING：任务正在运行 - STOPPED：任务已停止 
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 任务结束原因 - TENANT_STOP - EXCEED_MAX_IDLE_TIME - INTERNAL_ERROR
        /// </summary>
        [JsonProperty("stop_reason", NullValueHandling = NullValueHandling.Ignore)]
        public StopReasonEnum StopReason { get; set; }
        /// <summary>
        /// 状态描述，对state字段的一些补充说明，可用于人工查阅。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 任务开始时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务结束时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("stop_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StopTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-request-Id", IsHeader = true)]
        [JsonProperty("X-request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMixJobResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  mixParam: ").Append(MixParam).Append("\n");
            sb.Append("  recordParam: ").Append(RecordParam).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  stopReason: ").Append(StopReason).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  stopTime: ").Append(StopTime).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateMixJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateMixJobResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.StreamName == input.StreamName ||
                    (this.StreamName != null &&
                    this.StreamName.Equals(input.StreamName))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.RoomId == input.RoomId ||
                    (this.RoomId != null &&
                    this.RoomId.Equals(input.RoomId))
                ) && 
                (
                    this.MixParam == input.MixParam ||
                    (this.MixParam != null &&
                    this.MixParam.Equals(input.MixParam))
                ) && 
                (
                    this.RecordParam == input.RecordParam ||
                    (this.RecordParam != null &&
                    this.RecordParam.Equals(input.RecordParam))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.StopReason == input.StopReason ||
                    (this.StopReason != null &&
                    this.StopReason.Equals(input.StopReason))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StopTime == input.StopTime ||
                    (this.StopTime != null &&
                    this.StopTime.Equals(input.StopTime))
                ) && 
                (
                    this.XRequestId == input.XRequestId ||
                    (this.XRequestId != null &&
                    this.XRequestId.Equals(input.XRequestId))
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
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.StreamName != null)
                    hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                if (this.AppId != null)
                    hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.RoomId != null)
                    hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.MixParam != null)
                    hashCode = hashCode * 59 + this.MixParam.GetHashCode();
                if (this.RecordParam != null)
                    hashCode = hashCode * 59 + this.RecordParam.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.StopReason != null)
                    hashCode = hashCode * 59 + this.StopReason.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StopTime != null)
                    hashCode = hashCode * 59 + this.StopTime.GetHashCode();
                if (this.XRequestId != null)
                    hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
