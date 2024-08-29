using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowPublicipPoolRequest 
    {

        /// <summary>
        /// 公网IP池ID唯一标识
        /// </summary>
        [SDKProperty("publicip_pool_id", IsPath = true)]
        [JsonProperty("publicip_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipPoolId { get; set; }

        /// <summary>
        /// 显示，形式为\&quot;fields&#x3D;id&amp;fields&#x3D;name&amp;...\&quot;  支持字段：id/name/size/used/project_id/status/billing_info/created_at/updated_at/type/shared/is_common/description/tags/enterprise_project_id/allow_share_bandwidth_types/public_border_group
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Fields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPublicipPoolRequest {\n");
            sb.Append("  publicipPoolId: ").Append(PublicipPoolId).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPublicipPoolRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPublicipPoolRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipPoolId == input.PublicipPoolId ||
                    (this.PublicipPoolId != null &&
                    this.PublicipPoolId.Equals(input.PublicipPoolId))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.PublicipPoolId != null)
                    hashCode = hashCode * 59 + this.PublicipPoolId.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }
    }
}
