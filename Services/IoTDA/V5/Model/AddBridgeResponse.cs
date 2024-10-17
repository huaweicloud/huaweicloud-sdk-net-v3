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
    /// Response Object
    /// </summary>
    public class AddBridgeResponse : SdkResponse
    {

        /// <summary>
        /// 网桥ID，用于唯一标识一个网桥。在注册网桥时直接指定，或者由物联网平台分配获得。
        /// </summary>
        [JsonProperty("bridge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeId { get; set; }

        /// <summary>
        /// 网桥名称。
        /// </summary>
        [JsonProperty("bridge_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("auth_info", NullValueHandling = NullValueHandling.Ignore)]
        public BridgeAuthInfo AuthInfo { get; set; }

        /// <summary>
        /// 在物联网平台注册网桥的时间。格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddBridgeResponse {\n");
            sb.Append("  bridgeId: ").Append(BridgeId).Append("\n");
            sb.Append("  bridgeName: ").Append(BridgeName).Append("\n");
            sb.Append("  authInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddBridgeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddBridgeResponse input)
        {
            if (input == null) return false;
            if (this.BridgeId != input.BridgeId || (this.BridgeId != null && !this.BridgeId.Equals(input.BridgeId))) return false;
            if (this.BridgeName != input.BridgeName || (this.BridgeName != null && !this.BridgeName.Equals(input.BridgeName))) return false;
            if (this.AuthInfo != input.AuthInfo || (this.AuthInfo != null && !this.AuthInfo.Equals(input.AuthInfo))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.BridgeId != null) hashCode = hashCode * 59 + this.BridgeId.GetHashCode();
                if (this.BridgeName != null) hashCode = hashCode * 59 + this.BridgeName.GetHashCode();
                if (this.AuthInfo != null) hashCode = hashCode * 59 + this.AuthInfo.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
