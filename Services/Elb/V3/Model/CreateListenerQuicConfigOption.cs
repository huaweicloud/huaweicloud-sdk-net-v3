using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// listener对象中的quic配置信息，仅protocol为HTTPS时有效。 支持创建和修改； 支持HTTPS监听器升级QUIC监听器能力。仅HTTPS监听器支持升级到QUIC监听器 当客户开启升级之后选择关联的quic监听器，https对象要保存改quic监听器ID。 对于TCP/UDP/HTTP/QUIC监听器，若该字段非空则报错。
    /// </summary>
    public class CreateListenerQuicConfigOption 
    {

        /// <summary>
        /// 监听器关联的QUIC监听器ID。指定的listener id必须已存在，且协议类型为QUIC，不能指定为null，否则与enable_quic_upgrade冲突。
        /// </summary>
        [JsonProperty("quic_listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuicListenerId { get; set; }

        /// <summary>
        /// QUIC升级的开启状态。 True:开启QUIC升级； Flase：关闭QUIC升级（默认）。 开启HTTPS监听器升级QUIC监听器能力
        /// </summary>
        [JsonProperty("enable_quic_upgrade", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQuicUpgrade { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateListenerQuicConfigOption {\n");
            sb.Append("  quicListenerId: ").Append(QuicListenerId).Append("\n");
            sb.Append("  enableQuicUpgrade: ").Append(EnableQuicUpgrade).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateListenerQuicConfigOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateListenerQuicConfigOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuicListenerId == input.QuicListenerId ||
                    (this.QuicListenerId != null &&
                    this.QuicListenerId.Equals(input.QuicListenerId))
                ) && 
                (
                    this.EnableQuicUpgrade == input.EnableQuicUpgrade ||
                    (this.EnableQuicUpgrade != null &&
                    this.EnableQuicUpgrade.Equals(input.EnableQuicUpgrade))
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
                if (this.QuicListenerId != null)
                    hashCode = hashCode * 59 + this.QuicListenerId.GetHashCode();
                if (this.EnableQuicUpgrade != null)
                    hashCode = hashCode * 59 + this.EnableQuicUpgrade.GetHashCode();
                return hashCode;
            }
        }
    }
}
