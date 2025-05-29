using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Proxy绑定解绑弹性公网IP请求体。
    /// </summary>
    public class SwitchGaussMySqlProxyEipRequestBody 
    {

        /// <summary>
        /// 待绑定的弹性公网IP地址。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 弹性公网IP地址对应的ID。请求为绑定弹性公网IP时需传入该参数，请求为解绑弹性公网IP时无需传入。
        /// </summary>
        [JsonProperty("public_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpId { get; set; }

        /// <summary>
        /// 请求是否为绑定弹性公网IP。  取值范围： - true：表示请求为绑定弹性公网IP。 - false：表示请求为解绑弹性公网IP。
        /// </summary>
        [JsonProperty("bind", NullValueHandling = NullValueHandling.Ignore)]
        public string Bind { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchGaussMySqlProxyEipRequestBody {\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  publicIpId: ").Append(PublicIpId).Append("\n");
            sb.Append("  bind: ").Append(Bind).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchGaussMySqlProxyEipRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchGaussMySqlProxyEipRequestBody input)
        {
            if (input == null) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.PublicIpId != input.PublicIpId || (this.PublicIpId != null && !this.PublicIpId.Equals(input.PublicIpId))) return false;
            if (this.Bind != input.Bind || (this.Bind != null && !this.Bind.Equals(input.Bind))) return false;

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
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.PublicIpId != null) hashCode = hashCode * 59 + this.PublicIpId.GetHashCode();
                if (this.Bind != null) hashCode = hashCode * 59 + this.Bind.GetHashCode();
                return hashCode;
            }
        }
    }
}
