using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListFirewallListResponse : SdkResponse
    {

        /// <summary>
        /// 是否支持eps
        /// </summary>
        [JsonProperty("user_support_eps", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserSupportEps { get; set; }

        /// <summary>
        /// 是否存在ndr
        /// </summary>
        [JsonProperty("has_ndr", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasNdr { get; set; }

        /// <summary>
        /// 是否支持按需购买
        /// </summary>
        [JsonProperty("is_support_postpaid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportPostpaid { get; set; }

        /// <summary>
        /// 是否支持基础版
        /// </summary>
        [JsonProperty("is_support_basic_version", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportBasicVersion { get; set; }

        /// <summary>
        /// 是否支持购买专业版
        /// </summary>
        [JsonProperty("is_support_buy_professional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportBuyProfessional { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public HttpFirewallInstanceListResponseData Data { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFirewallListResponse {\n");
            sb.Append("  userSupportEps: ").Append(UserSupportEps).Append("\n");
            sb.Append("  hasNdr: ").Append(HasNdr).Append("\n");
            sb.Append("  isSupportPostpaid: ").Append(IsSupportPostpaid).Append("\n");
            sb.Append("  isSupportBasicVersion: ").Append(IsSupportBasicVersion).Append("\n");
            sb.Append("  isSupportBuyProfessional: ").Append(IsSupportBuyProfessional).Append("\n");
            sb.Append("  data: ").Append(Data).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFirewallListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFirewallListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserSupportEps == input.UserSupportEps ||
                    (this.UserSupportEps != null &&
                    this.UserSupportEps.Equals(input.UserSupportEps))
                ) && 
                (
                    this.HasNdr == input.HasNdr ||
                    (this.HasNdr != null &&
                    this.HasNdr.Equals(input.HasNdr))
                ) && 
                (
                    this.IsSupportPostpaid == input.IsSupportPostpaid ||
                    (this.IsSupportPostpaid != null &&
                    this.IsSupportPostpaid.Equals(input.IsSupportPostpaid))
                ) && 
                (
                    this.IsSupportBasicVersion == input.IsSupportBasicVersion ||
                    (this.IsSupportBasicVersion != null &&
                    this.IsSupportBasicVersion.Equals(input.IsSupportBasicVersion))
                ) && 
                (
                    this.IsSupportBuyProfessional == input.IsSupportBuyProfessional ||
                    (this.IsSupportBuyProfessional != null &&
                    this.IsSupportBuyProfessional.Equals(input.IsSupportBuyProfessional))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.UserSupportEps != null)
                    hashCode = hashCode * 59 + this.UserSupportEps.GetHashCode();
                if (this.HasNdr != null)
                    hashCode = hashCode * 59 + this.HasNdr.GetHashCode();
                if (this.IsSupportPostpaid != null)
                    hashCode = hashCode * 59 + this.IsSupportPostpaid.GetHashCode();
                if (this.IsSupportBasicVersion != null)
                    hashCode = hashCode * 59 + this.IsSupportBasicVersion.GetHashCode();
                if (this.IsSupportBuyProfessional != null)
                    hashCode = hashCode * 59 + this.IsSupportBuyProfessional.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }
}
