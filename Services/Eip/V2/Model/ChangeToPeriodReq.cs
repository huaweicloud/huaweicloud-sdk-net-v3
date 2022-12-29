using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 云服务按需转包请求体
    /// </summary>
    public class ChangeToPeriodReq 
    {

        /// <summary>
        /// 待按需转包IP列表 
        /// </summary>
        [JsonProperty("publicip_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PublicipIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extendParam", NullValueHandling = NullValueHandling.Ignore)]
        public CreatePrePaidPublicipExtendParamOption ExtendParam { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeToPeriodReq {\n");
            sb.Append("  publicipIds: ").Append(PublicipIds).Append("\n");
            sb.Append("  extendParam: ").Append(ExtendParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeToPeriodReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeToPeriodReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipIds == input.PublicipIds ||
                    this.PublicipIds != null &&
                    input.PublicipIds != null &&
                    this.PublicipIds.SequenceEqual(input.PublicipIds)
                ) && 
                (
                    this.ExtendParam == input.ExtendParam ||
                    (this.ExtendParam != null &&
                    this.ExtendParam.Equals(input.ExtendParam))
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
                if (this.PublicipIds != null)
                    hashCode = hashCode * 59 + this.PublicipIds.GetHashCode();
                if (this.ExtendParam != null)
                    hashCode = hashCode * 59 + this.ExtendParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
