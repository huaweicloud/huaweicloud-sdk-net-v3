using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 租户配置权限修改请求体。
    /// </summary>
    public class AccountConfigModifyRequest 
    {

        /// <summary>
        /// OBS委托授权，使用OBS私有桶作为源站时需要开启该委托授权。当前仅支持传on：开启OBS委托授权。
        /// </summary>
        [JsonProperty("obs_agency_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsAgencyStatus { get; set; }

        /// <summary>
        /// SCM委托授权，配置HTTPS证书时，证书来源选择SCM证书时需要开启该委托授权。当前仅支持传on：开启SCM委托授权。
        /// </summary>
        [JsonProperty("scm_agency_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmAgencyStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfigModifyRequest {\n");
            sb.Append("  obsAgencyStatus: ").Append(ObsAgencyStatus).Append("\n");
            sb.Append("  scmAgencyStatus: ").Append(ScmAgencyStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountConfigModifyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccountConfigModifyRequest input)
        {
            if (input == null) return false;
            if (this.ObsAgencyStatus != input.ObsAgencyStatus || (this.ObsAgencyStatus != null && !this.ObsAgencyStatus.Equals(input.ObsAgencyStatus))) return false;
            if (this.ScmAgencyStatus != input.ScmAgencyStatus || (this.ScmAgencyStatus != null && !this.ScmAgencyStatus.Equals(input.ScmAgencyStatus))) return false;

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
                if (this.ObsAgencyStatus != null) hashCode = hashCode * 59 + this.ObsAgencyStatus.GetHashCode();
                if (this.ScmAgencyStatus != null) hashCode = hashCode * 59 + this.ScmAgencyStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
