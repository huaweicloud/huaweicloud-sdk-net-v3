using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowResourceInfoResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cloud_service", NullValueHandling = NullValueHandling.Ignore)]
        public CloudServiceInfo CloudService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ccsp_service", NullValueHandling = NullValueHandling.Ignore)]
        public CcspServiceInfo CcspService { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vsm", NullValueHandling = NullValueHandling.Ignore)]
        public VsmResourceInfo Vsm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public AppResourceInfo App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("kms", NullValueHandling = NullValueHandling.Ignore)]
        public KmsResourceInfo Kms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowResourceInfoResponse {\n");
            sb.Append("  cloudService: ").Append(CloudService).Append("\n");
            sb.Append("  ccspService: ").Append(CcspService).Append("\n");
            sb.Append("  vsm: ").Append(Vsm).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  kms: ").Append(Kms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowResourceInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowResourceInfoResponse input)
        {
            if (input == null) return false;
            if (this.CloudService != input.CloudService || (this.CloudService != null && !this.CloudService.Equals(input.CloudService))) return false;
            if (this.CcspService != input.CcspService || (this.CcspService != null && !this.CcspService.Equals(input.CcspService))) return false;
            if (this.Vsm != input.Vsm || (this.Vsm != null && !this.Vsm.Equals(input.Vsm))) return false;
            if (this.App != input.App || (this.App != null && !this.App.Equals(input.App))) return false;
            if (this.Kms != input.Kms || (this.Kms != null && !this.Kms.Equals(input.Kms))) return false;

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
                if (this.CloudService != null) hashCode = hashCode * 59 + this.CloudService.GetHashCode();
                if (this.CcspService != null) hashCode = hashCode * 59 + this.CcspService.GetHashCode();
                if (this.Vsm != null) hashCode = hashCode * 59 + this.Vsm.GetHashCode();
                if (this.App != null) hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Kms != null) hashCode = hashCode * 59 + this.Kms.GetHashCode();
                return hashCode;
            }
        }
    }
}
