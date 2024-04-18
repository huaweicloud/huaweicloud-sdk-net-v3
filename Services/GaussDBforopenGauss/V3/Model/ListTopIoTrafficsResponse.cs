using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTopIoTrafficsResponse : SdkResponse
    {

        /// <summary>
        /// Top IO列表
        /// </summary>
        [JsonProperty("top_io_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TopIoInfo> TopIoInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTopIoTrafficsResponse {\n");
            sb.Append("  topIoInfos: ").Append(TopIoInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTopIoTrafficsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTopIoTrafficsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TopIoInfos == input.TopIoInfos ||
                    this.TopIoInfos != null &&
                    input.TopIoInfos != null &&
                    this.TopIoInfos.SequenceEqual(input.TopIoInfos)
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
                if (this.TopIoInfos != null)
                    hashCode = hashCode * 59 + this.TopIoInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
