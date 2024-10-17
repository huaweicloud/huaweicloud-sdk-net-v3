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
    /// 
    /// </summary>
    public class OpenGaussInstanceActionRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("expand_cluster", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussExpandCluster ExpandCluster { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("enlarge_volume", NullValueHandling = NullValueHandling.Ignore)]
        public OpenGaussEnlargeVolume EnlargeVolume { get; set; }

        /// <summary>
        /// 包周期实例时可指定，表示是否自动从账户中支付，此字段不影响自动续订的支付方式。  true，表示自动从账户中支付。 false，表示手动从账户中支付，默认为该方式。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenGaussInstanceActionRequest {\n");
            sb.Append("  expandCluster: ").Append(ExpandCluster).Append("\n");
            sb.Append("  enlargeVolume: ").Append(EnlargeVolume).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OpenGaussInstanceActionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OpenGaussInstanceActionRequest input)
        {
            if (input == null) return false;
            if (this.ExpandCluster != input.ExpandCluster || (this.ExpandCluster != null && !this.ExpandCluster.Equals(input.ExpandCluster))) return false;
            if (this.EnlargeVolume != input.EnlargeVolume || (this.EnlargeVolume != null && !this.EnlargeVolume.Equals(input.EnlargeVolume))) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;

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
                if (this.ExpandCluster != null) hashCode = hashCode * 59 + this.ExpandCluster.GetHashCode();
                if (this.EnlargeVolume != null) hashCode = hashCode * 59 + this.EnlargeVolume.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
