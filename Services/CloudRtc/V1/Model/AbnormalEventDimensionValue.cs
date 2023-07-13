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
    public class AbnormalEventDimensionValue 
    {

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
        /// 异常影响的用户数
        /// </summary>
        [JsonProperty("user_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? UserCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbnormalEventDimensionValue {\n");
            sb.Append("  abnormalType: ").Append(AbnormalType).Append("\n");
            sb.Append("  abnormalTypeDesc: ").Append(AbnormalTypeDesc).Append("\n");
            sb.Append("  abnormalFactor: ").Append(AbnormalFactor).Append("\n");
            sb.Append("  abnormalFactorDesc: ").Append(AbnormalFactorDesc).Append("\n");
            sb.Append("  userCount: ").Append(UserCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AbnormalEventDimensionValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AbnormalEventDimensionValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbnormalType == input.AbnormalType ||
                    (this.AbnormalType != null &&
                    this.AbnormalType.Equals(input.AbnormalType))
                ) && 
                (
                    this.AbnormalTypeDesc == input.AbnormalTypeDesc ||
                    (this.AbnormalTypeDesc != null &&
                    this.AbnormalTypeDesc.Equals(input.AbnormalTypeDesc))
                ) && 
                (
                    this.AbnormalFactor == input.AbnormalFactor ||
                    (this.AbnormalFactor != null &&
                    this.AbnormalFactor.Equals(input.AbnormalFactor))
                ) && 
                (
                    this.AbnormalFactorDesc == input.AbnormalFactorDesc ||
                    (this.AbnormalFactorDesc != null &&
                    this.AbnormalFactorDesc.Equals(input.AbnormalFactorDesc))
                ) && 
                (
                    this.UserCount == input.UserCount ||
                    (this.UserCount != null &&
                    this.UserCount.Equals(input.UserCount))
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
                if (this.AbnormalType != null)
                    hashCode = hashCode * 59 + this.AbnormalType.GetHashCode();
                if (this.AbnormalTypeDesc != null)
                    hashCode = hashCode * 59 + this.AbnormalTypeDesc.GetHashCode();
                if (this.AbnormalFactor != null)
                    hashCode = hashCode * 59 + this.AbnormalFactor.GetHashCode();
                if (this.AbnormalFactorDesc != null)
                    hashCode = hashCode * 59 + this.AbnormalFactorDesc.GetHashCode();
                if (this.UserCount != null)
                    hashCode = hashCode * 59 + this.UserCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
