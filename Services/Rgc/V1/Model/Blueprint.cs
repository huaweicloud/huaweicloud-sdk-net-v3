using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// 模板。
    /// </summary>
    public class Blueprint 
    {

        /// <summary>
        /// 模板ID。
        /// </summary>
        [JsonProperty("blueprint_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductId { get; set; }

        /// <summary>
        /// 模板版本。
        /// </summary>
        [JsonProperty("blueprint_product_version", NullValueHandling = NullValueHandling.Ignore)]
        public string BlueprintProductVersion { get; set; }

        /// <summary>
        /// 模板部署参数。
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public string Variables { get; set; }

        /// <summary>
        /// 模板是否包含多账号资源。
        /// </summary>
        [JsonProperty("is_blueprint_has_multi_account_resource", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBlueprintHasMultiAccountResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Blueprint {\n");
            sb.Append("  blueprintProductId: ").Append(BlueprintProductId).Append("\n");
            sb.Append("  blueprintProductVersion: ").Append(BlueprintProductVersion).Append("\n");
            sb.Append("  variables: ").Append(Variables).Append("\n");
            sb.Append("  isBlueprintHasMultiAccountResource: ").Append(IsBlueprintHasMultiAccountResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Blueprint);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Blueprint input)
        {
            if (input == null) return false;
            if (this.BlueprintProductId != input.BlueprintProductId || (this.BlueprintProductId != null && !this.BlueprintProductId.Equals(input.BlueprintProductId))) return false;
            if (this.BlueprintProductVersion != input.BlueprintProductVersion || (this.BlueprintProductVersion != null && !this.BlueprintProductVersion.Equals(input.BlueprintProductVersion))) return false;
            if (this.Variables != input.Variables || (this.Variables != null && !this.Variables.Equals(input.Variables))) return false;
            if (this.IsBlueprintHasMultiAccountResource != input.IsBlueprintHasMultiAccountResource || (this.IsBlueprintHasMultiAccountResource != null && !this.IsBlueprintHasMultiAccountResource.Equals(input.IsBlueprintHasMultiAccountResource))) return false;

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
                if (this.BlueprintProductId != null) hashCode = hashCode * 59 + this.BlueprintProductId.GetHashCode();
                if (this.BlueprintProductVersion != null) hashCode = hashCode * 59 + this.BlueprintProductVersion.GetHashCode();
                if (this.Variables != null) hashCode = hashCode * 59 + this.Variables.GetHashCode();
                if (this.IsBlueprintHasMultiAccountResource != null) hashCode = hashCode * 59 + this.IsBlueprintHasMultiAccountResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
