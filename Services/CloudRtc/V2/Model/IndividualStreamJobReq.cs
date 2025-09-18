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
    /// 单流任务请求，转推和录制至少选一个
    /// </summary>
    public class IndividualStreamJobReq 
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

            private static readonly Dictionary<string, VideoTypeEnum> StaticFields =
            new Dictionary<string, VideoTypeEnum>()
            {
                { "CAMERASTREAM", CAMERASTREAM },
                { "SCREENSTREAM", SCREENSTREAM },
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

            public static bool operator !=(SelectStreamTypeEnum a, SelectStreamTypeEnum b)
            {
                return !(a == b);
            }
        }


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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndividualStreamJobReq {\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  isRecordAudio: ").Append(IsRecordAudio).Append("\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  selectStreamType: ").Append(SelectStreamType).Append("\n");
            sb.Append("  maxIdleTime: ").Append(MaxIdleTime).Append("\n");
            sb.Append("  recordParam: ").Append(RecordParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IndividualStreamJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IndividualStreamJobReq input)
        {
            if (input == null) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.IsRecordAudio != input.IsRecordAudio || (this.IsRecordAudio != null && !this.IsRecordAudio.Equals(input.IsRecordAudio))) return false;
            if (this.VideoType != input.VideoType) return false;
            if (this.SelectStreamType != input.SelectStreamType) return false;
            if (this.MaxIdleTime != input.MaxIdleTime || (this.MaxIdleTime != null && !this.MaxIdleTime.Equals(input.MaxIdleTime))) return false;
            if (this.RecordParam != input.RecordParam || (this.RecordParam != null && !this.RecordParam.Equals(input.RecordParam))) return false;

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
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.IsRecordAudio != null) hashCode = hashCode * 59 + this.IsRecordAudio.GetHashCode();
                hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                hashCode = hashCode * 59 + this.SelectStreamType.GetHashCode();
                if (this.MaxIdleTime != null) hashCode = hashCode * 59 + this.MaxIdleTime.GetHashCode();
                if (this.RecordParam != null) hashCode = hashCode * 59 + this.RecordParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
