using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AdministrationAgencyUrnPrimitiveTypeHolder 
    {

        /// <summary>
        /// 管理委托URN  资源编排服务使用该委托获取成员账号委托给管理账号的权限。该委托中必须含有sts:tokens:assume权限，用以后续获取被管理委托凭证。如果不包含，则会在新增或者部署实例时报错。  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给予administration_agency_urn，administration_agency_name只支持接收普通委托名称，若给予了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyUrn { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdministrationAgencyUrnPrimitiveTypeHolder {\n");
            sb.Append("  administrationAgencyUrn: ").Append(AdministrationAgencyUrn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdministrationAgencyUrnPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdministrationAgencyUrnPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdministrationAgencyUrn == input.AdministrationAgencyUrn ||
                    (this.AdministrationAgencyUrn != null &&
                    this.AdministrationAgencyUrn.Equals(input.AdministrationAgencyUrn))
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
                if (this.AdministrationAgencyUrn != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyUrn.GetHashCode();
                return hashCode;
            }
        }
    }
}
