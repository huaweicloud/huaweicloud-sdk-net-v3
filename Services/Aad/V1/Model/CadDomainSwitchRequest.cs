using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CadDomainSwitchRequest 
    {

        /// <summary>
        /// 域名id
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 是否开启WEB基础防护开关。0 - 开启， 1 - 关闭
        /// </summary>
        [JsonProperty("waf_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? WafSwitch { get; set; }

        /// <summary>
        /// 是否开启CC防护开关。0 - 开启， 1 - 关闭。开启CC开关必须同时开启WEB基础防护开关
        /// </summary>
        [JsonProperty("cc_switch", NullValueHandling = NullValueHandling.Ignore)]
        public int? CcSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CadDomainSwitchRequest {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  wafSwitch: ").Append(WafSwitch).Append("\n");
            sb.Append("  ccSwitch: ").Append(CcSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CadDomainSwitchRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CadDomainSwitchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.WafSwitch == input.WafSwitch ||
                    (this.WafSwitch != null &&
                    this.WafSwitch.Equals(input.WafSwitch))
                ) && 
                (
                    this.CcSwitch == input.CcSwitch ||
                    (this.CcSwitch != null &&
                    this.CcSwitch.Equals(input.CcSwitch))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.WafSwitch != null)
                    hashCode = hashCode * 59 + this.WafSwitch.GetHashCode();
                if (this.CcSwitch != null)
                    hashCode = hashCode * 59 + this.CcSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
