using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowApplicationsRequest 
    {

        /// <summary>
        /// **参数说明**：实例ID。物理多租下各实例的唯一标识，一般华为云租户无需携带该参数，仅在物理多租场景下从管理面访问API时需要携带该参数。
        /// </summary>
        [SDKProperty("Instance-Id", IsHeader = true)]
        [JsonProperty("Instance-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数说明**：默认资源空间标识，不携带则查询所有资源空间。 **取值范围**： - true：查询默认资源空间。 - false：查询非默认资源空间。
        /// </summary>
        [SDKProperty("default_app", IsQuery = true)]
        [JsonProperty("default_app", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultApp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowApplicationsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  defaultApp: ").Append(DefaultApp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowApplicationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowApplicationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.DefaultApp == input.DefaultApp ||
                    (this.DefaultApp != null &&
                    this.DefaultApp.Equals(input.DefaultApp))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.DefaultApp != null)
                    hashCode = hashCode * 59 + this.DefaultApp.GetHashCode();
                return hashCode;
            }
        }
    }
}
