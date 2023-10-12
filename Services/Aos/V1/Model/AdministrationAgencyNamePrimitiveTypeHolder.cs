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
    public class AdministrationAgencyNamePrimitiveTypeHolder 
    {

        /// <summary>
        /// 管理委托名称  资源编排服务使用该委托获取成员账号委托给管理账号的权限  当用户定义SELF_MANAGED权限类型时，administration_agency_name和administration_agency_urn 必须有且只有一个存在。  推荐用户在使用v5委托时给与administration_agency_urn，administration_agency_name只支持接收v3委托名称，若给与了v5委托名称，则会在部署模板时失败。  当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400。
        /// </summary>
        [JsonProperty("administration_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AdministrationAgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdministrationAgencyNamePrimitiveTypeHolder {\n");
            sb.Append("  administrationAgencyName: ").Append(AdministrationAgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdministrationAgencyNamePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdministrationAgencyNamePrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdministrationAgencyName == input.AdministrationAgencyName ||
                    (this.AdministrationAgencyName != null &&
                    this.AdministrationAgencyName.Equals(input.AdministrationAgencyName))
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
                if (this.AdministrationAgencyName != null)
                    hashCode = hashCode * 59 + this.AdministrationAgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
