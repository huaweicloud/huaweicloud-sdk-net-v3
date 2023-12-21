using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class VodRetrievalData 
    {

        /// <summary>
        /// 低频取回量 
        /// </summary>
        [JsonProperty("retrieval_warm", NullValueHandling = NullValueHandling.Ignore)]
        public double? RetrievalWarm { get; set; }

        /// <summary>
        /// 归档标准取回量 
        /// </summary>
        [JsonProperty("retrieval_cold", NullValueHandling = NullValueHandling.Ignore)]
        public double? RetrievalCold { get; set; }

        /// <summary>
        /// 归档快速取回量 
        /// </summary>
        [JsonProperty("retrieval_cold_speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? RetrievalColdSpeed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VodRetrievalData {\n");
            sb.Append("  retrievalWarm: ").Append(RetrievalWarm).Append("\n");
            sb.Append("  retrievalCold: ").Append(RetrievalCold).Append("\n");
            sb.Append("  retrievalColdSpeed: ").Append(RetrievalColdSpeed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VodRetrievalData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VodRetrievalData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RetrievalWarm == input.RetrievalWarm ||
                    (this.RetrievalWarm != null &&
                    this.RetrievalWarm.Equals(input.RetrievalWarm))
                ) && 
                (
                    this.RetrievalCold == input.RetrievalCold ||
                    (this.RetrievalCold != null &&
                    this.RetrievalCold.Equals(input.RetrievalCold))
                ) && 
                (
                    this.RetrievalColdSpeed == input.RetrievalColdSpeed ||
                    (this.RetrievalColdSpeed != null &&
                    this.RetrievalColdSpeed.Equals(input.RetrievalColdSpeed))
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
                if (this.RetrievalWarm != null)
                    hashCode = hashCode * 59 + this.RetrievalWarm.GetHashCode();
                if (this.RetrievalCold != null)
                    hashCode = hashCode * 59 + this.RetrievalCold.GetHashCode();
                if (this.RetrievalColdSpeed != null)
                    hashCode = hashCode * 59 + this.RetrievalColdSpeed.GetHashCode();
                return hashCode;
            }
        }
    }
}
