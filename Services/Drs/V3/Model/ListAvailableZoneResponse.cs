using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAvailableZoneResponse : SdkResponse
    {

        /// <summary>
        /// 可用区信息
        /// </summary>
        [JsonProperty("az_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<AzInfoResp> AzInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAvailableZoneResponse {\n");
            sb.Append("  azInfos: ").Append(AzInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAvailableZoneResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAvailableZoneResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AzInfos == input.AzInfos ||
                    this.AzInfos != null &&
                    input.AzInfos != null &&
                    this.AzInfos.SequenceEqual(input.AzInfos)
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
                if (this.AzInfos != null)
                    hashCode = hashCode * 59 + this.AzInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
