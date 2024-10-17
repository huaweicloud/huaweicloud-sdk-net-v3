using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Frs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowAllFaceSetsResponse : SdkResponse
    {

        /// <summary>
        /// [人脸库信息，详见[FaceSetInfo](https://support.huaweicloud.com/api-face/face_02_0020.html)。调用失败时无此字段。](tag:hc) [人脸库信息，详见[FaceSetInfo](https://support.huaweicloud.com/intl/zh-cn/api-face/face_02_0020.html)。调用失败时无此字段。](tag:hk)
        /// </summary>
        [JsonProperty("face_sets_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<FaceSetInfo> FaceSetsInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAllFaceSetsResponse {\n");
            sb.Append("  faceSetsInfo: ").Append(FaceSetsInfo).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAllFaceSetsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAllFaceSetsResponse input)
        {
            if (input == null) return false;
            if (this.FaceSetsInfo != input.FaceSetsInfo || (this.FaceSetsInfo != null && input.FaceSetsInfo != null && !this.FaceSetsInfo.SequenceEqual(input.FaceSetsInfo))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.FaceSetsInfo != null) hashCode = hashCode * 59 + this.FaceSetsInfo.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
