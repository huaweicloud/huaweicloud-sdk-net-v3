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
    public class CreateIndividualStreamJobResponse : SdkResponse
    {
        /// <summary>
        /// 标识视频流的类型，可选摄像头流或者屏幕分享流，未填写表示不录制视频。  - CAMERASTREAM：摄像头视频流 - SCREENSTREAM：屏幕分享视频流  默认为CAMERASTREAM。 
        /// </summary>
        /// <value>标识视频流的类型，可选摄像头流或者屏幕分享流，未填写表示不录制视频。  - CAMERASTREAM：摄像头视频流 - SCREENSTREAM：屏幕分享视频流  默认为CAMERASTREAM。 </value>
        [JsonConverter(typeof(EnumClassConverter<VideoTypeEnum>))]
        public class VideoTypeEnum
        {
            /// <summary>
            /// Enum CAMERASTREAM for value: CAMERASTREAM
            /// </summary>
            public static readonly VideoTypeEnum CAMERASTREAM = new VideoTypeEnum("CAMERASTREAM");

            /// <summary>
            /// Enum SCREENSTREAM for value: SCREENSTREAM
            /// </summary>
            public static readonly VideoTypeEnum SCREENSTREAM = new VideoTypeEnum("SCREENSTREAM");

            /// <summary>
            /// Enum EMPTY for value: 
            /// </summary>
            public static readonly VideoTypeEnum EMPTY = new VideoTypeEnum("");

            private static readonly Dictionary<string, VideoTypeEnum> StaticFields =
            new Dictionary<string, VideoTypeEnum>()
            {
                { "CAMERASTREAM", CAMERASTREAM },
                { "SCREENSTREAM", SCREENSTREAM },
                { "", EMPTY },
            };

            private string _value;

            public VideoTypeEnum()
            {

            }

            public VideoTypeEnum(string value)
            {
                _value = value;
            }

            public static VideoTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VideoTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoTypeEnum a, VideoTypeEnum b)
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

            public static bool operator !=(VideoTypeEnum a, VideoTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 指定窗口拉取的分辨率档位。  - LD - SD - HD - FHD  缺省为FHD。 
        /// </summary>
        /// <value>指定窗口拉取的分辨率档位。  - LD - SD - HD - FHD  缺省为FHD。 </value>
        [JsonConverter(typeof(EnumClassConverter<SelectStreamTypeEnum>))]
        public class SelectStreamTypeEnum
        {
            /// <summary>
            /// Enum LD for value: LD
            /// </summary>
            public static readonly SelectStreamTypeEnum LD = new SelectStreamTypeEnum("LD");

            /// <summary>
            /// Enum SD for value: SD
            /// </summary>
            public static readonly SelectStreamTypeEnum SD = new SelectStreamTypeEnum("SD");

            /// <summary>
            /// Enum HD for value: HD
            /// </summary>
            public static readonly SelectStreamTypeEnum HD = new SelectStreamTypeEnum("HD");

            /// <summary>
            /// Enum FHD for value: FHD
            /// </summary>
            public static readonly SelectStreamTypeEnum FHD = new SelectStreamTypeEnum("FHD");

            private static readonly Dictionary<string, SelectStreamTypeEnum> StaticFields =
            new Dictionary<string, SelectStreamTypeEnum>()
            {
                { "LD", LD },
                { "SD", SD },
                { "HD", HD },
                { "FHD", FHD },
            };

            private string _value;

            public SelectStreamTypeEnum()
            {

            }

            public SelectStreamTypeEnum(string value)
            {
                _value = value;
            }

            public static SelectStreamTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SelectStreamTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SelectStreamTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SelectStreamTypeEnum a, SelectStreamTypeEnum b)
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

            public static bool operator !=(SelectStreamTypeEnum a, SelectStreamTypeEnum b)
            {
                return !(a == b);
            }
        }

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
        /// 任务编号
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
        /// 选看的用户id，单个录制任务内保证唯一
        /// </summary>
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        ///  是否录制音频。  - true：录制音频 - false：不录制音频  缺省为true。 
        /// </summary>
        [JsonProperty("is_record_audio", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRecordAudio { get; set; }

        /// <summary>
        /// 标识视频流的类型，可选摄像头流或者屏幕分享流，未填写表示不录制视频。  - CAMERASTREAM：摄像头视频流 - SCREENSTREAM：屏幕分享视频流  默认为CAMERASTREAM。 
        /// </summary>
        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTypeEnum VideoType { get; set; }
        /// <summary>
        /// 指定窗口拉取的分辨率档位。  - LD - SD - HD - FHD  缺省为FHD。 
        /// </summary>
        [JsonProperty("select_stream_type", NullValueHandling = NullValueHandling.Ignore)]
        public SelectStreamTypeEnum SelectStreamType { get; set; }
        /// <summary>
        /// 最长空闲频道时间。  取值范围：[5，43200]，默认值为30。  单位：秒。  如果频道内无连麦方的状态持续超过该时间，录制程序会自动退出。退出后，再次调用start请求，会产生新的录制任务。  连麦方指：joiner或者publisher的用户。 
        /// </summary>
        [JsonProperty("max_idle_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIdleTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("record_param", NullValueHandling = NullValueHandling.Ignore)]
        public RecordParam RecordParam { get; set; }

        /// <summary>
        /// 创建时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
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
        /// 针对任务状态的详细信息描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 任务开始时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务完成时间，形如“2006-01-02T15:04:05.075Z”，时区为：UTC
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
            sb.Append("class CreateIndividualStreamJobResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  isRecordAudio: ").Append(IsRecordAudio).Append("\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  selectStreamType: ").Append(SelectStreamType).Append("\n");
            sb.Append("  maxIdleTime: ").Append(MaxIdleTime).Append("\n");
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
            return this.Equals(input as CreateIndividualStreamJobResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateIndividualStreamJobResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.StreamName != input.StreamName || (this.StreamName != null && !this.StreamName.Equals(input.StreamName))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.IsRecordAudio != input.IsRecordAudio || (this.IsRecordAudio != null && !this.IsRecordAudio.Equals(input.IsRecordAudio))) return false;
            if (this.VideoType != input.VideoType) return false;
            if (this.SelectStreamType != input.SelectStreamType) return false;
            if (this.MaxIdleTime != input.MaxIdleTime || (this.MaxIdleTime != null && !this.MaxIdleTime.Equals(input.MaxIdleTime))) return false;
            if (this.RecordParam != input.RecordParam || (this.RecordParam != null && !this.RecordParam.Equals(input.RecordParam))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.State != input.State) return false;
            if (this.StopReason != input.StopReason) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.StopTime != input.StopTime || (this.StopTime != null && !this.StopTime.Equals(input.StopTime))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.StreamName != null) hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.IsRecordAudio != null) hashCode = hashCode * 59 + this.IsRecordAudio.GetHashCode();
                hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                hashCode = hashCode * 59 + this.SelectStreamType.GetHashCode();
                if (this.MaxIdleTime != null) hashCode = hashCode * 59 + this.MaxIdleTime.GetHashCode();
                if (this.RecordParam != null) hashCode = hashCode * 59 + this.RecordParam.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.StopReason.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.StopTime != null) hashCode = hashCode * 59 + this.StopTime.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
