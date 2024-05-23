using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 委托管理员相关操作的请求体。
    /// </summary>
    public class DelegatedAdministratorReqBody 
    {

        /// <summary>
        /// 服务主体名称。
        /// </summary>
        [JsonProperty("service_principal", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// 账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelegatedAdministratorReqBody {\n");
            sb.Append("  servicePrincipal: ").Append(ServicePrincipal).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DelegatedAdministratorReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DelegatedAdministratorReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServicePrincipal == input.ServicePrincipal ||
                    (this.ServicePrincipal != null &&
                    this.ServicePrincipal.Equals(input.ServicePrincipal))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                if (this.ServicePrincipal != null)
                    hashCode = hashCode * 59 + this.ServicePrincipal.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                return hashCode;
            }
        }
    }
}
