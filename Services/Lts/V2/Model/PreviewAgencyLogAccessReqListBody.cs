using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PreviewAgencyLogAccessReqListBody 
    {

        /// <summary>
        /// 预览代理列表
        /// </summary>
        [JsonProperty("preview_agency_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PreviewAgencyLogAccessReqBody> PreviewAgencyList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreviewAgencyLogAccessReqListBody {\n");
            sb.Append("  previewAgencyList: ").Append(PreviewAgencyList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreviewAgencyLogAccessReqListBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreviewAgencyLogAccessReqListBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreviewAgencyList == input.PreviewAgencyList ||
                    this.PreviewAgencyList != null &&
                    input.PreviewAgencyList != null &&
                    this.PreviewAgencyList.SequenceEqual(input.PreviewAgencyList)
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
                if (this.PreviewAgencyList != null)
                    hashCode = hashCode * 59 + this.PreviewAgencyList.GetHashCode();
                return hashCode;
            }
        }
    }
}
