using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateGlobalEipRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dry_run", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("global_eip", NullValueHandling = NullValueHandling.Ignore)]
        public CreateGlobalEipRequestBodyGlobalEip GlobalEip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateGlobalEipRequestBody {\n");
            sb.Append("  dryRun: ").Append(DryRun).Append("\n");
            sb.Append("  globalEip: ").Append(GlobalEip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateGlobalEipRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateGlobalEipRequestBody input)
        {
            if (input == null) return false;
            if (this.DryRun != input.DryRun || (this.DryRun != null && !this.DryRun.Equals(input.DryRun))) return false;
            if (this.GlobalEip != input.GlobalEip || (this.GlobalEip != null && !this.GlobalEip.Equals(input.GlobalEip))) return false;

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
                if (this.DryRun != null) hashCode = hashCode * 59 + this.DryRun.GetHashCode();
                if (this.GlobalEip != null) hashCode = hashCode * 59 + this.GlobalEip.GetHashCode();
                return hashCode;
            }
        }
    }
}
