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
    /// 
    /// </summary>
    public class AbnormalEvent 
    {

        /// <summary>
        /// 采样时间。日期格式按照ISO8601表示法，并使用UTC时间。格式为YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 出现异常的用户ID
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 出现异常的房间ID
        /// </summary>
        [JsonProperty("room_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoomId { get; set; }

        /// <summary>
        /// 出现异常的环节 - join_room：加入房间 - communication：通话中 
        /// </summary>
        [JsonProperty("stage", NullValueHandling = NullValueHandling.Ignore)]
        public string Stage { get; set; }

        /// <summary>
        /// 事件发生位置 - local：事件发生在客户端本地 - remote：事件发生在远端 
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        /// <summary>
        /// 如果根因来自远端用户，则peerid为远端用户的用户ID。如果根因来自自身，则peerid为空字符串
        /// </summary>
        [JsonProperty("peer_uid", NullValueHandling = NullValueHandling.Ignore)]
        public string PeerUid { get; set; }

        /// <summary>
        /// 异常类型： - 1：进房慢(5s加入房间失败) - 2：视频卡顿 - 3：音频卡顿 
        /// </summary>
        [JsonProperty("abnormal_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalType { get; set; }

        /// <summary>
        /// 异常类型描述与异常类型对应，支持国际化，取值范围为： - 进房慢(5s加入房间失败) - 视频卡顿 - 音频卡顿 
        /// </summary>
        [JsonProperty("abnormal_type_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AbnormalTypeDesc { get; set; }

        /// <summary>
        /// 异常因素 当异常类型为1时，异常因素取值范围为： - 1：建链失败 - 2：房间非空闲 - 3：服务器异常 - 4：服务器反馈503 - 5：鉴权失败 - 6：鉴权重试 - 7：时钟同步失败 - 8：url错误 - 9：终端内部异常 - 90000004：SDK发出的加入房间信令响应超时 - 90100009：web侧没有收到MSP下发的配置信息 - 90100008：websocket链路建链失败 - 10000001：服务侧返回的异常信息 - 31000003：服务侧返回的异常信息 - 32000030：服务侧返回的异常信息 - 15：浏览器设置sdp异常 当异常类型为2或者3时，异常因素取值范围为： - 1：系统CPU占用高 - 2：App CPU占用高 - 3：音频上行网络延时 - 4：音频上行网络抖动 - 5：视频上行网络延时 - 6：视频上行网络抖动 - 7：音频下行网络延时 - 8：音频下行网络抖动 - 9：视频下行网络延时 - 10：视频下行网络抖动 - 11：上行音频丢包 - 12：上行视频丢包 - 13：下行音频丢包 - 14：下行视频丢包 - 15：下行音频无声音 - 16：其他 - 17：对端用户离线 - 18：对端用户无码流 - 19：对端用户无帧率 - 20：本端服务器下行无码流 - 21：本端服务器下行无帧率 
        /// </summary>
        [JsonProperty("abnormal_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? AbnormalFactor { get; set; }

        /// <summary>
        /// 异常因素描述，支持国际化 当异常类型为1时，异常因素描述与异常因素对应，取值范围为： - 建链失败 - 房间非空闲 - 服务器异常 - 服务器反馈503 - 鉴权失败 - 鉴权重试 - 时钟同步失败 - url错误 - 终端内部异常 - SDK发出的加入房间信令响应超时 - web侧没有收到MSP下发的配置信息 - websocket链路建链失败 - 服务侧返回的异常信息 - 服务侧返回的异常信息 - 服务侧返回的异常信息 - 浏览器设置sdp异常 当异常类型为2或者3时，异常因素描述与异常因素对应，取值范围为： - 系统CPU占用高 - App CPU占用高 - 音频上行网络延时 - 音频上行网络抖动 - 视频上行网络延时 - 视频上行网络抖动 - 音频下行网络延时 - 音频下行网络抖动 - 视频下行网络延时 - 视频下行网络抖动 - 上行音频丢包 - 上行视频丢包 - 下行音频丢包 - 下行视频丢包 - 下行音频无声音 - 其他 - 对端用户离线 - 对端用户无码流 - 对端用户无帧率 - 本端服务器下行无码流 - 本端服务器下行无帧率 其他情况，异常因素描述为：其他 
        /// </summary>
        [JsonProperty("abnormal_factor_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AbnormalFactorDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbnormalEvent {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  roomId: ").Append(RoomId).Append("\n");
            sb.Append("  stage: ").Append(Stage).Append("\n");
            sb.Append("  location: ").Append(Location).Append("\n");
            sb.Append("  peerUid: ").Append(PeerUid).Append("\n");
            sb.Append("  abnormalType: ").Append(AbnormalType).Append("\n");
            sb.Append("  abnormalTypeDesc: ").Append(AbnormalTypeDesc).Append("\n");
            sb.Append("  abnormalFactor: ").Append(AbnormalFactor).Append("\n");
            sb.Append("  abnormalFactorDesc: ").Append(AbnormalFactorDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AbnormalEvent);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AbnormalEvent input)
        {
            if (input == null) return false;
            if (this.Time != input.Time || (this.Time != null && !this.Time.Equals(input.Time))) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.RoomId != input.RoomId || (this.RoomId != null && !this.RoomId.Equals(input.RoomId))) return false;
            if (this.Stage != input.Stage || (this.Stage != null && !this.Stage.Equals(input.Stage))) return false;
            if (this.Location != input.Location || (this.Location != null && !this.Location.Equals(input.Location))) return false;
            if (this.PeerUid != input.PeerUid || (this.PeerUid != null && !this.PeerUid.Equals(input.PeerUid))) return false;
            if (this.AbnormalType != input.AbnormalType || (this.AbnormalType != null && !this.AbnormalType.Equals(input.AbnormalType))) return false;
            if (this.AbnormalTypeDesc != input.AbnormalTypeDesc || (this.AbnormalTypeDesc != null && !this.AbnormalTypeDesc.Equals(input.AbnormalTypeDesc))) return false;
            if (this.AbnormalFactor != input.AbnormalFactor || (this.AbnormalFactor != null && !this.AbnormalFactor.Equals(input.AbnormalFactor))) return false;
            if (this.AbnormalFactorDesc != input.AbnormalFactorDesc || (this.AbnormalFactorDesc != null && !this.AbnormalFactorDesc.Equals(input.AbnormalFactorDesc))) return false;

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
                if (this.Time != null) hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.RoomId != null) hashCode = hashCode * 59 + this.RoomId.GetHashCode();
                if (this.Stage != null) hashCode = hashCode * 59 + this.Stage.GetHashCode();
                if (this.Location != null) hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.PeerUid != null) hashCode = hashCode * 59 + this.PeerUid.GetHashCode();
                if (this.AbnormalType != null) hashCode = hashCode * 59 + this.AbnormalType.GetHashCode();
                if (this.AbnormalTypeDesc != null) hashCode = hashCode * 59 + this.AbnormalTypeDesc.GetHashCode();
                if (this.AbnormalFactor != null) hashCode = hashCode * 59 + this.AbnormalFactor.GetHashCode();
                if (this.AbnormalFactorDesc != null) hashCode = hashCode * 59 + this.AbnormalFactorDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
