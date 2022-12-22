using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 修改规则动作请求结构体
    /// </summary>
    public class UpdateActionReq 
    {

        /// <summary>
        /// **参数说明**：规则动作的类型。 **取值范围**： - HTTP_FORWARDING：HTTP服务消息类型。 - DIS_FORWARDING：转发DIS服务消息类型。 - OBS_FORWARDING：转发OBS服务消息类型。 - AMQP_FORWARDING：转发AMQP服务消息类型。 - DMS_KAFKA_FORWARDING：转发kafka消息类型。
        /// </summary>
        [JsonProperty("channel", NullValueHandling = NullValueHandling.Ignore)]
        public string Channel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("channel_detail", NullValueHandling = NullValueHandling.Ignore)]
        public ChannelDetail ChannelDetail { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateActionReq {\n");
            sb.Append("  channel: ").Append(Channel).Append("\n");
            sb.Append("  channelDetail: ").Append(ChannelDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateActionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateActionReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.ChannelDetail == input.ChannelDetail ||
                    (this.ChannelDetail != null &&
                    this.ChannelDetail.Equals(input.ChannelDetail))
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
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.ChannelDetail != null)
                    hashCode = hashCode * 59 + this.ChannelDetail.GetHashCode();
                return hashCode;
            }
        }
    }
}
