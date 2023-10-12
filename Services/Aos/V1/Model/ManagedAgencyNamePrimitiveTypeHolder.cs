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
    public class ManagedAgencyNamePrimitiveTypeHolder 
    {

        /// <summary>
        /// 被管理的委托名称。  资源编排服务会使用该委托获取实际部署资源所需要的权限  不同成员账号委托给管理账号的委托名称需要保持一致。暂不支持根据不同provider定义不同委托权限  当用户定义SELF_MANAGED权限类型时，必须指定该参数。当用户使用SERVICE_MANAGED权限类型时，指定该参数将报错400
        /// </summary>
        [JsonProperty("managed_agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedAgencyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ManagedAgencyNamePrimitiveTypeHolder {\n");
            sb.Append("  managedAgencyName: ").Append(ManagedAgencyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManagedAgencyNamePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ManagedAgencyNamePrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ManagedAgencyName == input.ManagedAgencyName ||
                    (this.ManagedAgencyName != null &&
                    this.ManagedAgencyName.Equals(input.ManagedAgencyName))
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
                if (this.ManagedAgencyName != null)
                    hashCode = hashCode * 59 + this.ManagedAgencyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
