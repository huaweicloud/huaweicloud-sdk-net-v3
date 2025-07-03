using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMasterAddressResponse : SdkResponse
    {

        /// <summary>
        /// region的英文名称。
        /// </summary>
        [JsonProperty("region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionName { get; set; }

        /// <summary>
        /// APMmaster服务对外暴露的地址，提供服务注册和心跳上报。
        /// </summary>
        [JsonProperty("master_address", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterAddress { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMasterAddressResponse {\n");
            sb.Append("  regionName: ").Append(RegionName).Append("\n");
            sb.Append("  masterAddress: ").Append(MasterAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMasterAddressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMasterAddressResponse input)
        {
            if (input == null) return false;
            if (this.RegionName != input.RegionName || (this.RegionName != null && !this.RegionName.Equals(input.RegionName))) return false;
            if (this.MasterAddress != input.MasterAddress || (this.MasterAddress != null && !this.MasterAddress.Equals(input.MasterAddress))) return false;

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
                if (this.RegionName != null) hashCode = hashCode * 59 + this.RegionName.GetHashCode();
                if (this.MasterAddress != null) hashCode = hashCode * 59 + this.MasterAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
