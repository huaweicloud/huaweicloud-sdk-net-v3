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
    public class CreateFaceSetResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("face_set_info", NullValueHandling = NullValueHandling.Ignore)]
        public FaceSetInfo FaceSetInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFaceSetResponse {\n");
            sb.Append("  faceSetInfo: ").Append(FaceSetInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFaceSetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFaceSetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FaceSetInfo == input.FaceSetInfo ||
                    (this.FaceSetInfo != null &&
                    this.FaceSetInfo.Equals(input.FaceSetInfo))
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
                if (this.FaceSetInfo != null)
                    hashCode = hashCode * 59 + this.FaceSetInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
