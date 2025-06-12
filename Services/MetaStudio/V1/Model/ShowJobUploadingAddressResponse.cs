using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowJobUploadingAddressResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("segment_url", NullValueHandling = NullValueHandling.Ignore)]
        public ShowJobUploadingAddressRspSegmentUrl SegmentUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("package_url", NullValueHandling = NullValueHandling.Ignore)]
        public ShowJobUploadingAddressRspPackageUrl PackageUrl { get; set; }

        /// <summary>
        /// 授权书的上传地址。
        /// </summary>
        [JsonProperty("authorization_letter_uploading_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizationLetterUploadingUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowJobUploadingAddressResponse {\n");
            sb.Append("  segmentUrl: ").Append(SegmentUrl).Append("\n");
            sb.Append("  packageUrl: ").Append(PackageUrl).Append("\n");
            sb.Append("  authorizationLetterUploadingUrl: ").Append(AuthorizationLetterUploadingUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowJobUploadingAddressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowJobUploadingAddressResponse input)
        {
            if (input == null) return false;
            if (this.SegmentUrl != input.SegmentUrl || (this.SegmentUrl != null && !this.SegmentUrl.Equals(input.SegmentUrl))) return false;
            if (this.PackageUrl != input.PackageUrl || (this.PackageUrl != null && !this.PackageUrl.Equals(input.PackageUrl))) return false;
            if (this.AuthorizationLetterUploadingUrl != input.AuthorizationLetterUploadingUrl || (this.AuthorizationLetterUploadingUrl != null && !this.AuthorizationLetterUploadingUrl.Equals(input.AuthorizationLetterUploadingUrl))) return false;

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
                if (this.SegmentUrl != null) hashCode = hashCode * 59 + this.SegmentUrl.GetHashCode();
                if (this.PackageUrl != null) hashCode = hashCode * 59 + this.PackageUrl.GetHashCode();
                if (this.AuthorizationLetterUploadingUrl != null) hashCode = hashCode * 59 + this.AuthorizationLetterUploadingUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
