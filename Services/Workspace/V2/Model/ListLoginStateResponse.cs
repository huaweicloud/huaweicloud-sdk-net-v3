using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListLoginStateResponse : SdkResponse
    {

        /// <summary>
        /// 使用中。
        /// </summary>
        [JsonProperty("in_use_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InUseNum { get; set; }

        /// <summary>
        /// 关机数目(关机中、已关机)。
        /// </summary>
        [JsonProperty("stop_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? StopNum { get; set; }

        /// <summary>
        /// 未注册数目。
        /// </summary>
        [JsonProperty("unregistered_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnregisteredNum { get; set; }

        /// <summary>
        /// 未注册数目。
        /// </summary>
        [JsonProperty("unable_to_connect_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnableToConnectNum { get; set; }

        /// <summary>
        /// 空闲数目。
        /// </summary>
        [JsonProperty("ready_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadyNum { get; set; }

        /// <summary>
        /// 断开连接数目。
        /// </summary>
        [JsonProperty("disconnected_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisconnectedNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLoginStateResponse {\n");
            sb.Append("  inUseNum: ").Append(InUseNum).Append("\n");
            sb.Append("  stopNum: ").Append(StopNum).Append("\n");
            sb.Append("  unregisteredNum: ").Append(UnregisteredNum).Append("\n");
            sb.Append("  unableToConnectNum: ").Append(UnableToConnectNum).Append("\n");
            sb.Append("  readyNum: ").Append(ReadyNum).Append("\n");
            sb.Append("  disconnectedNum: ").Append(DisconnectedNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLoginStateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLoginStateResponse input)
        {
            if (input == null) return false;
            if (this.InUseNum != input.InUseNum || (this.InUseNum != null && !this.InUseNum.Equals(input.InUseNum))) return false;
            if (this.StopNum != input.StopNum || (this.StopNum != null && !this.StopNum.Equals(input.StopNum))) return false;
            if (this.UnregisteredNum != input.UnregisteredNum || (this.UnregisteredNum != null && !this.UnregisteredNum.Equals(input.UnregisteredNum))) return false;
            if (this.UnableToConnectNum != input.UnableToConnectNum || (this.UnableToConnectNum != null && !this.UnableToConnectNum.Equals(input.UnableToConnectNum))) return false;
            if (this.ReadyNum != input.ReadyNum || (this.ReadyNum != null && !this.ReadyNum.Equals(input.ReadyNum))) return false;
            if (this.DisconnectedNum != input.DisconnectedNum || (this.DisconnectedNum != null && !this.DisconnectedNum.Equals(input.DisconnectedNum))) return false;

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
                if (this.InUseNum != null) hashCode = hashCode * 59 + this.InUseNum.GetHashCode();
                if (this.StopNum != null) hashCode = hashCode * 59 + this.StopNum.GetHashCode();
                if (this.UnregisteredNum != null) hashCode = hashCode * 59 + this.UnregisteredNum.GetHashCode();
                if (this.UnableToConnectNum != null) hashCode = hashCode * 59 + this.UnableToConnectNum.GetHashCode();
                if (this.ReadyNum != null) hashCode = hashCode * 59 + this.ReadyNum.GetHashCode();
                if (this.DisconnectedNum != null) hashCode = hashCode * 59 + this.DisconnectedNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
