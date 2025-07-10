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
    /// 接入信息。
    /// </summary>
    public class AccessConfig 
    {

        /// <summary>
        /// 接入方式。 - INTERNET：表示互联网接入 - DEDICATED：表示专线接入 - BOTH：表示同时支持互联网接入和专线接入
        /// </summary>
        [JsonProperty("access_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessMode { get; set; }

        /// <summary>
        /// 互联网接入地址，只有access_mode为“INTERNET”或“BOTH”时才会返回该参数。
        /// </summary>
        [JsonProperty("internet_access_address", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetAccessAddress { get; set; }

        /// <summary>
        /// 互联网接入端口。
        /// </summary>
        [JsonProperty("internet_access_port", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetAccessPort { get; set; }

        /// <summary>
        /// 专线接入地址，只有access_mode为“DEDICATED”或“BOTH”时才会返回该参数。
        /// </summary>
        [JsonProperty("dedicated_access_address", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedAccessAddress { get; set; }

        /// <summary>
        /// 专线接入备用地址，只有当开启专线备用线路时才会返回该参数。
        /// </summary>
        [JsonProperty("dedicated_access_standby_address", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DedicatedAccessStandbyAddress { get; set; }

        /// <summary>
        /// 专线备用线路失败错误码。
        /// </summary>
        [JsonProperty("standby_address_result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StandbyAddressResultCode { get; set; }

        /// <summary>
        /// 专线接入网段。接入模式包含专线方式时选填，多个网段信息用分号隔开，列表长度不超过5。
        /// </summary>
        [JsonProperty("dedicated_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedCidrs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfig {\n");
            sb.Append("  accessMode: ").Append(AccessMode).Append("\n");
            sb.Append("  internetAccessAddress: ").Append(InternetAccessAddress).Append("\n");
            sb.Append("  internetAccessPort: ").Append(InternetAccessPort).Append("\n");
            sb.Append("  dedicatedAccessAddress: ").Append(DedicatedAccessAddress).Append("\n");
            sb.Append("  dedicatedAccessStandbyAddress: ").Append(DedicatedAccessStandbyAddress).Append("\n");
            sb.Append("  standbyAddressResultCode: ").Append(StandbyAddressResultCode).Append("\n");
            sb.Append("  dedicatedCidrs: ").Append(DedicatedCidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfig input)
        {
            if (input == null) return false;
            if (this.AccessMode != input.AccessMode || (this.AccessMode != null && !this.AccessMode.Equals(input.AccessMode))) return false;
            if (this.InternetAccessAddress != input.InternetAccessAddress || (this.InternetAccessAddress != null && !this.InternetAccessAddress.Equals(input.InternetAccessAddress))) return false;
            if (this.InternetAccessPort != input.InternetAccessPort || (this.InternetAccessPort != null && !this.InternetAccessPort.Equals(input.InternetAccessPort))) return false;
            if (this.DedicatedAccessAddress != input.DedicatedAccessAddress || (this.DedicatedAccessAddress != null && !this.DedicatedAccessAddress.Equals(input.DedicatedAccessAddress))) return false;
            if (this.DedicatedAccessStandbyAddress != input.DedicatedAccessStandbyAddress || (this.DedicatedAccessStandbyAddress != null && input.DedicatedAccessStandbyAddress != null && !this.DedicatedAccessStandbyAddress.SequenceEqual(input.DedicatedAccessStandbyAddress))) return false;
            if (this.StandbyAddressResultCode != input.StandbyAddressResultCode || (this.StandbyAddressResultCode != null && !this.StandbyAddressResultCode.Equals(input.StandbyAddressResultCode))) return false;
            if (this.DedicatedCidrs != input.DedicatedCidrs || (this.DedicatedCidrs != null && !this.DedicatedCidrs.Equals(input.DedicatedCidrs))) return false;

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
                if (this.AccessMode != null) hashCode = hashCode * 59 + this.AccessMode.GetHashCode();
                if (this.InternetAccessAddress != null) hashCode = hashCode * 59 + this.InternetAccessAddress.GetHashCode();
                if (this.InternetAccessPort != null) hashCode = hashCode * 59 + this.InternetAccessPort.GetHashCode();
                if (this.DedicatedAccessAddress != null) hashCode = hashCode * 59 + this.DedicatedAccessAddress.GetHashCode();
                if (this.DedicatedAccessStandbyAddress != null) hashCode = hashCode * 59 + this.DedicatedAccessStandbyAddress.GetHashCode();
                if (this.StandbyAddressResultCode != null) hashCode = hashCode * 59 + this.StandbyAddressResultCode.GetHashCode();
                if (this.DedicatedCidrs != null) hashCode = hashCode * 59 + this.DedicatedCidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
