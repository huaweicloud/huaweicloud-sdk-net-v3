using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListRtcClientQosDetailsRequest 
    {
        /// <summary>
        /// 需查询的指标，填all则返回所有指标。多个指标使用&#39;,&#39;分割 - appcpu：端侧APP CPU使用率（appCpu） - syscpu：端侧系统 CPU使用率（deviceCpu） - abit：端侧音频码率kpbs（bitrate） - vbit：端侧视频码率kbps（bitRate） - dbit：端侧辅流码率kbps（bitRate） - vfps：端侧视频帧率fps（actFrameRate） - dfps：端侧辅流帧率fps（actFrameRate） - vblock：端侧视频卡顿率（统计大于等于600ms视频卡顿） - dblock：端侧辅流卡顿率（统计大于等于600ms辅流卡顿） - aloss：端侧音频丢包率（pktLoss） - vloss：端侧视频丢包率（pktLoss） - dloss：端侧辅流丢包率（pktLoss） - vwidth：端侧视频分辨率宽（actPicW） - vheight：端侧视频分辨率高（actPicH） - dwidth：端侧辅流分辨率宽（actPicW） - dheight：端侧辅流分辨率高（actPicH） - ajitter：端侧音频抖动率（jitter） - artt：端侧音频时延（rtt） - vjitter：端侧视频抖动率（jitter） - vrtt：端侧视频时延（rtt） - djitter：端侧辅流抖动率（jitter） - drtt：端侧辅流时延（rtt） 
        /// </summary>
        /// <value>需查询的指标，填all则返回所有指标。多个指标使用&#39;,&#39;分割 - appcpu：端侧APP CPU使用率（appCpu） - syscpu：端侧系统 CPU使用率（deviceCpu） - abit：端侧音频码率kpbs（bitrate） - vbit：端侧视频码率kbps（bitRate） - dbit：端侧辅流码率kbps（bitRate） - vfps：端侧视频帧率fps（actFrameRate） - dfps：端侧辅流帧率fps（actFrameRate） - vblock：端侧视频卡顿率（统计大于等于600ms视频卡顿） - dblock：端侧辅流卡顿率（统计大于等于600ms辅流卡顿） - aloss：端侧音频丢包率（pktLoss） - vloss：端侧视频丢包率（pktLoss） - dloss：端侧辅流丢包率（pktLoss） - vwidth：端侧视频分辨率宽（actPicW） - vheight：端侧视频分辨率高（actPicH） - dwidth：端侧辅流分辨率宽（actPicW） - dheight：端侧辅流分辨率高（actPicH） - ajitter：端侧音频抖动率（jitter） - artt：端侧音频时延（rtt） - vjitter：端侧视频抖动率（jitter） - vrtt：端侧视频时延（rtt） - djitter：端侧辅流抖动率（jitter） - drtt：端侧辅流时延（rtt） </value>
        [JsonConverter(typeof(EnumClassConverter<MidEnum>))]
        public class MidEnum
        {
            /// <summary>
            /// Enum APPCPU for value: appcpu
            /// </summary>
            public static readonly MidEnum APPCPU = new MidEnum("appcpu");

            /// <summary>
            /// Enum SYSCPU for value: syscpu
            /// </summary>
            public static readonly MidEnum SYSCPU = new MidEnum("syscpu");

            /// <summary>
            /// Enum ABIT for value: abit
            /// </summary>
            public static readonly MidEnum ABIT = new MidEnum("abit");

            /// <summary>
            /// Enum ABLOCK for value: ablock
            /// </summary>
            public static readonly MidEnum ABLOCK = new MidEnum("ablock");

            /// <summary>
            /// Enum VBIT for value: vbit
            /// </summary>
            public static readonly MidEnum VBIT = new MidEnum("vbit");

            /// <summary>
            /// Enum DBIT for value: dbit
            /// </summary>
            public static readonly MidEnum DBIT = new MidEnum("dbit");

            /// <summary>
            /// Enum VFPS for value: vfps
            /// </summary>
            public static readonly MidEnum VFPS = new MidEnum("vfps");

            /// <summary>
            /// Enum DFPS for value: dfps
            /// </summary>
            public static readonly MidEnum DFPS = new MidEnum("dfps");

            /// <summary>
            /// Enum VBLOCK for value: vblock
            /// </summary>
            public static readonly MidEnum VBLOCK = new MidEnum("vblock");

            /// <summary>
            /// Enum DBLOCK for value: dblock
            /// </summary>
            public static readonly MidEnum DBLOCK = new MidEnum("dblock");

            /// <summary>
            /// Enum ALOSS for value: aloss
            /// </summary>
            public static readonly MidEnum ALOSS = new MidEnum("aloss");

            /// <summary>
            /// Enum VLOSS for value: vloss
            /// </summary>
            public static readonly MidEnum VLOSS = new MidEnum("vloss");

            /// <summary>
            /// Enum DLOSS for value: dloss
            /// </summary>
            public static readonly MidEnum DLOSS = new MidEnum("dloss");

            /// <summary>
            /// Enum VWIDTH for value: vwidth
            /// </summary>
            public static readonly MidEnum VWIDTH = new MidEnum("vwidth");

            /// <summary>
            /// Enum VHEIGHT for value: vheight
            /// </summary>
            public static readonly MidEnum VHEIGHT = new MidEnum("vheight");

            /// <summary>
            /// Enum DWIDTH for value: dwidth
            /// </summary>
            public static readonly MidEnum DWIDTH = new MidEnum("dwidth");

            /// <summary>
            /// Enum DHEIGHT for value: dheight
            /// </summary>
            public static readonly MidEnum DHEIGHT = new MidEnum("dheight");

            /// <summary>
            /// Enum AJITTER for value: ajitter
            /// </summary>
            public static readonly MidEnum AJITTER = new MidEnum("ajitter");

            /// <summary>
            /// Enum ARTT for value: artt
            /// </summary>
            public static readonly MidEnum ARTT = new MidEnum("artt");

            /// <summary>
            /// Enum VJITTER for value: vjitter
            /// </summary>
            public static readonly MidEnum VJITTER = new MidEnum("vjitter");

            /// <summary>
            /// Enum VRTT for value: vrtt
            /// </summary>
            public static readonly MidEnum VRTT = new MidEnum("vrtt");

            /// <summary>
            /// Enum DJITTER for value: djitter
            /// </summary>
            public static readonly MidEnum DJITTER = new MidEnum("djitter");

            /// <summary>
            /// Enum DRTT for value: drtt
            /// </summary>
            public static readonly MidEnum DRTT = new MidEnum("drtt");

            private static readonly Dictionary<string, MidEnum> StaticFields =
            new Dictionary<string, MidEnum>()
            {
                { "appcpu", APPCPU },
                { "syscpu", SYSCPU },
                { "abit", ABIT },
                { "ablock", ABLOCK },
                { "vbit", VBIT },
                { "dbit", DBIT },
                { "vfps", VFPS },
                { "dfps", DFPS },
                { "vblock", VBLOCK },
                { "dblock", DBLOCK },
                { "aloss", ALOSS },
                { "vloss", VLOSS },
                { "dloss", DLOSS },
                { "vwidth", VWIDTH },
                { "vheight", VHEIGHT },
                { "dwidth", DWIDTH },
                { "dheight", DHEIGHT },
                { "ajitter", AJITTER },
                { "artt", ARTT },
                { "vjitter", VJITTER },
                { "vrtt", VRTT },
                { "djitter", DJITTER },
                { "drtt", DRTT },
            };

            private string _value;

            public MidEnum()
            {

            }

            public MidEnum(string value)
            {
                _value = value;
            }

            public static MidEnum FromValue(string value)
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

                if (this.Equals(obj as MidEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MidEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MidEnum a, MidEnum b)
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

            public static bool operator !=(MidEnum a, MidEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。 
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。 
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息，与路径参数中的项目ID相同。 
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 域名 
        /// </summary>
        [SDKProperty("domain", IsQuery = true)]
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 应用id 
        /// </summary>
        [SDKProperty("app_id", IsQuery = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 房间ID 
        /// </summary>
        [SDKProperty("room_id", IsQuery = true)]
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 发送端用户 
        /// </summary>
        [SDKProperty("user_id", IsQuery = true)]
        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        /// <summary>
        /// 需查询接收端用户id 
        /// </summary>
        [SDKProperty("peer_id", IsQuery = true)]
        [JsonProperty("peer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerId { get; set; }

        /// <summary>
        /// 流号 
        /// </summary>
        [SDKProperty("stream_id", IsQuery = true)]
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 判断上下行数据 
        /// </summary>
        [SDKProperty("direction", IsQuery = true)]
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 需查询的指标，填all则返回所有指标。多个指标使用&#39;,&#39;分割 - appcpu：端侧APP CPU使用率（appCpu） - syscpu：端侧系统 CPU使用率（deviceCpu） - abit：端侧音频码率kpbs（bitrate） - vbit：端侧视频码率kbps（bitRate） - dbit：端侧辅流码率kbps（bitRate） - vfps：端侧视频帧率fps（actFrameRate） - dfps：端侧辅流帧率fps（actFrameRate） - vblock：端侧视频卡顿率（统计大于等于600ms视频卡顿） - dblock：端侧辅流卡顿率（统计大于等于600ms辅流卡顿） - aloss：端侧音频丢包率（pktLoss） - vloss：端侧视频丢包率（pktLoss） - dloss：端侧辅流丢包率（pktLoss） - vwidth：端侧视频分辨率宽（actPicW） - vheight：端侧视频分辨率高（actPicH） - dwidth：端侧辅流分辨率宽（actPicW） - dheight：端侧辅流分辨率高（actPicH） - ajitter：端侧音频抖动率（jitter） - artt：端侧音频时延（rtt） - vjitter：端侧视频抖动率（jitter） - vrtt：端侧视频时延（rtt） - djitter：端侧辅流抖动率（jitter） - drtt：端侧辅流时延（rtt） 
        /// </summary>
        [SDKProperty("mid", IsQuery = true)]
        [JsonProperty("mid", NullValueHandling = NullValueHandling.Ignore)]
        public MidEnum Mid { get; set; }
        /// <summary>
        /// 查询起始时间。UTC时间，格式：yyyy-mm-ddThh:mm:ssZ，如2020-04-23T06:00:00Z 
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询结束时间。UTC时间，格式：yyyy-mm-ddThh:mm:ssZ，如2020-04-23T07:00:00Z 
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询的时间类型取值：stime 数据库打点时间，不填默认ctime查询
        /// </summary>
        [SDKProperty("time_type", IsQuery = true)]
        [JsonProperty("time_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeType { get; set; }

        /// <summary>
        /// 查询结果限制 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询偏移量 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRtcClientQosDetailsRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  userId: ").Append(UserId).Append("\n");
            sb.Append("  peerId: ").Append(PeerId).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  mid: ").Append(Mid).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  timeType: ").Append(TimeType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRtcClientQosDetailsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRtcClientQosDetailsRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.UserId != input.UserId || (this.UserId != null && !this.UserId.Equals(input.UserId))) return false;
            if (this.PeerId != input.PeerId || (this.PeerId != null && !this.PeerId.Equals(input.PeerId))) return false;
            if (this.StreamId != input.StreamId || (this.StreamId != null && !this.StreamId.Equals(input.StreamId))) return false;
            if (this.Direction != input.Direction || (this.Direction != null && !this.Direction.Equals(input.Direction))) return false;
            if (this.Mid != input.Mid) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.TimeType != input.TimeType || (this.TimeType != null && !this.TimeType.Equals(input.TimeType))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.UserId != null) hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.PeerId != null) hashCode = hashCode * 59 + this.PeerId.GetHashCode();
                if (this.StreamId != null) hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.Direction != null) hashCode = hashCode * 59 + this.Direction.GetHashCode();
                hashCode = hashCode * 59 + this.Mid.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.TimeType != null) hashCode = hashCode * 59 + this.TimeType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
