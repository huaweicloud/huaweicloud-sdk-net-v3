using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SessionConfiguration 
    {

        /// <summary>
        /// TCP会话过期时间。
        /// </summary>
        [JsonProperty("tcp_session_expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TcpSessionExpireTime { get; set; }

        /// <summary>
        /// UDP会话过期时间。
        /// </summary>
        [JsonProperty("udp_session_expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? UdpSessionExpireTime { get; set; }

        /// <summary>
        /// ICMP会话过期时间。
        /// </summary>
        [JsonProperty("icmp_session_expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? IcmpSessionExpireTime { get; set; }

        /// <summary>
        /// TCP连接关闭时TIME_WAIT状态持续时间。
        /// </summary>
        [JsonProperty("tcp_time_wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TcpTimeWaitTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionConfiguration {\n");
            sb.Append("  tcpSessionExpireTime: ").Append(TcpSessionExpireTime).Append("\n");
            sb.Append("  udpSessionExpireTime: ").Append(UdpSessionExpireTime).Append("\n");
            sb.Append("  icmpSessionExpireTime: ").Append(IcmpSessionExpireTime).Append("\n");
            sb.Append("  tcpTimeWaitTime: ").Append(TcpTimeWaitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionConfiguration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TcpSessionExpireTime == input.TcpSessionExpireTime ||
                    (this.TcpSessionExpireTime != null &&
                    this.TcpSessionExpireTime.Equals(input.TcpSessionExpireTime))
                ) && 
                (
                    this.UdpSessionExpireTime == input.UdpSessionExpireTime ||
                    (this.UdpSessionExpireTime != null &&
                    this.UdpSessionExpireTime.Equals(input.UdpSessionExpireTime))
                ) && 
                (
                    this.IcmpSessionExpireTime == input.IcmpSessionExpireTime ||
                    (this.IcmpSessionExpireTime != null &&
                    this.IcmpSessionExpireTime.Equals(input.IcmpSessionExpireTime))
                ) && 
                (
                    this.TcpTimeWaitTime == input.TcpTimeWaitTime ||
                    (this.TcpTimeWaitTime != null &&
                    this.TcpTimeWaitTime.Equals(input.TcpTimeWaitTime))
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
                if (this.TcpSessionExpireTime != null)
                    hashCode = hashCode * 59 + this.TcpSessionExpireTime.GetHashCode();
                if (this.UdpSessionExpireTime != null)
                    hashCode = hashCode * 59 + this.UdpSessionExpireTime.GetHashCode();
                if (this.IcmpSessionExpireTime != null)
                    hashCode = hashCode * 59 + this.IcmpSessionExpireTime.GetHashCode();
                if (this.TcpTimeWaitTime != null)
                    hashCode = hashCode * 59 + this.TcpTimeWaitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
