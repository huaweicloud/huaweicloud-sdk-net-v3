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
        /// 人脸库信息集合，详见[FaceSetInfo](zh-cn_topic_0106912072.xml)。 调用失败时无此字段。
        /// </summary>
        [JsonProperty("face_sets_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<FaceSetInfo> FaceSetsInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAllFaceSetsResponse {\n");
            sb.Append("  faceSetsInfo: ").Append(FaceSetsInfo).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.FaceSetsInfo == input.FaceSetsInfo ||
                    this.FaceSetsInfo != null &&
                    input.FaceSetsInfo != null &&
                    this.FaceSetsInfo.SequenceEqual(input.FaceSetsInfo)
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
                if (this.FaceSetsInfo != null)
                    hashCode = hashCode * 59 + this.FaceSetsInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
